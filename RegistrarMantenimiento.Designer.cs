namespace AppTesis
{
    partial class RegistrarMantenimiento
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
            System.Windows.Forms.Label codMantenimientoLabel;
            System.Windows.Forms.Label nroPlacaLabel;
            System.Windows.Forms.Label fechaMantenimientoLabel;
            System.Windows.Forms.Label anotacionesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMantenimiento));
            this.basededatosDataSet = new AppTesis.basededatosDataSet();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoTableAdapter = new AppTesis.basededatosDataSetTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager = new AppTesis.basededatosDataSetTableAdapters.TableAdapterManager();
            this.mantenimientoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenimientoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codMantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.nroPlacaTextBox = new System.Windows.Forms.TextBox();
            this.fechaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.anotacionesTextBox = new System.Windows.Forms.TextBox();
            this.Agregar = new BotonRedondo();
            this.Salir = new BotonRedondo();
            this.label1 = new System.Windows.Forms.Label();
            codMantenimientoLabel = new System.Windows.Forms.Label();
            nroPlacaLabel = new System.Windows.Forms.Label();
            fechaMantenimientoLabel = new System.Windows.Forms.Label();
            anotacionesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).BeginInit();
            this.mantenimientoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codMantenimientoLabel
            // 
            codMantenimientoLabel.AutoSize = true;
            codMantenimientoLabel.Location = new System.Drawing.Point(35, 69);
            codMantenimientoLabel.Name = "codMantenimientoLabel";
            codMantenimientoLabel.Size = new System.Drawing.Size(101, 13);
            codMantenimientoLabel.TabIndex = 1;
            codMantenimientoLabel.Text = "Cod Mantenimiento:";
            // 
            // nroPlacaLabel
            // 
            nroPlacaLabel.AutoSize = true;
            nroPlacaLabel.Location = new System.Drawing.Point(36, 100);
            nroPlacaLabel.Name = "nroPlacaLabel";
            nroPlacaLabel.Size = new System.Drawing.Size(57, 13);
            nroPlacaLabel.TabIndex = 3;
            nroPlacaLabel.Text = "Nro Placa:";
            // 
            // fechaMantenimientoLabel
            // 
            fechaMantenimientoLabel.AutoSize = true;
            fechaMantenimientoLabel.Location = new System.Drawing.Point(35, 122);
            fechaMantenimientoLabel.Name = "fechaMantenimientoLabel";
            fechaMantenimientoLabel.Size = new System.Drawing.Size(112, 13);
            fechaMantenimientoLabel.TabIndex = 5;
            fechaMantenimientoLabel.Text = "Fecha Mantenimiento:";
            // 
            // anotacionesLabel
            // 
            anotacionesLabel.AutoSize = true;
            anotacionesLabel.Location = new System.Drawing.Point(35, 147);
            anotacionesLabel.Name = "anotacionesLabel";
            anotacionesLabel.Size = new System.Drawing.Size(69, 13);
            anotacionesLabel.TabIndex = 7;
            anotacionesLabel.Text = "Anotaciones:";
            // 
            // basededatosDataSet
            // 
            this.basededatosDataSet.DataSetName = "basededatosDataSet";
            this.basededatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource.DataSource = this.basededatosDataSet;
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferesTableAdapter = null;
            this.tableAdapterManager.Estatus_ChoferesTableAdapter = null;
            this.tableAdapterManager.Estatus_OrdenTableAdapter = null;
            this.tableAdapterManager.Estatus_VehiculoTableAdapter = null;
            this.tableAdapterManager.Jerarquia_UsuariosTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = this.mantenimientoTableAdapter;
            this.tableAdapterManager.Ordenes_ViajeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.basededatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // mantenimientoBindingNavigator
            // 
            this.mantenimientoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mantenimientoBindingNavigator.BindingSource = this.mantenimientoBindingSource;
            this.mantenimientoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mantenimientoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mantenimientoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mantenimientoBindingNavigatorSaveItem});
            this.mantenimientoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mantenimientoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mantenimientoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mantenimientoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mantenimientoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mantenimientoBindingNavigator.Name = "mantenimientoBindingNavigator";
            this.mantenimientoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mantenimientoBindingNavigator.Size = new System.Drawing.Size(388, 25);
            this.mantenimientoBindingNavigator.TabIndex = 0;
            this.mantenimientoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mantenimientoBindingNavigatorSaveItem
            // 
            this.mantenimientoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mantenimientoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoBindingNavigatorSaveItem.Image")));
            this.mantenimientoBindingNavigatorSaveItem.Name = "mantenimientoBindingNavigatorSaveItem";
            this.mantenimientoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mantenimientoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.mantenimientoBindingNavigatorSaveItem.Click += new System.EventHandler(this.mantenimientoBindingNavigatorSaveItem_Click);
            // 
            // codMantenimientoTextBox
            // 
            this.codMantenimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "CodMantenimiento", true));
            this.codMantenimientoTextBox.Location = new System.Drawing.Point(153, 66);
            this.codMantenimientoTextBox.Name = "codMantenimientoTextBox";
            this.codMantenimientoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codMantenimientoTextBox.TabIndex = 2;
            // 
            // nroPlacaTextBox
            // 
            this.nroPlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "NroPlaca", true));
            this.nroPlacaTextBox.Location = new System.Drawing.Point(153, 92);
            this.nroPlacaTextBox.Name = "nroPlacaTextBox";
            this.nroPlacaTextBox.Size = new System.Drawing.Size(200, 20);
            this.nroPlacaTextBox.TabIndex = 4;
            // 
            // fechaMantenimientoDateTimePicker
            // 
            this.fechaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaMantenimiento", true));
            this.fechaMantenimientoDateTimePicker.Location = new System.Drawing.Point(153, 118);
            this.fechaMantenimientoDateTimePicker.Name = "fechaMantenimientoDateTimePicker";
            this.fechaMantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaMantenimientoDateTimePicker.TabIndex = 6;
            // 
            // anotacionesTextBox
            // 
            this.anotacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "Anotaciones", true));
            this.anotacionesTextBox.Location = new System.Drawing.Point(153, 144);
            this.anotacionesTextBox.Name = "anotacionesTextBox";
            this.anotacionesTextBox.Size = new System.Drawing.Size(200, 20);
            this.anotacionesTextBox.TabIndex = 8;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Agregar.FlatAppearance.BorderSize = 2;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Location = new System.Drawing.Point(23, 184);
            this.Agregar.Name = "Agregar";
            this.Agregar.RadioBorde = 20;
            this.Agregar.Size = new System.Drawing.Size(150, 40);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar Mantenimiento";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.IndianRed;
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Salir.FlatAppearance.BorderSize = 2;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Location = new System.Drawing.Point(213, 184);
            this.Salir.Name = "Salir";
            this.Salir.RadioBorde = 20;
            this.Salir.Size = new System.Drawing.Size(150, 40);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registrar Mantenimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegistrarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(codMantenimientoLabel);
            this.Controls.Add(this.codMantenimientoTextBox);
            this.Controls.Add(nroPlacaLabel);
            this.Controls.Add(this.nroPlacaTextBox);
            this.Controls.Add(fechaMantenimientoLabel);
            this.Controls.Add(this.fechaMantenimientoDateTimePicker);
            this.Controls.Add(anotacionesLabel);
            this.Controls.Add(this.anotacionesTextBox);
            this.Controls.Add(this.mantenimientoBindingNavigator);
            this.Name = "RegistrarMantenimiento";
            this.Text = "RegistrarMantenimiento";
            this.Load += new System.EventHandler(this.RegistrarMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).EndInit();
            this.mantenimientoBindingNavigator.ResumeLayout(false);
            this.mantenimientoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private basededatosDataSet basededatosDataSet;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private basededatosDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private basededatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mantenimientoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mantenimientoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codMantenimientoTextBox;
        private System.Windows.Forms.TextBox nroPlacaTextBox;
        private System.Windows.Forms.DateTimePicker fechaMantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox anotacionesTextBox;
        private BotonRedondo Agregar;
        private BotonRedondo Salir;
        private System.Windows.Forms.Label label1;
    }
}