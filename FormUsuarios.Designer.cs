namespace AppTesis
{
    partial class FormUsuarios
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label jerarquiaLabel;
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.jerarquiacomboBox = new System.Windows.Forms.ComboBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripLblDev = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLblDev2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuarioTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager1 = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerarquiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salir = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.agregar = new BotonRedondo();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            jerarquiaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.Location = new System.Drawing.Point(46, 84);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(53, 16);
            cedulaLabel.TabIndex = 6;
            cedulaLabel.Text = "Cédula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(45, 123);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(45, 163);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(60, 16);
            apellidoLabel.TabIndex = 10;
            apellidoLabel.Text = "Apellido:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(46, 201);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(57, 16);
            usuarioLabel.TabIndex = 12;
            usuarioLabel.Text = "Usuario:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(39, 239);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(79, 16);
            contrasenaLabel.TabIndex = 14;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(46, 278);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(51, 16);
            correoLabel.TabIndex = 16;
            correoLabel.Text = "Correo:";
            // 
            // jerarquiaLabel
            // 
            jerarquiaLabel.AutoSize = true;
            jerarquiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jerarquiaLabel.Location = new System.Drawing.Point(41, 317);
            jerarquiaLabel.Name = "jerarquiaLabel";
            jerarquiaLabel.Size = new System.Drawing.Size(67, 16);
            jerarquiaLabel.TabIndex = 18;
            jerarquiaLabel.Text = "Jerarquía:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(46, 360);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 16);
            label2.TabIndex = 20;
            label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIOS";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cedula", true));
            this.cedulaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaTextBox.Location = new System.Drawing.Point(21, 100);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 22);
            this.cedulaTextBox.TabIndex = 7;
            this.cedulaTextBox.TextChanged += new System.EventHandler(this.cedulaTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(21, 139);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 9;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(21, 179);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 22);
            this.apellidoTextBox.TabIndex = 11;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(21, 217);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.usuarioTextBox.TabIndex = 13;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTextBox.Location = new System.Drawing.Point(21, 255);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(100, 22);
            this.contrasenaTextBox.TabIndex = 15;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(21, 294);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 22);
            this.correoTextBox.TabIndex = 17;
            // 
            // jerarquiacomboBox
            // 
            this.jerarquiacomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Jerarquia", true));
            this.jerarquiacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jerarquiacomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jerarquiacomboBox.FormattingEnabled = true;
            this.jerarquiacomboBox.Items.AddRange(new object[] {
            "Jefe",
            "Secretario",
            "Empleado"});
            this.jerarquiacomboBox.Location = new System.Drawing.Point(21, 333);
            this.jerarquiacomboBox.Name = "jerarquiacomboBox";
            this.jerarquiacomboBox.Size = new System.Drawing.Size(100, 24);
            this.jerarquiacomboBox.TabIndex = 19;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Estado", true));
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Activo",
            "Bloqueado"});
            this.EstadoComboBox.Location = new System.Drawing.Point(21, 379);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(100, 21);
            this.EstadoComboBox.TabIndex = 21;
            this.EstadoComboBox.SelectedIndexChanged += new System.EventHandler(this.EstadoComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLblDev,
            this.ToolStripLblDev2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripLblDev
            // 
            this.ToolStripLblDev.Name = "ToolStripLblDev";
            this.ToolStripLblDev.Size = new System.Drawing.Size(690, 17);
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
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChoferTableAdapter = null;
            this.tableAdapterManager1.ClienteTableAdapter = null;
            this.tableAdapterManager1.EmpresasSubcontratadaTableAdapter = null;
            this.tableAdapterManager1.MantenimientoTableAdapter = null;
            this.tableAdapterManager1.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager1.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager1.RutasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuarioTableAdapter = this.usuarioTableAdapter;
            this.tableAdapterManager1.VehiculoTableAdapter = null;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.jerarquiaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.clienteDataGridView.DataSource = this.usuarioBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(156, 84);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.Size = new System.Drawing.Size(723, 316);
            this.clienteDataGridView.TabIndex = 26;
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
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "Contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            this.contrasenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jerarquiaDataGridViewTextBoxColumn
            // 
            this.jerarquiaDataGridViewTextBoxColumn.DataPropertyName = "Jerarquia";
            this.jerarquiaDataGridViewTextBoxColumn.HeaderText = "Jerarquia";
            this.jerarquiaDataGridViewTextBoxColumn.Name = "jerarquiaDataGridViewTextBoxColumn";
            this.jerarquiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(641, 429);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 5;
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
            this.modificar.Location = new System.Drawing.Point(430, 429);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar Usuario";
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
            this.agregar.Location = new System.Drawing.Point(220, 429);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 3;
            this.agregar.Text = "Agregar Usuario";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 542);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.jerarquiacomboBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(jerarquiaLabel);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuarios";
            this.Text = "Gestionar Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BotonRedondo agregar;
        private BotonRedondo modificar;
        private BotonRedondo salir;
        private DataBaseDataSet dataBaseDataSet;
        private DataBaseDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ComboBox jerarquiacomboBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev2;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerarquiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}