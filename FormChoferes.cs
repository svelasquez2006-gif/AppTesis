using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.dataBaseDataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Chofer' Puede moverla o quitarla según sea necesario.
            this.choferTableAdapter.Fill(this.dataBaseDataSet.Chofer);
            Filtro.SelectedItem = "<Selecionar>";
            telefonoTextBox.MaxLength = 11;     
            cedulaTextBox.MaxLength = 8;
            experienciaTextBox.MaxLength = 2;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
     
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || telefonoTextBox.Text == "" || correoTextBox.Text == "" || licenciacombobox.Text == "" || direccionTextBox.Text == "" || estatuscombobox.Text == "")
            {
                MessageBox.Show("No se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cedulaTextBox.Text.Length<7)
            {
                MessageBox.Show("No se puede registrar Choferes con cedulas menores a 7 digitos", "Corregir longitud de Cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (telefonoTextBox.Text.Length<10)
            {
                MessageBox.Show("El telefono no puede tener menos de 10 digitos", "Faltan Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;
                    DateTime fechaNacimiento = fecha_NacimientoDateTimePicker.Value;
                    int.TryParse(edadTextBox.Text, out int ed);
                    string telefono = telefonoTextBox.Text;
                    string correo = correoTextBox.Text;
                    int.TryParse(licenciacombobox.Text, out int licencia);
                    int.TryParse(experienciaTextBox.Text, out int experiencia);
                    string dirreccion = direccionTextBox.Text;
                    string ruta = RutaComboBox.Text;
                    string estatus = estatuscombobox.Text;
                    string afiliacion = AfiliacionComboBox.Text;
                    this.choferTableAdapter.add(cedula, nombre, apellido,fechaNacimiento,ed, telefono, correo, licencia,experiencia, dirreccion,ruta, estatus,afiliacion);
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
                        MessageBox.Show("Intentas ingresar Una cedula que ya pertenece a otro chofer.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellidoTextBox.Text == "" || telefonoTextBox.Text == "" || correoTextBox.Text == "" || licenciacombobox.Text == "" || direccionTextBox.Text == "" || estatuscombobox.Text == "")
            {
                MessageBox.Show("no se pueden enviar campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cedulaTextBox.Text.Length < 7)
            {
                MessageBox.Show("No se puede registrar Choferes con cedulas menores a 7 digitos", "Corregir longitud de Cedula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (telefonoTextBox.Text.Length < 10)
            {
                MessageBox.Show("El telefono no puede tener menos de 10 digitos", "Faltan Digitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string cedula = cedulaTextBox.Text;
                    string nombre = nombreTextBox.Text;
                    string apellido = apellidoTextBox.Text;
                    DateTime fechaNacimiento = fecha_NacimientoDateTimePicker.Value;
                    int.TryParse(edadTextBox.Text, out int ed);
                    string telefono = telefonoTextBox.Text;
                    string correo = correoTextBox.Text;
                    int.TryParse(licenciacombobox.Text, out int licencia);
                    int.TryParse(experienciaTextBox.Text, out int experiencia);
                    string dirreccion = direccionTextBox.Text;
                    string ruta = RutaComboBox.Text;
                    string estatus = estatuscombobox.Text;
                    string afiliacion = AfiliacionComboBox.Text;
                    this.choferTableAdapter.modify(nombre, apellido,fechaNacimiento,ed, telefono, correo, licencia ,experiencia, dirreccion,ruta, estatus,afiliacion, cedula);

                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Intentas ingresar Una cedula que ya pertenece a otro chofer.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal princpal = new FormPrincipal();
            princpal.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {
            // 1. Elimina cualquier cosa que no sea un número
            string limpio = Regex.Replace(telefonoTextBox.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (telefonoTextBox.Text != limpio)
            {
                telefonoTextBox.Text = limpio;
                telefonoTextBox.SelectionStart = telefonoTextBox.Text.Length; // Mantiene el cursor al final
            }

        }

        private void cedulaTextBox_TextChanged(object sender, EventArgs e)
        {
            string limpio = Regex.Replace(cedulaTextBox.Text, @"[^\d]", "");

            // 2. Si cambió el texto, lo actualiza (evita bucles infinitos)
            if (cedulaTextBox.Text != limpio)
            {
                cedulaTextBox.Text = limpio;
                cedulaTextBox.SelectionStart = cedulaTextBox.Text.Length; // Mantiene el cursor al final
            }
        }

        private void fecha_NacimientoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // 1. Obtener la fecha seleccionada en el DatePicker
            DateTime fechaNacimiento = fecha_NacimientoDateTimePicker.Value;
            DateTime fechaActual = DateTime.Today;

            // 2. Calcular la diferencia inicial en años
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // 3. Ajustar si no ha pasado su cumpleaños este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            // El resultado está en la variable 'edad'
            edadTextBox.Text = edad.ToString();
        }

        private void experienciaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
