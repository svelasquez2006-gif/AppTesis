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
    public partial class Formordenes : Form
    {
        public Formordenes()
        {
            InitializeComponent();
        }

        private void ordenes_ViajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void Formordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Orden_Viaje' Puede moverla o quitarla según sea necesario.
            this.orden_ViajeTableAdapter.Fill(this.dataBaseDataSet.Orden_Viaje);


        }

        private void ordenes_ViajeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (cedula_ChoferTextBox.Text == "" || vehiculos_NroPlacaTextBox.Text == "" || cedula_ClienteTextBox.Text == "" || destinoTextBox.Text == "" || distancia_Esperada_KmTextBox.Text == "" || Estatuscombobox.Text == "")

            {
                MessageBox.Show("Se esta enviado un campo vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedula_ChoferTextBox.Text;
                    string placa = vehiculos_NroPlacaTextBox.Text;
                    string ced_cliente = cedula_ClienteTextBox.Text;
                    string destino = destinoTextBox.Text;
                    string formato = "dd/mm/yyyy";
                    DateTime.TryParseExact(fecha_InicioDateTimePicker.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio);
                    DateTime.TryParseExact(fecha_FinalizacionDateTimePicker.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime final);
                    decimal.TryParse(distancia_Esperada_KmTextBox.Text, out decimal distancia);
                    string estatus = Estatuscombobox.Text;
                    this.orden_ViajeTableAdapter.add(cedula, placa, ced_cliente, destino, distancia, inicio, final, estatus);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha Ocurrido un error inesperado"+ ex.Message, "Ha Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void orden_ViajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orden_ViajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void orden_ViajeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (cedula_ChoferTextBox.Text == "" || vehiculos_NroPlacaTextBox.Text == "" || cedula_ClienteTextBox.Text == "" || destinoTextBox.Text == "" || distancia_Esperada_KmTextBox.Text == "" || Estatuscombobox.Text == "")

            {
                MessageBox.Show("Se esta enviado un campo vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int.TryParse(iDOrdenes_ViajeTextBox.Text, out int id);
                    string cedula = cedula_ChoferTextBox.Text;
                    string placa = vehiculos_NroPlacaTextBox.Text;
                    string ced_cliente = cedula_ClienteTextBox.Text;
                    string destino = destinoTextBox.Text;
                    string formato = "dd/mm/yyyy";
                    DateTime.TryParseExact(fecha_InicioDateTimePicker.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inicio);
                    DateTime.TryParseExact(fecha_FinalizacionDateTimePicker.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime final);
                    decimal.TryParse(distancia_Esperada_KmTextBox.Text, out decimal distancia);
                    string estatus = Estatuscombobox.Text;
                    this.orden_ViajeTableAdapter.Modify(cedula, placa, ced_cliente, destino, distancia,inicio, final, estatus,id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha Ocurrido un error inesperado" + ex.Message, "Ha Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iDOrdenes_ViajeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
