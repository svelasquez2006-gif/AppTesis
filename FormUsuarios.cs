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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);
            cedulaTextBox.MaxLength = 8;
            


        }

        private void agregar_Click(object sender, EventArgs e)
        {
            bool existe = ExisteUsuario(usuarioTextBox.Text.Trim());

            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || usuarioTextBox.Text == "" || contrasenaTextBox.Text == "" || correoTextBox.Text == "" || jerarquiacomboBox == null)
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(existe)
            {
                MessageBox.Show("Ya Esxiste este Usuario, Porfavor Ingrese Otro","Usuario Existente",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {

                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text.Trim();
                    string apellido = apellidoTextBox.Text.Trim();
                    string usuario = usuarioTextBox.Text.Trim();
                    string contrasena = contrasenaTextBox.Text.Trim();
                    string correo = correoTextBox.Text.Trim();
                    string jerarquia = jerarquiacomboBox.Text;
                    this.usuarioTableAdapter.add(cedula, nombre, apellido, usuario, contrasena, correo, jerarquia);
                    this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);
                    usuarioDataGridView.Refresh();
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
            bool existe = ExisteUsuario(usuarioTextBox.Text.Trim());

            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || usuarioTextBox.Text == "" || contrasenaTextBox.Text == "" || correoTextBox.Text == "" || jerarquiacomboBox == null)
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string nombre = nombreTextBox.Text.Trim();
                    string apellido = apellidoTextBox.Text.Trim();
                    string usuario = usuarioTextBox.Text.Trim();
                    string contrasena = contrasenaTextBox.Text.Trim();
                    string correo = correoTextBox.Text.Trim();
                    string jerarquia = jerarquiacomboBox.Text;
                    this.usuarioTableAdapter.modify(nombre, apellido, usuario, contrasena, correo, jerarquia, cedula);
                    usuarioDataGridView.Refresh();
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

        private bool ExisteUsuario(string usuario)
        {
            try
            {
                // Llamamos al método pasando solo los 2 argumentos que te pide: usuario y contraseña
                string resultado = this.usuarioTableAdapter.ExistUsuario(usuario);

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
    }
}
