using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class FormEmpresasSubcontratadas : Form
    {
        public FormEmpresasSubcontratadas()
        {
            InitializeComponent();
        }

        private void FormEmpresasSubcontratadas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.EmpresasSubcontratada' Puede moverla o quitarla según sea necesario.
            this.empresasSubcontratadaTableAdapter.Fill(this.dataBaseDataSet.EmpresasSubcontratada);
            telefonoTextBox.MaxLength = 7;
            textBoxTelfRepre.MaxLength = 7;
            dataBaseDataSet.EmpresasSubcontratada.rifColumn.AllowDBNull = true;
            empresasSubcontratadaBindingSource.AddNew();

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            List<string> camposVacios = new List<string>();
            bool emailvalido = ValidarCorreo.EsEmailValido(correoTextBox.Text);

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

            else if (!emailvalido)
            {
                MessageBox.Show("El correo ingresado no es válido. Por favor verifícalo.", "Formato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (RifTextBox.Text.Length < 7)
            {
                MessageBox.Show("El rif de la empresa no puede tener menos de 7 digitos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (telefonoTextBox.Text.Length < 7)
            {
                MessageBox.Show("El telefono no puede tener menos de 10 digitos", "Faltan Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string rif = RifTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string direccion = direccionTextBox.Text;
                    string correo = correoTextBox.Text;
                    string codigo = CodigoTelfComboBox.Text;
                    string celdigitos = telefonoTextBox.Text;
                    string telefono = codigo + celdigitos;
                    string celrep = $"{comboBoxTelfRepre.Text}{textBoxTelfRepre.Text}";
                    string nomrep = NombreRepresentanteTextBox.Text;
                    DateTime inicio = fechaInicioDateTimePicker.Value;
                    DateTime final = fechafinalDateTimePicker.Value;
                    string calificacion = CalificacionComboBox.Text;
                    string estatus = EstadoComboBox.Text;

                    empresasSubcontratadaBindingSource.EndEdit();

                    this.empresasSubcontratadaTableAdapter.add(rif,nombre,direccion,telefono,correo,nomrep,celrep,inicio,final,calificacion,estatus);
                    this.empresasSubcontratadaTableAdapter.Fill(this.dataBaseDataSet.EmpresasSubcontratada);

                    dataBaseDataSet.AcceptChanges();
                    empresasSubcontratadaBindingSource.AddNew();

                }
                catch (Exception ex)

                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void textBoxTelfRepre_TextChanged(object sender, EventArgs e)
        {
            // 1. Elimina cualquier cosa que no sea un número
            string limpio = Regex.Replace(textBoxTelfRepre.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (textBoxTelfRepre.Text != limpio)
            {
                textBoxTelfRepre.Text = limpio;
                textBoxTelfRepre.SelectionStart = textBoxTelfRepre.Text.Length; // Mantiene el cursor al final
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            List<string> camposVacios = new List<string>();
            bool emailvalido = ValidarCorreo.EsEmailValido(correoTextBox.Text);

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

            else if (!emailvalido)
            {
                MessageBox.Show("El correo ingresado no es válido. Por favor verifícalo.", "Formato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (RifTextBox.Text.Length < 7)
            {
                MessageBox.Show("El rif de la empresa no puede tener menos de 7 digitos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (telefonoTextBox.Text.Length < 7)
            {
                MessageBox.Show("El telefono no puede tener menos de 10 digitos", "Faltan Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string rif = RifTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string direccion = direccionTextBox.Text;
                    string correo = correoTextBox.Text;
                    string codigo = CodigoTelfComboBox.Text;
                    string celdigitos = telefonoTextBox.Text;
                    string telefono = codigo + celdigitos;
                    string celrep = $"{comboBoxTelfRepre.Text}{textBoxTelfRepre.Text}";
                    string nomrep = NombreRepresentanteTextBox.Text;
                    DateTime inicio = fechaInicioDateTimePicker.Value;
                    DateTime final = fechafinalDateTimePicker.Value;
                    string calificacion = CalificacionComboBox.Text;
                    string estatus = EstadoComboBox.Text;

                    empresasSubcontratadaBindingSource.EndEdit();

                    this.empresasSubcontratadaTableAdapter.modify(nombre, direccion, telefono, correo, nomrep, celrep, inicio, final, calificacion, estatus, rif);
                    this.empresasSubcontratadaTableAdapter.Fill(this.dataBaseDataSet.EmpresasSubcontratada);

                    dataBaseDataSet.AcceptChanges();
                    empresasSubcontratadaBindingSource.AddNew();

                }
                catch (Exception ex)

                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 2. Obtener la fila actual
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // 3. Leer el teléfono. Reemplaza "Telefono" por el nombre de tu columna
                string telefonoCompleto = fila.Cells["Telefono"].Value?.ToString() ?? "";
                string telefonorepCompleto = fila.Cells["TelefonoRepresentante"].Value?.ToString() ?? "";

                // 4. Verificar que tenga los 11 dígitos requeridos en Venezuela
                if (telefonoCompleto.Length >= 11 && telefonorepCompleto.Length >=11)
                {
                    // Extrae los primeros 4 dígitos (Código de área/operadora)
                    string codigo = telefonoCompleto.Substring(0, 4);

                    // Extrae los 7 dígitos restantes (Número local)
                    string numero = telefonoCompleto.Substring(4);

                    string codigorep = telefonorepCompleto.Substring(0, 4);

                    string numerorep = telefonorepCompleto.Substring(4);

                    // 5. Cargar los datos en los controles de tu formulario
                    CodigoTelfComboBox.Text = codigo; // Busca y asigna el código en el Combo
                    telefonoTextBox.Text = numero;      // Muestra el número en el TextBox
                    comboBoxTelfRepre.Text = codigorep;
                    textBoxTelfRepre.Text = numerorep;
                }
                else
                {
                    // Limpia los campos si el formato es inválido o está vacío
                    CodigoTelfComboBox.SelectedIndex = -1;
                    telefonoTextBox.Clear();

                    comboBoxTelfRepre .SelectedIndex = -1;
                    textBoxTelfRepre.Clear();

                }
            }
        }

        private void fechaInicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechafinalDateTimePicker.Value < fechaInicioDateTimePicker.Value)
            {
                fechafinalDateTimePicker.Value = fechaInicioDateTimePicker.Value;
            }
            fechafinalDateTimePicker.MinDate = fechaInicioDateTimePicker.Value;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            empresasSubcontratadaBindingSource.CancelEdit();
            this.Close();
            FormPrincipal prin = new FormPrincipal();
            prin.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;

            // 2. Si la fila falló por estar incompleta al moverse, la descarta de la memoria
            empresasSubcontratadaBindingSource.CancelEdit();
        }

        private void correoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTelfRepre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NombreRepresentanteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utiles.SoloLetras(e);
        }
    }
}
