namespace PL.Pantallas.Extras
{
    partial class Frm_Contado_PL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Express = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_Contado = new System.Windows.Forms.RadioButton();
            this.rdb_Credito = new System.Windows.Forms.RadioButton();
            this.dtg_Articulos = new System.Windows.Forms.DataGridView();
            this.txt_Impuesto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gp_cantidades = new System.Windows.Forms.GroupBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Importe = new System.Windows.Forms.TextBox();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.txt_NoCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Fecha_Doc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_Factura = new System.Windows.Forms.DataGridView();
            this.IdArti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Recetas = new System.Windows.Forms.Button();
            this.btn_Promociones = new System.Windows.Forms.Button();
            this.btn_Orden = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Factura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNroCorrelativo = new System.Windows.Forms.Label();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nom_Produc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            this.gp_cantidades.SuspendLayout();
            this.gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Factura)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.cb_Express);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Descripcion);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_Productos);
            this.panel1.Controls.Add(this.btn_BuscarCliente);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_Producto);
            this.panel1.Controls.Add(this.txt_Cliente);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dtg_Articulos);
            this.panel1.Controls.Add(this.txt_Impuesto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtg_Clientes);
            this.panel1.Controls.Add(this.txt_SubTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gp_cantidades);
            this.panel1.Controls.Add(this.gb_Datos);
            this.panel1.Controls.Add(this.dtg_Factura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 713);
            this.panel1.TabIndex = 1;
            // 
            // cb_Express
            // 
            this.cb_Express.AutoSize = true;
            this.cb_Express.ForeColor = System.Drawing.Color.White;
            this.cb_Express.Location = new System.Drawing.Point(657, 475);
            this.cb_Express.Name = "cb_Express";
            this.cb_Express.Size = new System.Drawing.Size(145, 31);
            this.cb_Express.TabIndex = 43;
            this.cb_Express.Text = "Servicio Express";
            this.cb_Express.UseVisualStyleBackColor = true;
            this.cb_Express.Click += new System.EventHandler(this.cb_Express_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(710, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Descripción Factura:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(657, 627);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(251, 62);
            this.txt_Descripcion.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(710, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 23);
            this.label15.TabIndex = 40;
            this.label15.Text = "Buscar Producto:";
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackgroundImage = global::PL.Properties.Resources.search;
            this.btn_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Productos.FlatAppearance.BorderSize = 0;
            this.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Productos.Location = new System.Drawing.Point(1035, 419);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(44, 36);
            this.btn_Productos.TabIndex = 39;
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click_1);
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.BackgroundImage = global::PL.Properties.Resources.search;
            this.btn_BuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarCliente.FlatAppearance.BorderSize = 0;
            this.btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCliente.Location = new System.Drawing.Point(1028, 193);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(44, 36);
            this.btn_BuscarCliente.TabIndex = 38;
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(716, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 37;
            this.label14.Text = "Buscar Cliente:";
            // 
            // txt_Producto
            // 
            this.txt_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Producto.ForeColor = System.Drawing.Color.White;
            this.txt_Producto.Location = new System.Drawing.Point(829, 421);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(200, 30);
            this.txt_Producto.TabIndex = 34;
            this.txt_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Producto_KeyPress);
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cliente.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.ForeColor = System.Drawing.Color.White;
            this.txt_Cliente.Location = new System.Drawing.Point(819, 196);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(203, 26);
            this.txt_Cliente.TabIndex = 1;
            this.txt_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cliente_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_Contado);
            this.groupBox2.Controls.Add(this.rdb_Credito);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(829, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 112);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Pago";
            // 
            // rdb_Contado
            // 
            this.rdb_Contado.AutoSize = true;
            this.rdb_Contado.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Contado.ForeColor = System.Drawing.Color.White;
            this.rdb_Contado.Location = new System.Drawing.Point(4, 19);
            this.rdb_Contado.Name = "rdb_Contado";
            this.rdb_Contado.Size = new System.Drawing.Size(90, 31);
            this.rdb_Contado.TabIndex = 1;
            this.rdb_Contado.Text = "Contado";
            this.rdb_Contado.UseVisualStyleBackColor = true;
            // 
            // rdb_Credito
            // 
            this.rdb_Credito.AutoSize = true;
            this.rdb_Credito.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Credito.ForeColor = System.Drawing.Color.White;
            this.rdb_Credito.Location = new System.Drawing.Point(6, 54);
            this.rdb_Credito.Name = "rdb_Credito";
            this.rdb_Credito.Size = new System.Drawing.Size(81, 31);
            this.rdb_Credito.TabIndex = 2;
            this.rdb_Credito.Text = "Crédito";
            this.rdb_Credito.UseVisualStyleBackColor = true;
            this.rdb_Credito.Click += new System.EventHandler(this.rdb_Credito_Click);
            // 
            // dtg_Articulos
            // 
            this.dtg_Articulos.AllowUserToAddRows = false;
            this.dtg_Articulos.AllowUserToDeleteRows = false;
            this.dtg_Articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Articulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Articulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Articulos.Location = new System.Drawing.Point(643, 246);
            this.dtg_Articulos.Name = "dtg_Articulos";
            this.dtg_Articulos.ReadOnly = true;
            this.dtg_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Articulos.Size = new System.Drawing.Size(541, 159);
            this.dtg_Articulos.TabIndex = 33;
            this.dtg_Articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Articulos_CellClick);
            // 
            // txt_Impuesto
            // 
            this.txt_Impuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Impuesto.ForeColor = System.Drawing.Color.White;
            this.txt_Impuesto.Location = new System.Drawing.Point(1108, 575);
            this.txt_Impuesto.MaxLength = 5;
            this.txt_Impuesto.Name = "txt_Impuesto";
            this.txt_Impuesto.ReadOnly = true;
            this.txt_Impuesto.Size = new System.Drawing.Size(117, 30);
            this.txt_Impuesto.TabIndex = 32;
            this.txt_Impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(959, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 38);
            this.label9.TabIndex = 31;
            this.label9.Text = "Impuesto%";
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.AllowUserToAddRows = false;
            this.dtg_Clientes.AllowUserToDeleteRows = false;
            this.dtg_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Clientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Clientes.GridColor = System.Drawing.Color.Black;
            this.dtg_Clientes.Location = new System.Drawing.Point(643, 12);
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.ReadOnly = true;
            this.dtg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Clientes.Size = new System.Drawing.Size(541, 159);
            this.dtg_Clientes.TabIndex = 30;
            this.dtg_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Clientes_CellClick);
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_SubTotal.ForeColor = System.Drawing.Color.White;
            this.txt_SubTotal.Location = new System.Drawing.Point(1108, 519);
            this.txt_SubTotal.MaxLength = 5;
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(117, 30);
            this.txt_SubTotal.TabIndex = 29;
            this.txt_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(959, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 38);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sub Total:";
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Total.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(1108, 630);
            this.txt_Total.MaxLength = 5;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(129, 35);
            this.txt_Total.TabIndex = 27;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(944, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Factura:";
            // 
            // gp_cantidades
            // 
            this.gp_cantidades.Controls.Add(this.label6);
            this.gp_cantidades.Controls.Add(this.txt_Nom_Produc);
            this.gp_cantidades.Controls.Add(this.txt_Descuento);
            this.gp_cantidades.Controls.Add(this.txt_Cantidad);
            this.gp_cantidades.Controls.Add(this.label10);
            this.gp_cantidades.Controls.Add(this.btn_Eliminar);
            this.gp_cantidades.Controls.Add(this.label3);
            this.gp_cantidades.Controls.Add(this.btn_Agregar);
            this.gp_cantidades.Controls.Add(this.label11);
            this.gp_cantidades.Controls.Add(this.label12);
            this.gp_cantidades.Controls.Add(this.txt_Precio);
            this.gp_cantidades.Controls.Add(this.txt_Importe);
            this.gp_cantidades.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cantidades.ForeColor = System.Drawing.Color.White;
            this.gp_cantidades.Location = new System.Drawing.Point(5, 246);
            this.gp_cantidades.Name = "gp_cantidades";
            this.gp_cantidades.Size = new System.Drawing.Size(564, 203);
            this.gp_cantidades.TabIndex = 22;
            this.gp_cantidades.TabStop = false;
            this.gp_cantidades.Text = "Producto-Servicio";
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Descuento.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descuento.ForeColor = System.Drawing.Color.White;
            this.txt_Descuento.Location = new System.Drawing.Point(33, 156);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(92, 26);
            this.txt_Descuento.TabIndex = 5;
            this.txt_Descuento.Text = "0";
            this.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Descuento_KeyPress);
            this.txt_Descuento.Leave += new System.EventHandler(this.txt_Descuento_Leave);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cantidad.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_Cantidad.Location = new System.Drawing.Point(377, 77);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(155, 26);
            this.txt_Cantidad.TabIndex = 4;
            this.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            this.txt_Cantidad.Leave += new System.EventHandler(this.txt_Cantidad_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(373, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cantidad";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Eliminar.BackgroundImage = global::PL.Properties.Resources.cancelar;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(439, 143);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(46, 45);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento%";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Agregar.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_Agregar.Location = new System.Drawing.Point(377, 143);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(43, 45);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(193, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Precio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(162, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Importe";
            // 
            // txt_Precio
            // 
            this.txt_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Precio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.ForeColor = System.Drawing.Color.White;
            this.txt_Precio.Location = new System.Drawing.Point(197, 77);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.ReadOnly = true;
            this.txt_Precio.Size = new System.Drawing.Size(155, 26);
            this.txt_Precio.TabIndex = 1;
            this.txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Importe
            // 
            this.txt_Importe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Importe.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Importe.ForeColor = System.Drawing.Color.White;
            this.txt_Importe.Location = new System.Drawing.Point(156, 152);
            this.txt_Importe.Name = "txt_Importe";
            this.txt_Importe.ReadOnly = true;
            this.txt_Importe.Size = new System.Drawing.Size(153, 30);
            this.txt_Importe.TabIndex = 3;
            this.txt_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_Datos
            // 
            this.gb_Datos.Controls.Add(this.txt_idCliente);
            this.gb_Datos.Controls.Add(this.txt_NoCliente);
            this.gb_Datos.Controls.Add(this.label1);
            this.gb_Datos.Controls.Add(this.txt_Fecha_Doc);
            this.gb_Datos.Controls.Add(this.label7);
            this.gb_Datos.Controls.Add(this.txt_Nombre);
            this.gb_Datos.Controls.Add(this.label2);
            this.gb_Datos.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Datos.ForeColor = System.Drawing.Color.White;
            this.gb_Datos.Location = new System.Drawing.Point(18, 12);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(551, 217);
            this.gb_Datos.TabIndex = 21;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Documento";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_idCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_idCliente.Location = new System.Drawing.Point(438, 156);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(62, 32);
            this.txt_idCliente.TabIndex = 41;
            // 
            // txt_NoCliente
            // 
            this.txt_NoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_NoCliente.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoCliente.ForeColor = System.Drawing.Color.White;
            this.txt_NoCliente.Location = new System.Drawing.Point(6, 71);
            this.txt_NoCliente.Name = "txt_NoCliente";
            this.txt_NoCliente.ReadOnly = true;
            this.txt_NoCliente.Size = new System.Drawing.Size(201, 26);
            this.txt_NoCliente.TabIndex = 11;
            this.txt_NoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cédula";
            // 
            // txt_Fecha_Doc
            // 
            this.txt_Fecha_Doc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Fecha_Doc.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha_Doc.ForeColor = System.Drawing.Color.White;
            this.txt_Fecha_Doc.Location = new System.Drawing.Point(8, 158);
            this.txt_Fecha_Doc.Name = "txt_Fecha_Doc";
            this.txt_Fecha_Doc.ReadOnly = true;
            this.txt_Fecha_Doc.Size = new System.Drawing.Size(199, 26);
            this.txt_Fecha_Doc.TabIndex = 3;
            this.txt_Fecha_Doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha Documento";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(240, 71);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(279, 26);
            this.txt_Nombre.TabIndex = 1;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // dtg_Factura
            // 
            this.dtg_Factura.AllowUserToAddRows = false;
            this.dtg_Factura.AllowUserToDeleteRows = false;
            this.dtg_Factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Factura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Factura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArti,
            this.nom,
            this.cant,
            this.Precio,
            this.descuento,
            this.total});
            this.dtg_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Factura.Location = new System.Drawing.Point(12, 462);
            this.dtg_Factura.Name = "dtg_Factura";
            this.dtg_Factura.ReadOnly = true;
            this.dtg_Factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Factura.Size = new System.Drawing.Size(612, 220);
            this.dtg_Factura.TabIndex = 16;
            this.dtg_Factura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Factura_CellClick);
            // 
            // IdArti
            // 
            this.IdArti.HeaderText = "IdArticulo";
            this.IdArti.Name = "IdArti";
            this.IdArti.ReadOnly = true;
            this.IdArti.Width = 105;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 96;
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            this.cant.Width = 101;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 111;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 74;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.btn_Confirmar.BackgroundImage = global::PL.Properties.Resources.confirmar;
            this.btn_Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirmar.Location = new System.Drawing.Point(23, 540);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(60, 57);
            this.btn_Confirmar.TabIndex = 9;
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Recetas
            // 
            this.btn_Recetas.ForeColor = System.Drawing.Color.Black;
            this.btn_Recetas.Location = new System.Drawing.Point(20, 380);
            this.btn_Recetas.Name = "btn_Recetas";
            this.btn_Recetas.Size = new System.Drawing.Size(75, 55);
            this.btn_Recetas.TabIndex = 24;
            this.btn_Recetas.Text = "Recetas";
            this.btn_Recetas.UseVisualStyleBackColor = true;
            // 
            // btn_Promociones
            // 
            this.btn_Promociones.ForeColor = System.Drawing.Color.Black;
            this.btn_Promociones.Location = new System.Drawing.Point(19, 267);
            this.btn_Promociones.Name = "btn_Promociones";
            this.btn_Promociones.Size = new System.Drawing.Size(75, 49);
            this.btn_Promociones.TabIndex = 25;
            this.btn_Promociones.Text = "Promociones";
            this.btn_Promociones.UseVisualStyleBackColor = true;
            // 
            // btn_Orden
            // 
            this.btn_Orden.BackgroundImage = global::PL.Properties.Resources.doctor;
            this.btn_Orden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Orden.FlatAppearance.BorderSize = 0;
            this.btn_Orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orden.Location = new System.Drawing.Point(20, 133);
            this.btn_Orden.Name = "btn_Orden";
            this.btn_Orden.Size = new System.Drawing.Size(80, 67);
            this.btn_Orden.TabIndex = 6;
            this.btn_Orden.UseVisualStyleBackColor = true;
            this.btn_Orden.Click += new System.EventHandler(this.btn_Orden_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.txt_Factura);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblNroCorrelativo);
            this.panel2.Controls.Add(this.btn_inicio);
            this.panel2.Controls.Add(this.btn_Confirmar);
            this.panel2.Controls.Add(this.btn_Orden);
            this.panel2.Controls.Add(this.btn_Promociones);
            this.panel2.Controls.Add(this.btn_Recetas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1255, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 713);
            this.panel2.TabIndex = 2;
            // 
            // txt_Factura
            // 
            this.txt_Factura.BackColor = System.Drawing.Color.White;
            this.txt_Factura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Factura.ForeColor = System.Drawing.Color.Red;
            this.txt_Factura.Location = new System.Drawing.Point(6, 35);
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.ReadOnly = true;
            this.txt_Factura.Size = new System.Drawing.Size(100, 31);
            this.txt_Factura.TabIndex = 41;
            this.txt_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 23);
            this.label13.TabIndex = 37;
            this.label13.Text = "Factura";
            // 
            // lblNroCorrelativo
            // 
            this.lblNroCorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCorrelativo.ForeColor = System.Drawing.Color.Red;
            this.lblNroCorrelativo.Location = new System.Drawing.Point(16, 28);
            this.lblNroCorrelativo.Name = "lblNroCorrelativo";
            this.lblNroCorrelativo.Size = new System.Drawing.Size(78, 23);
            this.lblNroCorrelativo.TabIndex = 36;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(8, 648);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 11;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IdArticulo
            // 
            this.IdArticulo.HeaderText = "IdArticulo";
            this.IdArticulo.Name = "IdArticulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // txt_Nom_Produc
            // 
            this.txt_Nom_Produc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Nom_Produc.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom_Produc.ForeColor = System.Drawing.Color.White;
            this.txt_Nom_Produc.Location = new System.Drawing.Point(13, 77);
            this.txt_Nom_Produc.Name = "txt_Nom_Produc";
            this.txt_Nom_Produc.ReadOnly = true;
            this.txt_Nom_Produc.Size = new System.Drawing.Size(155, 26);
            this.txt_Nom_Produc.TabIndex = 11;
            this.txt_Nom_Produc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Contado_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Contado_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Frm_Contado_PL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            this.gp_cantidades.ResumeLayout(false);
            this.gp_cantidades.PerformLayout();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Factura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gp_cantidades;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Importe;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Orden;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_Recetas;
        private System.Windows.Forms.Button btn_Promociones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_Contado;
        private System.Windows.Forms.RadioButton rdb_Credito;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtg_Clientes;
        public System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Impuesto;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dtg_Factura;
        public System.Windows.Forms.DataGridView dtg_Articulos;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.Label lblNroCorrelativo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_NoCliente;
        public System.Windows.Forms.TextBox txt_Fecha_Doc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Factura;
        private System.Windows.Forms.TextBox txt_idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArti;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.CheckBox cb_Express;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Nom_Produc;
    }
}