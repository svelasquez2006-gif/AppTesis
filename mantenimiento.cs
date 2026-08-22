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
    public partial class mantenimiento : Form
    {
        public mantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);

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
