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
    public partial class RegistarVehiculo : Form
    {
        public RegistarVehiculo()
        {
            InitializeComponent();
        }



        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.basededatosDataSet.Vehiculos);

        }

        private void anioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
