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

            int.TryParse(cedulaTextBox.Text, out int ced);
            int cedula = ced;

            string telefono = telefonoTextBox.Text;
            string correo = correoTextBox.Text;

            int.TryParse(grado_LicenciaTextBox.Text, out int grado);
            int licencia = grado;

            string direccion = direccionTextBox.Text;
            int.TryParse(estatusTextBox.Text, out int stat);
            int estatus = stat;

            this.choferesTableAdapter.Guardar(nombre, apellido, cedula, telefono, correo, licencia, direccion, estatus);

            //this.Validate();
            //this.choferesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

            
        }



        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void choferesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
