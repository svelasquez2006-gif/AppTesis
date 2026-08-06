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
    public partial class Formvehiculos : Form
    {
        public Formvehiculos()
        {
            InitializeComponent();
        }

        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Formvehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);


        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if(nroPlacaTextBox.Text==""|| marcaTextBox.Text==""||modeloTextBox.Text==""||anioTextBox.Text==""||colorTextBox.Text==""|| estatuscombobox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string placa = nroPlacaTextBox.Text;
                    string marca = marcaTextBox.Text;
                    string modelo = modeloTextBox.Text;
                    int.TryParse(anioTextBox.Text,out int anio);
                    string color = colorTextBox.Text;
                    string estatus = estatuscombobox.Text;
                    this.vehiculoTableAdapter.add(placa, marca, modelo, anio, color, estatus);
                }catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void mantenimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMantenimiento mantenimiento = new FormMantenimiento();
            mantenimiento.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (nroPlacaTextBox.Text == "" || marcaTextBox.Text == "" || modeloTextBox.Text == "" || anioTextBox.Text == "" || colorTextBox.Text == "" || estatuscombobox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string placa = nroPlacaTextBox.Text;
                    string marca = marcaTextBox.Text;
                    string modelo = modeloTextBox.Text;
                    int.TryParse(anioTextBox.Text, out int anio);
                    string color = colorTextBox.Text;
                    string estatus = estatuscombobox.Text;
                    this.vehiculoTableAdapter.Modify( marca, modelo, anio, color, estatus,placa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
