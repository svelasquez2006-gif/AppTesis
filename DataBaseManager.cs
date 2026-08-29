using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public class SqlServerBackupService
    {
        private readonly string _connectionStringMaster;
        private readonly string _nombreBaseDatos;

        // Constructor para inyectar la configuración dinámicamente
        public SqlServerBackupService(string servidor, string baseDatos)
        {
            _nombreBaseDatos = baseDatos;
            _connectionStringMaster = $"Server={servidor};Database=master;Trusted_Connection=False;";
        }

        public bool Respaldar(string rutaDestino)
        {
            string query = $"BACKUP DATABASE [{_nombreBaseDatos}] TO DISK = @ruta WITH FORMAT, INIT, STATS = 10;";
            string carpeta = Path.GetDirectoryName(rutaDestino);

            // 2. Si la carpeta no existe, C# la crea automáticamente
            if (!string.IsNullOrEmpty(carpeta) && !Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionStringMaster))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@ruta", rutaDestino);
                        comando.CommandTimeout = 300;
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al respaldar: {ex.Message}");
                return false;
            }
        }

        public bool Restaurar(string rutaArchivoBak)
        {
            string carpeta = Path.GetDirectoryName(rutaArchivoBak);

            // 2. Si la carpeta no existe, C# la crea automáticamente
            if (!string.IsNullOrEmpty(carpeta) && !Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            string query = $@"
            ALTER DATABASE [{_nombreBaseDatos}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [{_nombreBaseDatos}] FROM DISK = @ruta WITH REPLACE;
            ALTER DATABASE [{_nombreBaseDatos}] SET MULTI_USER;";


            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionStringMaster))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@ruta", rutaArchivoBak);
                        comando.CommandTimeout = 600; // 10 minutos para bases de datos pesadas
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Intenta restaurar el acceso multiusuario si ocurrió un fallo a mitad del proceso
                RestablecerMultiusuario();
                MessageBox.Show($"Error al restaurar: {ex.Message}");
                return false;
            }
        }

        private void RestablecerMultiusuario()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(_connectionStringMaster))
                {
                    conexion.Open();
                    string query = $"ALTER DATABASE [{_nombreBaseDatos}] SET MULTI_USER;";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch { /* Fallback de emergencia */ }
        }
    }
}
