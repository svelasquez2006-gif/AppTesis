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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonChoferes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formchoferes choferes = new Formchoferes();
            choferes.ShowDialog();
        }

        private void panelMenú_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formlogin login=new Formlogin();
            login.Show();
        }

        private void btnVehículos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formvehiculos vehiculos= new Formvehiculos();
            vehiculos.Show();
        }

        private void c_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formordenes ordenes=new Formordenes();
            ordenes.Show();

        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarios usuario =new FormUsuarios();
            usuario.Show();

        }
    }
}
