namespace AppTesis
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenú = new System.Windows.Forms.Panel();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Reportes = new System.Windows.Forms.Button();
            this.rutas = new System.Windows.Forms.Button();
            this.Clientes = new System.Windows.Forms.Button();
            this.Basededatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.btnVehículos = new System.Windows.Forms.Button();
            this.buttonChoferes = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripLblDev = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLblDev2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codMantenimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPlacaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMantenimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaUSDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costeBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.mantenimientoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.orden_ViajeDataGridView = new System.Windows.Forms.DataGridView();
            this.orden_ViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orden_ViajeTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter();
            this.iDOrdenesViajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasViajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paradasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaChoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculosNroPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaUSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenú.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenú
            // 
            this.panelMenú.AutoScroll = true;
            this.panelMenú.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenú.Controls.Add(this.Usuarios);
            this.panelMenú.Controls.Add(this.Reportes);
            this.panelMenú.Controls.Add(this.rutas);
            this.panelMenú.Controls.Add(this.Clientes);
            this.panelMenú.Controls.Add(this.Basededatos);
            this.panelMenú.Controls.Add(this.btnSalir);
            this.panelMenú.Controls.Add(this.c);
            this.panelMenú.Controls.Add(this.btnVehículos);
            this.panelMenú.Controls.Add(this.buttonChoferes);
            this.panelMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenú.Location = new System.Drawing.Point(0, 0);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(166, 701);
            this.panelMenú.TabIndex = 0;
            this.panelMenú.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenú_Paint);
            // 
            // Usuarios
            // 
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.Location = new System.Drawing.Point(0, 386);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(166, 79);
            this.Usuarios.TabIndex = 8;
            this.Usuarios.Text = "Gestionar Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click_1);
            // 
            // Reportes
            // 
            this.Reportes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.Color.White;
            this.Reportes.Location = new System.Drawing.Point(0, 465);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(166, 66);
            this.Reportes.TabIndex = 7;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // rutas
            // 
            this.rutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutas.ForeColor = System.Drawing.Color.White;
            this.rutas.Location = new System.Drawing.Point(0, 304);
            this.rutas.Name = "rutas";
            this.rutas.Size = new System.Drawing.Size(166, 81);
            this.rutas.TabIndex = 6;
            this.rutas.Text = "Rutas";
            this.rutas.UseVisualStyleBackColor = true;
            this.rutas.Click += new System.EventHandler(this.rutas_Click);
            // 
            // Clientes
            // 
            this.Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.Location = new System.Drawing.Point(0, 231);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(166, 73);
            this.Clientes.TabIndex = 5;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // Basededatos
            // 
            this.Basededatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Basededatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Basededatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basededatos.ForeColor = System.Drawing.Color.White;
            this.Basededatos.Location = new System.Drawing.Point(0, 531);
            this.Basededatos.Name = "Basededatos";
            this.Basededatos.Size = new System.Drawing.Size(166, 79);
            this.Basededatos.TabIndex = 4;
            this.Basededatos.Text = "Base de Datos";
            this.Basededatos.UseVisualStyleBackColor = true;
            this.Basededatos.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 610);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 91);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // c
            // 
            this.c.Dock = System.Windows.Forms.DockStyle.Top;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(0, 152);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(166, 79);
            this.c.TabIndex = 2;
            this.c.Text = "Órdenes de viaje";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // btnVehículos
            // 
            this.btnVehículos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehículos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehículos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehículos.ForeColor = System.Drawing.Color.White;
            this.btnVehículos.Location = new System.Drawing.Point(0, 79);
            this.btnVehículos.Name = "btnVehículos";
            this.btnVehículos.Size = new System.Drawing.Size(166, 73);
            this.btnVehículos.TabIndex = 1;
            this.btnVehículos.Text = "Vehículos";
            this.btnVehículos.UseVisualStyleBackColor = true;
            this.btnVehículos.Click += new System.EventHandler(this.btnVehículos_Click);
            // 
            // buttonChoferes
            // 
            this.buttonChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoferes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoferes.ForeColor = System.Drawing.Color.White;
            this.buttonChoferes.Location = new System.Drawing.Point(0, 0);
            this.buttonChoferes.Name = "buttonChoferes";
            this.buttonChoferes.Size = new System.Drawing.Size(166, 79);
            this.buttonChoferes.TabIndex = 0;
            this.buttonChoferes.Text = "Choferes";
            this.buttonChoferes.UseVisualStyleBackColor = true;
            this.buttonChoferes.Click += new System.EventHandler(this.buttonChoferes_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.statusStrip1);
            this.panelContenedor.Controls.Add(this.panel3);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(166, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1035, 701);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLblDev,
            this.ToolStripLblDev2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1035, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripLblDev
            // 
            this.ToolStripLblDev.Name = "ToolStripLblDev";
            this.ToolStripLblDev.Size = new System.Drawing.Size(801, 17);
            this.ToolStripLblDev.Spring = true;
            this.ToolStripLblDev.Text = "Desarrollado por:";
            this.ToolStripLblDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolStripLblDev2
            // 
            this.ToolStripLblDev2.Name = "ToolStripLblDev2";
            this.ToolStripLblDev2.Size = new System.Drawing.Size(202, 17);
            this.ToolStripLblDev2.Text = "Sebastián Velásquez y Veider Gallardo";
            this.ToolStripLblDev2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(24, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 222);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::AppTesis.Properties.Resources._6900514;
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMantenimientoDataGridViewTextBoxColumn1,
            this.nroPlacaDataGridViewTextBoxColumn1,
            this.fechaMantenimientoDataGridViewTextBoxColumn1,
            this.anotacionesDataGridViewTextBoxColumn1,
            this.tasaUSDDataGridViewTextBoxColumn1,
            this.costeBSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mantenimientoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(14, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(449, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // codMantenimientoDataGridViewTextBoxColumn1
            // 
            this.codMantenimientoDataGridViewTextBoxColumn1.DataPropertyName = "CodMantenimiento";
            this.codMantenimientoDataGridViewTextBoxColumn1.HeaderText = "CodMantenimiento";
            this.codMantenimientoDataGridViewTextBoxColumn1.Name = "codMantenimientoDataGridViewTextBoxColumn1";
            this.codMantenimientoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nroPlacaDataGridViewTextBoxColumn1
            // 
            this.nroPlacaDataGridViewTextBoxColumn1.DataPropertyName = "NroPlaca";
            this.nroPlacaDataGridViewTextBoxColumn1.HeaderText = "NroPlaca";
            this.nroPlacaDataGridViewTextBoxColumn1.Name = "nroPlacaDataGridViewTextBoxColumn1";
            this.nroPlacaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaMantenimientoDataGridViewTextBoxColumn1
            // 
            this.fechaMantenimientoDataGridViewTextBoxColumn1.DataPropertyName = "FechaMantenimiento";
            this.fechaMantenimientoDataGridViewTextBoxColumn1.HeaderText = "FechaMantenimiento";
            this.fechaMantenimientoDataGridViewTextBoxColumn1.Name = "fechaMantenimientoDataGridViewTextBoxColumn1";
            this.fechaMantenimientoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // anotacionesDataGridViewTextBoxColumn1
            // 
            this.anotacionesDataGridViewTextBoxColumn1.DataPropertyName = "Anotaciones";
            this.anotacionesDataGridViewTextBoxColumn1.HeaderText = "Anotaciones";
            this.anotacionesDataGridViewTextBoxColumn1.Name = "anotacionesDataGridViewTextBoxColumn1";
            this.anotacionesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tasaUSDDataGridViewTextBoxColumn1
            // 
            this.tasaUSDDataGridViewTextBoxColumn1.DataPropertyName = "Tasa_USD";
            this.tasaUSDDataGridViewTextBoxColumn1.HeaderText = "Tasa_USD";
            this.tasaUSDDataGridViewTextBoxColumn1.Name = "tasaUSDDataGridViewTextBoxColumn1";
            this.tasaUSDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costeBSDataGridViewTextBoxColumn
            // 
            this.costeBSDataGridViewTextBoxColumn.DataPropertyName = "Coste_BS";
            this.costeBSDataGridViewTextBoxColumn.HeaderText = "Coste_BS";
            this.costeBSDataGridViewTextBoxColumn.Name = "costeBSDataGridViewTextBoxColumn";
            this.costeBSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTÓRICO DE MANTENIMIENTO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.orden_ViajeDataGridView);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(505, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 226);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::AppTesis.Properties.Resources._5670281;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "HISTÓRICO DE VIAJES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Controls.Add(this.labelHora);
            this.panel1.Controls.Add(this.labelRol);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 222);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppTesis.Properties.Resources.Logo_Luis_Velásquez_Transportes_Empresa_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(28, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(258, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::AppTesis.Properties.Resources.Icon_User;
            this.pictureBoxUser.Location = new System.Drawing.Point(376, 17);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 3;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(813, 186);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(127, 30);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "13/08/2026";
            this.labelHora.Click += new System.EventHandler(this.labelHora_Click);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(386, 74);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(247, 30);
            this.labelRol.TabIndex = 1;
            this.labelRol.Text = "Administrador principal";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(430, 21);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(153, 37);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Juan Pérez";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChoferTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmpresasSubcontratadaTableAdapter = null;
            this.tableAdapterManager.MantenimientoTableAdapter = this.mantenimientoTableAdapter;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // orden_ViajeDataGridView
            // 
            this.orden_ViajeDataGridView.AllowUserToAddRows = false;
            this.orden_ViajeDataGridView.AllowUserToDeleteRows = false;
            this.orden_ViajeDataGridView.AutoGenerateColumns = false;
            this.orden_ViajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_ViajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOrdenesViajeDataGridViewTextBoxColumn,
            this.rutaDataGridViewTextBoxColumn,
            this.diasViajeDataGridViewTextBoxColumn,
            this.distanciaDataGridViewTextBoxColumn,
            this.paradasDataGridViewTextBoxColumn,
            this.cedulaChoferDataGridViewTextBoxColumn,
            this.vehiculosNroPlacaDataGridViewTextBoxColumn,
            this.cedulaClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinalizacionDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.tasaUSDDataGridViewTextBoxColumn,
            this.pagoBSDataGridViewTextBoxColumn,
            this.incidenciasDataGridViewTextBoxColumn});
            this.orden_ViajeDataGridView.DataSource = this.orden_ViajeBindingSource;
            this.orden_ViajeDataGridView.Location = new System.Drawing.Point(14, 56);
            this.orden_ViajeDataGridView.Name = "orden_ViajeDataGridView";
            this.orden_ViajeDataGridView.ReadOnly = true;
            this.orden_ViajeDataGridView.Size = new System.Drawing.Size(461, 152);
            this.orden_ViajeDataGridView.TabIndex = 25;
            // 
            // orden_ViajeBindingSource
            // 
            this.orden_ViajeBindingSource.DataMember = "Orden_Viaje";
            this.orden_ViajeBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // orden_ViajeTableAdapter
            // 
            this.orden_ViajeTableAdapter.ClearBeforeFill = true;
            // 
            // iDOrdenesViajeDataGridViewTextBoxColumn
            // 
            this.iDOrdenesViajeDataGridViewTextBoxColumn.DataPropertyName = "IDOrdenes_Viaje";
            this.iDOrdenesViajeDataGridViewTextBoxColumn.HeaderText = "Codigo de Viaje";
            this.iDOrdenesViajeDataGridViewTextBoxColumn.Name = "iDOrdenesViajeDataGridViewTextBoxColumn";
            this.iDOrdenesViajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutaDataGridViewTextBoxColumn
            // 
            this.rutaDataGridViewTextBoxColumn.DataPropertyName = "Ruta";
            this.rutaDataGridViewTextBoxColumn.HeaderText = "Ruta del Viaje";
            this.rutaDataGridViewTextBoxColumn.Name = "rutaDataGridViewTextBoxColumn";
            this.rutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasViajeDataGridViewTextBoxColumn
            // 
            this.diasViajeDataGridViewTextBoxColumn.DataPropertyName = "Dias_Viaje";
            this.diasViajeDataGridViewTextBoxColumn.HeaderText = "Dias en Viaje";
            this.diasViajeDataGridViewTextBoxColumn.Name = "diasViajeDataGridViewTextBoxColumn";
            this.diasViajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanciaDataGridViewTextBoxColumn
            // 
            this.distanciaDataGridViewTextBoxColumn.DataPropertyName = "Distancia";
            this.distanciaDataGridViewTextBoxColumn.HeaderText = "Distancia del Viaje en Km";
            this.distanciaDataGridViewTextBoxColumn.Name = "distanciaDataGridViewTextBoxColumn";
            this.distanciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paradasDataGridViewTextBoxColumn
            // 
            this.paradasDataGridViewTextBoxColumn.DataPropertyName = "Paradas";
            this.paradasDataGridViewTextBoxColumn.HeaderText = "Paradas";
            this.paradasDataGridViewTextBoxColumn.Name = "paradasDataGridViewTextBoxColumn";
            this.paradasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaChoferDataGridViewTextBoxColumn
            // 
            this.cedulaChoferDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Chofer";
            this.cedulaChoferDataGridViewTextBoxColumn.HeaderText = "Cedula del Chofer";
            this.cedulaChoferDataGridViewTextBoxColumn.Name = "cedulaChoferDataGridViewTextBoxColumn";
            this.cedulaChoferDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculosNroPlacaDataGridViewTextBoxColumn
            // 
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.DataPropertyName = "Vehiculos_NroPlaca";
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.HeaderText = "Placa del Vehiculo";
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.Name = "vehiculosNroPlacaDataGridViewTextBoxColumn";
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaClienteDataGridViewTextBoxColumn
            // 
            this.cedulaClienteDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Cliente";
            this.cedulaClienteDataGridViewTextBoxColumn.HeaderText = "Cedula del Cliente";
            this.cedulaClienteDataGridViewTextBoxColumn.Name = "cedulaClienteDataGridViewTextBoxColumn";
            this.cedulaClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalizacionDataGridViewTextBoxColumn
            // 
            this.fechaFinalizacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Finalizacion";
            this.fechaFinalizacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion";
            this.fechaFinalizacionDataGridViewTextBoxColumn.Name = "fechaFinalizacionDataGridViewTextBoxColumn";
            this.fechaFinalizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tasaUSDDataGridViewTextBoxColumn
            // 
            this.tasaUSDDataGridViewTextBoxColumn.DataPropertyName = "Tasa_USD";
            this.tasaUSDDataGridViewTextBoxColumn.HeaderText = "Tasa USD";
            this.tasaUSDDataGridViewTextBoxColumn.Name = "tasaUSDDataGridViewTextBoxColumn";
            this.tasaUSDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoBSDataGridViewTextBoxColumn
            // 
            this.pagoBSDataGridViewTextBoxColumn.DataPropertyName = "Pago_BS";
            this.pagoBSDataGridViewTextBoxColumn.HeaderText = "Pago en BS";
            this.pagoBSDataGridViewTextBoxColumn.Name = "pagoBSDataGridViewTextBoxColumn";
            this.pagoBSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incidenciasDataGridViewTextBoxColumn
            // 
            this.incidenciasDataGridViewTextBoxColumn.DataPropertyName = "Incidencias";
            this.incidenciasDataGridViewTextBoxColumn.HeaderText = "Incidencias";
            this.incidenciasDataGridViewTextBoxColumn.Name = "incidenciasDataGridViewTextBoxColumn";
            this.incidenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 701);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenú);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Viajes V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenú.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenú;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button buttonChoferes;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button btnVehículos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Button Basededatos;
        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private DataBaseDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciaEsperadaKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button rutas;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLblDev2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMantenimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPlacaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMantenimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaUSDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costeBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView orden_ViajeDataGridView;
        private System.Windows.Forms.BindingSource orden_ViajeBindingSource;
        private DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter orden_ViajeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrdenesViajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasViajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paradasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaChoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculosNroPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaUSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidenciasDataGridViewTextBoxColumn;
    }
}

