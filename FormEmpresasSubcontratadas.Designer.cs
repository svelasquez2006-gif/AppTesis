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
            System.Windows.Forms.Label calificacionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label rifLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label nombreRepresentanteLabel;
            System.Windows.Forms.Label fechaInicioLabel;
            System.Windows.Forms.Label fechafinalLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            calificacionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            rifLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            nombreRepresentanteLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            fechafinalLabel = new System.Windows.Forms.Label();
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
            lblTelefRepresentante.Location = new System.Drawing.Point(666, 198);
            lblTelefRepresentante.Name = "lblTelefRepresentante";
            lblTelefRepresentante.Size = new System.Drawing.Size(120, 40);
            lblTelefRepresentante.TabIndex = 43;
            lblTelefRepresentante.Text = "Teléfono del \r\nRepresentante:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Location = new System.Drawing.Point(0, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new System.Drawing.Size(100, 23);
            lblFechaInicio.TabIndex = 8;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.Location = new System.Drawing.Point(0, 0);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new System.Drawing.Size(100, 23);
            lblFechaFinal.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new System.Drawing.Point(0, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(100, 23);
            lblCorreo.TabIndex = 6;
            // 
            // lblDirección
            // 
            lblDirección.Location = new System.Drawing.Point(0, 0);
            lblDirección.Name = "lblDirección";
            lblDirección.Size = new System.Drawing.Size(100, 23);
            lblDirección.TabIndex = 5;
            // 
            // lblCalificación
            // 
            lblCalificación.Location = new System.Drawing.Point(0, 0);
            lblCalificación.Name = "lblCalificación";
            lblCalificación.Size = new System.Drawing.Size(100, 23);
            lblCalificación.TabIndex = 4;
            // 
            // lblNomRepre
            // 
            lblNomRepre.Location = new System.Drawing.Point(0, 0);
            lblNomRepre.Name = "lblNomRepre";
            lblNomRepre.Size = new System.Drawing.Size(100, 23);
            lblNomRepre.TabIndex = 3;
            // 
            // lblRIF
            // 
            lblRIF.Location = new System.Drawing.Point(0, 0);
            lblRIF.Name = "lblRIF";
            lblRIF.Size = new System.Drawing.Size(100, 23);
            lblRIF.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.Location = new System.Drawing.Point(0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(100, 23);
            lblNombre.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.Location = new System.Drawing.Point(0, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(100, 23);
            lblEstado.TabIndex = 0;
            // 
            // calificacionLabel
            // 
            calificacionLabel.AutoSize = true;
            calificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            calificacionLabel.Location = new System.Drawing.Point(717, 165);
            calificacionLabel.Name = "calificacionLabel";
            calificacionLabel.Size = new System.Drawing.Size(93, 20);
            calificacionLabel.TabIndex = 60;
            calificacionLabel.Text = "Calificacion:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            direccionLabel.Location = new System.Drawing.Point(664, 114);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(79, 20);
            direccionLabel.TabIndex = 60;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nombreLabel.Location = new System.Drawing.Point(8, 158);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 20);
            nombreLabel.TabIndex = 60;
            nombreLabel.Text = "Nombre:";
            // 
            // rifLabel
            // 
            rifLabel.AutoSize = true;
            rifLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            rifLabel.Location = new System.Drawing.Point(37, 106);
            rifLabel.Name = "rifLabel";
            rifLabel.Size = new System.Drawing.Size(26, 20);
            rifLabel.TabIndex = 60;
            rifLabel.Text = "rif:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            estadoLabel.Location = new System.Drawing.Point(12, 215);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(64, 20);
            estadoLabel.TabIndex = 60;
            estadoLabel.Text = "Estado:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            correoLabel.Location = new System.Drawing.Point(211, 165);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(61, 20);
            correoLabel.TabIndex = 60;
            correoLabel.Text = "Correo:";
            // 
            // nombreRepresentanteLabel
            // 
            nombreRepresentanteLabel.AutoSize = true;
            nombreRepresentanteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nombreRepresentanteLabel.Location = new System.Drawing.Point(218, 198);
            nombreRepresentanteLabel.Name = "nombreRepresentanteLabel";
            nombreRepresentanteLabel.Size = new System.Drawing.Size(124, 40);
            nombreRepresentanteLabel.TabIndex = 60;
            nombreRepresentanteLabel.Text = "Nombre del\r\n Representante:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            fechaInicioLabel.Location = new System.Drawing.Point(513, 94);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(117, 40);
            fechaInicioLabel.TabIndex = 60;
            fechaInicioLabel.Text = "Fecha de Inicio\r\ndel Contrato:";
            // 
            // fechafinalLabel
            // 
            fechafinalLabel.AutoSize = true;
            fechafinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            fechafinalLabel.Location = new System.Drawing.Point(495, 172);
            fechafinalLabel.Name = "fechafinalLabel";
            fechafinalLabel.Size = new System.Drawing.Size(157, 40);
            fechafinalLabel.TabIndex = 60;
            fechafinalLabel.Text = "Fecha de finalilazion \r\ndel contrato:";
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 200);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
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
            this.correoTextBox.Location = new System.Drawing.Point(278, 165);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(157, 22);
            this.correoTextBox.TabIndex = 40;
            this.correoTextBox.TextChanged += new System.EventHandler(this.correoTextBox_TextChanged);
            // 
            // NombreRepresentanteTextBox
            // 
            this.NombreRepresentanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasSubcontratadaBindingSource, "NombreRepresentante", true));
            this.NombreRepresentanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreRepresentanteTextBox.Location = new System.Drawing.Point(348, 198);
            this.NombreRepresentanteTextBox.Name = "NombreRepresentanteTextBox";
            this.NombreRepresentanteTextBox.Size = new System.Drawing.Size(135, 22);
            this.NombreRepresentanteTextBox.TabIndex = 42;
            this.NombreRepresentanteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreRepresentanteTextBox_KeyPress);
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
            this.comboBoxTelfRepre.Location = new System.Drawing.Point(779, 209);
            this.comboBoxTelfRepre.Name = "comboBoxTelfRepre";
            this.comboBoxTelfRepre.Size = new System.Drawing.Size(50, 21);
            this.comboBoxTelfRepre.TabIndex = 45;
            this.comboBoxTelfRepre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTelfRepre_SelectedIndexChanged);
            // 
            // textBoxTelfRepre
            // 
            this.textBoxTelfRepre.Location = new System.Drawing.Point(835, 210);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1255, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripLblDev
            // 
            this.ToolStripLblDev.Name = "ToolStripLblDev";
            this.ToolStripLblDev.Size = new System.Drawing.Size(1038, 17);
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
            this.CalificacionComboBox.Location = new System.Drawing.Point(816, 167);
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
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(517, 136);
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
            this.fechafinalDateTimePicker.Location = new System.Drawing.Point(517, 215);
            this.fechafinalDateTimePicker.Name = "fechafinalDateTimePicker";
            this.fechafinalDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.fechafinalDateTimePicker.TabIndex = 60;
            // 
            // FormEmpresasSubcontratadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 557);
            this.Controls.Add(fechafinalLabel);
            this.Controls.Add(fechaInicioLabel);
            this.Controls.Add(nombreRepresentanteLabel);
            this.Controls.Add(correoLabel);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(rifLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(calificacionLabel);
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