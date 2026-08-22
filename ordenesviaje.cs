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
    public partial class ordenesviaje : Form
    {
        public ordenesviaje()
        {
            InitializeComponent();
        }

        private void ordenesviaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Orden_Viaje' Puede moverla o quitarla según sea necesario.
            this.orden_ViajeTableAdapter.Fill(this.dataBaseDataSet.Orden_Viaje);

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
