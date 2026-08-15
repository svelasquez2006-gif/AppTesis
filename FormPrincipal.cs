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
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Orden_Viaje' Puede moverla o quitarla según sea necesario.
            this.orden_ViajeTableAdapter.Fill(this.dataBaseDataSet.Orden_Viaje);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);

        }

        private void buttonChoferes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChoferes choferes = new FormChoferes();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente insertar=new FormCliente();
            insertar.ShowDialog();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }
    }
}
