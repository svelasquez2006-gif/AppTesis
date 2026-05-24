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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.buttonChoferes = new System.Windows.Forms.Button();
            this.btnVehículos = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.panelMenú.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenú
            // 
            this.panelMenú.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenú.Controls.Add(this.btnSalir);
            this.panelMenú.Controls.Add(this.c);
            this.panelMenú.Controls.Add(this.btnVehículos);
            this.panelMenú.Controls.Add(this.buttonChoferes);
            this.panelMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenú.Location = new System.Drawing.Point(0, 0);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(210, 711);
            this.panelMenú.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(210, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(974, 711);
            this.panelContenedor.TabIndex = 1;
            // 
            // buttonChoferes
            // 
            this.buttonChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoferes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferes.ForeColor = System.Drawing.Color.White;
            this.buttonChoferes.Location = new System.Drawing.Point(0, 0);
            this.buttonChoferes.Name = "buttonChoferes";
            this.buttonChoferes.Size = new System.Drawing.Size(210, 136);
            this.buttonChoferes.TabIndex = 0;
            this.buttonChoferes.Text = "Choferes";
            this.buttonChoferes.UseVisualStyleBackColor = true;
            // 
            // btnVehículos
            // 
            this.btnVehículos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehículos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehículos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehículos.ForeColor = System.Drawing.Color.White;
            this.btnVehículos.Location = new System.Drawing.Point(0, 136);
            this.btnVehículos.Name = "btnVehículos";
            this.btnVehículos.Size = new System.Drawing.Size(210, 136);
            this.btnVehículos.TabIndex = 1;
            this.btnVehículos.Text = "Vehículos";
            this.btnVehículos.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.Dock = System.Windows.Forms.DockStyle.Top;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(0, 272);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(210, 136);
            this.c.TabIndex = 2;
            this.c.Text = "Órdenes de viaje";
            this.c.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 575);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(210, 136);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
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
    }
}

