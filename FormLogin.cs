using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class Formlogin : Form
    {
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
            string usuario=usuarioTextBox.Text,contra=contrasenaTextBox.Text;

            if (usuario==""||contra=="")
            {
               MessageBox.Show("Por favor, Ingresar su Usuario y Contraseña","Campos Vacios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
             
            //proxima funcion para diseñar el login
            this.Hide();
            FormPrincipal Principal = new FormPrincipal();
            Principal.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            

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
    }
}
