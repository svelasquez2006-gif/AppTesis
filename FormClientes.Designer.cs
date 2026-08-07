namespace AppTesis
{
    partial class FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.agregar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager1 = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.botonRedondo1 = new BotonRedondo();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(10, 102);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 19;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(10, 128);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(10, 154);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 23;
            apellidoLabel.Text = "Apellido:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(10, 180);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 25;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(10, 206);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 27;
            correoLabel.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lista de Clientes";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Location = new System.Drawing.Point(93, 308);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 18;
            this.agregar.Text = "Agregar Cliente";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(554, 308);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 19;
            this.salir.Text = "Cancelar";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChoferTableAdapter = null;
            this.tableAdapterManager1.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager1.MantenimientoTableAdapter = null;
            this.tableAdapterManager1.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuarioTableAdapter = null;
            this.tableAdapterManager1.VehiculoTableAdapter = null;
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(186, 45);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(543, 220);
            this.clienteDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(68, 99);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaTextBox.TabIndex = 20;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(68, 125);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 22;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(68, 151);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 24;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(68, 177);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 26;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(68, 203);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoTextBox.TabIndex = 28;
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botonRedondo1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonRedondo1.FlatAppearance.BorderSize = 2;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Location = new System.Drawing.Point(334, 308);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.RadioBorde = 20;
            this.botonRedondo1.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo1.TabIndex = 29;
            this.botonRedondo1.Text = "Modificar Cliente";
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 378);
            this.Controls.Add(this.botonRedondo1);
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
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BotonRedondo agregar;
        private BotonRedondo salir;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataBaseDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private BotonRedondo botonRedondo1;
    }
}