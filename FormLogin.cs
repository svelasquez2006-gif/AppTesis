using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class Formlogin : Form
    {
        private int intentos = 0;
        private int max_intentos = 3;
        public Formlogin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            string usuario=usuarioTextBox.Text.Trim(),contra=contrasenaTextBox.Text.Trim();
            

            if(intentos<3){

                if (usuarioTextBox.Text==""|| contrasenaTextBox.Text == "")
                {
                    MessageBox.Show("Por favor, Rellene ambos cmapos","Campos Vacios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);    
                }

                else if(usuarioTextBox.Text == "")
                {
                    MessageBox.Show("Por favor, Rellene el campo de usuario", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (contrasenaTextBox.Text == "")
                {
                    MessageBox.Show("Por favor, Rellene el campo de contraseña", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    bool esvalido = ValidarUsuario(usuario, contra);
                    if(esvalido)
                    {
                        MessageBox.Show($"Inicio de Sesion Exitoso, Bienvenido {usuario}","Inicio de Sesion Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        this.Hide();
                        FormPrincipal Principal = new FormPrincipal();
                        Principal.Show();
                        intentos=0;
                    }
                    else 
                    {
                        int restantes = (max_intentos - 1) - intentos;
                        MessageBox.Show($"El usuario o la contraseña son incorrectos. Quedan {restantes} intentos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Limpiar campo de contraseña y enfocar usuario para reintentar
                        usuarioTextBox.Clear();
                        contrasenaTextBox.Clear();
                        usuarioTextBox.Focus();
                        intentos++;
                        if (intentos == max_intentos)
                        {
                            MessageBox.Show("Demasiados Intentos de Inicio de Sesion, Luego de Este mensaje sera expulsado del programa", "Demasiados Intentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataBaseDataSet.Usuario);



        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (contrasenaTextBox.UseSystemPasswordChar == true)
            {
                contrasenaTextBox.UseSystemPasswordChar= false;
            }
            else
            {
                contrasenaTextBox.UseSystemPasswordChar = true;
            }
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }
        private bool ValidarUsuario(string usuario, string contra)
        {
            try
            {
                // Llamamos al método pasando solo los 2 argumentos que te pide: usuario y contraseña
                string resultado = this.usuarioTableAdapter.Login(usuario, contra);

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

