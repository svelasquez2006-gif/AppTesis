using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using AppTesis; // Asegúrate de incluir este namespace


namespace ControlesPersonalizados
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);

            this.reportViewer2.RefreshReport();
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes rep = new Reportes();
            rep.Show();
        }
    }
}
