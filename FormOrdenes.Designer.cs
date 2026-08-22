namespace AppTesis
{
    partial class Formordenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDOrdenes_ViajeLabel;
            System.Windows.Forms.Label cedula_ChoferLabel;
            System.Windows.Forms.Label vehiculos_NroPlacaLabel;
            System.Windows.Forms.Label cedula_ClienteLabel;
            System.Windows.Forms.Label destinoLabel;
            System.Windows.Forms.Label fecha_InicioLabel;
            System.Windows.Forms.Label fecha_FinalizacionLabel;
            System.Windows.Forms.Label estatusLabel;
            System.Windows.Forms.Label rutaLabel;
            System.Windows.Forms.Label dias_ViajeLabel;
            System.Windows.Forms.Label distanciaLabel;
            System.Windows.Forms.Label origenLabel;
            System.Windows.Forms.Label paradasLabel;
            System.Windows.Forms.Label tasa_USDLabel;
            System.Windows.Forms.Label pago_BSLabel;
            System.Windows.Forms.Label BS;
            System.Windows.Forms.Label USD;
            this.label1 = new System.Windows.Forms.Label();
            this.orden_ViajeDataGridView = new System.Windows.Forms.DataGridView();
            this.IDOrdenes_Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula_Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculos_NroPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Finalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_USD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago_BS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_ViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.orden_ViajeTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.iDOrdenes_ViajeTextBox = new System.Windows.Forms.TextBox();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_FinalizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dias_ViajeTextBox = new System.Windows.Forms.TextBox();
            this.distanciaTextBox = new System.Windows.Forms.TextBox();
            this.origenTextBox = new System.Windows.Forms.TextBox();
            this.paradasTextBox = new System.Windows.Forms.TextBox();
            this.tasa_USDTextBox = new System.Windows.Forms.TextBox();
            this.montobs = new System.Windows.Forms.TextBox();
            this.EstatusComboBox = new System.Windows.Forms.ComboBox();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RutaComboBox = new System.Windows.Forms.ComboBox();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChoferComboBox = new System.Windows.Forms.ComboBox();
            this.choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlacaComboBox = new System.Windows.Forms.ComboBox();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutasTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.RutasTableAdapter();
            this.choferTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.ChoferTableAdapter();
            this.vehiculoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.VehiculoTableAdapter();
            this.clienteTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.ClienteTableAdapter();
            this.montousd = new System.Windows.Forms.TextBox();
            this.UsdRadio = new System.Windows.Forms.RadioButton();
            this.BsRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salir = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.agregar = new BotonRedondo();
            iDOrdenes_ViajeLabel = new System.Windows.Forms.Label();
            cedula_ChoferLabel = new System.Windows.Forms.Label();
            vehiculos_NroPlacaLabel = new System.Windows.Forms.Label();
            cedula_ClienteLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            fecha_InicioLabel = new System.Windows.Forms.Label();
            fecha_FinalizacionLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            rutaLabel = new System.Windows.Forms.Label();
            dias_ViajeLabel = new System.Windows.Forms.Label();
            distanciaLabel = new System.Windows.Forms.Label();
            origenLabel = new System.Windows.Forms.Label();
            paradasLabel = new System.Windows.Forms.Label();
            tasa_USDLabel = new System.Windows.Forms.Label();
            pago_BSLabel = new System.Windows.Forms.Label();
            BS = new System.Windows.Forms.Label();
            USD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDOrdenes_ViajeLabel
            // 
            iDOrdenes_ViajeLabel.AutoSize = true;
            iDOrdenes_ViajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            iDOrdenes_ViajeLabel.Location = new System.Drawing.Point(29, 39);
            iDOrdenes_ViajeLabel.Name = "iDOrdenes_ViajeLabel";
            iDOrdenes_ViajeLabel.Size = new System.Drawing.Size(77, 16);
            iDOrdenes_ViajeLabel.TabIndex = 6;
            iDOrdenes_ViajeLabel.Text = "ID del viaje:";
            // 
            // cedula_ChoferLabel
            // 
            cedula_ChoferLabel.AutoSize = true;
            cedula_ChoferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            cedula_ChoferLabel.Location = new System.Drawing.Point(186, 39);
            cedula_ChoferLabel.Name = "cedula_ChoferLabel";
            cedula_ChoferLabel.Size = new System.Drawing.Size(115, 16);
            cedula_ChoferLabel.TabIndex = 8;
            cedula_ChoferLabel.Text = "Cedula del chofer:";
            // 
            // vehiculos_NroPlacaLabel
            // 
            vehiculos_NroPlacaLabel.AutoSize = true;
            vehiculos_NroPlacaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            vehiculos_NroPlacaLabel.Location = new System.Drawing.Point(184, 82);
            vehiculos_NroPlacaLabel.Name = "vehiculos_NroPlacaLabel";
            vehiculos_NroPlacaLabel.Size = new System.Drawing.Size(120, 16);
            vehiculos_NroPlacaLabel.TabIndex = 10;
            vehiculos_NroPlacaLabel.Text = "Placa del vehiculo:";
            // 
            // cedula_ClienteLabel
            // 
            cedula_ClienteLabel.AutoSize = true;
            cedula_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            cedula_ClienteLabel.Location = new System.Drawing.Point(184, 130);
            cedula_ClienteLabel.Name = "cedula_ClienteLabel";
            cedula_ClienteLabel.Size = new System.Drawing.Size(117, 16);
            cedula_ClienteLabel.TabIndex = 12;
            cedula_ClienteLabel.Text = "Cedula del cliente:";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            destinoLabel.Location = new System.Drawing.Point(34, 311);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(110, 16);
            destinoLabel.TabIndex = 14;
            destinoLabel.Text = "Destino del viaje:";
            // 
            // fecha_InicioLabel
            // 
            fecha_InicioLabel.AutoSize = true;
            fecha_InicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fecha_InicioLabel.Location = new System.Drawing.Point(184, 175);
            fecha_InicioLabel.Name = "fecha_InicioLabel";
            fecha_InicioLabel.Size = new System.Drawing.Size(101, 16);
            fecha_InicioLabel.TabIndex = 16;
            fecha_InicioLabel.Text = "Fecha de Inicio:";
            // 
            // fecha_FinalizacionLabel
            // 
            fecha_FinalizacionLabel.AutoSize = true;
            fecha_FinalizacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fecha_FinalizacionLabel.Location = new System.Drawing.Point(175, 220);
            fecha_FinalizacionLabel.Name = "fecha_FinalizacionLabel";
            fecha_FinalizacionLabel.Size = new System.Drawing.Size(141, 16);
            fecha_FinalizacionLabel.TabIndex = 18;
            fecha_FinalizacionLabel.Text = "Fecha de Finalizacion:";
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            estatusLabel.Location = new System.Drawing.Point(213, 262);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(54, 16);
            estatusLabel.TabIndex = 20;
            estatusLabel.Text = "Estatus:";
            // 
            // rutaLabel
            // 
            rutaLabel.AutoSize = true;
            rutaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            rutaLabel.Location = new System.Drawing.Point(32, 85);
            rutaLabel.Name = "rutaLabel";
            rutaLabel.Size = new System.Drawing.Size(92, 16);
            rutaLabel.TabIndex = 22;
            rutaLabel.Text = "Ruta del viaje:";
            // 
            // dias_ViajeLabel
            // 
            dias_ViajeLabel.AutoSize = true;
            dias_ViajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dias_ViajeLabel.Location = new System.Drawing.Point(32, 136);
            dias_ViajeLabel.Name = "dias_ViajeLabel";
            dias_ViajeLabel.Size = new System.Drawing.Size(91, 16);
            dias_ViajeLabel.TabIndex = 24;
            dias_ViajeLabel.Text = "Dias de Viaje:";
            // 
            // distanciaLabel
            // 
            distanciaLabel.AutoSize = true;
            distanciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            distanciaLabel.Location = new System.Drawing.Point(32, 181);
            distanciaLabel.Name = "distanciaLabel";
            distanciaLabel.Size = new System.Drawing.Size(106, 16);
            distanciaLabel.TabIndex = 26;
            distanciaLabel.Text = "Distancia en Km:";
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            origenLabel.Location = new System.Drawing.Point(32, 223);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new System.Drawing.Size(104, 16);
            origenLabel.TabIndex = 28;
            origenLabel.Text = "Origen del viaje:";
            // 
            // paradasLabel
            // 
            paradasLabel.AutoSize = true;
            paradasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            paradasLabel.Location = new System.Drawing.Point(32, 265);
            paradasLabel.Name = "paradasLabel";
            paradasLabel.Size = new System.Drawing.Size(116, 16);
            paradasLabel.TabIndex = 30;
            paradasLabel.Text = "Paradas del viaje:";
            // 
            // tasa_USDLabel
            // 
            tasa_USDLabel.AutoSize = true;
            tasa_USDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            tasa_USDLabel.Location = new System.Drawing.Point(53, 361);
            tasa_USDLabel.Name = "tasa_USDLabel";
            tasa_USDLabel.Size = new System.Drawing.Size(74, 16);
            tasa_USDLabel.TabIndex = 32;
            tasa_USDLabel.Text = "Tasa USD:";
            // 
            // pago_BSLabel
            // 
            pago_BSLabel.AutoSize = true;
            pago_BSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            pago_BSLabel.Location = new System.Drawing.Point(3, 46);
            pago_BSLabel.Name = "pago_BSLabel";
            pago_BSLabel.Size = new System.Drawing.Size(61, 16);
            pago_BSLabel.TabIndex = 34;
            pago_BSLabel.Text = "Pago en:";
            // 
            // BS
            // 
            BS.AutoSize = true;
            BS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            BS.Location = new System.Drawing.Point(63, 42);
            BS.Name = "BS";
            BS.Size = new System.Drawing.Size(86, 16);
            BS.TabIndex = 41;
            BS.Text = "Monto en BS:";
            // 
            // USD
            // 
            USD.AutoSize = true;
            USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            USD.Location = new System.Drawing.Point(56, 68);
            USD.Name = "USD";
            USD.Size = new System.Drawing.Size(93, 16);
            USD.TabIndex = 45;
            USD.Text = "Monto en Usd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "LISTA DE ÓRDENES DE VIAJE";
            // 
            // orden_ViajeDataGridView
            // 
            this.orden_ViajeDataGridView.AllowUserToDeleteRows = false;
            this.orden_ViajeDataGridView.AutoGenerateColumns = false;
            this.orden_ViajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_ViajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOrdenes_Viaje,
            this.Ruta,
            this.Dias_Viaje,
            this.Distancia,
            this.Origen,
            this.Paradas,
            this.Destino,
            this.Cedula_Chofer,
            this.Vehiculos_NroPlaca,
            this.Cedula_Cliente,
            this.Fecha_Inicio,
            this.Fecha_Finalizacion,
            this.Tasa_USD,
            this.Pago_BS,
            this.Estatus});
            this.orden_ViajeDataGridView.DataSource = this.orden_ViajeBindingSource;
            this.orden_ViajeDataGridView.Location = new System.Drawing.Point(430, 90);
            this.orden_ViajeDataGridView.Name = "orden_ViajeDataGridView";
            this.orden_ViajeDataGridView.ReadOnly = true;
            this.orden_ViajeDataGridView.Size = new System.Drawing.Size(842, 220);
            this.orden_ViajeDataGridView.TabIndex = 6;
            this.orden_ViajeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_ViajeDataGridView_CellContentClick);
            // 
            // IDOrdenes_Viaje
            // 
            this.IDOrdenes_Viaje.DataPropertyName = "IDOrdenes_Viaje";
            this.IDOrdenes_Viaje.HeaderText = "ID de la orden";
            this.IDOrdenes_Viaje.Name = "IDOrdenes_Viaje";
            this.IDOrdenes_Viaje.ReadOnly = true;
            // 
            // Ruta
            // 
            this.Ruta.DataPropertyName = "Ruta";
            this.Ruta.HeaderText = "Ruta del viaje";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Dias_Viaje
            // 
            this.Dias_Viaje.DataPropertyName = "Dias_Viaje";
            this.Dias_Viaje.HeaderText = "Dias de viaje";
            this.Dias_Viaje.Name = "Dias_Viaje";
            this.Dias_Viaje.ReadOnly = true;
            // 
            // Distancia
            // 
            this.Distancia.DataPropertyName = "Distancia";
            this.Distancia.HeaderText = "Distancia en Km";
            this.Distancia.Name = "Distancia";
            this.Distancia.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Paradas
            // 
            this.Paradas.DataPropertyName = "Paradas";
            this.Paradas.HeaderText = "Paradas";
            this.Paradas.Name = "Paradas";
            this.Paradas.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Cedula_Chofer
            // 
            this.Cedula_Chofer.DataPropertyName = "Cedula_Chofer";
            this.Cedula_Chofer.HeaderText = "Cedula del chofer";
            this.Cedula_Chofer.Name = "Cedula_Chofer";
            this.Cedula_Chofer.ReadOnly = true;
            // 
            // Vehiculos_NroPlaca
            // 
            this.Vehiculos_NroPlaca.DataPropertyName = "Vehiculos_NroPlaca";
            this.Vehiculos_NroPlaca.HeaderText = "Placa del vehiculo";
            this.Vehiculos_NroPlaca.Name = "Vehiculos_NroPlaca";
            this.Vehiculos_NroPlaca.ReadOnly = true;
            // 
            // Cedula_Cliente
            // 
            this.Cedula_Cliente.DataPropertyName = "Cedula_Cliente";
            this.Cedula_Cliente.HeaderText = "Cedula del cliente";
            this.Cedula_Cliente.Name = "Cedula_Cliente";
            this.Cedula_Cliente.ReadOnly = true;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.DataPropertyName = "Fecha_Inicio";
            this.Fecha_Inicio.HeaderText = "Fecha de inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            // 
            // Fecha_Finalizacion
            // 
            this.Fecha_Finalizacion.DataPropertyName = "Fecha_Finalizacion";
            this.Fecha_Finalizacion.HeaderText = "Fecha de finalizacion ";
            this.Fecha_Finalizacion.Name = "Fecha_Finalizacion";
            this.Fecha_Finalizacion.ReadOnly = true;
            // 
            // Tasa_USD
            // 
            this.Tasa_USD.DataPropertyName = "Tasa_USD";
            this.Tasa_USD.HeaderText = "Tasa USD";
            this.Tasa_USD.Name = "Tasa_USD";
            this.Tasa_USD.ReadOnly = true;
            // 
            // Pago_BS
            // 
            this.Pago_BS.DataPropertyName = "Pago_BS";
            this.Pago_BS.HeaderText = "Pago en BS";
            this.Pago_BS.Name = "Pago_BS";
            this.Pago_BS.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // orden_ViajeBindingSource
            // 
            this.orden_ViajeBindingSource.DataMember = "Orden_Viaje";
            this.orden_ViajeBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orden_ViajeTableAdapter
            // 
            this.orden_ViajeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Orden_ViajeTableAdapter = this.orden_ViajeTableAdapter;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // iDOrdenes_ViajeTextBox
            // 
            this.iDOrdenes_ViajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "IDOrdenes_Viaje", true));
            this.iDOrdenes_ViajeTextBox.Location = new System.Drawing.Point(32, 58);
            this.iDOrdenes_ViajeTextBox.Name = "iDOrdenes_ViajeTextBox";
            this.iDOrdenes_ViajeTextBox.ReadOnly = true;
            this.iDOrdenes_ViajeTextBox.Size = new System.Drawing.Size(109, 20);
            this.iDOrdenes_ViajeTextBox.TabIndex = 7;
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Destino", true));
            this.destinoTextBox.Location = new System.Drawing.Point(35, 330);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.ReadOnly = true;
            this.destinoTextBox.Size = new System.Drawing.Size(109, 20);
            this.destinoTextBox.TabIndex = 15;
            // 
            // fecha_InicioDateTimePicker
            // 
            this.fecha_InicioDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fecha_InicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orden_ViajeBindingSource, "Fecha_Inicio", true));
            this.fecha_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_InicioDateTimePicker.Location = new System.Drawing.Point(187, 197);
            this.fecha_InicioDateTimePicker.Name = "fecha_InicioDateTimePicker";
            this.fecha_InicioDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.fecha_InicioDateTimePicker.TabIndex = 17;
            this.fecha_InicioDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_InicioDateTimePicker_ValueChanged);
            // 
            // fecha_FinalizacionDateTimePicker
            // 
            this.fecha_FinalizacionDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fecha_FinalizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orden_ViajeBindingSource, "Fecha_Finalizacion", true));
            this.fecha_FinalizacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_FinalizacionDateTimePicker.Location = new System.Drawing.Point(187, 239);
            this.fecha_FinalizacionDateTimePicker.Name = "fecha_FinalizacionDateTimePicker";
            this.fecha_FinalizacionDateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.fecha_FinalizacionDateTimePicker.TabIndex = 19;
            // 
            // dias_ViajeTextBox
            // 
            this.dias_ViajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Dias_Viaje", true));
            this.dias_ViajeTextBox.Location = new System.Drawing.Point(35, 158);
            this.dias_ViajeTextBox.Name = "dias_ViajeTextBox";
            this.dias_ViajeTextBox.ReadOnly = true;
            this.dias_ViajeTextBox.Size = new System.Drawing.Size(106, 20);
            this.dias_ViajeTextBox.TabIndex = 25;
            // 
            // distanciaTextBox
            // 
            this.distanciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Distancia", true));
            this.distanciaTextBox.Location = new System.Drawing.Point(32, 200);
            this.distanciaTextBox.Name = "distanciaTextBox";
            this.distanciaTextBox.ReadOnly = true;
            this.distanciaTextBox.Size = new System.Drawing.Size(109, 20);
            this.distanciaTextBox.TabIndex = 27;
            // 
            // origenTextBox
            // 
            this.origenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Origen", true));
            this.origenTextBox.Location = new System.Drawing.Point(32, 242);
            this.origenTextBox.Name = "origenTextBox";
            this.origenTextBox.ReadOnly = true;
            this.origenTextBox.Size = new System.Drawing.Size(109, 20);
            this.origenTextBox.TabIndex = 29;
            // 
            // paradasTextBox
            // 
            this.paradasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Paradas", true));
            this.paradasTextBox.Location = new System.Drawing.Point(35, 284);
            this.paradasTextBox.Name = "paradasTextBox";
            this.paradasTextBox.ReadOnly = true;
            this.paradasTextBox.Size = new System.Drawing.Size(109, 20);
            this.paradasTextBox.TabIndex = 31;
            // 
            // tasa_USDTextBox
            // 
            this.tasa_USDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Tasa_USD", true));
            this.tasa_USDTextBox.Location = new System.Drawing.Point(35, 380);
            this.tasa_USDTextBox.Name = "tasa_USDTextBox";
            this.tasa_USDTextBox.Size = new System.Drawing.Size(109, 20);
            this.tasa_USDTextBox.TabIndex = 33;
            this.tasa_USDTextBox.TextChanged += new System.EventHandler(this.tasa_USDTextBox_TextChanged);
            // 
            // montobs
            // 
            this.montobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Pago_BS", true));
            this.montobs.Location = new System.Drawing.Point(155, 42);
            this.montobs.Name = "montobs";
            this.montobs.ReadOnly = true;
            this.montobs.Size = new System.Drawing.Size(109, 20);
            this.montobs.TabIndex = 35;
            this.montobs.TextChanged += new System.EventHandler(this.montobs_TextChanged);
            this.montobs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montobs_KeyPress);
            // 
            // EstatusComboBox
            // 
            this.EstatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Estatus", true));
            this.EstatusComboBox.FormattingEnabled = true;
            this.EstatusComboBox.Items.AddRange(new object[] {
            "Completada",
            "En Curso",
            "Atrasada",
            "Pendiente a Realizar",
            "Pendiente por Pago",
            "Cancelada"});
            this.EstatusComboBox.Location = new System.Drawing.Point(189, 280);
            this.EstatusComboBox.Name = "EstatusComboBox";
            this.EstatusComboBox.Size = new System.Drawing.Size(109, 21);
            this.EstatusComboBox.TabIndex = 36;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orden_ViajeBindingSource, "Cedula_Cliente", true));
            this.ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Cedula_Cliente", true));
            this.ClienteComboBox.DataSource = this.clienteBindingSource;
            this.ClienteComboBox.DisplayMember = "Cedula";
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(189, 151);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(107, 21);
            this.ClienteComboBox.TabIndex = 37;
            this.ClienteComboBox.ValueMember = "Cedula";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // RutaComboBox
            // 
            this.RutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orden_ViajeBindingSource, "Ruta", true));
            this.RutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Ruta", true));
            this.RutaComboBox.DataSource = this.rutasBindingSource;
            this.RutaComboBox.DisplayMember = "Nombre_Ruta";
            this.RutaComboBox.FormattingEnabled = true;
            this.RutaComboBox.Location = new System.Drawing.Point(32, 104);
            this.RutaComboBox.Name = "RutaComboBox";
            this.RutaComboBox.Size = new System.Drawing.Size(109, 21);
            this.RutaComboBox.TabIndex = 38;
            this.RutaComboBox.ValueMember = "Nombre_Ruta";
            this.RutaComboBox.SelectionChangeCommitted += new System.EventHandler(this.RutaComboBox_SelectionChangeCommitted);
            // 
            // rutasBindingSource
            // 
            this.rutasBindingSource.DataMember = "Rutas";
            this.rutasBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // ChoferComboBox
            // 
            this.ChoferComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orden_ViajeBindingSource, "Cedula_Chofer", true));
            this.ChoferComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Cedula_Chofer", true));
            this.ChoferComboBox.DataSource = this.choferBindingSource;
            this.ChoferComboBox.DisplayMember = "Cedula";
            this.ChoferComboBox.FormattingEnabled = true;
            this.ChoferComboBox.Location = new System.Drawing.Point(189, 58);
            this.ChoferComboBox.Name = "ChoferComboBox";
            this.ChoferComboBox.Size = new System.Drawing.Size(107, 21);
            this.ChoferComboBox.TabIndex = 39;
            this.ChoferComboBox.ValueMember = "Cedula";
            // 
            // choferBindingSource
            // 
            this.choferBindingSource.DataMember = "Chofer";
            this.choferBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // PlacaComboBox
            // 
            this.PlacaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orden_ViajeBindingSource, "Vehiculos_NroPlaca", true));
            this.PlacaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Vehiculos_NroPlaca", true));
            this.PlacaComboBox.DataSource = this.vehiculoBindingSource;
            this.PlacaComboBox.DisplayMember = "NroPlaca";
            this.PlacaComboBox.FormattingEnabled = true;
            this.PlacaComboBox.Location = new System.Drawing.Point(189, 101);
            this.PlacaComboBox.Name = "PlacaComboBox";
            this.PlacaComboBox.Size = new System.Drawing.Size(107, 21);
            this.PlacaComboBox.TabIndex = 40;
            this.PlacaComboBox.ValueMember = "NroPlaca";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "Vehiculo";
            this.vehiculoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // rutasTableAdapter
            // 
            this.rutasTableAdapter.ClearBeforeFill = true;
            // 
            // choferTableAdapter
            // 
            this.choferTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // montousd
            // 
            this.montousd.Location = new System.Drawing.Point(155, 67);
            this.montousd.Name = "montousd";
            this.montousd.ReadOnly = true;
            this.montousd.Size = new System.Drawing.Size(109, 20);
            this.montousd.TabIndex = 42;
            this.montousd.TextChanged += new System.EventHandler(this.montousd_TextChanged);
            this.montousd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montousd_KeyPress);
            // 
            // UsdRadio
            // 
            this.UsdRadio.AutoSize = true;
            this.UsdRadio.Location = new System.Drawing.Point(55, 12);
            this.UsdRadio.Name = "UsdRadio";
            this.UsdRadio.Size = new System.Drawing.Size(44, 17);
            this.UsdRadio.TabIndex = 43;
            this.UsdRadio.TabStop = true;
            this.UsdRadio.Text = "Usd";
            this.UsdRadio.UseVisualStyleBackColor = true;
            this.UsdRadio.CheckedChanged += new System.EventHandler(this.UsdRadio_CheckedChanged);
            // 
            // BsRadio
            // 
            this.BsRadio.AutoSize = true;
            this.BsRadio.Location = new System.Drawing.Point(6, 12);
            this.BsRadio.Name = "BsRadio";
            this.BsRadio.Size = new System.Drawing.Size(37, 17);
            this.BsRadio.TabIndex = 44;
            this.BsRadio.TabStop = true;
            this.BsRadio.Text = "Bs";
            this.BsRadio.UseVisualStyleBackColor = true;
            this.BsRadio.CheckedChanged += new System.EventHandler(this.BsRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsdRadio);
            this.groupBox1.Controls.Add(USD);
            this.groupBox1.Controls.Add(this.BsRadio);
            this.groupBox1.Controls.Add(pago_BSLabel);
            this.groupBox1.Controls.Add(this.montobs);
            this.groupBox1.Controls.Add(BS);
            this.groupBox1.Controls.Add(this.montousd);
            this.groupBox1.Location = new System.Drawing.Point(154, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 93);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moneda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(1122, 338);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 4;
            this.salir.Text = "Volver al Menú";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar.FlatAppearance.BorderSize = 2;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(796, 338);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar Orden";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(430, 338);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Orden";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // Formordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlacaComboBox);
            this.Controls.Add(this.ChoferComboBox);
            this.Controls.Add(this.RutaComboBox);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.EstatusComboBox);
            this.Controls.Add(iDOrdenes_ViajeLabel);
            this.Controls.Add(this.iDOrdenes_ViajeTextBox);
            this.Controls.Add(cedula_ChoferLabel);
            this.Controls.Add(vehiculos_NroPlacaLabel);
            this.Controls.Add(cedula_ClienteLabel);
            this.Controls.Add(destinoLabel);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(fecha_InicioLabel);
            this.Controls.Add(this.fecha_InicioDateTimePicker);
            this.Controls.Add(fecha_FinalizacionLabel);
            this.Controls.Add(this.fecha_FinalizacionDateTimePicker);
            this.Controls.Add(estatusLabel);
            this.Controls.Add(rutaLabel);
            this.Controls.Add(dias_ViajeLabel);
            this.Controls.Add(this.dias_ViajeTextBox);
            this.Controls.Add(distanciaLabel);
            this.Controls.Add(this.distanciaTextBox);
            this.Controls.Add(origenLabel);
            this.Controls.Add(this.origenTextBox);
            this.Controls.Add(paradasLabel);
            this.Controls.Add(this.paradasTextBox);
            this.Controls.Add(tasa_USDLabel);
            this.Controls.Add(this.tasa_USDTextBox);
            this.Controls.Add(this.orden_ViajeDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Name = "Formordenes";
            this.Text = "Ordenes de Viaje";
            this.Load += new System.EventHandler(this.Formordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonRedondo agregar;
        private BotonRedondo modificar;
        private BotonRedondo salir;
        private System.Windows.Forms.Label label1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource orden_ViajeBindingSource;
        private DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter orden_ViajeTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView orden_ViajeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iDOrdenes_ViajeTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_InicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_FinalizacionDateTimePicker;
        private System.Windows.Forms.TextBox dias_ViajeTextBox;
        private System.Windows.Forms.TextBox distanciaTextBox;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.TextBox paradasTextBox;
        private System.Windows.Forms.TextBox tasa_USDTextBox;
        private System.Windows.Forms.TextBox montobs;
        private System.Windows.Forms.ComboBox EstatusComboBox;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.ComboBox RutaComboBox;
        private System.Windows.Forms.ComboBox ChoferComboBox;
        private System.Windows.Forms.ComboBox PlacaComboBox;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private DataBaseDataSetTableAdapters.RutasTableAdapter rutasTableAdapter;
        private System.Windows.Forms.BindingSource choferBindingSource;
        private DataBaseDataSetTableAdapters.ChoferTableAdapter choferTableAdapter;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private DataBaseDataSetTableAdapters.VehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataBaseDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox montousd;
        private System.Windows.Forms.RadioButton UsdRadio;
        private System.Windows.Forms.RadioButton BsRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOrdenes_Viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula_Chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculos_NroPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Finalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_USD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago_BS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}