using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);
            BsRadio.Checked = true;
            

        }

        private void agregar_Click(object sender, EventArgs e)
        {

            List<string> camposVacios = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    // Agrega el nombre del campo a la lista
                    camposVacios.Add(textBox.Name);
                }
            }

            // Si la lista tiene elementos, muestra el mensaje
            if (camposVacios.Count > 0)
            {
                string mensaje = "Los siguientes campos están vacíos:\n" + string.Join("\n", camposVacios);
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PlacaComboBox.Text.Length <7) {
                MessageBox.Show("el numero de placa no puede tener menos de 7 digitos", "Verificar placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else {

                try
                {
                    int.TryParse(codMantenimientoTextBox.Text, out int codmantenimiento);
                    string placa = PlacaComboBox.Text;
                    DateTime fecha = fechaMantenimientoDateTimePicker.Value;
                    string anotaciones = anotacionesTextBox.Text;
                    decimal.TryParse(tasa_USDTextBox.Text,out decimal tasa);
                    decimal.TryParse(montobs.Text, out decimal coste);
                    this.mantenimientoTableAdapter.add(placa, fecha, anotaciones,tasa,coste);
                    this.vehiculoTableAdapter.addMantenimiento(fecha, placa);
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

        private void tasa_USDLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlacaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CalcularConversion()
        {
            if (!decimal.TryParse(tasa_USDTextBox.Text.Replace('.', ','), out decimal tasa) || tasa <= 0)
                return;

            try
            {
                if (UsdRadio.Checked)
                {
                    if (decimal.TryParse(montousd.Text, out decimal montoUSD))
                    {
                        // 1. Limite de seguridad en USD (Máximo 999 Millones)
                        if (montoUSD > 999999999m)
                        {
                            montobs.Text = "0,00";
                            return;
                        }

                        decimal resultadoBs = montoUSD * tasa;

                        // 2. Limite de seguridad en el Resultado en Bs antes de enviarlo al control/DataGrid
                        if (resultadoBs > 999999999999m)
                        {
                            montobs.Text = "0,00";
                            return;
                        }

                        string conversionStr = resultadoBs.ToString("0.00");
                        if (montobs.Text != conversionStr) montobs.Text = conversionStr;
                    }
                }
                else if (BsRadio.Checked)
                {
                    if (decimal.TryParse(montobs.Text, out decimal montoBs))
                    {
                        // 3. Si al cambiar a BsRadio el campo Bs tiene una cifra gigante, aborta de inmediato
                        if (montoBs > 999999999999m)
                        {
                            montousd.Text = "0,00";
                            return;
                        }

                        decimal resultadoUsd = montoBs / tasa;

                        if (resultadoUsd > 999999999m)
                        {
                            montousd.Text = "0,00";
                            return;
                        }

                        string conversionStr = resultadoUsd.ToString("0.00");
                        if (montousd.Text != conversionStr) montousd.Text = conversionStr;
                    }
                }
            }
            catch (OverflowException)
            {
                // Si la operación matemática se pasa del límite numérico de C#, resetea las cajas
                montousd.Text = "0,00";
                montobs.Text = "0,00";
            }
        }



        private void BsRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Solo actuamos si el RadioButton se acaba de activar (Checked == true)
            if (sender is RadioButton rb && rb.Checked)
            {
                if (UsdRadio.Checked)
                {
                    montobs.Clear();
                    montobs.ReadOnly = true;    // Bloqueado (aquí cae el resultado)
                    montousd.ReadOnly = false;  // Permitir escribir el monto en dólares
                    montousd.Focus();
                }
                else if (BsRadio.Checked)
                {
                    montousd.Clear();
                    montousd.ReadOnly = true;   // Bloqueado (aquí cae el resultado)
                    montobs.ReadOnly = false;   // Permitir escribir el monto en bolívares
                    montobs.Focus();
                }
            }
        }

        private void UsdRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Solo actuamos si el RadioButton se acaba de activar (Checked == true)
            if (sender is RadioButton rb && rb.Checked)
            {
                if (UsdRadio.Checked)
                {
                    montobs.Clear();
                    montobs.ReadOnly = true;    // Bloqueado (aquí cae el resultado)
                    montousd.ReadOnly = false;  // Permitir escribir el monto en dólares
                    montousd.Focus();
                }
                else if (BsRadio.Checked)
                {
                    montousd.Clear();
                    montousd.ReadOnly = true;   // Bloqueado (aquí cae el resultado)
                    montobs.ReadOnly = false;   // Permitir escribir el monto en bolívares
                    montobs.Focus();
                }
            }
        }
        private void montobs_TextChanged(object sender, EventArgs e)
        {

            CalcularConversion();
        }

        private void montousd_TextChanged(object sender, EventArgs e)
        {


            CalcularConversion();
        }

        private void montobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (char.IsControl(e.KeyChar)) return;

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = ',';
                if (txt.Text.Contains(",")) e.Handled = true; // Si ya hay coma, la bloquea
                return;
            }

            if (!char.IsDigit(e.KeyChar)) e.Handled = true; // Bloquea letras y símbolos

        }

        private void montousd_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (char.IsControl(e.KeyChar)) return;

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = ',';
                if (txt.Text.Contains(",")) e.Handled = true; // Si ya hay coma, la bloquea
                return;
            }

            if (!char.IsDigit(e.KeyChar)) e.Handled = true; // Bloquea letras y símbolos

        }
    }
}
