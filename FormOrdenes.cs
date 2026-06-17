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
    public partial class Formordenes : Form
    {
        public Formordenes()
        {
            InitializeComponent();
        }

        private void ordenes_ViajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenes_ViajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basededatosDataSet);

        }

        private void Formordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatosDataSet.Ordenes_Viaje' Puede moverla o quitarla según sea necesario.
            this.ordenes_ViajeTableAdapter.Fill(this.basededatosDataSet.Ordenes_Viaje);

        }

        private void ordenes_ViajeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            RegistarOrd registrar = new RegistarOrd();
            registrar.Show();
        }
    }
}
