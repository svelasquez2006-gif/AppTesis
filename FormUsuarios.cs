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
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.basededatosDataSet.Usuarios);

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Registrarusu agregarusu = new Registrarusu();
            agregarusu.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal= new FormPrincipal();
            principal.Show();
        }
    }
}
