using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);
            cedulaTextBox.MaxLength = 8;









        }

        private void agregar_Click(object sender, EventArgs e)
        {
            bool existe = ExisteUsuario(usuarioTextBox.Text.Trim(), cedulaTextBox.Text.Trim());
            bool emailvalido = ValidarCorreo.EsEmailValido(correoTextBox.Text);

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

            
            else if (!emailvalido)
            {
                MessageBox.Show("El correo ingresado no es válido. Por favor verifícalo.","Formato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (existe)
            {
                MessageBox.Show("Ya Esxiste este Usuario, Porfavor Ingrese Otro", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {

                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;
                    string usuario = usuarioTextBox.Text;
                    string contrasena = contrasenaTextBox.Text;
                    string correo = correoTextBox.Text;
                    string jerarquia = jerarquiacomboBox.Text;


                    this.usuarioTableAdapter.add(cedula, nombre, apellido, usuario, contrasena, correo, jerarquia);
                    this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);




                    jerarquiacomboBox.SelectedIndex = -1; // O asigna el valor por defecto que prefieras
                    EstadoComboBox.SelectedIndex = -1;
                }
                //valores nulos 
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //exepceiones de sql para vlor indice duplicado y error inesperado
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("La Cedula que intentaste Ingresar Ya la Posee otro usuario..", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado en la base de datos, " + ex.Message, "Error en la Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , Por Favor contacte a soporte tecnico para resolverlo" + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {

            this.Close();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            bool existe = ExisteUsuario(usuarioTextBox.Text.Trim(), cedulaTextBox.Text);
            bool emailvalido = ValidarCorreo.EsEmailValido(correoTextBox.Text);

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

            else if (!emailvalido)
            {
                MessageBox.Show("El correo ingresado no es válido. Por favor verifícalo.", "Formato Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (existe)
            {
                MessageBox.Show("Ya Esxiste este Usuario, Porfavor Ingrese Otro", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;
                    string usuario = usuarioTextBox.Text;
                    string contrasena = contrasenaTextBox.Text;
                    string correo = correoTextBox.Text;
                    string jerarquia = jerarquiacomboBox.Text;
                    string estado = EstadoComboBox.Text;



                    this.usuarioTableAdapter.modify(nombre, apellido, usuario, contrasena, correo, jerarquia,estado, cedula);
                    this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);

                    




                }

                //Valor nulos
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //exepceiones de sql para vlor indice duplicado y error inesperado
                catch (SqlException ex)
                {

                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("La Cedula que intentaste Ingresar Ya la Posee otro usuario.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private bool ExisteUsuario(string usuario, string cedula)
        {
            try
            {
                // Llamamos al método pasando solo los 2 argumentos que te pide: usuario y contraseña
                string resultado = this.usuarioTableAdapter.ExistUsuario(usuario, cedula)?.ToString() ?? "";

                // Si la base de datos encontró coincidencia, el resultado no será nulo ni vacío
                if (!string.IsNullOrEmpty(resultado))
                {
                    return true;  // Login correcto
                }
                else
                {
                    return false; // Login incorrecto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void usuarioDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            e.ThrowException = false;

            
             usuarioBindingSource.CancelEdit();

        }

        private void EstadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utiles.SoloLetras(e);
        }

        private void apellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            utiles.SoloLetras(e);
        }
    }
}
