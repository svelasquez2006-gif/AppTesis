namespace AppTesis
{
    partial class FormChoferes
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
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label grado_LicenciaLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label estatusLabel;
            System.Windows.Forms.Label fecha_NacimientoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label experienciaLabel;
            System.Windows.Forms.Label ruta_AsignadaLabel;
            System.Windows.Forms.Label afiliacionLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.labelCédulaNombreBuscar = new System.Windows.Forms.Label();
            this.txtBuscarChofer = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoLicenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_Asignada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.choferTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.ChoferTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.licenciacombobox = new System.Windows.Forms.ComboBox();
            this.estatuscombobox = new System.Windows.Forms.ComboBox();
            this.agregar = new BotonRedondo();
            this.botonRedondo1 = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.Filtro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.experienciaTextBox = new System.Windows.Forms.TextBox();
            this.RutaComboBox = new System.Windows.Forms.ComboBox();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutasTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.RutasTableAdapter();
            this.AfiliacionComboBox = new System.Windows.Forms.ComboBox();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            grado_LicenciaLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            fecha_NacimientoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            experienciaLabel = new System.Windows.Forms.Label();
            ruta_AsignadaLabel = new System.Windows.Forms.Label();
            afiliacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.Location = new System.Drawing.Point(70, 164);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(53, 16);
            cedulaLabel.TabIndex = 10;
            cedulaLabel.Text = "Cédula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(64, 190);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(63, 216);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(60, 16);
            apellidoLabel.TabIndex = 14;
            apellidoLabel.Text = "Apellido:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(56, 297);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(64, 16);
            telefonoLabel.TabIndex = 16;
            telefonoLabel.Text = "Teléfono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(73, 320);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(51, 16);
            correoLabel.TabIndex = 18;
            correoLabel.Text = "Correo:";
            // 
            // grado_LicenciaLabel
            // 
            grado_LicenciaLabel.AutoSize = true;
            grado_LicenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grado_LicenciaLabel.Location = new System.Drawing.Point(23, 347);
            grado_LicenciaLabel.Name = "grado_LicenciaLabel";
            grado_LicenciaLabel.Size = new System.Drawing.Size(101, 16);
            grado_LicenciaLabel.TabIndex = 20;
            grado_LicenciaLabel.Text = "Grado Licencia:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(53, 414);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(67, 16);
            direccionLabel.TabIndex = 22;
            direccionLabel.Text = "Dirección:";
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estatusLabel.Location = new System.Drawing.Point(66, 449);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(54, 16);
            estatusLabel.TabIndex = 24;
            estatusLabel.Text = "Estatus:";
            // 
            // fecha_NacimientoLabel
            // 
            fecha_NacimientoLabel.AutoSize = true;
            fecha_NacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            fecha_NacimientoLabel.Location = new System.Drawing.Point(5, 241);
            fecha_NacimientoLabel.Name = "fecha_NacimientoLabel";
            fecha_NacimientoLabel.Size = new System.Drawing.Size(119, 16);
            fecha_NacimientoLabel.TabIndex = 33;
            fecha_NacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            edadLabel.Location = new System.Drawing.Point(77, 270);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(43, 16);
            edadLabel.TabIndex = 34;
            edadLabel.Text = "Edad:";
            // 
            // experienciaLabel
            // 
            experienciaLabel.AutoSize = true;
            experienciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            experienciaLabel.Location = new System.Drawing.Point(39, 372);
            experienciaLabel.Name = "experienciaLabel";
            experienciaLabel.Size = new System.Drawing.Size(81, 32);
            experienciaLabel.TabIndex = 35;
            experienciaLabel.Text = "Años de \r\nExperiencia:";
            // 
            // ruta_AsignadaLabel
            // 
            ruta_AsignadaLabel.AutoSize = true;
            ruta_AsignadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            ruta_AsignadaLabel.Location = new System.Drawing.Point(21, 476);
            ruta_AsignadaLabel.Name = "ruta_AsignadaLabel";
            ruta_AsignadaLabel.Size = new System.Drawing.Size(99, 16);
            ruta_AsignadaLabel.TabIndex = 36;
            ruta_AsignadaLabel.Text = "Ruta Asignada:";
            // 
            // afiliacionLabel
            // 
            afiliacionLabel.AutoSize = true;
            afiliacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            afiliacionLabel.Location = new System.Drawing.Point(56, 502);
            afiliacionLabel.Name = "afiliacionLabel";
            afiliacionLabel.Size = new System.Drawing.Size(64, 16);
            afiliacionLabel.TabIndex = 37;
            afiliacionLabel.Text = "Afiliacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(359, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE CHOFERES";
            // 
            // labelCédulaNombreBuscar
            // 
            this.labelCédulaNombreBuscar.AutoSize = true;
            this.labelCédulaNombreBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCédulaNombreBuscar.Location = new System.Drawing.Point(37, 105);
            this.labelCédulaNombreBuscar.Name = "labelCédulaNombreBuscar";
            this.labelCédulaNombreBuscar.Size = new System.Drawing.Size(111, 30);
            this.labelCédulaNombreBuscar.TabIndex = 1;
            this.labelCédulaNombreBuscar.Text = "Filtrar por";
            // 
            // txtBuscarChofer
            // 
            this.txtBuscarChofer.Location = new System.Drawing.Point(314, 114);
            this.txtBuscarChofer.Name = "txtBuscarChofer";
            this.txtBuscarChofer.Size = new System.Drawing.Size(381, 20);
            this.txtBuscarChofer.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(698, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(773, 112);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvChoferes
            // 
            this.dgvChoferes.AllowUserToAddRows = false;
            this.dgvChoferes.AllowUserToDeleteRows = false;
            this.dgvChoferes.AutoGenerateColumns = false;
            this.dgvChoferes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChoferes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.Fecha_Nacimiento,
            this.Edad,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.gradoLicenciaDataGridViewTextBoxColumn,
            this.Experiencia,
            this.direccionDataGridViewTextBoxColumn,
            this.Ruta_Asignada,
            this.estatusDataGridViewTextBoxColumn,
            this.Afiliacion});
            this.dgvChoferes.DataSource = this.choferBindingSource;
            this.dgvChoferes.Location = new System.Drawing.Point(247, 163);
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.ReadOnly = true;
            this.dgvChoferes.Size = new System.Drawing.Size(831, 333);
            this.dgvChoferes.TabIndex = 5;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradoLicenciaDataGridViewTextBoxColumn
            // 
            this.gradoLicenciaDataGridViewTextBoxColumn.DataPropertyName = "Grado_Licencia";
            this.gradoLicenciaDataGridViewTextBoxColumn.HeaderText = "Grado de la Licencia";
            this.gradoLicenciaDataGridViewTextBoxColumn.Name = "gradoLicenciaDataGridViewTextBoxColumn";
            this.gradoLicenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Experiencia
            // 
            this.Experiencia.DataPropertyName = "Experiencia";
            this.Experiencia.HeaderText = "Años de Experiencia";
            this.Experiencia.Name = "Experiencia";
            this.Experiencia.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ruta_Asignada
            // 
            this.Ruta_Asignada.DataPropertyName = "Ruta_Asignada";
            this.Ruta_Asignada.HeaderText = "Ruta Asignada";
            this.Ruta_Asignada.Name = "Ruta_Asignada";
            this.Ruta_Asignada.ReadOnly = true;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Afiliacion
            // 
            this.Afiliacion.DataPropertyName = "Afiliacion";
            this.Afiliacion.HeaderText = "Afiliacion";
            this.Afiliacion.Name = "Afiliacion";
            this.Afiliacion.ReadOnly = true;
            // 
            // choferBindingSource
            // 
            this.choferBindingSource.DataMember = "Chofer";
            this.choferBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choferTableAdapter
            // 
            this.choferTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = this.choferTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(126, 163);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaTextBox.TabIndex = 11;
            this.cedulaTextBox.TextChanged += new System.EventHandler(this.cedulaTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(126, 189);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 13;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(126, 215);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 15;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(126, 293);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 17;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(126, 319);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoTextBox.TabIndex = 19;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(126, 413);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 23;
            // 
            // licenciacombobox
            // 
            this.licenciacombobox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Grado_Licencia", true));
            this.licenciacombobox.FormattingEnabled = true;
            this.licenciacombobox.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.licenciacombobox.Location = new System.Drawing.Point(126, 345);
            this.licenciacombobox.Name = "licenciacombobox";
            this.licenciacombobox.Size = new System.Drawing.Size(100, 21);
            this.licenciacombobox.TabIndex = 25;
            // 
            // estatuscombobox
            // 
            this.estatuscombobox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Estatus", true));
            this.estatuscombobox.FormattingEnabled = true;
            this.estatuscombobox.Items.AddRange(new object[] {
            "Activo",
            "En Viaje",
            "De Vacaciones",
            "Inactivo"});
            this.estatuscombobox.Location = new System.Drawing.Point(126, 448);
            this.estatuscombobox.Name = "estatuscombobox";
            this.estatuscombobox.Size = new System.Drawing.Size(100, 21);
            this.estatuscombobox.TabIndex = 26;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(247, 511);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(238, 40);
            this.agregar.TabIndex = 27;
            this.agregar.Text = "Agregar Chofer";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botonRedondo1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonRedondo1.FlatAppearance.BorderSize = 2;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.Location = new System.Drawing.Point(579, 511);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.RadioBorde = 20;
            this.botonRedondo1.Size = new System.Drawing.Size(205, 40);
            this.botonRedondo1.TabIndex = 30;
            this.botonRedondo1.Text = "Modificar Chofer";
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(854, 511);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(224, 40);
            this.salir.TabIndex = 31;
            this.salir.Text = "Cancelar";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Filtro
            // 
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.FormattingEnabled = true;
            this.Filtro.Items.AddRange(new object[] {
            "<Selecionar>",
            "Cedula",
            "Nombre"});
            this.Filtro.Location = new System.Drawing.Point(143, 113);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(121, 21);
            this.Filtro.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fecha_NacimientoDateTimePicker
            // 
            this.fecha_NacimientoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fecha_NacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.choferBindingSource, "Fecha_Nacimiento", true));
            this.fecha_NacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_NacimientoDateTimePicker.Location = new System.Drawing.Point(126, 241);
            this.fecha_NacimientoDateTimePicker.Name = "fecha_NacimientoDateTimePicker";
            this.fecha_NacimientoDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fecha_NacimientoDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fecha_NacimientoDateTimePicker.TabIndex = 34;
            this.fecha_NacimientoDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_NacimientoDateTimePicker_ValueChanged);
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Edad", true));
            this.edadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.edadTextBox.Location = new System.Drawing.Point(126, 267);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.ReadOnly = true;
            this.edadTextBox.Size = new System.Drawing.Size(100, 22);
            this.edadTextBox.TabIndex = 35;
            // 
            // experienciaTextBox
            // 
            this.experienciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Experiencia", true));
            this.experienciaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.experienciaTextBox.Location = new System.Drawing.Point(126, 381);
            this.experienciaTextBox.Name = "experienciaTextBox";
            this.experienciaTextBox.Size = new System.Drawing.Size(100, 22);
            this.experienciaTextBox.TabIndex = 36;
            this.experienciaTextBox.TextChanged += new System.EventHandler(this.experienciaTextBox_TextChanged);
            // 
            // RutaComboBox
            // 
            this.RutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.choferBindingSource, "Ruta_Asignada", true));
            this.RutaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Ruta_Asignada", true));
            this.RutaComboBox.DataSource = this.rutasBindingSource;
            this.RutaComboBox.DisplayMember = "Nombre_Ruta";
            this.RutaComboBox.FormattingEnabled = true;
            this.RutaComboBox.Location = new System.Drawing.Point(126, 475);
            this.RutaComboBox.Name = "RutaComboBox";
            this.RutaComboBox.Size = new System.Drawing.Size(100, 21);
            this.RutaComboBox.TabIndex = 39;
            this.RutaComboBox.ValueMember = "Nombre_Ruta";
            // 
            // rutasBindingSource
            // 
            this.rutasBindingSource.DataMember = "Rutas";
            this.rutasBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // rutasTableAdapter
            // 
            this.rutasTableAdapter.ClearBeforeFill = true;
            // 
            // AfiliacionComboBox
            // 
            this.AfiliacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.choferBindingSource, "Afiliacion", true));
            this.AfiliacionComboBox.FormattingEnabled = true;
            this.AfiliacionComboBox.Items.AddRange(new object[] {
            "Empresa",
            "Subcontratado"});
            this.AfiliacionComboBox.Location = new System.Drawing.Point(126, 502);
            this.AfiliacionComboBox.Name = "AfiliacionComboBox";
            this.AfiliacionComboBox.Size = new System.Drawing.Size(100, 21);
            this.AfiliacionComboBox.TabIndex = 40;
            // 
            // FormChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 578);
            this.Controls.Add(this.AfiliacionComboBox);
            this.Controls.Add(this.RutaComboBox);
            this.Controls.Add(afiliacionLabel);
            this.Controls.Add(ruta_AsignadaLabel);
            this.Controls.Add(experienciaLabel);
            this.Controls.Add(this.experienciaTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(fecha_NacimientoLabel);
            this.Controls.Add(this.fecha_NacimientoDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.botonRedondo1);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.estatuscombobox);
            this.Controls.Add(this.licenciacombobox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(grado_LicenciaLabel);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(estatusLabel);
            this.Controls.Add(this.dgvChoferes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarChofer);
            this.Controls.Add(this.labelCédulaNombreBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormChoferes";
            this.Text = "FormChoferes";
            this.Load += new System.EventHandler(this.FormChoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCédulaNombreBuscar;
        private System.Windows.Forms.TextBox txtBuscarChofer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvChoferes;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource choferBindingSource;
        private DataBaseDataSetTableAdapters.ChoferTableAdapter choferTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.ComboBox licenciacombobox;
        private System.Windows.Forms.ComboBox estatuscombobox;
        private BotonRedondo agregar;
        private BotonRedondo botonRedondo1;
        private BotonRedondo salir;
        private System.Windows.Forms.ComboBox Filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha_NacimientoDateTimePicker;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox experienciaTextBox;
        private System.Windows.Forms.ComboBox RutaComboBox;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private DataBaseDataSetTableAdapters.RutasTableAdapter rutasTableAdapter;
        private System.Windows.Forms.ComboBox AfiliacionComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoLicenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_Asignada;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afiliacion;
    }
}