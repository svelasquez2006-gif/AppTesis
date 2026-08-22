namespace AppTesis
{
    partial class vehiculo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vehiculoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.VehiculoTableAdapter();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "Vehiculo";
            this.vehiculoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vehiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppTesis.ReporteVehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1160, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(474, 264);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(216, 33);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 309);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "vehiculo";
            this.Text = "vehiculo";
            this.Load += new System.EventHandler(this.vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private DataBaseDataSetTableAdapters.VehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.Button salir;
    }
}