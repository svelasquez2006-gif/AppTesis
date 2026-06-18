using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            nroPlacaTextBox.Clear();
            anotacionesTextBox.Clear();
            this.Close();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string placa = nroPlacaTextBox.Text;

            //formato de fceha necesario para hacer la conversion
            string formato =" dd / mm / aaaa";
            //funcion que nos permite tomar un valor string(texto) y volverlo un valor date(Fecha)
            DateTime.TryParseExact(fechaMantenimientoDateTimePicker.Text,formato,CultureInfo.InvariantCulture,DateTimeStyles.None,out DateTime mantenimiento);
            string anotaciones = anotacionesTextBox.Text;

            //permite darle funcion a los botones guardando el valor del boton selecionado
            DialogResult resultado = MessageBox.Show("Desea Ingresar este mantenimiento","Seguro?"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //si se elije si
            if (resultado==DialogResult.Yes) {
                //agregar nuevo mantenimiento
                this.mantenimientoTableAdapter.Guardar(placa, mantenimiento, anotaciones);
                //agregar fecha del ultimo mantenimiento en la tabla de vehiculo correspondiente
                this.vehiculosTableAdapter1.AgregarMantenimiento(mantenimiento, placa);
            }
            else if (resultado==DialogResult.No) {
            
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
