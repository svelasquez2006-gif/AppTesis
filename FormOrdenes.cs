using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        }

        private void Formordenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dataBaseDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dataBaseDataSet.Vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Chofer' Puede moverla o quitarla según sea necesario.
            this.choferTableAdapter.Fill(this.dataBaseDataSet.Chofer);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Rutas' Puede moverla o quitarla según sea necesario.
            this.rutasTableAdapter.Fill(this.dataBaseDataSet.Rutas);
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Orden_Viaje' Puede moverla o quitarla según sea necesario.
            this.orden_ViajeTableAdapter.Fill(this.dataBaseDataSet.Orden_Viaje);
            //this.orden_ViajeTableAdapter.ScalarQuery();
            BsRadio.Checked = true;




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
            if (RutaComboBox.Text=="" ||ChoferComboBox.Text == "" || PlacaComboBox.Text == "" || ClienteComboBox.Text == "" 
                || fecha_InicioDateTimePicker==null || fecha_FinalizacionDateTimePicker==null || EstatusComboBox.Text == "")
            {
                MessageBox.Show("Se esta enviado un campo vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (UsdRadio.Checked==false && BsRadio.Checked==false)
            {
                MessageBox.Show("Seleccione un tipo de moneda", "Moneda no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (montobs.Text=="")
            {
                MessageBox.Show("Se debe ingresar un monto a pagar en la orden de viaje", "No se puede agregar una orden sin pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                try
                {

                    string ruta = RutaComboBox.Text;
                    int.TryParse(dias_ViajeTextBox.Text,out int dias);
                    decimal.TryParse(distanciaTextBox.Text, out decimal distancia);
                    string origen =origenTextBox.Text;
                    string paradas =paradasTextBox.Text;
                    string destino = destinoTextBox.Text;

                    string chofer =ChoferComboBox.Text;
                    string placa =PlacaComboBox.Text;
                    string cliente = ClienteComboBox.Text;
                    

                    DateTime inicio = fecha_InicioDateTimePicker.Value;
                    DateTime final = fecha_FinalizacionDateTimePicker.Value;                  
                    string estatus = EstatusComboBox.Text;
                    decimal.TryParse(tasa_USDTextBox.Text, out decimal tasa);
                    decimal.TryParse(montobs.Text, out decimal monto);


                    this.orden_ViajeTableAdapter.add(ruta,dias,distancia,origen,paradas, destino,chofer, placa, cliente,  inicio, final, tasa,monto,estatus);
                    this.orden_ViajeTableAdapter.Fill(this.dataBaseDataSet.Orden_Viaje);
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
                    MessageBox.Show("Ha Ocurrido un error inesperado" + ex.Message, "Ha Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void orden_ViajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orden_ViajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void orden_ViajeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (orden_ViajeDataGridView.CurrentRow != null)
            {
                // 1. Obtener las fechas de la fila seleccionada
                DateTime nuevaFechaInicio = Convert.ToDateTime(orden_ViajeDataGridView.CurrentRow.Cells["Fecha_Inicio"].Value);
                DateTime nuevaFechaFin = Convert.ToDateTime(orden_ViajeDataGridView.CurrentRow.Cells["Fecha_Finalizacion"].Value);

                // 2. CORRECCIÓN: Usar 01/01/1753 en lugar de DateTime.MinValue
                fecha_FinalizacionDateTimePicker.MinDate = new DateTime(1753, 1, 1);

                // 3. Asignar primero la fecha de fin (así nunca será menor que el MinDate temporal)
                fecha_FinalizacionDateTimePicker.Value = nuevaFechaFin;

                // 4. Asignar la fecha de inicio
                fecha_InicioDateTimePicker.Value = nuevaFechaInicio;

                // 5. Aplicar el límite real de seguridad
                fecha_FinalizacionDateTimePicker.MinDate = fecha_InicioDateTimePicker.Value;
            }
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCliente formCliente = new FormCliente();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (RutaComboBox.Text == "" || ChoferComboBox.Text == "" || PlacaComboBox.Text == "" || ClienteComboBox.Text == ""
                || fecha_InicioDateTimePicker == null || fecha_FinalizacionDateTimePicker == null || EstatusComboBox.Text == "")
            {
                MessageBox.Show("Se esta enviado un campo vacio", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (UsdRadio.Checked == false && BsRadio.Checked == false)
            {
                MessageBox.Show("Seleccione un tipo de moneda", "Moneda no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (montobs.Text == "")
            {
                MessageBox.Show("Se debe ingresar un monto a pagar en la orden de viaje", "No se puede agregar una orden sin pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                try
                {
                    int.TryParse(iDOrdenes_ViajeTextBox.Text,out int id);
                    string ruta = RutaComboBox.Text;
                    int.TryParse(dias_ViajeTextBox.Text, out int dias);
                    decimal.TryParse(distanciaTextBox.Text, out decimal distancia);
                    string origen = origenTextBox.Text;
                    string paradas = paradasTextBox.Text;
                    string destino = destinoTextBox.Text;

                    string chofer = ChoferComboBox.Text;
                    string placa = PlacaComboBox.Text;
                    string cliente = ClienteComboBox.Text;


                    DateTime inicio = fecha_InicioDateTimePicker.Value;
                    DateTime final = fecha_FinalizacionDateTimePicker.Value;
                    string estatus = EstatusComboBox.Text;
                    decimal.TryParse(tasa_USDTextBox.Text, out decimal tasa);
                    decimal.TryParse(montobs.Text, out decimal monto);

                    this.orden_ViajeTableAdapter.modify(ruta,dias,distancia,origen,paradas,destino,chofer,placa,cliente,inicio,final,tasa,monto,estatus, id);
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
                    MessageBox.Show("Ha Ocurrido un error inesperado" + ex.Message, "Ha Ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iDOrdenes_ViajeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vehiculos_NroPlacaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedula_ClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedula_ChoferTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void distancia_Esperada_KmTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void RutaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Validar que exista una selección válida
            
        }

        private void fecha_InicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (fecha_FinalizacionDateTimePicker.Value < fecha_InicioDateTimePicker.Value)
            {
                fecha_FinalizacionDateTimePicker.Value = fecha_InicioDateTimePicker.Value;
            }
            fecha_FinalizacionDateTimePicker.MinDate = fecha_InicioDateTimePicker.Value;
        }

        //clases
        private void CalcularConversion()
        {
            // Aseguramos que haya una tasa válida antes de operar para evitar divisiones entre cero
            if (decimal.TryParse(tasa_USDTextBox.Text, out decimal tasa) && tasa > 0)
            {
                decimal.TryParse(montobs.Text, out decimal monto);
                decimal.TryParse(montousd.Text, out decimal monto2);

                if (UsdRadio.Checked)
                {
                    montobs.ReadOnly =true; // Nota: Si deshabilitas montopri aquí, el usuario no podrá escribir más en él. Revisa si querías deshabilitar montoresult.
                    montousd.ReadOnly = false;
                    decimal resultado = monto * tasa;
                    // ¡Cuidado! Si escribes el resultado en montopri, sobreescribirás lo que el usuario está digitando.
                    montobs.Text = resultado.ToString("N2");
                }
                else if (BsRadio.Checked)
                {
                    montousd.ReadOnly = true;
                    montobs.ReadOnly=false;
                    decimal resultado = monto2 / tasa;
                    montousd.Text = resultado.ToString("N2");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CalcularConversion();
        }

        private void RutaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 1. Validaciones de selección
            if (RutaComboBox.SelectedIndex == -1 || RutaComboBox.SelectedValue == null)
                return;

            if (RutaComboBox.SelectedValue is System.Data.DataRowView)
                return;

            try
            {
                string idBuscar = RutaComboBox.SelectedValue.ToString();

                // 2. Traer los datos a una tabla temporal (NO sobrescribe la lista del ComboBox)
                var tablaTemporal = this.rutasTableAdapter.GetDataByID(idBuscar);

                // 3. Cargar los campos en los TextBox
                if (tablaTemporal != null && tablaTemporal.Rows.Count > 0)
                {
                    var fila = tablaTemporal[0];

                    dias_ViajeTextBox.Text = fila.Dias_Viaje.ToString();
                    distanciaTextBox.Text = fila.Distancia_km.ToString();
                    origenTextBox.Text = fila.Origen;
                    paradasTextBox.Text = fila.Paradas;
                    destinoTextBox.Text = fila.Destino;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la ruta: " + ex.Message);
            }
        }

        // 2. Vincul
    }
}
