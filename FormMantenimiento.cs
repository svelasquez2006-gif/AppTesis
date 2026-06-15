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
    public partial class FormMantenimiento : Form
    {
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.basededatosDataSet.Mantenimiento);

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            
            RegistrarMantenimiento mantenimiento=new RegistrarMantenimiento();
            mantenimiento.ShowDialog();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formvehiculos vehiculos = new Formvehiculos();
            vehiculos.Show();
        }
    }
}
