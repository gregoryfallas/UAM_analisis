﻿namespace PL.Pantallas.Adicionales
{
    partial class Frm_Animal_PL
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AgregarTipoMascotabtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarAnimalbtn = new System.Windows.Forms.Button();
            this.mascotalbl = new System.Windows.Forms.Label();
            this.buscarAnimaltxt = new System.Windows.Forms.TextBox();
            this.animaltxt = new System.Windows.Forms.TextBox();
            this.tipoAnimaltxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CedulaClienteBusquedabtn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarUsuario = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.razaAnimaltxt = new System.Windows.Forms.TextBox();
            this.buscarClientebtn = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_inicio);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 749);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(945, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 41);
            this.button2.TabIndex = 35;
            this.button2.Text = "Inicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(489, 213);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 12;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btn_Agregar);
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 749);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AgregarTipoMascotabtn);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buscarAnimalbtn);
            this.groupBox3.Controls.Add(this.mascotalbl);
            this.groupBox3.Controls.Add(this.buscarAnimaltxt);
            this.groupBox3.Controls.Add(this.animaltxt);
            this.groupBox3.Controls.Add(this.tipoAnimaltxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(56, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 320);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mascota";
            // 
            // AgregarTipoMascotabtn
            // 
            this.AgregarTipoMascotabtn.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.AgregarTipoMascotabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarTipoMascotabtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.AgregarTipoMascotabtn.FlatAppearance.BorderSize = 0;
            this.AgregarTipoMascotabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarTipoMascotabtn.Location = new System.Drawing.Point(282, 150);
            this.AgregarTipoMascotabtn.Name = "AgregarTipoMascotabtn";
            this.AgregarTipoMascotabtn.Size = new System.Drawing.Size(30, 28);
            this.AgregarTipoMascotabtn.TabIndex = 40;
            this.AgregarTipoMascotabtn.UseVisualStyleBackColor = true;
            this.AgregarTipoMascotabtn.Click += new System.EventHandler(this.AgregarTipoMascotabtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(32, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 87);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 27);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hembra";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(54, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 27);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Macho";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // buscarAnimalbtn
            // 
            this.buscarAnimalbtn.BackgroundImage = global::PL.Properties.Resources.search;
            this.buscarAnimalbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarAnimalbtn.FlatAppearance.BorderSize = 0;
            this.buscarAnimalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarAnimalbtn.Location = new System.Drawing.Point(729, 38);
            this.buscarAnimalbtn.Name = "buscarAnimalbtn";
            this.buscarAnimalbtn.Size = new System.Drawing.Size(31, 27);
            this.buscarAnimalbtn.TabIndex = 32;
            this.buscarAnimalbtn.UseVisualStyleBackColor = true;
            // 
            // mascotalbl
            // 
            this.mascotalbl.AutoSize = true;
            this.mascotalbl.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascotalbl.ForeColor = System.Drawing.Color.White;
            this.mascotalbl.Location = new System.Drawing.Point(504, 41);
            this.mascotalbl.Name = "mascotalbl";
            this.mascotalbl.Size = new System.Drawing.Size(79, 23);
            this.mascotalbl.TabIndex = 33;
            this.mascotalbl.Text = "Id Mascota";
            this.mascotalbl.Click += new System.EventHandler(this.mascotalbl_Click);
            // 
            // buscarAnimaltxt
            // 
            this.buscarAnimaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.buscarAnimaltxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarAnimaltxt.ForeColor = System.Drawing.Color.White;
            this.buscarAnimaltxt.Location = new System.Drawing.Point(589, 38);
            this.buscarAnimaltxt.Name = "buscarAnimaltxt";
            this.buscarAnimaltxt.Size = new System.Drawing.Size(134, 26);
            this.buscarAnimaltxt.TabIndex = 31;
            // 
            // animaltxt
            // 
            this.animaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.animaltxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animaltxt.ForeColor = System.Drawing.Color.White;
            this.animaltxt.Location = new System.Drawing.Point(106, 58);
            this.animaltxt.Name = "animaltxt";
            this.animaltxt.Size = new System.Drawing.Size(170, 26);
            this.animaltxt.TabIndex = 21;
            // 
            // tipoAnimaltxt
            // 
            this.tipoAnimaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tipoAnimaltxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoAnimaltxt.ForeColor = System.Drawing.Color.White;
            this.tipoAnimaltxt.Location = new System.Drawing.Point(106, 104);
            this.tipoAnimaltxt.Name = "tipoAnimaltxt";
            this.tipoAnimaltxt.Size = new System.Drawing.Size(170, 26);
            this.tipoAnimaltxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Raza";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 213);
            this.dataGridView1.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.comboBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 31);
            this.comboBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de animal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CedulaClienteBusquedabtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AgregarUsuario);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.razaAnimaltxt);
            this.groupBox1.Controls.Add(this.buscarClientebtn);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(56, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 224);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Responsable";
            // 
            // CedulaClienteBusquedabtn
            // 
            this.CedulaClienteBusquedabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.CedulaClienteBusquedabtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaClienteBusquedabtn.ForeColor = System.Drawing.Color.White;
            this.CedulaClienteBusquedabtn.Location = new System.Drawing.Point(589, 40);
            this.CedulaClienteBusquedabtn.Name = "CedulaClienteBusquedabtn";
            this.CedulaClienteBusquedabtn.Size = new System.Drawing.Size(134, 26);
            this.CedulaClienteBusquedabtn.TabIndex = 42;
            this.CedulaClienteBusquedabtn.TextChanged += new System.EventHandler(this.CedulaClienteBusquedabtn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(484, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cédula Cliente";
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.AgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarUsuario.FlatAppearance.BorderSize = 0;
            this.AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarUsuario.Location = new System.Drawing.Point(282, 66);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Size = new System.Drawing.Size(30, 26);
            this.AgregarUsuario.TabIndex = 29;
            this.AgregarUsuario.UseVisualStyleBackColor = true;
            this.AgregarUsuario.Click += new System.EventHandler(this.AgregarUsuario_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(430, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(330, 105);
            this.dataGridView2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(106, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 26);
            this.textBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cliente";
            // 
            // razaAnimaltxt
            // 
            this.razaAnimaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.razaAnimaltxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razaAnimaltxt.ForeColor = System.Drawing.Color.White;
            this.razaAnimaltxt.Location = new System.Drawing.Point(106, 66);
            this.razaAnimaltxt.Name = "razaAnimaltxt";
            this.razaAnimaltxt.Size = new System.Drawing.Size(170, 26);
            this.razaAnimaltxt.TabIndex = 23;
            // 
            // buscarClientebtn
            // 
            this.buscarClientebtn.BackgroundImage = global::PL.Properties.Resources.search;
            this.buscarClientebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarClientebtn.FlatAppearance.BorderSize = 0;
            this.buscarClientebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarClientebtn.Location = new System.Drawing.Point(729, 40);
            this.buscarClientebtn.Name = "buscarClientebtn";
            this.buscarClientebtn.Size = new System.Drawing.Size(31, 26);
            this.buscarClientebtn.TabIndex = 25;
            this.buscarClientebtn.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(91, 644);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(54, 42);
            this.btn_Agregar.TabIndex = 27;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::PL.Properties.Resources.cancelar;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(318, 642);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(50, 46);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PL.Properties.Resources.editar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Location = new System.Drawing.Point(207, 644);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(60, 42);
            this.btn_Modificar.TabIndex = 28;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Frm_Animal_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Animal_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animales";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mascotalbl;
        private System.Windows.Forms.Button buscarAnimalbtn;
        private System.Windows.Forms.TextBox buscarAnimaltxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tipoAnimaltxt;
        private System.Windows.Forms.TextBox animaltxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox razaAnimaltxt;
        private System.Windows.Forms.Button buscarClientebtn;
        private System.Windows.Forms.Button AgregarUsuario;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CedulaClienteBusquedabtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AgregarTipoMascotabtn;
    }
}