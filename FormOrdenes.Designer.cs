namespace AppTesis
{
    partial class Formordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formordenes));
            this.basededatosDataSet = new AppTesis.basededatosDataSet();
            this.ordenes_ViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenes_ViajeTableAdapter = new AppTesis.basededatosDataSetTableAdapters.Ordenes_ViajeTableAdapter();
            this.tableAdapterManager = new AppTesis.basededatosDataSetTableAdapters.TableAdapterManager();
            this.ordenes_ViajeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ordenes_ViajeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ordenes_ViajeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new BotonRedondo();
            this.modificar = new BotonRedondo();
            this.salir = new BotonRedondo();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingNavigator)).BeginInit();
            this.ordenes_ViajeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeDataGridView)).BeginInit();
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
            this.ordenes_ViajeBindingNavigator.Size = new System.Drawing.Size(865, 25);
            this.ordenes_ViajeBindingNavigator.TabIndex = 0;
            this.ordenes_ViajeBindingNavigator.Text = "bindingNavigator1";
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
            // ordenes_ViajeBindingNavigatorSaveItem
            // 
            this.ordenes_ViajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordenes_ViajeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenes_ViajeBindingNavigatorSaveItem.Image")));
            this.ordenes_ViajeBindingNavigatorSaveItem.Name = "ordenes_ViajeBindingNavigatorSaveItem";
            this.ordenes_ViajeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordenes_ViajeBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ordenes_ViajeBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordenes_ViajeBindingNavigatorSaveItem_Click);
            // 
            // ordenes_ViajeDataGridView
            // 
            this.ordenes_ViajeDataGridView.AutoGenerateColumns = false;
            this.ordenes_ViajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordenes_ViajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ordenes_ViajeDataGridView.DataSource = this.ordenes_ViajeBindingSource;
            this.ordenes_ViajeDataGridView.Location = new System.Drawing.Point(21, 93);
            this.ordenes_ViajeDataGridView.Name = "ordenes_ViajeDataGridView";
            this.ordenes_ViajeDataGridView.Size = new System.Drawing.Size(832, 220);
            this.ordenes_ViajeDataGridView.TabIndex = 1;
            this.ordenes_ViajeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordenes_ViajeDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDOrdenes_Viaje";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDOrdenes_Viaje";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cedula_Chofer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cedula_Chofer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vehiculos_NroPlaca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehiculos_NroPlaca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Destino";
            this.dataGridViewTextBoxColumn4.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Inicio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha_Inicio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha_Finalizacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha_Finalizacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Distancia_Esperada";
            this.dataGridViewTextBoxColumn7.HeaderText = "Distancia_Esperada";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn8.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatAppearance.BorderSize = 2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Location = new System.Drawing.Point(131, 351);
            this.agregar.Name = "agregar";
            this.agregar.RadioBorde = 20;
            this.agregar.Size = new System.Drawing.Size(150, 40);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar Orden";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modificar.FlatAppearance.BorderSize = 2;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Location = new System.Drawing.Point(363, 351);
            this.modificar.Name = "modificar";
            this.modificar.RadioBorde = 20;
            this.modificar.Size = new System.Drawing.Size(150, 40);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar Orden";
            this.modificar.UseVisualStyleBackColor = false;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.IndianRed;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(598, 351);
            this.salir.Name = "salir";
            this.salir.RadioBorde = 20;
            this.salir.Size = new System.Drawing.Size(150, 40);
            this.salir.TabIndex = 4;
            this.salir.Text = "Volver al Menu";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de Ordenes de Viaje";
            // 
            // Formordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.ordenes_ViajeDataGridView);
            this.Controls.Add(this.ordenes_ViajeBindingNavigator);
            this.Name = "Formordenes";
            this.Text = "Ordenes de Viaje";
            this.Load += new System.EventHandler(this.Formordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeBindingNavigator)).EndInit();
            this.ordenes_ViajeBindingNavigator.ResumeLayout(false);
            this.ordenes_ViajeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenes_ViajeDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ordenes_ViajeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BotonRedondo agregar;
        private BotonRedondo modificar;
        private BotonRedondo salir;
        private System.Windows.Forms.Label label1;
    }
}