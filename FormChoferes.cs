using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (cedulaTextBox.Text==""|| nombreTextBox.Text==""|| apellidoTextBox.Text==""||telefonoTextBox.Text==""||correoTextBox.Text==""||licenciacombobox.Text==""||direccionTextBox.Text==""||estatuscombobox.Text=="")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;
                    string telefono = telefonoTextBox.Text;
                    string correo = correoTextBox.Text;
                    int.TryParse(licenciacombobox.Text, out int licencia);
                    string dirreccion = direccionTextBox.Text;
                    string estatus = estatuscombobox.Text;
                    this.choferTableAdapter.add(cedula, nombre, apellido, telefono, correo, licencia, dirreccion, estatus);
                    this.choferTableAdapter.Fill(this.dataBaseDataSet.Chofer);

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Un campo fue enviado vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar un valor que ya fue registrado en la base de datos.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado en la base de datos, " + ex.Message, "Error en la Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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

        private void estatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || telefonoTextBox.Text == "" || correoTextBox.Text == "" || licenciacombobox.Text == "" || direccionTextBox.Text == "" || estatuscombobox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;
                    string telefono = telefonoTextBox.Text;
                    string correo = correoTextBox.Text;
                    int.TryParse(licenciacombobox.Text, out int licencia);
                    string dirreccion = direccionTextBox.Text;
                    string estatus = estatuscombobox.Text;
                    this.choferTableAdapter.Modify(nombre, apellido, telefono, correo, licencia, dirreccion, estatus, cedula);

                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar un valor que ya fue registrado en la base de datos.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado en la base de datos, " + ex.Message, "Error en la Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error inesperado , " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
