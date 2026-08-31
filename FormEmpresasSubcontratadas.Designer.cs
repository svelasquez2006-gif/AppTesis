namespace AppTesis
{
    partial class FormEmpresasSubcontratadas
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
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label lblTelefRepresentante;
            System.Windows.Forms.Label lblFechaInicio;
            System.Windows.Forms.Label lblFechaFinal;
            System.Windows.Forms.Label lblCorreo;
            System.Windows.Forms.Label lblDirección;
            System.Windows.Forms.Label lblCalificación;
            System.Windows.Forms.Label lblNomRepre;
            System.Windows.Forms.Label lblRIF;
            System.Windows.Forms.Label lblNombre;
            System.Windows.Forms.Label lblEstado;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoRepresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresasSubcontratadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.RifTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.CodigoTelfComboBox = new System.Windows.Forms.ComboBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.NombreRepresentanteTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxTelfRepre = new System.Windows.Forms.ComboBox();
            this.textBoxTelfRepre = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.salir = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.agregar = new BotonRedondo();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripLblDev = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLblDev2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CalificacionComboBox = new System.Windows.Forms.ComboBox();
            this.empresasSubcontratadaTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.EmpresasSubcontratadaTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechafinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            telefonoLabel = new System.Windows.Forms.Label();
            lblTelefRepresentante = new System.Windows.Forms.Label();
            lblFechaInicio = new System.Windows.Forms.Label();
            lblFechaFinal = new System.Windows.Forms.Label();
            lblCorreo = new System.Windows.Forms.Label();
            lblDirección = new System.Windows.Forms.Label();
            lblCalificación = new System.Windows.Forms.Label();
            lblNomRepre = new System.Windows.Forms.Label();
            lblRIF = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSubcontratadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(211, 109);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 36;
            telefonoLabel.Text = "Teléfono:";
            // 
            // lblTelefRepresentante
            // 
            lblTelefRepresentante.AutoSize = true;
            lblTelefRepresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelefRepresentante.Location = new System.Drawing.Point(572, 211);
            lblTelefRepresentante.Name = "lblTelefRepresentante";
            lblTelefRepresentante.Size = new System.Drawing.Size(186, 20);
            lblTelefRepresentante.TabIndex = 43;
            lblTelefRepresentante.Text = "Teléfono Representante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMPRESAS SUBCONTRATADAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rifDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.nombreRepresentanteDataGridViewTextBoxColumn,
            this.telefonoRepresentanteDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechafinalDataGridViewTextBoxColumn,
            this.calificacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empresasSubcontratadaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 200);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // rifDataGridViewTextBoxColumn
            // 
            this.rifDataGridViewTextBoxColumn.DataPropertyName = "rif";
            this.rifDataGridViewTextBoxColumn.HeaderText = "Rif de la empresa";
            this.rifDataGridViewTextBoxColumn.Name = "rifDataGridViewTextBoxColumn";
            this.rifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre de la Empresa";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion de la Empresa";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono de la Empresa";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo de la Empresa";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreRepresentanteDataGridViewTextBoxColumn
            // 
            this.nombreRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "NombreRepresentante";
            this.nombreRepresentanteDataGridViewTextBoxColumn.HeaderText = "Nombre del Representante";
            this.nombreRepresentanteDataGridViewTextBoxColumn.Name = "nombreRepresentanteDataGridViewTextBoxColumn";
            this.nombreRepresentanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoRepresentanteDataGridViewTextBoxColumn
            // 
            this.telefonoRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "TelefonoRepresentante";
            this.telefonoRepresentanteDataGridViewTextBoxColumn.HeaderText = "Telefono del Representante";
            this.telefonoRepresentanteDataGridViewTextBoxColumn.Name = "telefonoRepresentanteDataGridViewTextBoxColumn";
            this.telefonoRepresentanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Inicio del Contrato";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechafinalDataGridViewTextBoxColumn
            // 
            this.fechafinalDataGridViewTextBoxColumn.DataPropertyName = "Fechafinal";
            this.fechafinalDataGridViewTextBoxColumn.HeaderText = "Finalizacion del Contrato";
            this.fechafinalDataGridViewTextBoxColumn.Name = "fechafinalDataGridViewTextBoxColumn";
            this.fechafinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            this.calificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresasSubcontratadaBindingSource
            // 
            this.empresasSubcontratadaBindingSource.DataMember = "EmpresasSubcontratada";
            this.empresasSubcontratadaBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RifTextBox
            // 
            this.RifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "rif", true));
            this.RifTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RifTextBox.Location = new System.Drawing.Point(85, 108);
            this.RifTextBox.Name = "RifTextBox";
            this.RifTextBox.Size = new System.Drawing.Size(100, 22);
            this.RifTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(85, 159);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 11;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "Estado", true));
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Vigente",
            "Expirado"});
            this.EstadoComboBox.Location = new System.Drawing.Point(85, 215);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(100, 21);
            this.EstadoComboBox.TabIndex = 23;
            // 
            // CodigoTelfComboBox
            // 
            this.CodigoTelfComboBox.FormattingEnabled = true;
            this.CodigoTelfComboBox.Items.AddRange(new object[] {
            "0412",
            "0414",
            "0416",
            "0422",
            "0424",
            "0426",
            "0212",
            "0241",
            "0243",
            "0251",
            "0261",
            "0268",
            "0281"});
            this.CodigoTelfComboBox.Location = new System.Drawing.Point(292, 108);
            this.CodigoTelfComboBox.Name = "CodigoTelfComboBox";
            this.CodigoTelfComboBox.Size = new System.Drawing.Size(50, 21);
            this.CodigoTelfComboBox.TabIndex = 38;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(348, 109);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(87, 20);
            this.telefonoTextBox.TabIndex = 37;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(279, 159);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(188, 22);
            this.correoTextBox.TabIndex = 40;
            this.correoTextBox.TextChanged += new System.EventHandler(this.correoTextBox_TextChanged);
            // 
            // NombreRepresentanteTextBox
            // 
            this.NombreRepresentanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "NombreRepresentante", true));
            this.NombreRepresentanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRepresentanteTextBox.Location = new System.Drawing.Point(419, 211);
            this.NombreRepresentanteTextBox.Name = "NombreRepresentanteTextBox";
            this.NombreRepresentanteTextBox.Size = new System.Drawing.Size(135, 22);
            this.NombreRepresentanteTextBox.TabIndex = 42;
            // 
            // comboBoxTelfRepre
            // 
            this.comboBoxTelfRepre.FormattingEnabled = true;
            this.comboBoxTelfRepre.Items.AddRange(new object[] {
            "0412",
            "0414",
            "0416",
            "0422",
            "0424",
            "0426",
            "0212",
            "0241",
            "0243",
            "0251",
            "0261",
            "0268",
            "0281"});
            this.comboBoxTelfRepre.Location = new System.Drawing.Point(769, 212);
            this.comboBoxTelfRepre.Name = "comboBoxTelfRepre";
            this.comboBoxTelfRepre.Size = new System.Drawing.Size(50, 21);
            this.comboBoxTelfRepre.TabIndex = 45;
            this.comboBoxTelfRepre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTelfRepre_SelectedIndexChanged);
            // 
            // textBoxTelfRepre
            // 
            this.textBoxTelfRepre.Location = new System.Drawing.Point(825, 213);
            this.textBoxTelfRepre.Name = "textBoxTelfRepre";
            this.textBoxTelfRepre.Size = new System.Drawing.Size(87, 20);
            this.textBoxTelfRepre.TabIndex = 44;
            this.textBoxTelfRepre.TextChanged += new System.EventHandler(this.textBoxTelfRepre_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(752, 114);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(133, 20);
            this.direccionTextBox.TabIndex = 53;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(1002, 175);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 56;
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
            this.modificar.Location = new System.Drawing.Point(1085, 110);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 55;
            this.modificar.Text = "Modificar Empresa";
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
            this.agregar.Location = new System.Drawing.Point(908, 111);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 54;
            this.agregar.Text = "Agregar Empresa";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLblDev,
            this.ToolStripLblDev2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1253, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripLblDev
            // 
            this.ToolStripLblDev.Name = "ToolStripLblDev";
            this.ToolStripLblDev.Size = new System.Drawing.Size(1036, 17);
            this.ToolStripLblDev.Spring = true;
            this.ToolStripLblDev.Text = "Desarrollado por:";
            this.ToolStripLblDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripLblDev2
            // 
            this.ToolStripLblDev2.Name = "ToolStripLblDev2";
            this.ToolStripLblDev2.Size = new System.Drawing.Size(202, 17);
            this.ToolStripLblDev2.Text = "Sebastián Velásquez y Veider Gallardo";
            this.ToolStripLblDev2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalificacionComboBox
            // 
            this.CalificacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "Calificacion", true));
            this.CalificacionComboBox.FormattingEnabled = true;
            this.CalificacionComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CalificacionComboBox.Location = new System.Drawing.Point(764, 166);
            this.CalificacionComboBox.Name = "CalificacionComboBox";
            this.CalificacionComboBox.Size = new System.Drawing.Size(35, 21);
            this.CalificacionComboBox.TabIndex = 58;
            // 
            // empresasSubcontratadaTableAdapter
            // 
            this.empresasSubcontratadaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmpresasSubcontratadaTableAdapter = this.empresasSubcontratadaTableAdapter;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empresasSubcontratadaBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(525, 116);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.fechaInicioDateTimePicker.TabIndex = 59;
            this.fechaInicioDateTimePicker.ValueChanged += new System.EventHandler(this.fechaInicioDateTimePicker_ValueChanged);
            // 
            // fechafinalDateTimePicker
            // 
            this.fechafinalDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechafinalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empresasSubcontratadaBindingSource, "Fechafinal", true));
            this.fechafinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechafinalDateTimePicker.Location = new System.Drawing.Point(525, 163);
            this.fechafinalDateTimePicker.Name = "fechafinalDateTimePicker";
            this.fechafinalDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.fechafinalDateTimePicker.TabIndex = 60;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFechaInicio.Location = new System.Drawing.Point(521, 93);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new System.Drawing.Size(121, 20);
            lblFechaInicio.TabIndex = 61;
            lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFechaFinal.Location = new System.Drawing.Point(521, 140);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new System.Drawing.Size(96, 20);
            lblFechaFinal.TabIndex = 62;
            lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCorreo.Location = new System.Drawing.Point(211, 158);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(61, 20);
            lblCorreo.TabIndex = 63;
            lblCorreo.Text = "Correo:";
            // 
            // lblDirección
            // 
            lblDirección.AutoSize = true;
            lblDirección.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDirección.Location = new System.Drawing.Point(667, 114);
            lblDirección.Name = "lblDirección";
            lblDirección.Size = new System.Drawing.Size(79, 20);
            lblDirección.TabIndex = 64;
            lblDirección.Text = "Dirección:";
            // 
            // lblCalificación
            // 
            lblCalificación.AutoSize = true;
            lblCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCalificación.Location = new System.Drawing.Point(665, 164);
            lblCalificación.Name = "lblCalificación";
            lblCalificación.Size = new System.Drawing.Size(93, 20);
            lblCalificación.TabIndex = 65;
            lblCalificación.Text = "Calificación:";
            // 
            // lblNomRepre
            // 
            lblNomRepre.AutoSize = true;
            lblNomRepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomRepre.Location = new System.Drawing.Point(211, 211);
            lblNomRepre.Name = "lblNomRepre";
            lblNomRepre.Size = new System.Drawing.Size(202, 20);
            lblNomRepre.TabIndex = 66;
            lblNomRepre.Text = "Nombre de Representante:";
            // 
            // lblRIF
            // 
            lblRIF.AutoSize = true;
            lblRIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRIF.Location = new System.Drawing.Point(39, 106);
            lblRIF.Name = "lblRIF";
            lblRIF.Size = new System.Drawing.Size(40, 20);
            lblRIF.TabIndex = 67;
            lblRIF.Text = "RIF:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombre.Location = new System.Drawing.Point(10, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(69, 20);
            lblNombre.TabIndex = 68;
            lblNombre.Text = "Nombre:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEstado.Location = new System.Drawing.Point(15, 213);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(64, 20);
            lblEstado.TabIndex = 69;
            lblEstado.Text = "Estado:";
            // 
            // FormEmpresasSubcontratadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1253, 540);
            this.Controls.Add(lblEstado);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblRIF);
            this.Controls.Add(lblNomRepre);
            this.Controls.Add(lblCalificación);
            this.Controls.Add(lblDirección);
            this.Controls.Add(lblCorreo);
            this.Controls.Add(lblFechaFinal);
            this.Controls.Add(lblFechaInicio);
            this.Controls.Add(this.fechafinalDateTimePicker);
            this.Controls.Add(this.fechaInicioDateTimePicker);
            this.Controls.Add(this.CalificacionComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.comboBoxTelfRepre);
            this.Controls.Add(lblTelefRepresentante);
            this.Controls.Add(this.textBoxTelfRepre);
            this.Controls.Add(this.NombreRepresentanteTextBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.CodigoTelfComboBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.RifTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpresasSubcontratadas";
            this.Text = "FormEmpresasSubcontratadas";
            this.Load += new System.EventHandler(this.FormEmpresasSubcontratadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSubcontratadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource empresasSubcontratadaBindingSource;
        private DataBaseDataSetTableAdapters.EmpresasSubcontratadaTableAdapter empresasSubcontratadaTableAdapter;
        private System.Windows.Forms.TextBox RifTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.ComboBox CodigoTelfComboBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox NombreRepresentanteTextBox;
        private System.Windows.Forms.ComboBox comboBoxTelfRepre;
        private System.Windows.Forms.TextBox textBoxTelfRepre;
        private System.Windows.Forms.TextBox direccionTextBox;
        private BotonRedondo salir;
        private BotonRedondo modificar;
        private BotonRedondo agregar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev2;
        private System.Windows.Forms.ComboBox CalificacionComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn rifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoRepresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechafinalDateTimePicker;
    }
}