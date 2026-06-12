namespace AppTesis
{
    partial class RegistarOrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistarOrd));
            System.Windows.Forms.Label cedula_ChoferLabel;
            System.Windows.Forms.Label vehiculos_NroPlacaLabel;
            System.Windows.Forms.Label destinoLabel;
            System.Windows.Forms.Label fecha_InicioLabel;
            System.Windows.Forms.Label fecha_FinalizacionLabel;
            System.Windows.Forms.Label distancia_EsperadaLabel;
            System.Windows.Forms.Label estatusLabel;
            this.basededatosDataSet = new AppTesis.basededatosDataSet();
            this.ordenes_ViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenes_ViajeTableAdapter = new AppTesis.basededatosDataSetTableAdapters.Ordenes_ViajeTableAdapter();
            this.tableAdapterManager = new AppTesis.basededatosDataSetTableAdapters.TableAdapterManager();
            this.ordenes_ViajeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordenes_ViajeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cedula_ChoferTextBox = new System.Windows.Forms.TextBox();
            this.vehiculos_NroPlacaTextBox = new System.Windows.Forms.TextBox();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_InicioTextBox = new System.Windows.Forms.TextBox();
            this.fecha_FinalizacionTextBox = new System.Windows.Forms.TextBox();
            this.distancia_EsperadaTextBox = new System.Windows.Forms.TextBox();
            this.estatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregar = new BotonRedondo();
            this.salir = new BotonRedondo();
            cedula_ChoferLabel = new System.Windows.Forms.Label();
            vehiculos_NroPlacaLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            fecha_InicioLabel = new System.Windows.Forms.Label();
            fecha_FinalizacionLabel = new System.Windows.Forms.Label();
            distancia_EsperadaLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingNavigator)).BeginInit();
            this.ordenes_ViajeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // basededatosDataSet
            // 
            this.basededatosDataSet.DataSetName = "basededatosDataSet";
            this.basededatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenes_ViajeBindingSource
            // 
            this.ordenes_ViajeBindingSource.DataMember = "Ordenes_Viaje";
            this.ordenes_ViajeBindingSource.DataSource = this.basededatosDataSet;
            // 
            // ordenes_ViajeTableAdapter
            // 
            this.ordenes_ViajeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferesTableAdapter = null;
            this.tableAdapterManager.Estatus_ChoferesTableAdapter = null;
            this.tableAdapterManager.Estatus_OrdenTableAdapter = null;
            this.tableAdapterManager.Estatus_VehiculoTableAdapter = null;
            this.tableAdapterManager.Jerarquia_UsuariosTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Ordenes_ViajeTableAdapter = this.ordenes_ViajeTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppTesis.basededatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // ordenes_ViajeBindingNavigator
            // 
            this.ordenes_ViajeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordenes_ViajeBindingNavigator.BindingSource = this.ordenes_ViajeBindingSource;
            this.ordenes_ViajeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordenes_ViajeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordenes_ViajeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordenes_ViajeBindingNavigatorSaveItem});
            this.ordenes_ViajeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordenes_ViajeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordenes_ViajeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordenes_ViajeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordenes_ViajeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordenes_ViajeBindingNavigator.Name = "ordenes_ViajeBindingNavigator";
            this.ordenes_ViajeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordenes_ViajeBindingNavigator.Size = new System.Drawing.Size(508, 25);
            this.ordenes_ViajeBindingNavigator.TabIndex = 0;
            this.ordenes_ViajeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // ordenes_ViajeBindingNavigatorSaveItem
            // 
            this.ordenes_ViajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordenes_ViajeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenes_ViajeBindingNavigatorSaveItem.Image")));
            this.ordenes_ViajeBindingNavigatorSaveItem.Name = "ordenes_ViajeBindingNavigatorSaveItem";
            this.ordenes_ViajeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordenes_ViajeBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ordenes_ViajeBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordenes_ViajeBindingNavigatorSaveItem_Click);
            // 
            // cedula_ChoferLabel
            // 
            cedula_ChoferLabel.AutoSize = true;
            cedula_ChoferLabel.Location = new System.Drawing.Point(29, 97);
            cedula_ChoferLabel.Name = "cedula_ChoferLabel";
            cedula_ChoferLabel.Size = new System.Drawing.Size(77, 13);
            cedula_ChoferLabel.TabIndex = 3;
            cedula_ChoferLabel.Text = "Cedula Chofer:";
            // 
            // cedula_ChoferTextBox
            // 
            this.cedula_ChoferTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Cedula_Chofer", true));
            this.cedula_ChoferTextBox.Location = new System.Drawing.Point(124, 94);
            this.cedula_ChoferTextBox.Name = "cedula_ChoferTextBox";
            this.cedula_ChoferTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedula_ChoferTextBox.TabIndex = 4;
            // 
            // vehiculos_NroPlacaLabel
            // 
            vehiculos_NroPlacaLabel.AutoSize = true;
            vehiculos_NroPlacaLabel.Location = new System.Drawing.Point(29, 145);
            vehiculos_NroPlacaLabel.Name = "vehiculos_NroPlacaLabel";
            vehiculos_NroPlacaLabel.Size = new System.Drawing.Size(106, 13);
            vehiculos_NroPlacaLabel.TabIndex = 5;
            vehiculos_NroPlacaLabel.Text = "Vehiculos Nro Placa:";
            // 
            // vehiculos_NroPlacaTextBox
            // 
            this.vehiculos_NroPlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Vehiculos_NroPlaca", true));
            this.vehiculos_NroPlacaTextBox.Location = new System.Drawing.Point(141, 142);
            this.vehiculos_NroPlacaTextBox.Name = "vehiculos_NroPlacaTextBox";
            this.vehiculos_NroPlacaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehiculos_NroPlacaTextBox.TabIndex = 6;
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.Location = new System.Drawing.Point(31, 206);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(46, 13);
            destinoLabel.TabIndex = 7;
            destinoLabel.Text = "Destino:";
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Destino", true));
            this.destinoTextBox.Location = new System.Drawing.Point(101, 203);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinoTextBox.TabIndex = 8;
            // 
            // fecha_InicioLabel
            // 
            fecha_InicioLabel.AutoSize = true;
            fecha_InicioLabel.Location = new System.Drawing.Point(266, 90);
            fecha_InicioLabel.Name = "fecha_InicioLabel";
            fecha_InicioLabel.Size = new System.Drawing.Size(68, 13);
            fecha_InicioLabel.TabIndex = 9;
            fecha_InicioLabel.Text = "Fecha Inicio:";
            // 
            // fecha_InicioTextBox
            // 
            this.fecha_InicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Fecha_Inicio", true));
            this.fecha_InicioTextBox.Location = new System.Drawing.Point(340, 87);
            this.fecha_InicioTextBox.Name = "fecha_InicioTextBox";
            this.fecha_InicioTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_InicioTextBox.TabIndex = 10;
            // 
            // fecha_FinalizacionLabel
            // 
            fecha_FinalizacionLabel.AutoSize = true;
            fecha_FinalizacionLabel.Location = new System.Drawing.Point(266, 130);
            fecha_FinalizacionLabel.Name = "fecha_FinalizacionLabel";
            fecha_FinalizacionLabel.Size = new System.Drawing.Size(98, 13);
            fecha_FinalizacionLabel.TabIndex = 11;
            fecha_FinalizacionLabel.Text = "Fecha Finalizacion:";
            // 
            // fecha_FinalizacionTextBox
            // 
            this.fecha_FinalizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Fecha_Finalizacion", true));
            this.fecha_FinalizacionTextBox.Location = new System.Drawing.Point(378, 127);
            this.fecha_FinalizacionTextBox.Name = "fecha_FinalizacionTextBox";
            this.fecha_FinalizacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.fecha_FinalizacionTextBox.TabIndex = 12;
            // 
            // distancia_EsperadaLabel
            // 
            distancia_EsperadaLabel.AutoSize = true;
            distancia_EsperadaLabel.Location = new System.Drawing.Point(266, 174);
            distancia_EsperadaLabel.Name = "distancia_EsperadaLabel";
            distancia_EsperadaLabel.Size = new System.Drawing.Size(102, 13);
            distancia_EsperadaLabel.TabIndex = 13;
            distancia_EsperadaLabel.Text = "Distancia Esperada:";
            // 
            // distancia_EsperadaTextBox
            // 
            this.distancia_EsperadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Distancia_Esperada", true));
            this.distancia_EsperadaTextBox.Location = new System.Drawing.Point(378, 171);
            this.distancia_EsperadaTextBox.Name = "distancia_EsperadaTextBox";
            this.distancia_EsperadaTextBox.Size = new System.Drawing.Size(100, 20);
            this.distancia_EsperadaTextBox.TabIndex = 14;
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Location = new System.Drawing.Point(266, 223);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(45, 13);
            estatusLabel.TabIndex = 15;
            estatusLabel.Text = "Estatus:";
            // 
            // estatusTextBox
            // 
            this.estatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenes_ViajeBindingSource, "Estatus", true));
            this.estatusTextBox.Location = new System.Drawing.Point(317, 220);
            this.estatusTextBox.Name = "estatusTextBox";
            this.estatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.estatusTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Ordenes de Viaje";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Location = new System.Drawing.Point(63, 271);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 18;
            this.agregar.Text = "Agregar Orden";
            this.agregar.UseVisualStyleBackColor = false;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(280, 271);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 19;
            this.salir.Text = "Cancelar";
            this.salir.UseVisualStyleBackColor = false;
            // 
            // RegistarOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 323);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(cedula_ChoferLabel);
            this.Controls.Add(this.cedula_ChoferTextBox);
            this.Controls.Add(vehiculos_NroPlacaLabel);
            this.Controls.Add(this.vehiculos_NroPlacaTextBox);
            this.Controls.Add(destinoLabel);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(fecha_InicioLabel);
            this.Controls.Add(this.fecha_InicioTextBox);
            this.Controls.Add(fecha_FinalizacionLabel);
            this.Controls.Add(this.fecha_FinalizacionTextBox);
            this.Controls.Add(distancia_EsperadaLabel);
            this.Controls.Add(this.distancia_EsperadaTextBox);
            this.Controls.Add(estatusLabel);
            this.Controls.Add(this.estatusTextBox);
            this.Controls.Add(this.ordenes_ViajeBindingNavigator);
            this.Name = "RegistarOrd";
            this.Text = "Registar Ordenes";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingNavigator)).EndInit();
            this.ordenes_ViajeBindingNavigator.ResumeLayout(false);
            this.ordenes_ViajeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private basededatosDataSet basededatosDataSet;
        private System.Windows.Forms.BindingSource ordenes_ViajeBindingSource;
        private basededatosDataSetTableAdapters.Ordenes_ViajeTableAdapter ordenes_ViajeTableAdapter;
        private basededatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordenes_ViajeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordenes_ViajeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cedula_ChoferTextBox;
        private System.Windows.Forms.TextBox vehiculos_NroPlacaTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.TextBox fecha_InicioTextBox;
        private System.Windows.Forms.TextBox fecha_FinalizacionTextBox;
        private System.Windows.Forms.TextBox distancia_EsperadaTextBox;
        private System.Windows.Forms.TextBox estatusTextBox;
        private System.Windows.Forms.Label label1;
        private BotonRedondo agregar;
        private BotonRedondo salir;
    }
}