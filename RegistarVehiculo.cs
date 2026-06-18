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
            string placa = nroPlacaTextBox.Text;
            string marca = marcaTextBox.Text;
            string modelo = modeloTextBox.Text;
            string anio =anioTextBox.Text;
            string color = colorTextBox.Text;
            int.TryParse(estatusTextBox.Text,out int estatus);

            //permite darle funcion a los botones guardando el valor del boton selecionado
            DialogResult resultado = MessageBox.Show($"Desea guardar los sigueintes datos?:" +
                $"Placa:{placa}, Marca:{marca}, Modelo:{modelo} ,Año:{anio} ,Color{color}",
                "¿Desea Guardar?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado==DialogResult.Yes) {
                this.vehiculosTableAdapter.Guardar(placa, marca, modelo, anio, color, estatus);
            }
            else if (resultado == DialogResult.No) {
            
            }
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            nroPlacaTextBox.Clear();
            marcaTextBox.Clear();
            modeloTextBox.Clear();
            anioTextBox.Clear();
            colorTextBox.Clear();
            estatusTextBox.Clear();
            this.Close();
        }
    }
}
