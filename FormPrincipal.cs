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
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Orden_Viaje' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);

            labelUser.Text = $"{SesionUsuario.Nombre} {SesionUsuario.Apellido}";
            labelRol.Text = SesionUsuario.Jerarquia;
            labelHora.Text = DateTime.Now.ToString("dd/MM/yyyy");
            string prohibido1 = "Empleado";
            string prohibido2 = "Test";
            if (SesionUsuario.Jerarquia == prohibido1 && SesionUsuario.Jerarquia == prohibido2)
            {
                Basededatos.Hide();
                Usuarios.Hide();
                Reportes.Hide();
            }

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
            SesionUsuario.Apellido = null;
            SesionUsuario.Nombre = null;
            SesionUsuario.Jerarquia = null;
            SesionUsuario.Cedula = null;
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
            FormBaseDatos bas = new FormBaseDatos();
            bas.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente insertar=new FormCliente();
            insertar.Show();
        }

        private void mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void rutas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRutas rutas = new FormRutas();
            rutas.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormUsuarios usuario = new FormUsuarios();
            usuario.Show();
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes rep = new Reportes();
            rep.Show();

        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orden_ViajeTableAdapter.FillBy(this.dataBaseDataSet.Orden_Viaje);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormEmpresasSubcontratadas sub = new FormEmpresasSubcontratadas();
            sub.Show();
        }
    }
}
