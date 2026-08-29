namespace AppTesis
{
    partial class FormBaseDatos
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
            this.Respaldar = new BotonRedondo();
            this.Restaurar = new BotonRedondo();
            this.label1 = new System.Windows.Forms.Label();
            this.Volver = new BotonRedondo();
            this.SuspendLayout();
            // 
            // Respaldar
            // 
            this.Respaldar.BackColor = System.Drawing.Color.OliveDrab;
            this.Respaldar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Respaldar.FlatAppearance.BorderSize = 2;
            this.Respaldar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Respaldar.Location = new System.Drawing.Point(64, 87);
            this.Respaldar.Name = "Respaldar";
            this.Respaldar.RadioBorde = 20;
            this.Respaldar.Size = new System.Drawing.Size(169, 40);
            this.Respaldar.TabIndex = 0;
            this.Respaldar.Text = "Respaldar Base de Datos";
            this.Respaldar.UseVisualStyleBackColor = false;
            this.Respaldar.Click += new System.EventHandler(this.Respaldar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.BackColor = System.Drawing.Color.DarkCyan;
            this.Restaurar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Restaurar.FlatAppearance.BorderSize = 2;
            this.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restaurar.Location = new System.Drawing.Point(312, 87);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.RadioBorde = 20;
            this.Restaurar.Size = new System.Drawing.Size(169, 40);
            this.Restaurar.TabIndex = 1;
            this.Restaurar.Text = "Restaurar Base de Datos";
            this.Restaurar.UseVisualStyleBackColor = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "MOVIMIENTOS DE LA BASE DE DATOS";
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.IndianRed;
            this.Volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Volver.FlatAppearance.BorderSize = 2;
            this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volver.Location = new System.Drawing.Point(204, 148);
            this.Volver.Name = "Volver";
            this.Volver.RadioBorde = 20;
            this.Volver.Size = new System.Drawing.Size(169, 40);
            this.Volver.TabIndex = 3;
            this.Volver.Text = "Volver al Menu";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // FormBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 200);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restaurar);
            this.Controls.Add(this.Respaldar);
            this.Name = "FormBaseDatos";
            this.Text = "FormBaseDatos";
            this.Load += new System.EventHandler(this.FormBaseDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BotonRedondo Respaldar;
        private BotonRedondo Restaurar;
        private System.Windows.Forms.Label label1;
        private BotonRedondo Volver;
    }
}