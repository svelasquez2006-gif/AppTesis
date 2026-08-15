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
            anioTextBox.MaxLength = 4;

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if(nroPlacaTextBox.Text==""|| marcaTextBox.Text==""||modeloTextBox.Text==""||anioTextBox.Text==""||colorTextBox.Text==""|| estatuscombobox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string marca = marcaTextBox.Text;
                    string modelo = modeloTextBox.Text;
                    int.TryParse(anioTextBox.Text, out int anio);
                    string color = colorTextBox.Text;
                    string estatus = estatuscombobox.Text;
                    this.vehiculoTableAdapter.add(placa, marca, modelo, anio, color, estatus);
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
            if (nroPlacaTextBox.Text == "" || marcaTextBox.Text == "" || modeloTextBox.Text == "" || anioTextBox.Text == "" || colorTextBox.Text == "" || estatuscombobox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string placa = nroPlacaTextBox.Text;
                    string marca = marcaTextBox.Text;
                    string modelo = modeloTextBox.Text;
                    int.TryParse(anioTextBox.Text, out int anio);
                    string color = colorTextBox.Text;
                    string estatus = estatuscombobox.Text;
                    this.vehiculoTableAdapter.Modify( marca, modelo, anio, color, estatus,placa);
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

        private void anioTextBox_TextChanged(object sender, EventArgs e)
        {
            string limpio = Regex.Replace(anioTextBox.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (anioTextBox.Text != limpio)
            {
                anioTextBox.Text = limpio;
                anioTextBox.SelectionStart = anioTextBox.Text.Length; // Mantiene el cursor al final
            }
        }
    }
}
