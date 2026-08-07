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
            

        }

        private void agregar_Click(object sender, EventArgs e)
        {

            if (cedulaTextBox.Text==""||nombreTextBox.Text==""||apellidoTextBox.Text=="" ||telefonoTextBox.Text==""||correoTextBox.Text=="") 
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    this.clienteTableAdapter.add(cedula,nombre,apellido,telefono,correo);
                }
                catch (Exception ex) 
                
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            
        }

        private void salir_Click(object sender, EventArgs e)
        {
           
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || telefonoTextBox.Text == "" || correoTextBox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
