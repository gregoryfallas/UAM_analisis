namespace PL.Pantallas.Adicionales
{
    partial class Frm_Compras_PL
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
            this.gpb_Articulos = new System.Windows.Forms.GroupBox();
            this.btn_Modi_Art = new System.Windows.Forms.Button();
            this.btn_Agre_Art = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_Metodo = new System.Windows.Forms.GroupBox();
            this.rdb_Contado = new System.Windows.Forms.RadioButton();
            this.gpb_Opciones = new System.Windows.Forms.GroupBox();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.dtg_Proveedor = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbp_Proveedor = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Impuesto = new System.Windows.Forms.TextBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpb_Articulos.SuspendLayout();
            this.gpb_Metodo.SuspendLayout();
            this.gpb_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Proveedor)).BeginInit();
            this.gbp_Proveedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.gpb_Articulos);
            this.panel1.Controls.Add(this.gpb_Metodo);
            this.panel1.Controls.Add(this.gpb_Opciones);
            this.panel1.Controls.Add(this.dtg_Proveedor);
            this.panel1.Controls.Add(this.gbp_Proveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 641);
            this.panel1.TabIndex = 0;
            // 
            // gpb_Articulos
            // 
            this.gpb_Articulos.Controls.Add(this.btn_Modi_Art);
            this.gpb_Articulos.Controls.Add(this.btn_Agre_Art);
            this.gpb_Articulos.Controls.Add(this.textBox5);
            this.gpb_Articulos.Controls.Add(this.textBox4);
            this.gpb_Articulos.Controls.Add(this.textBox3);
            this.gpb_Articulos.Controls.Add(this.textBox2);
            this.gpb_Articulos.Controls.Add(this.label8);
            this.gpb_Articulos.Controls.Add(this.label7);
            this.gpb_Articulos.Controls.Add(this.label5);
            this.gpb_Articulos.Controls.Add(this.label1);
            this.gpb_Articulos.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Articulos.ForeColor = System.Drawing.Color.White;
            this.gpb_Articulos.Location = new System.Drawing.Point(12, 242);
            this.gpb_Articulos.Name = "gpb_Articulos";
            this.gpb_Articulos.Size = new System.Drawing.Size(372, 387);
            this.gpb_Articulos.TabIndex = 12;
            this.gpb_Articulos.TabStop = false;
            this.gpb_Articulos.Text = "Artículos";
            // 
            // btn_Modi_Art
            // 
            this.btn_Modi_Art.BackgroundImage = global::PL.Properties.Resources.editar;
            this.btn_Modi_Art.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modi_Art.FlatAppearance.BorderSize = 0;
            this.btn_Modi_Art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modi_Art.Location = new System.Drawing.Point(310, 321);
            this.btn_Modi_Art.Name = "btn_Modi_Art";
            this.btn_Modi_Art.Size = new System.Drawing.Size(45, 41);
            this.btn_Modi_Art.TabIndex = 19;
            this.btn_Modi_Art.UseVisualStyleBackColor = true;
            // 
            // btn_Agre_Art
            // 
            this.btn_Agre_Art.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.btn_Agre_Art.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agre_Art.FlatAppearance.BorderSize = 0;
            this.btn_Agre_Art.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agre_Art.Location = new System.Drawing.Point(259, 321);
            this.btn_Agre_Art.Name = "btn_Agre_Art";
            this.btn_Agre_Art.Size = new System.Drawing.Size(45, 41);
            this.btn_Agre_Art.TabIndex = 18;
            this.btn_Agre_Art.UseVisualStyleBackColor = true;
            this.btn_Agre_Art.Click += new System.EventHandler(this.btn_Agre_Art_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(25, 320);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 26);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(20, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 26);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(22, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 26);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(22, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre Arículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // gpb_Metodo
            // 
            this.gpb_Metodo.Controls.Add(this.rdb_Contado);
            this.gpb_Metodo.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Metodo.ForeColor = System.Drawing.Color.White;
            this.gpb_Metodo.Location = new System.Drawing.Point(625, 29);
            this.gpb_Metodo.Name = "gpb_Metodo";
            this.gpb_Metodo.Size = new System.Drawing.Size(156, 127);
            this.gpb_Metodo.TabIndex = 6;
            this.gpb_Metodo.TabStop = false;
            this.gpb_Metodo.Text = "Forma Pago";
            // 
            // rdb_Contado
            // 
            this.rdb_Contado.AutoSize = true;
            this.rdb_Contado.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Contado.ForeColor = System.Drawing.Color.White;
            this.rdb_Contado.Location = new System.Drawing.Point(30, 59);
            this.rdb_Contado.Name = "rdb_Contado";
            this.rdb_Contado.Size = new System.Drawing.Size(80, 27);
            this.rdb_Contado.TabIndex = 7;
            this.rdb_Contado.TabStop = true;
            this.rdb_Contado.Text = "Contado";
            this.rdb_Contado.UseVisualStyleBackColor = true;
            // 
            // gpb_Opciones
            // 
            this.gpb_Opciones.Controls.Add(this.btn_Comprar);
            this.gpb_Opciones.Controls.Add(this.btn_Agregar);
            this.gpb_Opciones.Controls.Add(this.btn_Editar);
            this.gpb_Opciones.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Opciones.ForeColor = System.Drawing.Color.White;
            this.gpb_Opciones.Location = new System.Drawing.Point(787, 31);
            this.gpb_Opciones.Name = "gpb_Opciones";
            this.gpb_Opciones.Size = new System.Drawing.Size(250, 127);
            this.gpb_Opciones.TabIndex = 10;
            this.gpb_Opciones.TabStop = false;
            this.gpb_Opciones.Text = "Opciones";
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackgroundImage = global::PL.Properties.Resources.contab;
            this.btn_Comprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Comprar.FlatAppearance.BorderSize = 0;
            this.btn_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comprar.Location = new System.Drawing.Point(162, 30);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(71, 70);
            this.btn_Comprar.TabIndex = 11;
            this.btn_Comprar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PL.Properties.Resources.Guardar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(16, 45);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(45, 41);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackgroundImage = global::PL.Properties.Resources.editar;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(96, 45);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(45, 41);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // dtg_Proveedor
            // 
            this.dtg_Proveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Cantidad,
            this.Precio,
            this.Factura});
            this.dtg_Proveedor.Location = new System.Drawing.Point(393, 242);
            this.dtg_Proveedor.Name = "dtg_Proveedor";
            this.dtg_Proveedor.Size = new System.Drawing.Size(644, 387);
            this.dtg_Proveedor.TabIndex = 18;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Nombre Articulo";
            this.Articulo.Name = "Articulo";
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
            // Factura
            // 
            this.Factura.HeaderText = "Número Factura";
            this.Factura.Name = "Factura";
            // 
            // gbp_Proveedor
            // 
            this.gbp_Proveedor.Controls.Add(this.textBox1);
            this.gbp_Proveedor.Controls.Add(this.label6);
            this.gbp_Proveedor.Controls.Add(this.label2);
            this.gbp_Proveedor.Controls.Add(this.label3);
            this.gbp_Proveedor.Controls.Add(this.label4);
            this.gbp_Proveedor.Controls.Add(this.txt_Cantidad);
            this.gbp_Proveedor.Controls.Add(this.txt_Impuesto);
            this.gbp_Proveedor.Controls.Add(this.txt_Descuento);
            this.gbp_Proveedor.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp_Proveedor.ForeColor = System.Drawing.Color.White;
            this.gbp_Proveedor.Location = new System.Drawing.Point(12, 12);
            this.gbp_Proveedor.Name = "gbp_Proveedor";
            this.gbp_Proveedor.Size = new System.Drawing.Size(588, 209);
            this.gbp_Proveedor.TabIndex = 1;
            this.gbp_Proveedor.TabStop = false;
            this.gbp_Proveedor.Text = "Compras Proveedor";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(22, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(323, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(323, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Factura";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cantidad.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.ForeColor = System.Drawing.Color.White;
            this.txt_Cantidad.Location = new System.Drawing.Point(22, 77);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(201, 26);
            this.txt_Cantidad.TabIndex = 2;
            this.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Impuesto
            // 
            this.txt_Impuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Impuesto.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Impuesto.ForeColor = System.Drawing.Color.White;
            this.txt_Impuesto.Location = new System.Drawing.Point(328, 151);
            this.txt_Impuesto.Name = "txt_Impuesto";
            this.txt_Impuesto.Size = new System.Drawing.Size(201, 26);
            this.txt_Impuesto.TabIndex = 5;
            this.txt_Impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Descuento.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descuento.ForeColor = System.Drawing.Color.White;
            this.txt_Descuento.Location = new System.Drawing.Point(328, 77);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(201, 26);
            this.txt_Descuento.TabIndex = 4;
            this.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1055, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 641);
            this.panel2.TabIndex = 1;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(26, 571);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 17;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // Frm_Compras_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Compras_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.panel1.ResumeLayout(false);
            this.gpb_Articulos.ResumeLayout(false);
            this.gpb_Articulos.PerformLayout();
            this.gpb_Metodo.ResumeLayout(false);
            this.gpb_Metodo.PerformLayout();
            this.gpb_Opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Proveedor)).EndInit();
            this.gbp_Proveedor.ResumeLayout(false);
            this.gbp_Proveedor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.GroupBox gbp_Proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Impuesto;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.DataGridView dtg_Proveedor;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.GroupBox gpb_Metodo;
        private System.Windows.Forms.RadioButton rdb_Contado;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.GroupBox gpb_Opciones;
        private System.Windows.Forms.GroupBox gpb_Articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Modi_Art;
        private System.Windows.Forms.Button btn_Agre_Art;
    }
}