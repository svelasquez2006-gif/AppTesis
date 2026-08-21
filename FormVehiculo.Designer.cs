namespace AppTesis
{
    partial class Formvehiculos
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
            System.Windows.Forms.Label nroPlacaLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label anioLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label estatusLabel;
            System.Windows.Forms.Label tipo_VehiculoLabel;
            this.agregar = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.lblListVehículos = new System.Windows.Forms.Label();
            this.mantenimiento = new BotonRedondo();
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.VehiculoTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.vehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPlacaTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.estatuscombobox = new System.Windows.Forms.ComboBox();
            this.AñoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            nroPlacaLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            anioLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            tipo_VehiculoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nroPlacaLabel
            // 
            nroPlacaLabel.AutoSize = true;
            nroPlacaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nroPlacaLabel.Location = new System.Drawing.Point(89, 78);
            nroPlacaLabel.Name = "nroPlacaLabel";
            nroPlacaLabel.Size = new System.Drawing.Size(70, 16);
            nroPlacaLabel.TabIndex = 7;
            nroPlacaLabel.Text = "Nro Placa:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(111, 129);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(48, 16);
            marcaLabel.TabIndex = 9;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(103, 155);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(56, 16);
            modeloLabel.TabIndex = 11;
            modeloLabel.Text = "Modelo:";
            // 
            // anioLabel
            // 
            anioLabel.AutoSize = true;
            anioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anioLabel.Location = new System.Drawing.Point(125, 181);
            anioLabel.Name = "anioLabel";
            anioLabel.Size = new System.Drawing.Size(34, 16);
            anioLabel.TabIndex = 13;
            anioLabel.Text = "Año:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(117, 207);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(42, 16);
            colorLabel.TabIndex = 15;
            colorLabel.Text = "Color:";
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estatusLabel.Location = new System.Drawing.Point(105, 233);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(54, 16);
            estatusLabel.TabIndex = 19;
            estatusLabel.Text = "Estatus:";
            // 
            // tipo_VehiculoLabel
            // 
            tipo_VehiculoLabel.AutoSize = true;
            tipo_VehiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            tipo_VehiculoLabel.Location = new System.Drawing.Point(66, 102);
            tipo_VehiculoLabel.Name = "tipo_VehiculoLabel";
            tipo_VehiculoLabel.Size = new System.Drawing.Size(93, 16);
            tipo_VehiculoLabel.TabIndex = 21;
            tipo_VehiculoLabel.Text = "Tipo Vehiculo:";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(12, 294);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Vehículo";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar.FlatAppearance.BorderSize = 2;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(12, 354);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar Vehículo";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(184, 354);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 4;
            this.salir.Text = "Volver al Menú";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // lblListVehículos
            // 
            this.lblListVehículos.AutoSize = true;
            this.lblListVehículos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListVehículos.Location = new System.Drawing.Point(407, 21);
            this.lblListVehículos.Name = "lblListVehículos";
            this.lblListVehículos.Size = new System.Drawing.Size(249, 25);
            this.lblListVehículos.TabIndex = 5;
            this.lblListVehículos.Text = "LISTA DE VEHÍCULOS";
            this.lblListVehículos.Click += new System.EventHandler(this.label1_Click);
            // 
            // mantenimiento
            // 
            this.mantenimiento.BackColor = System.Drawing.Color.Yellow;
            this.mantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mantenimiento.FlatAppearance.BorderSize = 2;
            this.mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimiento.Location = new System.Drawing.Point(184, 294);
            this.mantenimiento.Name = "mantenimiento";
            this.mantenimiento.RadioBorde = 20;
            this.mantenimiento.Size = new System.Drawing.Size(150, 40);
            this.mantenimiento.TabIndex = 6;
            this.mantenimiento.Text = "Mantenimiento";
            this.mantenimiento.UseVisualStyleBackColor = false;
            this.mantenimiento.Click += new System.EventHandler(this.mantenimiento_Click);
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "Vehiculo";
            this.vehiculoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = this.vehiculoTableAdapter;
            // 
            // vehiculoDataGridView
            // 
            this.vehiculoDataGridView.AllowUserToAddRows = false;
            this.vehiculoDataGridView.AllowUserToDeleteRows = false;
            this.vehiculoDataGridView.AutoGenerateColumns = false;
            this.vehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vehiculoDataGridView.DataSource = this.vehiculoBindingSource;
            this.vehiculoDataGridView.Location = new System.Drawing.Point(347, 76);
            this.vehiculoDataGridView.Name = "vehiculoDataGridView";
            this.vehiculoDataGridView.ReadOnly = true;
            this.vehiculoDataGridView.Size = new System.Drawing.Size(736, 220);
            this.vehiculoDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NroPlaca";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero de Placa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Anio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Año";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UltimoMantenimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha del Ultimo Mantenimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // nroPlacaTextBox
            // 
            this.nroPlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "NroPlaca", true));
            this.nroPlacaTextBox.Location = new System.Drawing.Point(165, 76);
            this.nroPlacaTextBox.Name = "nroPlacaTextBox";
            this.nroPlacaTextBox.Size = new System.Drawing.Size(156, 20);
            this.nroPlacaTextBox.TabIndex = 8;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(165, 128);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(156, 20);
            this.marcaTextBox.TabIndex = 10;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(165, 154);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(156, 20);
            this.modeloTextBox.TabIndex = 12;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(165, 206);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(156, 20);
            this.colorTextBox.TabIndex = 16;
            // 
            // estatuscombobox
            // 
            this.estatuscombobox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "Estatus", true));
            this.estatuscombobox.FormattingEnabled = true;
            this.estatuscombobox.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado o en viaje",
            "Averiado"});
            this.estatuscombobox.Location = new System.Drawing.Point(165, 233);
            this.estatuscombobox.Name = "estatuscombobox";
            this.estatuscombobox.Size = new System.Drawing.Size(156, 21);
            this.estatuscombobox.TabIndex = 20;
            // 
            // AñoDatePicker
            // 
            this.AñoDatePicker.CustomFormat = "yyyy";
            this.AñoDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AñoDatePicker.Location = new System.Drawing.Point(165, 177);
            this.AñoDatePicker.Name = "AñoDatePicker";
            this.AñoDatePicker.Size = new System.Drawing.Size(63, 20);
            this.AñoDatePicker.TabIndex = 21;
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "Tipo_Vehiculo", true));
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Items.AddRange(new object[] {
            "Autobus",
            "Camioneta",
            "Automovil",
            "Trailer"});
            this.TipoComboBox.Location = new System.Drawing.Point(165, 102);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(156, 21);
            this.TipoComboBox.TabIndex = 22;
            // 
            // Formvehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 415);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(tipo_VehiculoLabel);
            this.Controls.Add(this.AñoDatePicker);
            this.Controls.Add(this.estatuscombobox);
            this.Controls.Add(nroPlacaLabel);
            this.Controls.Add(this.nroPlacaTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(anioLabel);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(estatusLabel);
            this.Controls.Add(this.vehiculoDataGridView);
            this.Controls.Add(this.mantenimiento);
            this.Controls.Add(this.lblListVehículos);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Name = "Formvehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Formvehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonRedondo agregar;
        private BotonRedondo modificar;
        private BotonRedondo salir;
        private System.Windows.Forms.Label lblListVehículos;
        private BotonRedondo mantenimiento;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private DataBaseDataSetTableAdapters.VehiculoTableAdapter vehiculoTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vehiculoDataGridView;
        private System.Windows.Forms.TextBox nroPlacaTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.ComboBox estatuscombobox;
        private System.Windows.Forms.DateTimePicker AñoDatePicker;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}