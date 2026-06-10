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
    public partial class RegistarChofer : Form
    {
        public RegistarChofer()
        {
            InitializeComponent();
        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Choferes' Puede moverla o quitarla según sea necesario.
            this.choferesTableAdapter.Fill(this.basededatosDataSet.Choferes);

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.choferesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
