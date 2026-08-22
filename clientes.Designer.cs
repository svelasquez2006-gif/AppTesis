namespace AppTesis
{
    partial class clientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salir = new System.Windows.Forms.Button();
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppTesis.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(802, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(302, 382);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(216, 33);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
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
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "clientes";
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button salir;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DataBaseDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}