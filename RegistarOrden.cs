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
    public partial class RegistarOrd : Form
    {
        public RegistarOrd()
        {
            InitializeComponent();
        }

        private void ordenes_ViajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenes_ViajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Ordenes_Viaje' Puede moverla o quitarla según sea necesario.
            this.ordenes_ViajeTableAdapter.Fill(this.basededatosDataSet.Ordenes_Viaje);

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int.TryParse(cedula_ChoferTextBox.Text,out int cedula);
            string placa = vehiculos_NroPlacaTextBox.Text;
            string destino = destinoTextBox.Text;
            string inicio=fecha_InicioTextBox.Text;
            string finalizacion = fecha_FinalizacionTextBox.Text;
            string distancia = distancia_EsperadaTextBox.Text;
            int.TryParse(estatusTextBox.Text, out int estatus);

            //permite darle funcion a los botones guardando el valor del boton selecionado
            DialogResult resultado = MessageBox.Show($"Desea guardar los siguientes datos?:" +
                $"Cedula del Chofer:{cedula} ," +
                $"Placa del Vehiculo:{placa} ," +
                $"Destino del Viaje:{destino} ," +
                $"Inicio:{inicio} ," +
                $"finalizacion:{finalizacion} ," +
                $"Distancia:{distancia}"
                ,"¿Desea Guardar los datos?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado== DialogResult.Yes) {
                this.ordenes_ViajeTableAdapter.Guardar(cedula, placa, destino, inicio, finalizacion, distancia, estatus);
            }
            else if (resultado==DialogResult.No) { 
            
            }
            

            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            cedula_ChoferTextBox.Clear();
            vehiculos_NroPlacaTextBox.Clear();
            destinoTextBox.Clear();
            fecha_InicioTextBox.Clear();
            fecha_FinalizacionTextBox.Clear();
            distancia_EsperadaTextBox.Clear();
            estatusTextBox.Clear();
            this.Close();
        }
    }
}
