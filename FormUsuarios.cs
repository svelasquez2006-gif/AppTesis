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


        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string cedula = cedulaTextBox.Text;
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            string usuario = usuarioTextBox.Text;
            string contrasena = contrasenaTextBox.Text;
            string correo = correoTextBox.Text;
            string jerarquia = jerarquiacomboBox.Text;
            this.usuarioTableAdapter.add(cedula,nombre,apellido,usuario,contrasena,correo,jerarquia);
            usuarioDataGridView.Refresh();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal= new FormPrincipal();
            principal.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            string cedula = cedulaTextBox.Text;
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            string usuario = usuarioTextBox.Text;
            string contrasena = contrasenaTextBox.Text;
            string correo = correoTextBox.Text;
            string jerarquia = jerarquiacomboBox.Text;
            this.usuarioTableAdapter.modify(nombre,apellido,usuario,contrasena,correo,jerarquia,cedula);
            usuarioDataGridView.Refresh();
        }
    }
}
