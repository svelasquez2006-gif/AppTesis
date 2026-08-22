namespace AppTesis
{
    partial class Reportes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reporteUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteFlotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteChoferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesOrdenesDeViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesRutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteUsuariosToolStripMenuItem,
            this.reporteFlotaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reporteUsuariosToolStripMenuItem
            // 
            this.reporteUsuariosToolStripMenuItem.Name = "reporteUsuariosToolStripMenuItem";
            this.reporteUsuariosToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.reporteUsuariosToolStripMenuItem.Text = "Reporte Usuarios";
            // 
            // reporteFlotaToolStripMenuItem
            // 
            this.reporteFlotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteVehiculoToolStripMenuItem,
            this.reporteChoferesToolStripMenuItem,
            this.reporteMantenimientosToolStripMenuItem,
            this.reportesOrdenesDeViajeToolStripMenuItem,
            this.reportesRutasToolStripMenuItem,
            this.reportesClientesToolStripMenuItem});
            this.reporteFlotaToolStripMenuItem.Name = "reporteFlotaToolStripMenuItem";
            this.reporteFlotaToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.reporteFlotaToolStripMenuItem.Text = "Reportes Operativos";
            // 
            // reporteVehiculoToolStripMenuItem
            // 
            this.reporteVehiculoToolStripMenuItem.Name = "reporteVehiculoToolStripMenuItem";
            this.reporteVehiculoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reporteVehiculoToolStripMenuItem.Text = "Reporte Vehiculo";
            // 
            // reporteChoferesToolStripMenuItem
            // 
            this.reporteChoferesToolStripMenuItem.Name = "reporteChoferesToolStripMenuItem";
            this.reporteChoferesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reporteChoferesToolStripMenuItem.Text = "Reporte Choferes";
            // 
            // reporteMantenimientosToolStripMenuItem
            // 
            this.reporteMantenimientosToolStripMenuItem.Name = "reporteMantenimientosToolStripMenuItem";
            this.reporteMantenimientosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reporteMantenimientosToolStripMenuItem.Text = "Reporte Mantenimientos";
            // 
            // reportesOrdenesDeViajeToolStripMenuItem
            // 
            this.reportesOrdenesDeViajeToolStripMenuItem.Name = "reportesOrdenesDeViajeToolStripMenuItem";
            this.reportesOrdenesDeViajeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reportesOrdenesDeViajeToolStripMenuItem.Text = "Reportes Ordenes de Viaje";
            // 
            // reportesRutasToolStripMenuItem
            // 
            this.reportesRutasToolStripMenuItem.Name = "reportesRutasToolStripMenuItem";
            this.reportesRutasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reportesRutasToolStripMenuItem.Text = "Reportes Rutas";
            // 
            // reportesClientesToolStripMenuItem
            // 
            this.reportesClientesToolStripMenuItem.Name = "reportesClientesToolStripMenuItem";
            this.reportesClientesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reportesClientesToolStripMenuItem.Text = "Reportes Clientes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 23);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteFlotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteChoferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesOrdenesDeViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesRutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}