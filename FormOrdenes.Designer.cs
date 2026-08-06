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
            System.Windows.Forms.Label cedula_ChoferLabel;
            System.Windows.Forms.Label vehiculos_NroPlacaLabel;
            System.Windows.Forms.Label cedula_ClienteLabel;
            System.Windows.Forms.Label destinoLabel;
            System.Windows.Forms.Label distancia_Esperada_KmLabel;
            System.Windows.Forms.Label fecha_InicioLabel;
            System.Windows.Forms.Label fecha_FinalizacionLabel;
            System.Windows.Forms.Label estatusLabel;
            System.Windows.Forms.Label iDOrdenes_ViajeLabel;
            this.agregar = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.label1 = new System.Windows.Forms.Label();
            this.orden_ViajeDataGridView = new System.Windows.Forms.DataGridView();
            this.cedula_ChoferTextBox = new System.Windows.Forms.TextBox();
            this.vehiculos_NroPlacaTextBox = new System.Windows.Forms.TextBox();
            this.cedula_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.distancia_Esperada_KmTextBox = new System.Windows.Forms.TextBox();
            this.fecha_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_FinalizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Estatuscombobox = new System.Windows.Forms.ComboBox();
            this.botonRedondo1 = new BotonRedondo();
            this.orden_ViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_ViajeTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.iDOrdenes_ViajeTextBox = new System.Windows.Forms.TextBox();
            cedula_ChoferLabel = new System.Windows.Forms.Label();
            vehiculos_NroPlacaLabel = new System.Windows.Forms.Label();
            cedula_ClienteLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            distancia_Esperada_KmLabel = new System.Windows.Forms.Label();
            fecha_InicioLabel = new System.Windows.Forms.Label();
            fecha_FinalizacionLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            iDOrdenes_ViajeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Location = new System.Drawing.Point(150, 351);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Orden";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar.FlatAppearance.BorderSize = 2;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Location = new System.Drawing.Point(750, 351);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar Orden";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(1036, 351);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 4;
            this.salir.Text = "Volver al Menu";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de Ordenes de Viaje";
            // 
            // orden_ViajeDataGridView
            // 
            this.orden_ViajeDataGridView.AllowUserToAddRows = false;
            this.orden_ViajeDataGridView.AllowUserToDeleteRows = false;
            this.orden_ViajeDataGridView.AutoGenerateColumns = false;
            this.orden_ViajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_ViajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.orden_ViajeDataGridView.DataSource = this.orden_ViajeBindingSource;
            this.orden_ViajeDataGridView.Location = new System.Drawing.Point(339, 98);
            this.orden_ViajeDataGridView.Name = "orden_ViajeDataGridView";
            this.orden_ViajeDataGridView.ReadOnly = true;
            this.orden_ViajeDataGridView.Size = new System.Drawing.Size(920, 220);
            this.orden_ViajeDataGridView.TabIndex = 6;
            this.orden_ViajeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_ViajeDataGridView_CellContentClick);
            // 
            // cedula_ChoferLabel
            // 
            cedula_ChoferLabel.AutoSize = true;
            cedula_ChoferLabel.Location = new System.Drawing.Point(15, 107);
            cedula_ChoferLabel.Name = "cedula_ChoferLabel";
            cedula_ChoferLabel.Size = new System.Drawing.Size(77, 13);
            cedula_ChoferLabel.TabIndex = 8;
            cedula_ChoferLabel.Text = "Cedula Chofer:";
            // 
            // cedula_ChoferTextBox
            // 
            this.cedula_ChoferTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Cedula_Chofer", true));
            this.cedula_ChoferTextBox.Location = new System.Drawing.Point(141, 104);
            this.cedula_ChoferTextBox.Name = "cedula_ChoferTextBox";
            this.cedula_ChoferTextBox.Size = new System.Drawing.Size(142, 20);
            this.cedula_ChoferTextBox.TabIndex = 9;
            // 
            // vehiculos_NroPlacaLabel
            // 
            vehiculos_NroPlacaLabel.AutoSize = true;
            vehiculos_NroPlacaLabel.Location = new System.Drawing.Point(15, 133);
            vehiculos_NroPlacaLabel.Name = "vehiculos_NroPlacaLabel";
            vehiculos_NroPlacaLabel.Size = new System.Drawing.Size(106, 13);
            vehiculos_NroPlacaLabel.TabIndex = 10;
            vehiculos_NroPlacaLabel.Text = "Vehiculos Nro Placa:";
            // 
            // vehiculos_NroPlacaTextBox
            // 
            this.vehiculos_NroPlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Vehiculos_NroPlaca", true));
            this.vehiculos_NroPlacaTextBox.Location = new System.Drawing.Point(141, 130);
            this.vehiculos_NroPlacaTextBox.Name = "vehiculos_NroPlacaTextBox";
            this.vehiculos_NroPlacaTextBox.Size = new System.Drawing.Size(142, 20);
            this.vehiculos_NroPlacaTextBox.TabIndex = 11;
            // 
            // cedula_ClienteLabel
            // 
            cedula_ClienteLabel.AutoSize = true;
            cedula_ClienteLabel.Location = new System.Drawing.Point(15, 159);
            cedula_ClienteLabel.Name = "cedula_ClienteLabel";
            cedula_ClienteLabel.Size = new System.Drawing.Size(78, 13);
            cedula_ClienteLabel.TabIndex = 12;
            cedula_ClienteLabel.Text = "Cedula Cliente:";
            // 
            // cedula_ClienteTextBox
            // 
            this.cedula_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Cedula_Cliente", true));
            this.cedula_ClienteTextBox.Location = new System.Drawing.Point(141, 156);
            this.cedula_ClienteTextBox.Name = "cedula_ClienteTextBox";
            this.cedula_ClienteTextBox.Size = new System.Drawing.Size(142, 20);
            this.cedula_ClienteTextBox.TabIndex = 13;
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Location = new System.Drawing.Point(15, 185);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(46, 13);
            destinoLabel.TabIndex = 14;
            destinoLabel.Text = "Destino:";
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Destino", true));
            this.destinoTextBox.Location = new System.Drawing.Point(141, 182);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.Size = new System.Drawing.Size(142, 20);
            this.destinoTextBox.TabIndex = 15;
            // 
            // distancia_Esperada_KmLabel
            // 
            distancia_Esperada_KmLabel.AutoSize = true;
            distancia_Esperada_KmLabel.Location = new System.Drawing.Point(15, 211);
            distancia_Esperada_KmLabel.Name = "distancia_Esperada_KmLabel";
            distancia_Esperada_KmLabel.Size = new System.Drawing.Size(120, 13);
            distancia_Esperada_KmLabel.TabIndex = 16;
            distancia_Esperada_KmLabel.Text = "Distancia Esperada Km:";
            // 
            // distancia_Esperada_KmTextBox
            // 
            this.distancia_Esperada_KmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "Distancia_Esperada_Km", true));
            this.distancia_Esperada_KmTextBox.Location = new System.Drawing.Point(141, 208);
            this.distancia_Esperada_KmTextBox.Name = "distancia_Esperada_KmTextBox";
            this.distancia_Esperada_KmTextBox.Size = new System.Drawing.Size(142, 20);
            this.distancia_Esperada_KmTextBox.TabIndex = 17;
            // 
            // fecha_InicioLabel
            // 
            fecha_InicioLabel.AutoSize = true;
            fecha_InicioLabel.Location = new System.Drawing.Point(15, 238);
            fecha_InicioLabel.Name = "fecha_InicioLabel";
            fecha_InicioLabel.Size = new System.Drawing.Size(68, 13);
            fecha_InicioLabel.TabIndex = 18;
            fecha_InicioLabel.Text = "Fecha Inicio:";
            // 
            // fecha_InicioDateTimePicker
            // 
            this.fecha_InicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orden_ViajeBindingSource, "Fecha_Inicio", true));
            this.fecha_InicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_InicioDateTimePicker.Location = new System.Drawing.Point(141, 234);
            this.fecha_InicioDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fecha_InicioDateTimePicker.Name = "fecha_InicioDateTimePicker";
            this.fecha_InicioDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.fecha_InicioDateTimePicker.TabIndex = 19;
            this.fecha_InicioDateTimePicker.Value = new System.DateTime(2026, 8, 5, 21, 36, 27, 0);
            // 
            // fecha_FinalizacionLabel
            // 
            fecha_FinalizacionLabel.AutoSize = true;
            fecha_FinalizacionLabel.Location = new System.Drawing.Point(15, 264);
            fecha_FinalizacionLabel.Name = "fecha_FinalizacionLabel";
            fecha_FinalizacionLabel.Size = new System.Drawing.Size(98, 13);
            fecha_FinalizacionLabel.TabIndex = 20;
            fecha_FinalizacionLabel.Text = "Fecha Finalizacion:";
            // 
            // fecha_FinalizacionDateTimePicker
            // 
            this.fecha_FinalizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orden_ViajeBindingSource, "Fecha_Finalizacion", true));
            this.fecha_FinalizacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_FinalizacionDateTimePicker.Location = new System.Drawing.Point(141, 260);
            this.fecha_FinalizacionDateTimePicker.Name = "fecha_FinalizacionDateTimePicker";
            this.fecha_FinalizacionDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.fecha_FinalizacionDateTimePicker.TabIndex = 21;
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Location = new System.Drawing.Point(15, 289);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(45, 13);
            estatusLabel.TabIndex = 22;
            estatusLabel.Text = "Estatus:";
            // 
            // Estatuscombobox
            // 
            this.Estatuscombobox.FormattingEnabled = true;
            this.Estatuscombobox.Items.AddRange(new object[] {
            "Pendiente",
            "Cancelada",
            "Completada"});
            this.Estatuscombobox.Location = new System.Drawing.Point(141, 286);
            this.Estatuscombobox.Name = "Estatuscombobox";
            this.Estatuscombobox.Size = new System.Drawing.Size(142, 21);
            this.Estatuscombobox.TabIndex = 23;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonRedondo1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonRedondo1.FlatAppearance.BorderSize = 2;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Location = new System.Drawing.Point(475, 351);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.RadioBorde = 20;
            this.botonRedondo1.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo1.TabIndex = 24;
            this.botonRedondo1.Text = "Agregar Cliente";
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDOrdenes_Viaje";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDOrdenes_Viaje";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cedula_Chofer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cedula_Chofer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vehiculos_NroPlaca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehiculos_NroPlaca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cedula_Cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cedula_Cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Destino";
            this.dataGridViewTextBoxColumn5.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Distancia_Esperada_Km";
            this.dataGridViewTextBoxColumn6.HeaderText = "Distancia_Esperada_Km";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha_Inicio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha_Inicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Fecha_Finalizacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha_Finalizacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn9.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // iDOrdenes_ViajeLabel
            // 
            iDOrdenes_ViajeLabel.AutoSize = true;
            iDOrdenes_ViajeLabel.Location = new System.Drawing.Point(17, 81);
            iDOrdenes_ViajeLabel.Name = "iDOrdenes_ViajeLabel";
            iDOrdenes_ViajeLabel.Size = new System.Drawing.Size(87, 13);
            iDOrdenes_ViajeLabel.TabIndex = 24;
            iDOrdenes_ViajeLabel.Text = "IDOrdenes Viaje:";
            // 
            // iDOrdenes_ViajeTextBox
            // 
            this.iDOrdenes_ViajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orden_ViajeBindingSource, "IDOrdenes_Viaje", true));
            this.iDOrdenes_ViajeTextBox.Location = new System.Drawing.Point(141, 78);
            this.iDOrdenes_ViajeTextBox.Name = "iDOrdenes_ViajeTextBox";
            this.iDOrdenes_ViajeTextBox.ReadOnly = true;
            this.iDOrdenes_ViajeTextBox.Size = new System.Drawing.Size(142, 20);
            this.iDOrdenes_ViajeTextBox.TabIndex = 25;
            this.iDOrdenes_ViajeTextBox.TextChanged += new System.EventHandler(this.iDOrdenes_ViajeTextBox_TextChanged);
            // 
            // Formordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 433);
            this.Controls.Add(iDOrdenes_ViajeLabel);
            this.Controls.Add(this.iDOrdenes_ViajeTextBox);
            this.Controls.Add(this.botonRedondo1);
            this.Controls.Add(this.Estatuscombobox);
            this.Controls.Add(cedula_ChoferLabel);
            this.Controls.Add(this.cedula_ChoferTextBox);
            this.Controls.Add(vehiculos_NroPlacaLabel);
            this.Controls.Add(this.vehiculos_NroPlacaTextBox);
            this.Controls.Add(cedula_ClienteLabel);
            this.Controls.Add(this.cedula_ClienteTextBox);
            this.Controls.Add(destinoLabel);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(distancia_Esperada_KmLabel);
            this.Controls.Add(this.distancia_Esperada_KmTextBox);
            this.Controls.Add(fecha_InicioLabel);
            this.Controls.Add(this.fecha_InicioDateTimePicker);
            this.Controls.Add(fecha_FinalizacionLabel);
            this.Controls.Add(this.fecha_FinalizacionDateTimePicker);
            this.Controls.Add(estatusLabel);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox cedula_ChoferTextBox;
        private System.Windows.Forms.TextBox vehiculos_NroPlacaTextBox;
        private System.Windows.Forms.TextBox cedula_ClienteTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.TextBox distancia_Esperada_KmTextBox;
        private System.Windows.Forms.DateTimePicker fecha_InicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_FinalizacionDateTimePicker;
        private System.Windows.Forms.ComboBox Estatuscombobox;
        private BotonRedondo botonRedondo1;
        private System.Windows.Forms.TextBox iDOrdenes_ViajeTextBox;
    }
}