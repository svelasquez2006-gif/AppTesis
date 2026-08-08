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
            this.nroPlacaTextBox = new System.Windows.Forms.TextBox();
            this.fechaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anotacionesTextBox = new System.Windows.Forms.TextBox();
            this.codMantenimientoTextBox = new System.Windows.Forms.TextBox();
            nroPlacaLabel = new System.Windows.Forms.Label();
            fechaMantenimientoLabel = new System.Windows.Forms.Label();
            anotacionesLabel = new System.Windows.Forms.Label();
            codMantenimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nroPlacaLabel
            // 
            nroPlacaLabel.AutoSize = true;
            nroPlacaLabel.Location = new System.Drawing.Point(14, 187);
            nroPlacaLabel.Name = "nroPlacaLabel";
            nroPlacaLabel.Size = new System.Drawing.Size(57, 13);
            nroPlacaLabel.TabIndex = 25;
            nroPlacaLabel.Text = "Nro Placa:";
            // 
            // fechaMantenimientoLabel
            // 
            fechaMantenimientoLabel.AutoSize = true;
            fechaMantenimientoLabel.Location = new System.Drawing.Point(14, 214);
            fechaMantenimientoLabel.Name = "fechaMantenimientoLabel";
            fechaMantenimientoLabel.Size = new System.Drawing.Size(112, 13);
            fechaMantenimientoLabel.TabIndex = 27;
            fechaMantenimientoLabel.Text = "Fecha Mantenimiento:";
            // 
            // anotacionesLabel
            // 
            anotacionesLabel.AutoSize = true;
            anotacionesLabel.Location = new System.Drawing.Point(14, 239);
            anotacionesLabel.Name = "anotacionesLabel";
            anotacionesLabel.Size = new System.Drawing.Size(69, 13);
            anotacionesLabel.TabIndex = 29;
            anotacionesLabel.Text = "Anotaciones:";
            // 
            // codMantenimientoLabel
            // 
            codMantenimientoLabel.AutoSize = true;
            codMantenimientoLabel.Location = new System.Drawing.Point(14, 161);
            codMantenimientoLabel.Name = "codMantenimientoLabel";
            codMantenimientoLabel.Size = new System.Drawing.Size(101, 13);
            codMantenimientoLabel.TabIndex = 23;
            codMantenimientoLabel.Text = "Cod Mantenimiento:";
            codMantenimientoLabel.Click += new System.EventHandler(this.codMantenimientoLabel_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.label1.Location = new System.Drawing.Point(229, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Historial de Mantenimientos";
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
            this.dataGridViewTextBoxColumn4});
            this.mantenimientoDataGridView.DataSource = this.mantenimientoBindingSource;
            this.mantenimientoDataGridView.Location = new System.Drawing.Point(287, 110);
            this.mantenimientoDataGridView.Name = "mantenimientoDataGridView";
            this.mantenimientoDataGridView.ReadOnly = true;
            this.mantenimientoDataGridView.Size = new System.Drawing.Size(441, 220);
            this.mantenimientoDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodMantenimiento";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodMantenimiento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NroPlaca";
            this.dataGridViewTextBoxColumn2.HeaderText = "NroPlaca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaMantenimiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaMantenimiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Anotaciones";
            this.dataGridViewTextBoxColumn4.HeaderText = "Anotaciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nroPlacaTextBox
            // 
            this.nroPlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "NroPlaca", true));
            this.nroPlacaTextBox.Location = new System.Drawing.Point(132, 184);
            this.nroPlacaTextBox.Name = "nroPlacaTextBox";
            this.nroPlacaTextBox.Size = new System.Drawing.Size(122, 20);
            this.nroPlacaTextBox.TabIndex = 26;
            // 
            // fechaMantenimientoDateTimePicker
            // 
            this.fechaMantenimientoDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.fechaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaMantenimiento", true));
            this.fechaMantenimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaMantenimientoDateTimePicker.Location = new System.Drawing.Point(132, 210);
            this.fechaMantenimientoDateTimePicker.Name = "fechaMantenimientoDateTimePicker";
            this.fechaMantenimientoDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.fechaMantenimientoDateTimePicker.TabIndex = 28;
            this.fechaMantenimientoDateTimePicker.Value = new System.DateTime(2026, 8, 7, 0, 0, 0, 0);
            // 
            // anotacionesTextBox
            // 
            this.anotacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "Anotaciones", true));
            this.anotacionesTextBox.Location = new System.Drawing.Point(89, 236);
            this.anotacionesTextBox.Multiline = true;
            this.anotacionesTextBox.Name = "anotacionesTextBox";
            this.anotacionesTextBox.Size = new System.Drawing.Size(182, 73);
            this.anotacionesTextBox.TabIndex = 30;
            // 
            // codMantenimientoTextBox
            // 
            this.codMantenimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "CodMantenimiento", true));
            this.codMantenimientoTextBox.Location = new System.Drawing.Point(132, 158);
            this.codMantenimientoTextBox.Name = "codMantenimientoTextBox";
            this.codMantenimientoTextBox.ReadOnly = true;
            this.codMantenimientoTextBox.Size = new System.Drawing.Size(122, 20);
            this.codMantenimientoTextBox.TabIndex = 24;
            this.codMantenimientoTextBox.TextChanged += new System.EventHandler(this.codMantenimientoTextBox_TextChanged);
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(codMantenimientoLabel);
            this.Controls.Add(this.codMantenimientoTextBox);
            this.Controls.Add(nroPlacaLabel);
            this.Controls.Add(this.nroPlacaTextBox);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox nroPlacaTextBox;
        private System.Windows.Forms.DateTimePicker fechaMantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox anotacionesTextBox;
        private System.Windows.Forms.TextBox codMantenimientoTextBox;
    }
}