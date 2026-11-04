using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        }

        private void Formvehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);
            nroPlacaTextBox.MaxLength = 7;
            vehiculoBindingSource.AddNew();
            

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            List<string> camposVacios = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox textBox && string.IsNullOrEmpty(textBox.Text))
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


            else if (nroPlacaTextBox.Text.Length < 7)
            {
                MessageBox.Show("el numero de placa no puede tener menos de 7 digitos", "Verificar placa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    string placa = nroPlacaTextBox.Text;
                    string marca = MarcaComboBox.Text;
                    string modelo = modeloTextBox.Text;
                    string tipo_vehiculo = TipoComboBox.Text;
                    int.TryParse(AñoDatePicker.Text, out int anio);
                    string color = colorTextBox.Text;
                    string estatus = estatuscombobox.Text;



                    this.vehiculoTableAdapter.add(placa,tipo_vehiculo, marca, modelo, anio, color, estatus);
                    this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);


                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar una placa que ya fue registrado en la base de datos.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void mantenimiento_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormMantenimiento mantenimiento = new FormMantenimiento();
            mantenimiento.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            List<string> camposVacios = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox textBox && string.IsNullOrEmpty(textBox.Text))
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


            else
            {
                try
                {
                    string placa = nroPlacaTextBox.Text;
                    string tipo_vehiculo = TipoComboBox.Text;
                    string marca = MarcaComboBox.Text;
                    string modelo = modeloTextBox.Text;
                    int.TryParse(AñoDatePicker.Text, out int anio);
                    string color = colorTextBox.Text;
                    string estatus = estatuscombobox.Text;

 

                    this.vehiculoTableAdapter.modify(tipo_vehiculo, marca, modelo, anio, color, estatus,placa);
                    this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);


                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar una placa que ya fue registrado en la base de datos.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void vehiculoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void colorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utiles.SoloLetras(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // 1. Cancelar cualquier edición en curso para no alterar la tabla
            vehiculoBindingSource.CancelEdit();

            // 2. Deseleccionar la tabla visualmente
            vehiculoDataGridView.ClearSelection();
            if (vehiculoDataGridView.CurrentRow != null)
            {
                vehiculoDataGridView.CurrentCell = null;
            }

            // 3. Limpiar manualmente cada caja de texto de manera segura
            nroPlacaTextBox.Clear(); // Ajusta según el nombre real de tu textbox de placa
            modeloTextBox.Clear();   // Ajusta según el nombre real de tu textbox de modelo
            colorTextBox.Clear();    // Ajusta según el nombre real de tu textbox de color

            // 4. Restablecer controles de fecha o numéricos (por ejemplo, el año actual)
            AñoDatePicker.Value = DateTime.Today; // O el control que utilices para el año

            // 5. Restablecer los selectores desplegables (ComboBoxes)
            if (TipoComboBox.Items.Count > 0) TipoComboBox.SelectedIndex = -1;
            if (MarcaComboBox.Items.Count > 0) MarcaComboBox.SelectedIndex = -1;
            if (estatuscombobox.Items.Count > 0) estatuscombobox.SelectedIndex = -1;
        }
    }
}
