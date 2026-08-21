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
    public partial class FormRutas : Form
    {
        public FormRutas()
        {
            InitializeComponent();
        }

        private void FormRutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.dataBaseDataSet.Rutas);

        }

        private void rutasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();

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


            else
            {
                try
                {
                    string Ruta = nombre_RutaTextBox.Text;
                    int.TryParse(dias_ViajeTextBox.Text, out int dias);
                    decimal.TryParse(distancia_kmTextBox.Text, out decimal distancia);
                    string origen = origenTextBox.Text;
                    string paradas = paradasTextBox.Text;
                    string destino = destinoTextBox.Text;
                    this.rutasTableAdapter.add(Ruta,dias,distancia,origen,paradas,destino);
                    this.rutasTableAdapter.Fill(this.dataBaseDataSet.Rutas);
                    
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Ya existe una ruta con ese nombre.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void dias_ViajeTextBox_TextChanged(object sender, EventArgs e)
        {
            string limpio = Regex.Replace(dias_ViajeTextBox.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (dias_ViajeTextBox.Text != limpio)
            {
                dias_ViajeTextBox.Text = limpio;
                dias_ViajeTextBox.SelectionStart = dias_ViajeTextBox.Text.Length; // Mantiene el cursor al final
            }
        }

        private void distancia_kmTextBox_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal =distancia_kmTextBox.Text;

            // 1. Remueve cualquier caracter que no sea dígito ni coma
            string limpio = Regex.Replace(textoOriginal, @"[^\d,]", "");

            // 2. Si hay más de una coma, conserva solo la primera
            int primerComa = limpio.IndexOf(',');
            if (primerComa != -1)
            {
                // Mantiene todo hasta la primera coma y elimina comas adicionales del resto
                string parteEntera = limpio.Substring(0, primerComa + 1);
                string parteDecimal = limpio.Substring(primerComa + 1).Replace(",", "");
                limpio = parteEntera + parteDecimal;
            }

            // 3. Si cambió el texto, lo actualiza
            if (distancia_kmTextBox.Text != limpio)
            {
                distancia_kmTextBox.Text = limpio;
                distancia_kmTextBox.SelectionStart = distancia_kmTextBox.Text.Length;
            }
        }

        private void modificar_Click(object sender, EventArgs e)
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


            else
            {
                try
                {
                    string Ruta = nombre_RutaTextBox.Text;
                    int.TryParse(dias_ViajeTextBox.Text, out int dias);
                    decimal.TryParse(distancia_kmTextBox.Text, out decimal distancia);
                    string origen = origenTextBox.Text;
                    string paradas = paradasTextBox.Text;
                    string destino = destinoTextBox.Text;
                    this.rutasTableAdapter.modify(dias, distancia, origen, paradas, destino, Ruta);
                    this.rutasTableAdapter.Fill(this.dataBaseDataSet.Rutas);

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Ya existe una ruta con ese nombre.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
