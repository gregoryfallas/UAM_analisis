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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_Contado = new System.Windows.Forms.RadioButton();
            this.rdb_Credito = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_FormaPago = new System.Windows.Forms.GroupBox();
            this.rdb_Efectivo = new System.Windows.Forms.RadioButton();
            this.rdb_Tarjeta = new System.Windows.Forms.RadioButton();
            this.btn_Promociones = new System.Windows.Forms.Button();
            this.btn_Recetas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Orden = new System.Windows.Forms.Button();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Fecha_Doc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            this.dtg_Factura = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grp_FormaPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Factura)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grp_FormaPago);
            this.panel1.Controls.Add(this.dtg_Clientes);
            this.panel1.Controls.Add(this.txt_SubTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Promociones);
            this.panel1.Controls.Add(this.btn_Recetas);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Controls.Add(this.btn_Orden);
            this.panel1.Controls.Add(this.gb_Datos);
            this.panel1.Controls.Add(this.dtg_Factura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 772);
            this.panel1.TabIndex = 1;
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.AllowUserToAddRows = false;
            this.dtg_Clientes.BackgroundColor = System.Drawing.Color.Gray;
            this.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Clientes.GridColor = System.Drawing.Color.Black;
            this.dtg_Clientes.Location = new System.Drawing.Point(602, 22);
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Clientes.Size = new System.Drawing.Size(627, 207);
            this.dtg_Clientes.TabIndex = 30;
            this.dtg_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Clientes_CellContentClick);
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Location = new System.Drawing.Point(911, 634);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(117, 30);
            this.txt_SubTotal.TabIndex = 29;
            this.txt_SubTotal.Text = "¢";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(805, 632);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sub Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_Contado);
            this.groupBox2.Controls.Add(this.rdb_Credito);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(625, 576);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 112);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método Pago";
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(911, 683);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 30);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "¢";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(791, 683);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Factura:";
            // 
            // grp_FormaPago
            // 
            this.grp_FormaPago.Controls.Add(this.rdb_Efectivo);
            this.grp_FormaPago.Controls.Add(this.rdb_Tarjeta);
            this.grp_FormaPago.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_FormaPago.ForeColor = System.Drawing.Color.White;
            this.grp_FormaPago.Location = new System.Drawing.Point(480, 576);
            this.grp_FormaPago.Name = "grp_FormaPago";
            this.grp_FormaPago.Size = new System.Drawing.Size(111, 112);
            this.grp_FormaPago.TabIndex = 26;
            this.grp_FormaPago.TabStop = false;
            this.grp_FormaPago.Text = "Forma Pago";
            // 
            // rdb_Efectivo
            // 
            this.rdb_Efectivo.AutoSize = true;
            this.rdb_Efectivo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Efectivo.ForeColor = System.Drawing.Color.White;
            this.rdb_Efectivo.Location = new System.Drawing.Point(4, 19);
            this.rdb_Efectivo.Name = "rdb_Efectivo";
            this.rdb_Efectivo.Size = new System.Drawing.Size(85, 31);
            this.rdb_Efectivo.TabIndex = 1;
            this.rdb_Efectivo.Text = "Efectivo";
            this.rdb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // rdb_Tarjeta
            // 
            this.rdb_Tarjeta.AutoSize = true;
            this.rdb_Tarjeta.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Tarjeta.ForeColor = System.Drawing.Color.White;
            this.rdb_Tarjeta.Location = new System.Drawing.Point(6, 54);
            this.rdb_Tarjeta.Name = "rdb_Tarjeta";
            this.rdb_Tarjeta.Size = new System.Drawing.Size(81, 31);
            this.rdb_Tarjeta.TabIndex = 2;
            this.rdb_Tarjeta.Text = "Tarjeta";
            this.rdb_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // btn_Promociones
            // 
            this.btn_Promociones.ForeColor = System.Drawing.Color.Black;
            this.btn_Promociones.Location = new System.Drawing.Point(172, 565);
            this.btn_Promociones.Name = "btn_Promociones";
            this.btn_Promociones.Size = new System.Drawing.Size(121, 49);
            this.btn_Promociones.TabIndex = 25;
            this.btn_Promociones.Text = "Promociones";
            this.btn_Promociones.UseVisualStyleBackColor = true;
            // 
            // btn_Recetas
            // 
            this.btn_Recetas.ForeColor = System.Drawing.Color.Black;
            this.btn_Recetas.Location = new System.Drawing.Point(317, 565);
            this.btn_Recetas.Name = "btn_Recetas";
            this.btn_Recetas.Size = new System.Drawing.Size(75, 55);
            this.btn_Recetas.TabIndex = 24;
            this.btn_Recetas.Text = "Recetas";
            this.btn_Recetas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Descuento);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Precio);
            this.groupBox1.Controls.Add(this.txt_Total);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 220);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto-Servicio";
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Descuento.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descuento.ForeColor = System.Drawing.Color.White;
            this.txt_Descuento.Location = new System.Drawing.Point(206, 77);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(92, 26);
            this.txt_Descuento.TabIndex = 8;
            this.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Guardar.BackgroundImage = global::PL.Properties.Resources.Guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.Location = new System.Drawing.Point(479, 149);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(42, 45);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cantidad.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_Cantidad.Location = new System.Drawing.Point(22, 77);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(155, 26);
            this.txt_Cantidad.TabIndex = 7;
            this.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 47);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(554, 149);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(46, 45);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 47);
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
            this.btn_Agregar.Location = new System.Drawing.Point(402, 149);
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
            this.label11.Location = new System.Drawing.Point(17, 134);
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
            this.label12.Location = new System.Drawing.Point(328, 47);
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
            this.txt_Precio.Location = new System.Drawing.Point(22, 164);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.ReadOnly = true;
            this.txt_Precio.Size = new System.Drawing.Size(155, 26);
            this.txt_Precio.TabIndex = 1;
            this.txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Total.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(332, 73);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(153, 30);
            this.txt_Total.TabIndex = 3;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Confirmar.BackgroundImage = global::PL.Properties.Resources.confirmar;
            this.btn_Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirmar.Location = new System.Drawing.Point(1151, 664);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(60, 57);
            this.btn_Confirmar.TabIndex = 9;
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Orden
            // 
            this.btn_Orden.BackgroundImage = global::PL.Properties.Resources.doctor;
            this.btn_Orden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Orden.FlatAppearance.BorderSize = 0;
            this.btn_Orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orden.Location = new System.Drawing.Point(28, 565);
            this.btn_Orden.Name = "btn_Orden";
            this.btn_Orden.Size = new System.Drawing.Size(99, 81);
            this.btn_Orden.TabIndex = 6;
            this.btn_Orden.UseVisualStyleBackColor = true;
            this.btn_Orden.Click += new System.EventHandler(this.btn_Orden_Click);
            // 
            // gb_Datos
            // 
            this.gb_Datos.Controls.Add(this.btn_Buscar);
            this.gb_Datos.Controls.Add(this.txt_Fecha_Doc);
            this.gb_Datos.Controls.Add(this.label7);
            this.gb_Datos.Controls.Add(this.txt_Nombre);
            this.gb_Datos.Controls.Add(this.txt_Cliente);
            this.gb_Datos.Controls.Add(this.label1);
            this.gb_Datos.Controls.Add(this.label6);
            this.gb_Datos.Controls.Add(this.label2);
            this.gb_Datos.Controls.Add(this.txt_Orden);
            this.gb_Datos.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Datos.ForeColor = System.Drawing.Color.White;
            this.gb_Datos.Location = new System.Drawing.Point(18, 12);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(551, 217);
            this.gb_Datos.TabIndex = 21;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Documento";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_Buscar.Location = new System.Drawing.Point(265, 38);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(96, 38);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Fecha_Doc
            // 
            this.txt_Fecha_Doc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Fecha_Doc.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha_Doc.ForeColor = System.Drawing.Color.White;
            this.txt_Fecha_Doc.Location = new System.Drawing.Point(181, 167);
            this.txt_Fecha_Doc.Name = "txt_Fecha_Doc";
            this.txt_Fecha_Doc.Size = new System.Drawing.Size(220, 26);
            this.txt_Fecha_Doc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(187, 134);
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
            this.txt_Nombre.Location = new System.Drawing.Point(6, 105);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(279, 26);
            this.txt_Nombre.TabIndex = 8;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cliente.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.ForeColor = System.Drawing.Color.White;
            this.txt_Cliente.Location = new System.Drawing.Point(90, 41);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(155, 26);
            this.txt_Cliente.TabIndex = 7;
            this.txt_Cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "No. Cédula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "No.Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txt_Orden
            // 
            this.txt_Orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Orden.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Orden.ForeColor = System.Drawing.Color.White;
            this.txt_Orden.Location = new System.Drawing.Point(6, 167);
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.ReadOnly = true;
            this.txt_Orden.Size = new System.Drawing.Size(155, 26);
            this.txt_Orden.TabIndex = 1;
            this.txt_Orden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtg_Factura
            // 
            this.dtg_Factura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Descuento,
            this.Total});
            this.dtg_Factura.Location = new System.Drawing.Point(649, 246);
            this.dtg_Factura.Name = "dtg_Factura";
            this.dtg_Factura.Size = new System.Drawing.Size(580, 306);
            this.dtg_Factura.TabIndex = 16;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento%";
            this.Descuento.Name = "Descuento";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 772);
            this.panel2.TabIndex = 2;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(29, 672);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 11;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(805, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.TabIndex = 31;
            this.label9.Text = "Impuesto%";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(911, 579);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 30);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "13";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Contado_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Contado_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas ";
            this.Load += new System.EventHandler(this.Frm_Contado_PL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_FormaPago.ResumeLayout(false);
            this.grp_FormaPago.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Factura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Orden;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.TextBox txt_Fecha_Doc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Orden;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_Recetas;
        private System.Windows.Forms.Button btn_Promociones;
        private System.Windows.Forms.GroupBox grp_FormaPago;
        private System.Windows.Forms.RadioButton rdb_Efectivo;
        private System.Windows.Forms.RadioButton rdb_Tarjeta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_Contado;
        private System.Windows.Forms.RadioButton rdb_Credito;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dtg_Clientes;
        public System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dtg_Factura;
    }
}