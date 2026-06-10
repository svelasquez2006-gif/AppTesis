namespace AppTesis
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenú = new System.Windows.Forms.Panel();
            this.Usuarios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.btnVehículos = new System.Windows.Forms.Button();
            this.buttonChoferes = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelResumenFlota = new System.Windows.Forms.Panel();
            this.panelActividadReciente = new System.Windows.Forms.Panel();
            this.labelResumen = new System.Windows.Forms.Label();
            this.labelActividad = new System.Windows.Forms.Label();
            this.labelVehículos = new System.Windows.Forms.Label();
            this.labelNúmeroVehículosTotales = new System.Windows.Forms.Label();
            this.labelVehículosDisponibles = new System.Windows.Forms.Label();
            this.labelNúmerosDisponibles = new System.Windows.Forms.Label();
            this.labelViajeReciente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenú.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelResumenFlota.SuspendLayout();
            this.panelActividadReciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenú
            // 
            this.panelMenú.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenú.Controls.Add(this.Usuarios);
            this.panelMenú.Controls.Add(this.btnSalir);
            this.panelMenú.Controls.Add(this.c);
            this.panelMenú.Controls.Add(this.btnVehículos);
            this.panelMenú.Controls.Add(this.buttonChoferes);
            this.panelMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenú.Location = new System.Drawing.Point(0, 0);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(172, 701);
            this.panelMenú.TabIndex = 0;
            this.panelMenú.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenú_Paint);
            // 
            // Usuarios
            // 
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Location = new System.Drawing.Point(0, 467);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(172, 132);
            this.Usuarios.TabIndex = 4;
            this.Usuarios.Text = "Gestionar Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 599);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(172, 102);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // c
            // 
            this.c.Dock = System.Windows.Forms.DockStyle.Top;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(0, 214);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(172, 118);
            this.c.TabIndex = 2;
            this.c.Text = "Órdenes de viaje";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // btnVehículos
            // 
            this.btnVehículos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehículos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehículos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehículos.ForeColor = System.Drawing.Color.White;
            this.btnVehículos.Location = new System.Drawing.Point(0, 103);
            this.btnVehículos.Name = "btnVehículos";
            this.btnVehículos.Size = new System.Drawing.Size(172, 111);
            this.btnVehículos.TabIndex = 1;
            this.btnVehículos.Text = "Vehículos";
            this.btnVehículos.UseVisualStyleBackColor = true;
            this.btnVehículos.Click += new System.EventHandler(this.btnVehículos_Click);
            // 
            // buttonChoferes
            // 
            this.buttonChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoferes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferes.ForeColor = System.Drawing.Color.White;
            this.buttonChoferes.Location = new System.Drawing.Point(0, 0);
            this.buttonChoferes.Name = "buttonChoferes";
            this.buttonChoferes.Size = new System.Drawing.Size(172, 103);
            this.buttonChoferes.TabIndex = 0;
            this.buttonChoferes.Text = "Choferes";
            this.buttonChoferes.UseVisualStyleBackColor = true;
            this.buttonChoferes.Click += new System.EventHandler(this.buttonChoferes_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.panelActividadReciente);
            this.panelContenedor.Controls.Add(this.panelResumenFlota);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(172, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1012, 701);
            this.panelContenedor.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.labelHora);
            this.panel1.Controls.Add(this.labelRol);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Location = new System.Drawing.Point(137, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 301);
            this.panel1.TabIndex = 0;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(306, 94);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(127, 30);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "23/05/2026";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(249, 61);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(247, 30);
            this.labelRol.TabIndex = 1;
            this.labelRol.Text = "Administrador principal";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(293, 24);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(153, 37);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Juan Pérez";
            // 
            // panelResumenFlota
            // 
            this.panelResumenFlota.BackColor = System.Drawing.Color.White;
            this.panelResumenFlota.Controls.Add(this.labelNúmerosDisponibles);
            this.panelResumenFlota.Controls.Add(this.labelVehículosDisponibles);
            this.panelResumenFlota.Controls.Add(this.labelNúmeroVehículosTotales);
            this.panelResumenFlota.Controls.Add(this.labelVehículos);
            this.panelResumenFlota.Controls.Add(this.labelResumen);
            this.panelResumenFlota.Location = new System.Drawing.Point(32, 359);
            this.panelResumenFlota.Name = "panelResumenFlota";
            this.panelResumenFlota.Size = new System.Drawing.Size(455, 200);
            this.panelResumenFlota.TabIndex = 1;
            // 
            // panelActividadReciente
            // 
            this.panelActividadReciente.BackColor = System.Drawing.Color.White;
            this.panelActividadReciente.Controls.Add(this.label2);
            this.panelActividadReciente.Controls.Add(this.label1);
            this.panelActividadReciente.Controls.Add(this.labelViajeReciente);
            this.panelActividadReciente.Controls.Add(this.labelActividad);
            this.panelActividadReciente.Location = new System.Drawing.Point(495, 359);
            this.panelActividadReciente.Name = "panelActividadReciente";
            this.panelActividadReciente.Size = new System.Drawing.Size(448, 200);
            this.panelActividadReciente.TabIndex = 2;
            // 
            // labelResumen
            // 
            this.labelResumen.AutoSize = true;
            this.labelResumen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResumen.Location = new System.Drawing.Point(17, 12);
            this.labelResumen.Name = "labelResumen";
            this.labelResumen.Size = new System.Drawing.Size(187, 30);
            this.labelResumen.TabIndex = 0;
            this.labelResumen.Text = "Resumen de Flota";
            // 
            // labelActividad
            // 
            this.labelActividad.AutoSize = true;
            this.labelActividad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActividad.Location = new System.Drawing.Point(14, 12);
            this.labelActividad.Name = "labelActividad";
            this.labelActividad.Size = new System.Drawing.Size(195, 30);
            this.labelActividad.TabIndex = 1;
            this.labelActividad.Text = "Actividad Reciente";
            // 
            // labelVehículos
            // 
            this.labelVehículos.AutoSize = true;
            this.labelVehículos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehículos.Location = new System.Drawing.Point(22, 54);
            this.labelVehículos.Name = "labelVehículos";
            this.labelVehículos.Size = new System.Drawing.Size(142, 21);
            this.labelVehículos.TabIndex = 1;
            this.labelVehículos.Text = "Vehículos Totales";
            // 
            // labelNúmeroVehículosTotales
            // 
            this.labelNúmeroVehículosTotales.AutoSize = true;
            this.labelNúmeroVehículosTotales.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNúmeroVehículosTotales.Location = new System.Drawing.Point(19, 75);
            this.labelNúmeroVehículosTotales.Name = "labelNúmeroVehículosTotales";
            this.labelNúmeroVehículosTotales.Size = new System.Drawing.Size(49, 37);
            this.labelNúmeroVehículosTotales.TabIndex = 2;
            this.labelNúmeroVehículosTotales.Text = "52";
            // 
            // labelVehículosDisponibles
            // 
            this.labelVehículosDisponibles.AutoSize = true;
            this.labelVehículosDisponibles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehículosDisponibles.Location = new System.Drawing.Point(240, 54);
            this.labelVehículosDisponibles.Name = "labelVehículosDisponibles";
            this.labelVehículosDisponibles.Size = new System.Drawing.Size(100, 21);
            this.labelVehículosDisponibles.TabIndex = 3;
            this.labelVehículosDisponibles.Text = "Disponibles";
            // 
            // labelNúmerosDisponibles
            // 
            this.labelNúmerosDisponibles.AutoSize = true;
            this.labelNúmerosDisponibles.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNúmerosDisponibles.Location = new System.Drawing.Point(237, 75);
            this.labelNúmerosDisponibles.Name = "labelNúmerosDisponibles";
            this.labelNúmerosDisponibles.Size = new System.Drawing.Size(49, 37);
            this.labelNúmerosDisponibles.TabIndex = 4;
            this.labelNúmerosDisponibles.Text = "45";
            // 
            // labelViajeReciente
            // 
            this.labelViajeReciente.AutoSize = true;
            this.labelViajeReciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViajeReciente.Location = new System.Drawing.Point(15, 54);
            this.labelViajeReciente.Name = "labelViajeReciente";
            this.labelViajeReciente.Size = new System.Drawing.Size(247, 21);
            this.labelViajeReciente.TabIndex = 5;
            this.labelViajeReciente.Text = "Viaje ID 02 - Salida Confirmada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehículo M01 - Reporte de Mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Viaje ID 01 - Llegada al Destino";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenú);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Viajes V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenú.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelResumenFlota.ResumeLayout(false);
            this.panelResumenFlota.PerformLayout();
            this.panelActividadReciente.ResumeLayout(false);
            this.panelActividadReciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenú;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button buttonChoferes;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button btnVehículos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Button Usuarios;
    }
}

