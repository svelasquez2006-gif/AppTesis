using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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


        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);
            nroPlacaTextBox.MaxLength = 7;

        }

        private void agregar_Click(object sender, EventArgs e)
        {

            if (nroPlacaTextBox.Text == "" || anotacionesTextBox.Text == "")
            {
                MessageBox.Show("Se esta enviado un campo vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (nroPlacaTextBox.Text.Length <7) {
                MessageBox.Show("el numero de placa no puede tener menos de 7 digitos", "Verificar placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else {

                try
                {
                    int.TryParse(codMantenimientoTextBox.Text, out int codmantenimiento);
                    string placa = nroPlacaTextBox.Text;
                    string formato = "yyyy-MM-dd";
                    DateTime.TryParseExact(fechaMantenimientoDateTimePicker.Text, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime mantenimiento);
                    string anotaciones = anotacionesTextBox.Text;
                    this.mantenimientoTableAdapter.add(placa, mantenimiento, anotaciones);
                    this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);

                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar un valor que ya fue registrado en la base de datos.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado en la base de datos, " + ex.Message, "Error en la Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formvehiculos vehiculos = new Formvehiculos();
            vehiculos.Show();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void codMantenimientoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codMantenimientoLabel_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nroPlacaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
