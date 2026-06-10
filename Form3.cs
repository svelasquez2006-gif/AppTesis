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
    public partial class Formchoferes : Form
    {
        public Formchoferes()
        {
            InitializeComponent();
        }

        private void choferesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.choferesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void Formchoferes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Choferes' Puede moverla o quitarla según sea necesario.
            this.choferesTableAdapter.Fill(this.basededatosDataSet.Choferes);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            RegistarVehiculo modificar = new RegistarVehiculo();
            modificar.Show();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            RegistarChofer registrar=new RegistarChofer();
            registrar.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void choferesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.choferesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }
    }
}
