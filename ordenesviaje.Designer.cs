namespace AppTesis
{
    partial class ordenesviaje
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
            this.ordenViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_ViajeTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenViajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ordenViajeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppTesis.ReporteOrdenesViaje.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1166, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenViajeBindingSource
            // 
            this.ordenViajeBindingSource.DataMember = "Orden_Viaje";
            this.ordenViajeBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // orden_ViajeTableAdapter
            // 
            this.orden_ViajeTableAdapter.ClearBeforeFill = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(336, 272);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(523, 33);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ordenesviaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 337);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ordenesviaje";
            this.Text = "ordenesviaje";
            this.Load += new System.EventHandler(this.ordenesviaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenViajeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource ordenViajeBindingSource;
        private DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter orden_ViajeTableAdapter;
        private System.Windows.Forms.Button salir;
    }
}