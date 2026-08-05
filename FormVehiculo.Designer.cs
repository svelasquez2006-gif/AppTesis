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
            this.vehiculosDataGridView = new System.Windows.Forms.DataGridView();
            this.agregar = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.lblListVehículos = new System.Windows.Forms.Label();
            this.mantenimiento = new BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculosDataGridView
            // 
            this.vehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculosDataGridView.Location = new System.Drawing.Point(12, 74);
            this.vehiculosDataGridView.Name = "vehiculosDataGridView";
            this.vehiculosDataGridView.Size = new System.Drawing.Size(839, 220);
            this.vehiculosDataGridView.TabIndex = 1;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Location = new System.Drawing.Point(60, 319);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Vehiculo";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar.FlatAppearance.BorderSize = 2;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Location = new System.Drawing.Point(458, 319);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar Vehiculo";
            this.modificar.UseVisualStyleBackColor = false;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(656, 319);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 4;
            this.salir.Text = "Volver al Menu";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // lblListVehículos
            // 
            this.lblListVehículos.AutoSize = true;
            this.lblListVehículos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListVehículos.Location = new System.Drawing.Point(342, 20);
            this.lblListVehículos.Name = "lblListVehículos";
            this.lblListVehículos.Size = new System.Drawing.Size(206, 25);
            this.lblListVehículos.TabIndex = 5;
            this.lblListVehículos.Text = "Lista de Vehículos";
            this.lblListVehículos.Click += new System.EventHandler(this.label1_Click);
            // 
            // mantenimiento
            // 
            this.mantenimiento.BackColor = System.Drawing.Color.Yellow;
            this.mantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mantenimiento.FlatAppearance.BorderSize = 2;
            this.mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mantenimiento.Location = new System.Drawing.Point(260, 319);
            this.mantenimiento.Name = "mantenimiento";
            this.mantenimiento.RadioBorde = 20;
            this.mantenimiento.Size = new System.Drawing.Size(150, 40);
            this.mantenimiento.TabIndex = 6;
            this.mantenimiento.Text = "Mantenimiento";
            this.mantenimiento.UseVisualStyleBackColor = false;
            this.mantenimiento.Click += new System.EventHandler(this.mantenimiento_Click);
            // 
            // Formvehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 382);
            this.Controls.Add(this.mantenimiento);
            this.Controls.Add(this.lblListVehículos);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.vehiculosDataGridView);
            this.Name = "Formvehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Formvehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView vehiculosDataGridView;
        private BotonRedondo agregar;
        private BotonRedondo modificar;
        private BotonRedondo salir;
        private System.Windows.Forms.Label lblListVehículos;
        private BotonRedondo mantenimiento;
    }
}