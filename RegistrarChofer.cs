using Mysqlx.Crud;
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
    public partial class RegistarChofer : Form
    {
        public RegistarChofer()
        {
            InitializeComponent();
        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Choferes' Puede moverla o quitarla según sea necesario.
            this.choferesTableAdapter.Fill(this.basededatosDataSet.Choferes);

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            int.TryParse(cedulaTextBox.Text, out int cedula);
            string telefono = telefonoTextBox.Text;
            string correo = correoTextBox.Text;
            int.TryParse(grado_LicenciaTextBox.Text, out int licencia);
            string direccion = direccionTextBox.Text;
            int.TryParse(estatusTextBox.Text, out int estatus);

            //permite darle funcion a los botones guardando el valor del boton selecionado
            DialogResult resultado = MessageBox.Show($"Seguro desea guardar los siguientes datos?" +
                                                     $"Nombre:{nombre} {apellido} ," +
                                                     $"Cedula:{cedula}" +
                                                     $"Telefono:{telefono} ," +
                                                     $"Correo:{correo} ," +
                                                     $"Grado de Licencia{licencia}° ," +
                                                     $"Dirrecion:{direccion}", 
                                                     "¿Desea Guardar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes) { 
                this.choferesTableAdapter.Guardar(nombre, apellido, cedula, telefono, correo, licencia, direccion, estatus);
                }
            else if (resultado == DialogResult.No)
            {


            }

        }



        private void salir_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            cedulaTextBox.Clear();
            telefonoTextBox.Clear();
            correoTextBox.Clear();
            grado_LicenciaTextBox.Clear();
            direccionTextBox.Clear();
            estatusTextBox.Clear();
            this.Close();
            
        }

        private void choferesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
