namespace AppTesis
{
    partial class FormMantenimiento
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
            System.Windows.Forms.Label fechaMantenimientoLabel;
            System.Windows.Forms.Label anotacionesLabel;
            System.Windows.Forms.Label codMantenimientoLabel;
            System.Windows.Forms.Label tasa_USDLabel;
            System.Windows.Forms.Label coste_BSLabel;
            this.agregar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.mantenimientoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_USD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coste_BS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anotacionesTextBox = new System.Windows.Forms.TextBox();
            this.codMantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.PlacaComboBox = new System.Windows.Forms.ComboBox();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.VehiculoTableAdapter();
            this.mantenimientoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tasa_USDTextBox = new System.Windows.Forms.TextBox();
            this.coste_BSTextBox = new System.Windows.Forms.TextBox();
            nroPlacaLabel = new System.Windows.Forms.Label();
            fechaMantenimientoLabel = new System.Windows.Forms.Label();
            anotacionesLabel = new System.Windows.Forms.Label();
            codMantenimientoLabel = new System.Windows.Forms.Label();
            tasa_USDLabel = new System.Windows.Forms.Label();
            coste_BSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nroPlacaLabel
            // 
            nroPlacaLabel.AutoSize = true;
            nroPlacaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nroPlacaLabel.Location = new System.Drawing.Point(117, 119);
            nroPlacaLabel.Name = "nroPlacaLabel";
            nroPlacaLabel.Size = new System.Drawing.Size(81, 20);
            nroPlacaLabel.TabIndex = 25;
            nroPlacaLabel.Text = "Nro Placa:";
            // 
            // fechaMantenimientoLabel
            // 
            fechaMantenimientoLabel.AutoSize = true;
            fechaMantenimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaMantenimientoLabel.Location = new System.Drawing.Point(31, 155);
            fechaMantenimientoLabel.Name = "fechaMantenimientoLabel";
            fechaMantenimientoLabel.Size = new System.Drawing.Size(167, 20);
            fechaMantenimientoLabel.TabIndex = 27;
            fechaMantenimientoLabel.Text = "Fecha Mantenimiento:";
            // 
            // anotacionesLabel
            // 
            anotacionesLabel.AutoSize = true;
            anotacionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anotacionesLabel.Location = new System.Drawing.Point(96, 259);
            anotacionesLabel.Name = "anotacionesLabel";
            anotacionesLabel.Size = new System.Drawing.Size(102, 20);
            anotacionesLabel.TabIndex = 29;
            anotacionesLabel.Text = "Anotaciones:";
            // 
            // codMantenimientoLabel
            // 
            codMantenimientoLabel.AutoSize = true;
            codMantenimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codMantenimientoLabel.Location = new System.Drawing.Point(47, 88);
            codMantenimientoLabel.Name = "codMantenimientoLabel";
            codMantenimientoLabel.Size = new System.Drawing.Size(151, 20);
            codMantenimientoLabel.TabIndex = 23;
            codMantenimientoLabel.Text = "Cod Mantenimiento:";
            codMantenimientoLabel.Click += new System.EventHandler(this.codMantenimientoLabel_Click);
            // 
            // tasa_USDLabel
            // 
            tasa_USDLabel.AutoSize = true;
            tasa_USDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            tasa_USDLabel.Location = new System.Drawing.Point(111, 192);
            tasa_USDLabel.Name = "tasa_USDLabel";
            tasa_USDLabel.Size = new System.Drawing.Size(87, 20);
            tasa_USDLabel.TabIndex = 31;
            tasa_USDLabel.Text = "Tasa USD:";
            tasa_USDLabel.Click += new System.EventHandler(this.tasa_USDLabel_Click);
            // 
            // coste_BSLabel
            // 
            coste_BSLabel.AutoSize = true;
            coste_BSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            coste_BSLabel.Location = new System.Drawing.Point(117, 227);
            coste_BSLabel.Name = "coste_BSLabel";
            coste_BSLabel.Size = new System.Drawing.Size(81, 20);
            coste_BSLabel.TabIndex = 32;
            coste_BSLabel.Text = "Coste BS:";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(159, 357);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 20;
            this.agregar.Text = "Agregar Mantenimiento";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(448, 357);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 21;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "HISTORIAL DE MANTENIMIENTOS";
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = this.mantenimientoTableAdapter;
            this.tableAdapterManager.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // mantenimientoDataGridView
            // 
            this.mantenimientoDataGridView.AllowUserToDeleteRows = false;
            this.mantenimientoDataGridView.AutoGenerateColumns = false;
            this.mantenimientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mantenimientoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Tasa_USD,
            this.Coste_BS});
            this.mantenimientoDataGridView.DataSource = this.mantenimientoBindingSource;
            this.mantenimientoDataGridView.Location = new System.Drawing.Point(423, 110);
            this.mantenimientoDataGridView.Name = "mantenimientoDataGridView";
            this.mantenimientoDataGridView.ReadOnly = true;
            this.mantenimientoDataGridView.Size = new System.Drawing.Size(441, 220);
            this.mantenimientoDataGridView.TabIndex = 23;
            this.mantenimientoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mantenimientoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodMantenimiento";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NroPlaca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero de Placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaMantenimiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha cuando se realizo el mantenimiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Anotaciones";
            this.dataGridViewTextBoxColumn4.HeaderText = "Anotaciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Tasa_USD
            // 
            this.Tasa_USD.DataPropertyName = "Tasa_USD";
            this.Tasa_USD.HeaderText = "Tasa USD";
            this.Tasa_USD.Name = "Tasa_USD";
            this.Tasa_USD.ReadOnly = true;
            // 
            // Coste_BS
            // 
            this.Coste_BS.DataPropertyName = "Coste_BS";
            this.Coste_BS.HeaderText = "Coste BS";
            this.Coste_BS.Name = "Coste_BS";
            this.Coste_BS.ReadOnly = true;
            // 
            // fechaMantenimientoDateTimePicker
            // 
            this.fechaMantenimientoDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.fechaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaMantenimiento", true));
            this.fechaMantenimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaMantenimientoDateTimePicker.Location = new System.Drawing.Point(204, 155);
            this.fechaMantenimientoDateTimePicker.Name = "fechaMantenimientoDateTimePicker";
            this.fechaMantenimientoDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.fechaMantenimientoDateTimePicker.TabIndex = 28;
            this.fechaMantenimientoDateTimePicker.Value = new System.DateTime(2026, 8, 7, 0, 0, 0, 0);
            // 
            // anotacionesTextBox
            // 
            this.anotacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "Anotaciones", true));
            this.anotacionesTextBox.Location = new System.Drawing.Point(204, 259);
            this.anotacionesTextBox.Multiline = true;
            this.anotacionesTextBox.Name = "anotacionesTextBox";
            this.anotacionesTextBox.Size = new System.Drawing.Size(182, 73);
            this.anotacionesTextBox.TabIndex = 30;
            // 
            // codMantenimientoTextBox
            // 
            this.codMantenimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "CodMantenimiento", true));
            this.codMantenimientoTextBox.Location = new System.Drawing.Point(204, 90);
            this.codMantenimientoTextBox.Name = "codMantenimientoTextBox";
            this.codMantenimientoTextBox.ReadOnly = true;
            this.codMantenimientoTextBox.Size = new System.Drawing.Size(182, 20);
            this.codMantenimientoTextBox.TabIndex = 24;
            this.codMantenimientoTextBox.TextChanged += new System.EventHandler(this.codMantenimientoTextBox_TextChanged);
            // 
            // PlacaComboBox
            // 
            this.PlacaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mantenimientoBindingSource1, "NroPlaca", true));
            this.PlacaComboBox.DataSource = this.vehiculoBindingSource;
            this.PlacaComboBox.DisplayMember = "NroPlaca";
            this.PlacaComboBox.FormattingEnabled = true;
            this.PlacaComboBox.Location = new System.Drawing.Point(204, 121);
            this.PlacaComboBox.Name = "PlacaComboBox";
            this.PlacaComboBox.Size = new System.Drawing.Size(182, 21);
            this.PlacaComboBox.TabIndex = 31;
            this.PlacaComboBox.ValueMember = "NroPlaca";
            this.PlacaComboBox.SelectedIndexChanged += new System.EventHandler(this.PlacaComboBox_SelectedIndexChanged);
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
            // mantenimientoBindingSource1
            // 
            this.mantenimientoBindingSource1.DataMember = "FK_Mantenimiento_Vehiculo";
            this.mantenimientoBindingSource1.DataSource = this.vehiculoBindingSource;
            // 
            // tasa_USDTextBox
            // 
            this.tasa_USDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource1, "Tasa_USD", true));
            this.tasa_USDTextBox.Location = new System.Drawing.Point(204, 192);
            this.tasa_USDTextBox.Name = "tasa_USDTextBox";
            this.tasa_USDTextBox.Size = new System.Drawing.Size(182, 20);
            this.tasa_USDTextBox.TabIndex = 32;
            // 
            // coste_BSTextBox
            // 
            this.coste_BSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource1, "Coste_BS", true));
            this.coste_BSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.coste_BSTextBox.Location = new System.Drawing.Point(204, 227);
            this.coste_BSTextBox.Name = "coste_BSTextBox";
            this.coste_BSTextBox.Size = new System.Drawing.Size(182, 26);
            this.coste_BSTextBox.TabIndex = 33;
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(coste_BSLabel);
            this.Controls.Add(this.coste_BSTextBox);
            this.Controls.Add(tasa_USDLabel);
            this.Controls.Add(this.tasa_USDTextBox);
            this.Controls.Add(this.PlacaComboBox);
            this.Controls.Add(codMantenimientoLabel);
            this.Controls.Add(this.codMantenimientoTextBox);
            this.Controls.Add(nroPlacaLabel);
            this.Controls.Add(fechaMantenimientoLabel);
            this.Controls.Add(this.fechaMantenimientoDateTimePicker);
            this.Controls.Add(anotacionesLabel);
            this.Controls.Add(this.anotacionesTextBox);
            this.Controls.Add(this.mantenimientoDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.agregar);
            this.Name = "FormMantenimiento";
            this.Text = "FormMantenimiento";
            this.Load += new System.EventHandler(this.FormMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonRedondo agregar;
        private BotonRedondo salir;
        private System.Windows.Forms.Label label1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private DataBaseDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mantenimientoDataGridView;
        private System.Windows.Forms.DateTimePicker fechaMantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox anotacionesTextBox;
        private System.Windows.Forms.TextBox codMantenimientoTextBox;
        private System.Windows.Forms.ComboBox PlacaComboBox;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private DataBaseDataSetTableAdapters.VehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource1;
        private System.Windows.Forms.TextBox tasa_USDTextBox;
        private System.Windows.Forms.TextBox coste_BSTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_USD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coste_BS;
    }
}