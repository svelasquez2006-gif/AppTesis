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
    public partial class Formvehiculos : Form
    {
        public Formvehiculos()
        {
            InitializeComponent();
        }

        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void Formvehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
            this.vehiculosTableAdapter.Fill(this.basededatosDataSet.Vehiculos);

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            RegistarVehiculo vehiculo = new RegistarVehiculo();
            vehiculo.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void mantenimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMantenimiento mantenimiento = new FormMantenimiento();
            mantenimiento.Show();
        }
    }
}
