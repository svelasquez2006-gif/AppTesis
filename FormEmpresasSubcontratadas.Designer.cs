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
            System.Windows.Forms.Label fecha_InicioLabel;
            System.Windows.Forms.Label fecha_FinalizacionLabel;
            System.Windows.Forms.Label labelCalificación;
            System.Windows.Forms.Label direccionLabel;
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
            this.empresasSubcontratadaTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.EmpresasSubcontratadaTableAdapter();
            this.RifTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.CodigoTelfComboBox = new System.Windows.Forms.ComboBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxTelfRepre = new System.Windows.Forms.ComboBox();
            this.textBoxTelfRepre = new System.Windows.Forms.TextBox();
            this.fecha_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_FinalizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxCalificación = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.salir = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.agregar = new BotonRedondo();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripLblDev = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLblDev2 = new System.Windows.Forms.ToolStripStatusLabel();
            rifLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            lblNombreRepresentante = new System.Windows.Forms.Label();
            lblTelefRepresentante = new System.Windows.Forms.Label();
            fecha_InicioLabel = new System.Windows.Forms.Label();
            fecha_FinalizacionLabel = new System.Windows.Forms.Label();
            labelCalificación = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
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
            // fecha_InicioLabel
            // 
            fecha_InicioLabel.AutoSize = true;
            fecha_InicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fecha_InicioLabel.Location = new System.Drawing.Point(536, 150);
            fecha_InicioLabel.Name = "fecha_InicioLabel";
            fecha_InicioLabel.Size = new System.Drawing.Size(101, 16);
            fecha_InicioLabel.TabIndex = 46;
            fecha_InicioLabel.Text = "Fecha de Inicio:";
            // 
            // fecha_FinalizacionLabel
            // 
            fecha_FinalizacionLabel.AutoSize = true;
            fecha_FinalizacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fecha_FinalizacionLabel.Location = new System.Drawing.Point(527, 195);
            fecha_FinalizacionLabel.Name = "fecha_FinalizacionLabel";
            fecha_FinalizacionLabel.Size = new System.Drawing.Size(141, 16);
            fecha_FinalizacionLabel.TabIndex = 48;
            fecha_FinalizacionLabel.Text = "Fecha de Finalizacion:";
            // 
            // labelCalificación
            // 
            labelCalificación.AutoSize = true;
            labelCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCalificación.Location = new System.Drawing.Point(676, 175);
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
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // rifDataGridViewTextBoxColumn
            // 
            this.rifDataGridViewTextBoxColumn.DataPropertyName = "rif";
            this.rifDataGridViewTextBoxColumn.HeaderText = "rif";
            this.rifDataGridViewTextBoxColumn.Name = "rifDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // nombreRepresentanteDataGridViewTextBoxColumn
            // 
            this.nombreRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "NombreRepresentante";
            this.nombreRepresentanteDataGridViewTextBoxColumn.HeaderText = "NombreRepresentante";
            this.nombreRepresentanteDataGridViewTextBoxColumn.Name = "nombreRepresentanteDataGridViewTextBoxColumn";
            // 
            // telefonoRepresentanteDataGridViewTextBoxColumn
            // 
            this.telefonoRepresentanteDataGridViewTextBoxColumn.DataPropertyName = "TelefonoRepresentante";
            this.telefonoRepresentanteDataGridViewTextBoxColumn.HeaderText = "TelefonoRepresentante";
            this.telefonoRepresentanteDataGridViewTextBoxColumn.Name = "telefonoRepresentanteDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechafinalDataGridViewTextBoxColumn
            // 
            this.fechafinalDataGridViewTextBoxColumn.DataPropertyName = "Fechafinal";
            this.fechafinalDataGridViewTextBoxColumn.HeaderText = "Fechafinal";
            this.fechafinalDataGridViewTextBoxColumn.Name = "fechafinalDataGridViewTextBoxColumn";
            // 
            // calificacionDataGridViewTextBoxColumn
            // 
            this.calificacionDataGridViewTextBoxColumn.DataPropertyName = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.HeaderText = "Calificacion";
            this.calificacionDataGridViewTextBoxColumn.Name = "calificacionDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
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
            // empresasSubcontratadaTableAdapter
            // 
            this.empresasSubcontratadaTableAdapter.ClearBeforeFill = true;
            // 
            // RifTextBox
            // 
            this.RifTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RifTextBox.Location = new System.Drawing.Point(88, 108);
            this.RifTextBox.Name = "RifTextBox";
            this.RifTextBox.Size = new System.Drawing.Size(100, 22);
            this.RifTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(88, 159);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 11;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Activo",
            "Bloqueado"});
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
            // 
            // correoTextBox
            // 
            this.correoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(300, 159);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 22);
            this.correoTextBox.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(388, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 42;
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
            // 
            // fecha_InicioDateTimePicker
            // 
            this.fecha_InicioDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fecha_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_InicioDateTimePicker.Location = new System.Drawing.Point(539, 172);
            this.fecha_InicioDateTimePicker.Name = "fecha_InicioDateTimePicker";
            this.fecha_InicioDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.fecha_InicioDateTimePicker.TabIndex = 47;
            // 
            // fecha_FinalizacionDateTimePicker
            // 
            this.fecha_FinalizacionDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fecha_FinalizacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_FinalizacionDateTimePicker.Location = new System.Drawing.Point(539, 214);
            this.fecha_FinalizacionDateTimePicker.Name = "fecha_FinalizacionDateTimePicker";
            this.fecha_FinalizacionDateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.fecha_FinalizacionDateTimePicker.TabIndex = 49;
            // 
            // textBoxCalificación
            // 
            this.textBoxCalificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalificación.Location = new System.Drawing.Point(762, 173);
            this.textBoxCalificación.Name = "textBoxCalificación";
            this.textBoxCalificación.Size = new System.Drawing.Size(100, 22);
            this.textBoxCalificación.TabIndex = 51;
            // 
            // direccionTextBox
            // 
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
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLblDev,
            this.ToolStripLblDev2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripLblDev
            // 
            this.ToolStripLblDev.Name = "ToolStripLblDev";
            this.ToolStripLblDev.Size = new System.Drawing.Size(1015, 17);
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
            // FormEmpresasSubcontratadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1232, 540);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(labelCalificación);
            this.Controls.Add(this.textBoxCalificación);
            this.Controls.Add(fecha_InicioLabel);
            this.Controls.Add(this.fecha_InicioDateTimePicker);
            this.Controls.Add(fecha_FinalizacionLabel);
            this.Controls.Add(this.fecha_FinalizacionDateTimePicker);
            this.Controls.Add(this.comboBoxTelfRepre);
            this.Controls.Add(lblTelefRepresentante);
            this.Controls.Add(this.textBoxTelfRepre);
            this.Controls.Add(lblNombreRepresentante);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox RifTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.ComboBox CodigoTelfComboBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxTelfRepre;
        private System.Windows.Forms.TextBox textBoxTelfRepre;
        private System.Windows.Forms.DateTimePicker fecha_InicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_FinalizacionDateTimePicker;
        private System.Windows.Forms.TextBox textBoxCalificación;
        private System.Windows.Forms.TextBox direccionTextBox;
        private BotonRedondo salir;
        private BotonRedondo modificar;
        private BotonRedondo agregar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev2;
    }
}