namespace AppTesis
{
    partial class FormRutas
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
            System.Windows.Forms.Label nombre_RutaLabel;
            System.Windows.Forms.Label dias_ViajeLabel;
            System.Windows.Forms.Label distancia_kmLabel;
            System.Windows.Forms.Label origenLabel;
            System.Windows.Forms.Label paradasLabel;
            System.Windows.Forms.Label destinoLabel;
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.rutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutasTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.RutasTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.rutasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_RutaTextBox = new System.Windows.Forms.TextBox();
            this.dias_ViajeTextBox = new System.Windows.Forms.TextBox();
            this.distancia_kmTextBox = new System.Windows.Forms.TextBox();
            this.origenTextBox = new System.Windows.Forms.TextBox();
            this.paradasTextBox = new System.Windows.Forms.TextBox();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.modificar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.agregar = new BotonRedondo();
            nombre_RutaLabel = new System.Windows.Forms.Label();
            dias_ViajeLabel = new System.Windows.Forms.Label();
            distancia_kmLabel = new System.Windows.Forms.Label();
            origenLabel = new System.Windows.Forms.Label();
            paradasLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_RutaLabel
            // 
            nombre_RutaLabel.AutoSize = true;
            nombre_RutaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nombre_RutaLabel.Location = new System.Drawing.Point(4, 130);
            nombre_RutaLabel.Name = "nombre_RutaLabel";
            nombre_RutaLabel.Size = new System.Drawing.Size(108, 20);
            nombre_RutaLabel.TabIndex = 18;
            nombre_RutaLabel.Text = "Nombre Ruta:";
            // 
            // dias_ViajeLabel
            // 
            dias_ViajeLabel.AutoSize = true;
            dias_ViajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dias_ViajeLabel.Location = new System.Drawing.Point(24, 154);
            dias_ViajeLabel.Name = "dias_ViajeLabel";
            dias_ViajeLabel.Size = new System.Drawing.Size(84, 20);
            dias_ViajeLabel.TabIndex = 20;
            dias_ViajeLabel.Text = "Dias Viaje:";
            // 
            // distancia_kmLabel
            // 
            distancia_kmLabel.AutoSize = true;
            distancia_kmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            distancia_kmLabel.Location = new System.Drawing.Point(4, 182);
            distancia_kmLabel.Name = "distancia_kmLabel";
            distancia_kmLabel.Size = new System.Drawing.Size(104, 20);
            distancia_kmLabel.TabIndex = 22;
            distancia_kmLabel.Text = "Distancia km:";
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            origenLabel.Location = new System.Drawing.Point(48, 206);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new System.Drawing.Size(60, 20);
            origenLabel.TabIndex = 24;
            origenLabel.Text = "Origen:";
            // 
            // paradasLabel
            // 
            paradasLabel.AutoSize = true;
            paradasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            paradasLabel.Location = new System.Drawing.Point(36, 232);
            paradasLabel.Name = "paradasLabel";
            paradasLabel.Size = new System.Drawing.Size(72, 20);
            paradasLabel.TabIndex = 26;
            paradasLabel.Text = "Paradas:";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            destinoLabel.Location = new System.Drawing.Point(36, 260);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(68, 20);
            destinoLabel.TabIndex = 28;
            destinoLabel.Text = "Destino:";
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Orden_ViajeTableAdapter = null;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = this.rutasTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // rutasDataGridView
            // 
            this.rutasDataGridView.AllowUserToAddRows = false;
            this.rutasDataGridView.AllowUserToDeleteRows = false;
            this.rutasDataGridView.AutoGenerateColumns = false;
            this.rutasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rutasDataGridView.DataSource = this.rutasBindingSource;
            this.rutasDataGridView.Location = new System.Drawing.Point(257, 105);
            this.rutasDataGridView.Name = "rutasDataGridView";
            this.rutasDataGridView.ReadOnly = true;
            this.rutasDataGridView.Size = new System.Drawing.Size(626, 220);
            this.rutasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre_Ruta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre de la Ruta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dias_Viaje";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dias de Viaje";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Distancia_km";
            this.dataGridViewTextBoxColumn3.HeaderText = "Distancia en km";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Origen";
            this.dataGridViewTextBoxColumn4.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Paradas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Paradas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Destino";
            this.dataGridViewTextBoxColumn6.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "LISTA DE RUTAS";
            // 
            // nombre_RutaTextBox
            // 
            this.nombre_RutaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Nombre_Ruta", true));
            this.nombre_RutaTextBox.Location = new System.Drawing.Point(118, 130);
            this.nombre_RutaTextBox.Name = "nombre_RutaTextBox";
            this.nombre_RutaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_RutaTextBox.TabIndex = 19;
            // 
            // dias_ViajeTextBox
            // 
            this.dias_ViajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Dias_Viaje", true));
            this.dias_ViajeTextBox.Location = new System.Drawing.Point(118, 156);
            this.dias_ViajeTextBox.Name = "dias_ViajeTextBox";
            this.dias_ViajeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dias_ViajeTextBox.TabIndex = 21;
            this.dias_ViajeTextBox.TextChanged += new System.EventHandler(this.dias_ViajeTextBox_TextChanged);
            // 
            // distancia_kmTextBox
            // 
            this.distancia_kmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Distancia_km", true));
            this.distancia_kmTextBox.Location = new System.Drawing.Point(118, 182);
            this.distancia_kmTextBox.Name = "distancia_kmTextBox";
            this.distancia_kmTextBox.Size = new System.Drawing.Size(100, 20);
            this.distancia_kmTextBox.TabIndex = 23;
            this.distancia_kmTextBox.TextChanged += new System.EventHandler(this.distancia_kmTextBox_TextChanged);
            // 
            // origenTextBox
            // 
            this.origenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Origen", true));
            this.origenTextBox.Location = new System.Drawing.Point(118, 208);
            this.origenTextBox.Name = "origenTextBox";
            this.origenTextBox.Size = new System.Drawing.Size(100, 20);
            this.origenTextBox.TabIndex = 25;
            // 
            // paradasTextBox
            // 
            this.paradasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Paradas", true));
            this.paradasTextBox.Location = new System.Drawing.Point(118, 234);
            this.paradasTextBox.Name = "paradasTextBox";
            this.paradasTextBox.Size = new System.Drawing.Size(100, 20);
            this.paradasTextBox.TabIndex = 27;
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rutasBindingSource, "Destino", true));
            this.destinoTextBox.Location = new System.Drawing.Point(118, 260);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinoTextBox.TabIndex = 29;
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar.FlatAppearance.BorderSize = 2;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(429, 358);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 32;
            this.modificar.Text = "Modificar Ruta";
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
            this.salir.Location = new System.Drawing.Point(733, 358);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 31;
            this.salir.Text = "Cancelar";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(68, 358);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 30;
            this.agregar.Text = "Agregar Ruta";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // FormRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 426);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.agregar);
            this.Controls.Add(nombre_RutaLabel);
            this.Controls.Add(this.nombre_RutaTextBox);
            this.Controls.Add(dias_ViajeLabel);
            this.Controls.Add(this.dias_ViajeTextBox);
            this.Controls.Add(distancia_kmLabel);
            this.Controls.Add(this.distancia_kmTextBox);
            this.Controls.Add(origenLabel);
            this.Controls.Add(this.origenTextBox);
            this.Controls.Add(paradasLabel);
            this.Controls.Add(this.paradasTextBox);
            this.Controls.Add(destinoLabel);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rutasDataGridView);
            this.Name = "FormRutas";
            this.Text = "FormRutas";
            this.Load += new System.EventHandler(this.FormRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource rutasBindingSource;
        private DataBaseDataSetTableAdapters.RutasTableAdapter rutasTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rutasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_RutaTextBox;
        private System.Windows.Forms.TextBox dias_ViajeTextBox;
        private System.Windows.Forms.TextBox distancia_kmTextBox;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.TextBox paradasTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private BotonRedondo modificar;
        private BotonRedondo salir;
        private BotonRedondo agregar;
    }
}