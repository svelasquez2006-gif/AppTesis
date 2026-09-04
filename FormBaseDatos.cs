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
            var backupService = new SqlServerBackupService("localhost\\SQLEXPRESS", "DataBase");

            string rutaBak = @"C:\Backups\DataBase.bak";
            if (backupService.Respaldar(rutaBak))
            {
                MessageBox.Show("Respaldo completado con éxito.","operacion exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            var backupService = new SqlServerBackupService("localhost\\SQLEXPRESS", "DataBase");

            string rutaBak = @"C:\Backups\DataBase.bak";
            if (backupService.Restaurar(rutaBak))
            {
                MessageBox.Show("Restauracion completada con éxito.", "operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormBaseDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
