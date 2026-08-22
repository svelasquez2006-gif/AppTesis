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
    public partial class ruta : Form
    {
        public ruta()
        {
            InitializeComponent();
        }

        private void ruta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.dataBaseDataSet.Rutas);

            this.reportViewer1.RefreshReport();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes rep = new Reportes();
            rep.Show();
        }
    }
}
