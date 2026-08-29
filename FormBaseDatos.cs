using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class FormBaseDatos : Form
    {
        public FormBaseDatos()
        {
            InitializeComponent();

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal prin = new FormPrincipal();
            prin.Show();
        }

        private void Respaldar_Click(object sender, EventArgs e)
        {
            var backupService = new SqlServerBackupService("localhost", "DataBase");

            string rutaBak = @"C:\Public\Backups\DataBase.mdf";
            if (backupService.Respaldar(rutaBak))
            {
                MessageBox.Show("Respaldo completado con éxito.","operacion exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            var backupService = new SqlServerBackupService("localhost", "DataBase");

            string rutaBak = @"C:\Backups\DataBase.mdf";
            if (backupService.Restaurar(rutaBak))
            {
                MessageBox.Show("Restauracion completada con éxito.", "operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
