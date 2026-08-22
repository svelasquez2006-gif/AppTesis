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
using System.Globalization;
using System.Text.RegularExpressions;

namespace AppTesis
{
    public partial class Formordenes : Form
    {
        // Bandera para evitar que la conversión se ejecute al seleccionar filas en el DataGrid
        private bool esCargaDeDatos = false;
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
            List<string> camposVacios = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    // Agrega el nombre del campo a la lista
                    camposVacios.Add(textBox.Name);
                }
            }

            // Si la lista tiene elementos, muestra el mensaje
            if (camposVacios.Count > 0)
            {
                string mensaje = "Los siguientes campos están vacíos:\n" + string.Join("\n", camposVacios);
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (e.RowIndex < 0) return;

            // 1. ACTIVAR la bandera para bloquear la conversión automática
            esCargaDeDatos = true;

            try
            {
                // Obtener la fila donde se hizo clic
                DataGridViewRow fila = orden_ViajeDataGridView.Rows[e.RowIndex];

                // Cargar el monto de la base de datos (Bs) en el TextBox montobs
                string montoBsBD = fila.Cells["Pago_Bs"].Value?.ToString() ?? "0,00";
                montobs.Text = montoBsBD;

                // Calcular la equivalencia en USD para mostrarla en el campo montousd
                if (decimal.TryParse(tasa_USDTextBox.Text.Replace('.', ','), out decimal tasa) && tasa > 0)
                {
                    if (decimal.TryParse(montoBsBD.Replace('.', ','), out decimal bsValue))
                    {
                        montousd.Text = Math.Round(bsValue / tasa, 2).ToString("0.00");
                    }
                }
            }
            finally
            {
                // 2. DESACTIVAR la bandera para permitir que el usuario vuelva a escribir
                esCargaDeDatos = false;
            }


            orden_ViajeDataGridView.Columns["Pago_Bs"].DefaultCellStyle.Format = "N2";
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
            List<string> camposVacios = new List<string>();

            foreach (Control c in this.Controls)
            {
                if (c is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    // Agrega el nombre del campo a la lista
                    camposVacios.Add(textBox.Name);
                }
            }

            // Si la lista tiene elementos, muestra el mensaje
            if (camposVacios.Count > 0)
            {
                string mensaje = "Los siguientes campos están vacíos:\n" + string.Join("\n", camposVacios);
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    this.orden_ViajeTableAdapter.Fill(this.dataBaseDataSet.Orden_Viaje);
                    montobs.Text = "0,00";
                    montousd.Text = "0,00";

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
            // 1. Validar la tasa de cambio primero

            if (esCargaDeDatos) return;
            // 1. Validar la tasa de cambio usando la cultura actual o InvariantCulture
            // Normalizar la tasa
            string tasaTexto = tasa_USDTextBox.Text.Replace('.', ',');
            if (!decimal.TryParse(tasaTexto, out decimal tasa) || tasa <= 0)
                return;

            try
            {
                if (UsdRadio.Checked)
                {
                    string usdTexto = montousd.Text.Replace('.', ',');

                    if (decimal.TryParse(usdTexto, out decimal montoUSD))
                    {
                        if (montoUSD > 999999999m) return; // Control anti-overflow

                        decimal resultadoBs = montoUSD * tasa;
                        if (resultadoBs > 999999999999m) return;

                        // Asignamos el valor exacto al instante
                        string conversionStr = Math.Round(resultadoBs, 2).ToString("0.00");
                        if (montobs.Text != conversionStr) montobs.Text = conversionStr;
                    }
                    else if (string.IsNullOrWhiteSpace(montousd.Text))
                    {
                        montobs.Text = "";
                    }
                }
                else if (BsRadio.Checked)
                {
                    string bsTexto = montobs.Text.Replace('.', ',');

                    if (decimal.TryParse(bsTexto, out decimal montoBs))
                    {
                        if (montoBs > 999999999999m) return; // Control anti-overflow

                        decimal resultadoUsd = montoBs / tasa;
                        if (resultadoUsd > 999999999m) return;

                        // Asignamos el valor exacto al instante (ejemplo: 750 / 750 = 1.00)
                        string conversionStr = Math.Round(resultadoUsd, 2).ToString("0.00");
                        if (montousd.Text != conversionStr) montousd.Text = conversionStr;
                    }
                    else if (string.IsNullOrWhiteSpace(montobs.Text))
                    {
                        montousd.Text = "";
                    }
                }
            }
            catch (OverflowException)
            {
                montousd.Text = "0,00";
                montobs.Text = "0,00";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
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

        private void BsRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Solo actuamos si el RadioButton se acaba de activar (Checked == true)
            if (sender is RadioButton rb && rb.Checked)
            {
                if (UsdRadio.Checked)
                {
                    montobs.Clear();
                    montobs.ReadOnly = true;    // Bloqueado (aquí cae el resultado)
                    montousd.ReadOnly = false;  // Permitir escribir el monto en dólares
                    montousd.Focus();
                }
                else if (BsRadio.Checked)
                {
                    montousd.Clear();
                    montousd.ReadOnly = true;   // Bloqueado (aquí cae el resultado)
                    montobs.ReadOnly = false;   // Permitir escribir el monto en bolívares
                    montobs.Focus();
                }
            }
        }

        private void UsdRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Solo actuamos si el RadioButton se acaba de activar (Checked == true)
            if (sender is RadioButton rb && rb.Checked)
            {
                if (UsdRadio.Checked)
                {
                    montobs.Clear();
                    montobs.ReadOnly = true;    // Bloqueado (aquí cae el resultado)
                    montousd.ReadOnly = false;  // Permitir escribir el monto en dólares
                    montousd.Focus();
                }
                else if (BsRadio.Checked)
                {
                    montousd.Clear();
                    montousd.ReadOnly = true;   // Bloqueado (aquí cae el resultado)
                    montobs.ReadOnly = false;   // Permitir escribir el monto en bolívares
                    montobs.Focus();
                }
            }
        }



        private void montousd_TextChanged(object sender, EventArgs e)
        {

            CalcularConversion();
        }

        private void tasa_USDTextBox_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = tasa_USDTextBox.Text;

            // 1. Remueve cualquier caracter que no sea dígito ni coma
            string limpio = Regex.Replace(textoOriginal, @"[^\d,]", "");

            // 2. Si hay más de una coma, conserva solo la primera
            int primerComa = limpio.IndexOf(',');
            if (primerComa != -1)
            {
                // Mantiene todo hasta la primera coma y elimina comas adicionales del resto
                string parteEntera = limpio.Substring(0, primerComa + 1);
                string parteDecimal = limpio.Substring(primerComa + 1).Replace(",", "");
                limpio = parteEntera + parteDecimal;
            }

            // 3. Si cambió el texto, lo actualiza
            if (tasa_USDTextBox.Text != limpio)
            {
                tasa_USDTextBox.Text = limpio;
                tasa_USDTextBox.SelectionStart = tasa_USDTextBox.Text.Length;
            }
        }

        private void montobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (char.IsControl(e.KeyChar)) return;

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = ',';
                if (txt.Text.Contains(",")) e.Handled = true; // Si ya hay coma, la bloquea
                return;
            }

            if (!char.IsDigit(e.KeyChar)) e.Handled = true; // Bloquea letras y símbolos

            
        }

        private void montobs_TextChanged(object sender, EventArgs e)
        {
            CalcularConversion();
        }

        private void montousd_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (char.IsControl(e.KeyChar)) return;

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = ',';
                if (txt.Text.Contains(",")) e.Handled = true; // Si ya hay coma, la bloquea
                return;
            }

            if (!char.IsDigit(e.KeyChar)) e.Handled = true; // Bloquea letras y símbolos

        }


        // 2. Vincul
    }
}
