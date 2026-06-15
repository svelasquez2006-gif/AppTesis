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
    public partial class RegistrarMantenimiento : Form
    {
        public RegistrarMantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void RegistrarMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.basededatosDataSet.Mantenimiento);

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            /**
             agregar formato string formato=dd/mm/aaaa
             DataTime.TryParseExact();
             */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
