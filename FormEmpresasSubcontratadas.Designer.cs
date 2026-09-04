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
            System.Windows.Forms.Label rifLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label lblNombreRepresentante;
            System.Windows.Forms.Label lblTelefRepresentante;
            System.Windows.Forms.Label labelCalificación;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaInicioLabel;
            System.Windows.Forms.Label fechafinalLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.rif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            rifLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            lblNombreRepresentante = new System.Windows.Forms.Label();
            lblTelefRepresentante = new System.Windows.Forms.Label();
            labelCalificación = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            fechafinalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSubcontratadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rifLabel
            // 
            rifLabel.AutoSize = true;
            rifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rifLabel.Location = new System.Drawing.Point(51, 110);
            rifLabel.Name = "rifLabel";
            rifLabel.Size = new System.Drawing.Size(31, 16);
            rifLabel.TabIndex = 8;
            rifLabel.Text = "RIF:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(23, 161);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(24, 215);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 16);
            label2.TabIndex = 22;
            label2.Text = "Estado:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(219, 109);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 36;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(243, 161);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(51, 16);
            correoLabel.TabIndex = 39;
            correoLabel.Text = "Correo:";
            // 
            // lblNombreRepresentante
            // 
            lblNombreRepresentante.AutoSize = true;
            lblNombreRepresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreRepresentante.Location = new System.Drawing.Point(231, 215);
            lblNombreRepresentante.Name = "lblNombreRepresentante";
            lblNombreRepresentante.Size = new System.Drawing.Size(151, 16);
            lblNombreRepresentante.TabIndex = 41;
            lblNombreRepresentante.Text = "Nombre Representante:";
            // 
            // lblTelefRepresentante
            // 
            lblTelefRepresentante.AutoSize = true;
            lblTelefRepresentante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelefRepresentante.Location = new System.Drawing.Point(501, 111);
            lblTelefRepresentante.Name = "lblTelefRepresentante";
            lblTelefRepresentante.Size = new System.Drawing.Size(186, 20);
            lblTelefRepresentante.TabIndex = 43;
            lblTelefRepresentante.Text = "Teléfono Representante:";
            // 
            // labelCalificación
            // 
            labelCalificación.AutoSize = true;
            labelCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCalificación.Location = new System.Drawing.Point(701, 175);
            labelCalificación.Name = "labelCalificación";
            labelCalificación.Size = new System.Drawing.Size(79, 16);
            labelCalificación.TabIndex = 50;
            labelCalificación.Text = "Calificación:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(689, 216);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(67, 16);
            direccionLabel.TabIndex = 52;
            direccionLabel.Text = "Dirección:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fechaInicioLabel.Location = new System.Drawing.Point(558, 151);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(82, 16);
            fechaInicioLabel.TabIndex = 58;
            fechaInicioLabel.Text = "Fecha Inicio:";
            // 
            // fechafinalLabel
            // 
            fechafinalLabel.AutoSize = true;
            fechafinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fechafinalLabel.Location = new System.Drawing.Point(558, 203);
            fechafinalLabel.Name = "fechafinalLabel";
            fechafinalLabel.Size = new System.Drawing.Size(72, 16);
            fechafinalLabel.TabIndex = 59;
            fechafinalLabel.Text = "Fechafinal:";
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
            this.rif,
            this.Nombre,
            this.direccion,
            this.Telefono,
            this.Correo,
            this.NombreRepresentante,
            this.TelefonoRepresentante,
            this.FechaInicio,
            this.FechaFinal,
            this.Calificacion,
            this.Estado});
            this.dataGridView1.DataSource = this.empresasSubcontratadaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
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
            this.RifTextBox.Location = new System.Drawing.Point(88, 108);
            this.RifTextBox.Name = "RifTextBox";
            this.RifTextBox.Size = new System.Drawing.Size(100, 22);
            this.RifTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(88, 159);
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
            this.EstadoComboBox.Location = new System.Drawing.Point(88, 215);
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
            this.CodigoTelfComboBox.Location = new System.Drawing.Point(300, 108);
            this.CodigoTelfComboBox.Name = "CodigoTelfComboBox";
            this.CodigoTelfComboBox.Size = new System.Drawing.Size(50, 21);
            this.CodigoTelfComboBox.TabIndex = 38;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(356, 109);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(87, 20);
            this.telefonoTextBox.TabIndex = 37;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(300, 159);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 22);
            this.correoTextBox.TabIndex = 40;
            // 
            // NombreRepresentanteTextBox
            // 
            this.NombreRepresentanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "NombreRepresentante", true));
            this.NombreRepresentanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRepresentanteTextBox.Location = new System.Drawing.Point(388, 215);
            this.NombreRepresentanteTextBox.Name = "NombreRepresentanteTextBox";
            this.NombreRepresentanteTextBox.Size = new System.Drawing.Size(100, 22);
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
            this.comboBoxTelfRepre.Location = new System.Drawing.Point(698, 112);
            this.comboBoxTelfRepre.Name = "comboBoxTelfRepre";
            this.comboBoxTelfRepre.Size = new System.Drawing.Size(50, 21);
            this.comboBoxTelfRepre.TabIndex = 45;
            // 
            // textBoxTelfRepre
            // 
            this.textBoxTelfRepre.Location = new System.Drawing.Point(754, 113);
            this.textBoxTelfRepre.Name = "textBoxTelfRepre";
            this.textBoxTelfRepre.Size = new System.Drawing.Size(87, 20);
            this.textBoxTelfRepre.TabIndex = 44;
            this.textBoxTelfRepre.TextChanged += new System.EventHandler(this.textBoxTelfRepre_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(762, 215);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 53;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(987, 191);
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
            this.modificar.Location = new System.Drawing.Point(1070, 126);
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
            this.agregar.Location = new System.Drawing.Point(893, 127);
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
            this.statusStrip1.Size = new System.Drawing.Size(1240, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripLblDev
            // 
            this.ToolStripLblDev.Name = "ToolStripLblDev";
            this.ToolStripLblDev.Size = new System.Drawing.Size(1023, 17);
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
            this.CalificacionComboBox.Location = new System.Drawing.Point(786, 174);
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
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(544, 175);
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
            this.fechafinalDateTimePicker.Location = new System.Drawing.Point(544, 222);
            this.fechafinalDateTimePicker.Name = "fechafinalDateTimePicker";
            this.fechafinalDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.fechafinalDateTimePicker.TabIndex = 60;
            // 
            // rif
            // 
            this.rif.DataPropertyName = "rif";
            this.rif.HeaderText = "Rif de la empresa";
            this.rif.Name = "rif";
            this.rif.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre de la Empresa";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion de la Empresa";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono de la Empresa";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo de la Empresa";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // NombreRepresentante
            // 
            this.NombreRepresentante.DataPropertyName = "NombreRepresentante";
            this.NombreRepresentante.HeaderText = "Nombre del Representante";
            this.NombreRepresentante.Name = "NombreRepresentante";
            this.NombreRepresentante.ReadOnly = true;
            // 
            // TelefonoRepresentante
            // 
            this.TelefonoRepresentante.DataPropertyName = "TelefonoRepresentante";
            this.TelefonoRepresentante.HeaderText = "Telefono del Representante";
            this.TelefonoRepresentante.Name = "TelefonoRepresentante";
            this.TelefonoRepresentante.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Inicio del Contrato";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFinal
            // 
            this.FechaFinal.DataPropertyName = "Fechafinal";
            this.FechaFinal.HeaderText = "Finalizacion del Contrato";
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            // 
            // Calificacion
            // 
            this.Calificacion.DataPropertyName = "Calificacion";
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FormEmpresasSubcontratadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1240, 540);
            this.Controls.Add(fechafinalLabel);
            this.Controls.Add(this.fechafinalDateTimePicker);
            this.Controls.Add(fechaInicioLabel);
            this.Controls.Add(this.fechaInicioDateTimePicker);
            this.Controls.Add(this.CalificacionComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(labelCalificación);
            this.Controls.Add(this.comboBoxTelfRepre);
            this.Controls.Add(lblTelefRepresentante);
            this.Controls.Add(this.textBoxTelfRepre);
            this.Controls.Add(lblNombreRepresentante);
            this.Controls.Add(this.NombreRepresentanteTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.CodigoTelfComboBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(rifLabel);
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
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechafinalDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn rif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}