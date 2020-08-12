namespace PL.Pantallas.Extras
{
    partial class Cobros_PL
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Factura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Fecha_Doc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NoCliente = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_Pago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cambio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Cobros = new System.Windows.Forms.DataGridView();
            this.grp_FormaPago = new System.Windows.Forms.GroupBox();
            this.rdb_Efectivo = new System.Windows.Forms.RadioButton();
            this.rdb_Tarjeta = new System.Windows.Forms.RadioButton();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cobros)).BeginInit();
            this.grp_FormaPago.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Fecha);
            this.panel2.Controls.Add(this.btn_inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1066, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 618);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Fecha";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Fecha.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.ForeColor = System.Drawing.Color.White;
            this.txt_Fecha.Location = new System.Drawing.Point(18, 49);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.ReadOnly = true;
            this.txt_Fecha.Size = new System.Drawing.Size(101, 30);
            this.txt_Fecha.TabIndex = 67;
            this.txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(18, 555);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 12;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Controls.Add(this.dtg_Cobros);
            this.panel1.Controls.Add(this.grp_FormaPago);
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 618);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_Factura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Cliente);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Fecha_Doc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_NoCliente);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(47, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 155);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Factura";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(253, 60);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(279, 26);
            this.txt_Nombre.TabIndex = 51;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Factura
            // 
            this.txt_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Factura.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Factura.ForeColor = System.Drawing.Color.White;
            this.txt_Factura.Location = new System.Drawing.Point(787, 58);
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.ReadOnly = true;
            this.txt_Factura.Size = new System.Drawing.Size(155, 26);
            this.txt_Factura.TabIndex = 53;
            this.txt_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(283, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 61;
            this.label11.Text = "Buscar Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(793, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "No.Factura";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cliente.ForeColor = System.Drawing.Color.White;
            this.txt_Cliente.Location = new System.Drawing.Point(386, 114);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(226, 26);
            this.txt_Cliente.TabIndex = 60;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::PL.Properties.Resources.search;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(634, 107);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(44, 36);
            this.btn_Buscar.TabIndex = 59;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(564, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "Fecha Documento";
            // 
            // txt_Fecha_Doc
            // 
            this.txt_Fecha_Doc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Fecha_Doc.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha_Doc.ForeColor = System.Drawing.Color.White;
            this.txt_Fecha_Doc.Location = new System.Drawing.Point(556, 61);
            this.txt_Fecha_Doc.Name = "txt_Fecha_Doc";
            this.txt_Fecha_Doc.ReadOnly = true;
            this.txt_Fecha_Doc.Size = new System.Drawing.Size(199, 26);
            this.txt_Fecha_Doc.TabIndex = 54;
            this.txt_Fecha_Doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 58;
            this.label10.Text = "Cédula";
            // 
            // txt_NoCliente
            // 
            this.txt_NoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_NoCliente.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoCliente.ForeColor = System.Drawing.Color.White;
            this.txt_NoCliente.Location = new System.Drawing.Point(38, 60);
            this.txt_NoCliente.Name = "txt_NoCliente";
            this.txt_NoCliente.ReadOnly = true;
            this.txt_NoCliente.Size = new System.Drawing.Size(201, 26);
            this.txt_NoCliente.TabIndex = 57;
            this.txt_NoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Confirmar.BackgroundImage = global::PL.Properties.Resources.confirmar;
            this.btn_Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirmar.Location = new System.Drawing.Point(894, 535);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(60, 57);
            this.btn_Confirmar.TabIndex = 66;
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // txt_Pago
            // 
            this.txt_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Pago.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pago.ForeColor = System.Drawing.Color.White;
            this.txt_Pago.Location = new System.Drawing.Point(223, 75);
            this.txt_Pago.MaxLength = 5;
            this.txt_Pago.Name = "txt_Pago";
            this.txt_Pago.Size = new System.Drawing.Size(129, 35);
            this.txt_Pago.TabIndex = 62;
            this.txt_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 47;
            this.label2.Text = "Monto de Pago:";
            // 
            // txt_Cambio
            // 
            this.txt_Cambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cambio.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cambio.ForeColor = System.Drawing.Color.White;
            this.txt_Cambio.Location = new System.Drawing.Point(223, 127);
            this.txt_Cambio.MaxLength = 5;
            this.txt_Cambio.Name = "txt_Cambio";
            this.txt_Cambio.ReadOnly = true;
            this.txt_Cambio.Size = new System.Drawing.Size(129, 35);
            this.txt_Cambio.TabIndex = 46;
            this.txt_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 45;
            this.label3.Text = "Su cambio es de:";
            // 
            // dtg_Cobros
            // 
            this.dtg_Cobros.AllowUserToAddRows = false;
            this.dtg_Cobros.AllowUserToDeleteRows = false;
            this.dtg_Cobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Cobros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Cobros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Cobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Cobros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Cobros.Location = new System.Drawing.Point(214, 164);
            this.dtg_Cobros.Name = "dtg_Cobros";
            this.dtg_Cobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Cobros.Size = new System.Drawing.Size(651, 238);
            this.dtg_Cobros.TabIndex = 44;
            this.dtg_Cobros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Cobros_CellClick);
            // 
            // grp_FormaPago
            // 
            this.grp_FormaPago.Controls.Add(this.rdb_Efectivo);
            this.grp_FormaPago.Controls.Add(this.rdb_Tarjeta);
            this.grp_FormaPago.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_FormaPago.ForeColor = System.Drawing.Color.White;
            this.grp_FormaPago.Location = new System.Drawing.Point(918, 357);
            this.grp_FormaPago.Name = "grp_FormaPago";
            this.grp_FormaPago.Size = new System.Drawing.Size(111, 112);
            this.grp_FormaPago.TabIndex = 27;
            this.grp_FormaPago.TabStop = false;
            this.grp_FormaPago.Text = "Forma Pago";
            // 
            // rdb_Efectivo
            // 
            this.rdb_Efectivo.AutoSize = true;
            this.rdb_Efectivo.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Efectivo.ForeColor = System.Drawing.Color.White;
            this.rdb_Efectivo.Location = new System.Drawing.Point(9, 25);
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
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Total.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(215, 19);
            this.txt_Total.MaxLength = 5;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(129, 35);
            this.txt_Total.TabIndex = 39;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 38);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total Factura:";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackgroundImage = global::PL.Properties.Resources.print;
            this.btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Imprimir.Enabled = false;
            this.btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Location = new System.Drawing.Point(975, 540);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 57);
            this.btn_Imprimir.TabIndex = 37;
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Total);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_Pago);
            this.groupBox2.Controls.Add(this.txt_Cambio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(499, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 198);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compras Contado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(98, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 188);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compras Crédito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 38);
            this.label8.TabIndex = 40;
            this.label8.Text = "Saldo Factura:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(201, 19);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 35);
            this.textBox1.TabIndex = 41;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 38);
            this.label9.TabIndex = 42;
            this.label9.Text = "Abono:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox2.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(201, 78);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(129, 35);
            this.textBox2.TabIndex = 43;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(37, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 38);
            this.label12.TabIndex = 44;
            this.label12.Text = "Saldo Actual:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox3.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(201, 128);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(129, 35);
            this.textBox3.TabIndex = 45;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cobros_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Cobros_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.Cobros_PL_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cobros)).EndInit();
            this.grp_FormaPago.ResumeLayout(false);
            this.grp_FormaPago.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_FormaPago;
        private System.Windows.Forms.RadioButton rdb_Efectivo;
        private System.Windows.Forms.RadioButton rdb_Tarjeta;
        private System.Windows.Forms.Button btn_Imprimir;
        public System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtg_Cobros;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Cambio;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_NoCliente;
        public System.Windows.Forms.TextBox txt_Fecha_Doc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Factura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Button btn_Buscar;
        public System.Windows.Forms.TextBox txt_Pago;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox1;
    }
}