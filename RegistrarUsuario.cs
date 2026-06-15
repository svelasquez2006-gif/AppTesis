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
    public partial class Registrarusu : Form
    {
        public Registrarusu()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void Registrarusu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.basededatosDataSet.Usuarios);

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string nombre = nombreTextBox.Text;
            string apellido = apellidoTextBox.Text;
            string cedula = cedulaTextBox.Text;
            string usuario = usuarioTextBox.Text;
            string contra = contrasenaTextBox.Text;
            int.TryParse(jerarquiaTextBox.Text,out int jerarquia);

            this.usuariosTableAdapter.Guardar(nombre,apellido,cedula,usuario,contra,jerarquia);
        }
    }
}
