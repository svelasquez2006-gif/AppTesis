namespace AppTesis
{
    partial class Choferes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.choferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choferTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.ChoferTableAdapter();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.choferBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppTesis.ReporteChoferes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1137, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choferBindingSource
            // 
            this.choferBindingSource.DataMember = "Chofer";
            this.choferBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // choferTableAdapter
            // 
            this.choferTableAdapter.ClearBeforeFill = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(461, 285);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(216, 33);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 343);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Choferes";
            this.Text = "Choferes";
            this.Load += new System.EventHandler(this.Choferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource choferBindingSource;
        private DataBaseDataSetTableAdapters.ChoferTableAdapter choferTableAdapter;
        private System.Windows.Forms.Button salir;
    }
}