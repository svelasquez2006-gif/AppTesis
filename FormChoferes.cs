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
    public partial class FormChoferes : Form
    {
        public FormChoferes()
        {
            InitializeComponent();
        }

        private void FormChoferes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Chofer' Puede moverla o quitarla según sea necesario.
            this.choferTableAdapter.Fill(this.dataBaseDataSet.Chofer);


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistarChofer chofer = new RegistarChofer();
            chofer.ShowDialog();
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal princpal = new FormPrincipal();
            princpal.Show();
        }

        private void choferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.choferBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }
    }
}
