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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa_USD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coste_BS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new AppTesis.DataBaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOrdenesViajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias_Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaChoferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculosNroPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago_BS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_ViajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.mantenimientoTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager = new AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.orden_ViajeTableAdapter = new AppTesis.DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter();
            this.panelMenú.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
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
            this.Usuarios.Location = new System.Drawing.Point(0, 572);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(149, 132);
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
            this.Reportes.Location = new System.Drawing.Point(0, 704);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(149, 132);
            this.Reportes.TabIndex = 7;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // rutas
            // 
            this.rutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutas.ForeColor = System.Drawing.Color.White;
            this.rutas.Location = new System.Drawing.Point(0, 461);
            this.rutas.Name = "rutas";
            this.rutas.Size = new System.Drawing.Size(149, 111);
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
            this.Clientes.Location = new System.Drawing.Point(0, 332);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(149, 129);
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
            this.Basededatos.Location = new System.Drawing.Point(0, 836);
            this.Basededatos.Name = "Basededatos";
            this.Basededatos.Size = new System.Drawing.Size(149, 132);
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
            this.btnSalir.Location = new System.Drawing.Point(0, 968);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 102);
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
            this.c.Location = new System.Drawing.Point(0, 214);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(149, 118);
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
            this.btnVehículos.Location = new System.Drawing.Point(0, 103);
            this.btnVehículos.Name = "btnVehículos";
            this.btnVehículos.Size = new System.Drawing.Size(149, 111);
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
            this.buttonChoferes.Size = new System.Drawing.Size(149, 103);
            this.buttonChoferes.TabIndex = 0;
            this.buttonChoferes.Text = "Choferes";
            this.buttonChoferes.UseVisualStyleBackColor = true;
            this.buttonChoferes.Click += new System.EventHandler(this.buttonChoferes_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelContenedor.Controls.Add(this.panel3);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(166, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1018, 701);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
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
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMantenimientoDataGridViewTextBoxColumn,
            this.nroPlacaDataGridViewTextBoxColumn,
            this.fechaMantenimientoDataGridViewTextBoxColumn,
            this.Tasa_USD,
            this.Coste_BS,
            this.anotacionesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mantenimientoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(14, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(449, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // codMantenimientoDataGridViewTextBoxColumn
            // 
            this.codMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "CodMantenimiento";
            this.codMantenimientoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.codMantenimientoDataGridViewTextBoxColumn.Name = "codMantenimientoDataGridViewTextBoxColumn";
            this.codMantenimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroPlacaDataGridViewTextBoxColumn
            // 
            this.nroPlacaDataGridViewTextBoxColumn.DataPropertyName = "NroPlaca";
            this.nroPlacaDataGridViewTextBoxColumn.HeaderText = "Numero de Placa";
            this.nroPlacaDataGridViewTextBoxColumn.Name = "nroPlacaDataGridViewTextBoxColumn";
            // 
            // fechaMantenimientoDataGridViewTextBoxColumn
            // 
            this.fechaMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMantenimiento";
            this.fechaMantenimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de cuando se realizo el mantenimiento";
            this.fechaMantenimientoDataGridViewTextBoxColumn.Name = "fechaMantenimientoDataGridViewTextBoxColumn";
            // 
            // Tasa_USD
            // 
            this.Tasa_USD.DataPropertyName = "Tasa_USD";
            this.Tasa_USD.HeaderText = "Tasa_USD";
            this.Tasa_USD.Name = "Tasa_USD";
            // 
            // Coste_BS
            // 
            this.Coste_BS.DataPropertyName = "Coste_BS";
            this.Coste_BS.HeaderText = "Coste_BS";
            this.Coste_BS.Name = "Coste_BS";
            // 
            // anotacionesDataGridViewTextBoxColumn
            // 
            this.anotacionesDataGridViewTextBoxColumn.DataPropertyName = "Anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.HeaderText = "Anotaciones";
            this.anotacionesDataGridViewTextBoxColumn.Name = "anotacionesDataGridViewTextBoxColumn";
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
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(505, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 222);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOrdenesViajeDataGridViewTextBoxColumn,
            this.Ruta,
            this.Dias_Viaje,
            this.Distancia,
            this.Origen,
            this.Paradas,
            this.destinoDataGridViewTextBoxColumn,
            this.cedulaChoferDataGridViewTextBoxColumn,
            this.vehiculosNroPlacaDataGridViewTextBoxColumn,
            this.cedulaClienteDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinalizacionDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.Pago_BS,
            this.estatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orden_ViajeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDOrdenesViajeDataGridViewTextBoxColumn
            // 
            this.iDOrdenesViajeDataGridViewTextBoxColumn.DataPropertyName = "IDOrdenes_Viaje";
            this.iDOrdenesViajeDataGridViewTextBoxColumn.HeaderText = "IDOrdenes_Viaje";
            this.iDOrdenesViajeDataGridViewTextBoxColumn.Name = "iDOrdenesViajeDataGridViewTextBoxColumn";
            this.iDOrdenesViajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ruta
            // 
            this.Ruta.DataPropertyName = "Ruta";
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            // 
            // Dias_Viaje
            // 
            this.Dias_Viaje.DataPropertyName = "Dias_Viaje";
            this.Dias_Viaje.HeaderText = "Dias de Viaje";
            this.Dias_Viaje.Name = "Dias_Viaje";
            // 
            // Distancia
            // 
            this.Distancia.DataPropertyName = "Distancia";
            this.Distancia.HeaderText = "Distancia en Km";
            this.Distancia.Name = "Distancia";
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            // 
            // Paradas
            // 
            this.Paradas.DataPropertyName = "Paradas";
            this.Paradas.HeaderText = "Paradas";
            this.Paradas.Name = "Paradas";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // cedulaChoferDataGridViewTextBoxColumn
            // 
            this.cedulaChoferDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Chofer";
            this.cedulaChoferDataGridViewTextBoxColumn.HeaderText = "Cedula del Chofer";
            this.cedulaChoferDataGridViewTextBoxColumn.Name = "cedulaChoferDataGridViewTextBoxColumn";
            // 
            // vehiculosNroPlacaDataGridViewTextBoxColumn
            // 
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.DataPropertyName = "Vehiculos_NroPlaca";
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.HeaderText = "Placa del Vehiculo";
            this.vehiculosNroPlacaDataGridViewTextBoxColumn.Name = "vehiculosNroPlacaDataGridViewTextBoxColumn";
            // 
            // cedulaClienteDataGridViewTextBoxColumn
            // 
            this.cedulaClienteDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Cliente";
            this.cedulaClienteDataGridViewTextBoxColumn.HeaderText = "Cedula del Cliente";
            this.cedulaClienteDataGridViewTextBoxColumn.Name = "cedulaClienteDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio de viaje";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinalizacionDataGridViewTextBoxColumn
            // 
            this.fechaFinalizacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Finalizacion";
            this.fechaFinalizacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Finalizacion del viaje";
            this.fechaFinalizacionDataGridViewTextBoxColumn.Name = "fechaFinalizacionDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tasa_USD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tasa USD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Pago_BS
            // 
            this.Pago_BS.DataPropertyName = "Pago_BS";
            this.Pago_BS.HeaderText = "Pago en BS";
            this.Pago_BS.Name = "Pago_BS";
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            // 
            // orden_ViajeBindingSource
            // 
            this.orden_ViajeBindingSource.DataMember = "Orden_Viaje";
            this.orden_ViajeBindingSource.DataSource = this.dataBaseDataSet;
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
            this.tableAdapterManager.MantenimientoTableAdapter = this.mantenimientoTableAdapter;
            this.tableAdapterManager.Orden_ViajeTableAdapter = this.orden_ViajeTableAdapter;
            this.tableAdapterManager.RegistroAccionesTableAdapter = null;
            this.tableAdapterManager.RutasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppTesis.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VehiculoTableAdapter = null;
            // 
            // orden_ViajeTableAdapter
            // 
            this.orden_ViajeTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenú);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Control de Viajes V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenú.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_ViajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private DataBaseDataSetTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataBaseDataSetTableAdapters.Orden_ViajeTableAdapter orden_ViajeTableAdapter;
        private System.Windows.Forms.BindingSource orden_ViajeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciaEsperadaKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa_USD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coste_BS;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrdenesViajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias_Viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaChoferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculosNroPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago_BS;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button rutas;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Button Reportes;
    }
}

