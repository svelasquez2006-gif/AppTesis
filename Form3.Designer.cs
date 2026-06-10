namespace AppTesis
{
    partial class Formchoferes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formchoferes));
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new BotonRedondo();
            this.Modificar = new BotonRedondo();
            this.Registrar = new BotonRedondo();
            this.basededatosDataSet = new AppTesis.basededatosDataSet();
            this.choferesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.choferesTableAdapter = new AppTesis.basededatosDataSetTableAdapters.ChoferesTableAdapter();
            this.tableAdapterManager = new AppTesis.basededatosDataSetTableAdapters.TableAdapterManager();
            this.choferesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.choferesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.choferesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingNavigator)).BeginInit();
            this.choferesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choferesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Choferes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.IndianRed;
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Salir.FlatAppearance.BorderSize = 2;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Location = new System.Drawing.Point(704, 318);
            this.Salir.Name = "Salir";
            this.Salir.RadioBorde = 20;
            this.Salir.Size = new System.Drawing.Size(174, 40);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Volver al Menu";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Modificar.FlatAppearance.BorderSize = 2;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.Location = new System.Drawing.Point(427, 318);
            this.Modificar.Name = "Modificar";
            this.Modificar.RadioBorde = 20;
            this.Modificar.Size = new System.Drawing.Size(183, 40);
            this.Modificar.TabIndex = 4;
            this.Modificar.Text = "Modificar Chofer";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.botonRedondo2_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Registrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Registrar.FlatAppearance.BorderSize = 2;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar.Location = new System.Drawing.Point(138, 318);
            this.Registrar.Name = "Registrar";
            this.Registrar.RadioBorde = 20;
            this.Registrar.Size = new System.Drawing.Size(186, 40);
            this.Registrar.TabIndex = 3;
            this.Registrar.Text = "Registrar Chofer";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // basededatosDataSet
            // 
            this.basededatosDataSet.DataSetName = "basededatosDataSet";
            this.basededatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // choferesBindingSource
            // 
            this.choferesBindingSource.DataMember = "Choferes";
            this.choferesBindingSource.DataSource = this.basededatosDataSet;
            // 
            // choferesTableAdapter
            // 
            this.choferesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferesTableAdapter = this.choferesTableAdapter;
            this.tableAdapterManager.Estatus_ChoferesTableAdapter = null;
            this.tableAdapterManager.Estatus_OrdenTableAdapter = null;
            this.tableAdapterManager.Estatus_VehiculoTableAdapter = null;
            this.tableAdapterManager.Jerarquia_UsuariosTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = null;
            this.tableAdapterManager.Ordenes_ViajeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.basededatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VehiculosTableAdapter = null;
            // 
            // choferesBindingNavigator
            // 
            this.choferesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.choferesBindingNavigator.BindingSource = this.choferesBindingSource;
            this.choferesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.choferesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.choferesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.choferesBindingNavigatorSaveItem});
            this.choferesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.choferesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.choferesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.choferesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.choferesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.choferesBindingNavigator.Name = "choferesBindingNavigator";
            this.choferesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.choferesBindingNavigator.Size = new System.Drawing.Size(972, 25);
            this.choferesBindingNavigator.TabIndex = 6;
            this.choferesBindingNavigator.Text = "bindingNavigator1";
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
            // choferesBindingNavigatorSaveItem
            // 
            this.choferesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.choferesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("choferesBindingNavigatorSaveItem.Image")));
            this.choferesBindingNavigatorSaveItem.Name = "choferesBindingNavigatorSaveItem";
            this.choferesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.choferesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.choferesBindingNavigatorSaveItem.Click += new System.EventHandler(this.choferesBindingNavigatorSaveItem_Click_1);
            // 
            // choferesDataGridView
            // 
            this.choferesDataGridView.AutoGenerateColumns = false;
            this.choferesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.choferesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.choferesDataGridView.DataSource = this.choferesBindingSource;
            this.choferesDataGridView.Location = new System.Drawing.Point(12, 79);
            this.choferesDataGridView.Name = "choferesDataGridView";
            this.choferesDataGridView.Size = new System.Drawing.Size(935, 220);
            this.choferesDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Grado_Licencia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grado_Licencia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn9.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Formchoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 383);
            this.Controls.Add(this.choferesDataGridView);
            this.Controls.Add(this.choferesBindingNavigator);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.label1);
            this.Name = "Formchoferes";
            this.Text = "Choferes";
            this.Load += new System.EventHandler(this.Formchoferes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basededatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choferesBindingNavigator)).EndInit();
            this.choferesBindingNavigator.ResumeLayout(false);
            this.choferesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choferesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BotonRedondo Registrar;
        private BotonRedondo Modificar;
        private BotonRedondo Salir;
        private basededatosDataSet basededatosDataSet;
        private System.Windows.Forms.BindingSource choferesBindingSource;
        private basededatosDataSetTableAdapters.ChoferesTableAdapter choferesTableAdapter;
        private basededatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator choferesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton choferesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView choferesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}