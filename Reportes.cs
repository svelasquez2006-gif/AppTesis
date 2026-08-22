using ControlesPersonalizados;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal= new FormPrincipal();
            principal.Show();
        }

        private void reporteUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios usu = new usuarios();
            usu.Show();
        }

        private void reporteChoferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choferes cho = new Choferes();
            cho.Show();
        }

        private void reporteMantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento man = new mantenimiento();
            man.Show();
        }

        private void reportesOrdenesDeViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ordenesviaje ord = new ordenesviaje();
            ord.Show();
        }

        private void reportesRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ruta rut = new ruta();
            rut.Show();

        }

        private void reportesClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes cli = new clientes();
            cli.Show();
        }
    }
}
