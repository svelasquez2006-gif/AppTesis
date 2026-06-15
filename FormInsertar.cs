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
    public partial class FormInsertar : Form
    {
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void estatus_ChoferesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estatus_ChoferesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void FormInsertar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Jerarquia_Usuarios' Puede moverla o quitarla según sea necesario.
            this.jerarquia_UsuariosTableAdapter.Fill(this.basededatosDataSet.Jerarquia_Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Estatus_Vehiculo' Puede moverla o quitarla según sea necesario.
            this.estatus_VehiculoTableAdapter.Fill(this.basededatosDataSet.Estatus_Vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Estatus_Orden' Puede moverla o quitarla según sea necesario.
            this.estatus_OrdenTableAdapter.Fill(this.basededatosDataSet.Estatus_Orden);
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Estatus_Choferes' Puede moverla o quitarla según sea necesario.
            this.estatus_ChoferesTableAdapter.Fill(this.basededatosDataSet.Estatus_Choferes);

        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal prin= new FormPrincipal();
            prin.Show();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            //choferes
            /*int.TryParse(cod_EstatusTextBox.Text,out int i);
            int idchofer = i;
            string stchofer=estatusTextBox.Text;
            */

            //ordenes
            /*int.TryParse(cod_EstatusTextBox1.Text, out int a);
            int idordenes = a;
            string stordenes=estatusTextBox1.Text;
            */

            //jerarquia
            /*int.TryParse(idJerarquiaTextBox.Text, out int b);
            int idjerarquia = b;
            string jerarquia = jerarquiaTextBox.Text;
            */

            
            int.TryParse(cod_EstatusTextBox2.Text, out int idvehiculos);            
            string stvehiculo = estatusTextBox2.Text;
            /*
            this.estatus_ChoferesTableAdapter.InsertQuery(idchofer, stchofer);
            this.estatus_OrdenTableAdapter.InsertQuery(idordenes, stordenes);
            this.jerarquia_UsuariosTableAdapter.InsertQuery(idjerarquia, jerarquia);
            */
            this.estatus_VehiculoTableAdapter.InsertQuery(idvehiculos,stvehiculo);

            this.jerarquia_UsuariosTableAdapter.Fill(this.basededatosDataSet.Jerarquia_Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Estatus_Vehiculo' Puede moverla o quitarla según sea necesario.
            this.estatus_VehiculoTableAdapter.Fill(this.basededatosDataSet.Estatus_Vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Estatus_Orden' Puede moverla o quitarla según sea necesario.
            this.estatus_OrdenTableAdapter.Fill(this.basededatosDataSet.Estatus_Orden);
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Estatus_Choferes' Puede moverla o quitarla según sea necesario.
            this.estatus_ChoferesTableAdapter.Fill(this.basededatosDataSet.Estatus_Choferes);
        }
    }
}
