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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void ordenes_ViajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dataBaseDataSet.Cliente);

            cedulaTextBox.MaxLength = 8;
            telefonoTextBox.MaxLength = 7;






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

            else if (cedulaTextBox.Text.Length < 7)
            {
                MessageBox.Show("No se puede registrar clientes con cedulas menores a 7 digitos", "Corregir longitud de Cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            else if (telefonoTextBox.Text.Length < 7)
            {
                MessageBox.Show("El telefono no puede tener menos de 10 digitos", "Faltan Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;

                    string codigo = CodigoTelfComboBox.Text;
                    string celdigitos = telefonoTextBox.Text;
                    string telefono = codigo + celdigitos;

                    string correo = correoTextBox.Text;
                    string dirreccion = DirrecionTextBox.Text;
                    string tipo = TipoComboBox.Text;

                    this.clienteTableAdapter.add(cedula, nombre, apellido, telefono, correo,dirreccion,tipo);
                    this.clienteTableAdapter.Fill(this.dataBaseDataSet.Cliente);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar una cedula o rif que ya pertenece a otro cliente.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            this.Hide();
            Formordenes ordenes = new Formordenes();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
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


            else if (cedulaTextBox.Text.Length < 7)
            {
                MessageBox.Show("No se puede registrar clientes con cedulas menores a 7 digitos", "Corregir longitud de Cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (telefonoTextBox.Text.Length < 7)
            {
                MessageBox.Show("El telefono no puede tener menos de 10 digitos", "Faltan Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;

                    string codigo = CodigoTelfComboBox.Text;
                    string celdigitos = telefonoTextBox.Text;
                    string telefono = codigo + celdigitos;

                    string correo = correoTextBox.Text;
                    string dirreccion = DirrecionTextBox.Text;
                    string tipo = TipoComboBox.Text;

                    this.clienteTableAdapter.modify( nombre, apellido, telefono, correo,dirreccion,tipo,cedula);
                    this.clienteTableAdapter.Fill(this.dataBaseDataSet.Cliente);
                }
                catch (Exception ex)

                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cedulaTextBox_TextChanged(object sender, EventArgs e)
        {
            string limpio = Regex.Replace(cedulaTextBox.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (cedulaTextBox.Text != limpio)
            {
                cedulaTextBox.Text = limpio;
                cedulaTextBox.SelectionStart = cedulaTextBox.Text.Length; // Mantiene el cursor al final
            }
        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {
            // 1. Elimina cualquier cosa que no sea un número
            string limpio = Regex.Replace(telefonoTextBox.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (telefonoTextBox.Text != limpio)
            {
                telefonoTextBox.Text = limpio;
                telefonoTextBox.SelectionStart = telefonoTextBox.Text.Length; // Mantiene el cursor al final
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 2. Obtener la fila actual
                DataGridViewRow fila = clienteDataGridView.Rows[e.RowIndex];

                // 3. Leer el teléfono. Reemplaza "Telefono" por el nombre de tu columna
                string telefonoCompleto = fila.Cells["Telefono"].Value?.ToString() ?? "";

                // 4. Verificar que tenga los 11 dígitos requeridos en Venezuela
                if (telefonoCompleto.Length >= 11)
                {
                    // Extrae los primeros 4 dígitos (Código de área/operadora)
                    string codigo = telefonoCompleto.Substring(0, 4);

                    // Extrae los 7 dígitos restantes (Número local)
                    string numero = telefonoCompleto.Substring(4);

                    // 5. Cargar los datos en los controles de tu formulario
                    CodigoTelfComboBox.Text = codigo; // Busca y asigna el código en el Combo
                    telefonoTextBox.Text = numero;      // Muestra el número en el TextBox
                }
                else
                {
                    // Limpia los campos si el formato es inválido o está vacío
                    CodigoTelfComboBox.SelectedIndex = -1;
                    telefonoTextBox.Clear();
                }
            }
        }

        private void TipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoComboBox.Text=="Natural")
            {
                labelced.Text = "Cedula:";
                LabelApellido.Text = "Apellido:";
                
            }
            else
            {
                labelced.Text = "Rif:";
                LabelApellido.Text = "Forma  \nSocietaria:";
            }
        }

        private void cedulaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LabelApellido_Click(object sender, EventArgs e)
        {

        }
    }
}
