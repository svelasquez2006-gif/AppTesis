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
    public partial class vehiculo : Form
    {
        public vehiculo()
        {
            InitializeComponent();
        }

        private void vehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);

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
