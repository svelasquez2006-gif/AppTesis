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
            telefonoTextBox.MaxLength = 11;
            

        }

        private void agregar_Click(object sender, EventArgs e)
        {

            if (cedulaTextBox.Text==""||nombreTextBox.Text==""||apellidoTextBox.Text=="" ||telefonoTextBox.Text==""||correoTextBox.Text=="") 
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (telefonoTextBox.Text.Length < 10)
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
                    string telefono = telefonoTextBox.Text;
                    string correo = correoTextBox.Text;

                    this.clienteTableAdapter.add(cedula, nombre, apellido, telefono, correo);
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
            this.Hide();
            Formordenes ordenes = new Formordenes();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || telefonoTextBox.Text == "" || correoTextBox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (telefonoTextBox.Text.Length < 10)
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
                    string telefono = telefonoTextBox.Text;
                    string correo = correoTextBox.Text;

                    this.clienteTableAdapter.modify( nombre, apellido, telefono, correo,cedula);
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
    }
}
