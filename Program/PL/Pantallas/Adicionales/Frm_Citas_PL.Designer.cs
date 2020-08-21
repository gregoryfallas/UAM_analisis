namespace PL.Pantallas.Adicionales
{
    partial class Frm_Citas_PL
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
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_HoraFin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_HoraIn = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_NombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clientes = new System.Windows.Forms.GroupBox();
            this.reprogramarCitabtn = new System.Windows.Forms.Button();
            this.dgv_Citas1 = new System.Windows.Forms.DataGridView();
            this.cbx_Motivo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cedula_Cliente = new System.Windows.Forms.TextBox();
            this.cbx_Macotas = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Consultorio = new System.Windows.Forms.ComboBox();
            this.buscarClientebtn = new System.Windows.Forms.Button();
            this.EliminarCitabtn = new System.Windows.Forms.Button();
            this.ModificarCitabtn = new System.Windows.Forms.Button();
            this.AgregarCitabtn = new System.Windows.Forms.Button();
            this.labal_Cancelar_Cita = new System.Windows.Forms.LinkLabel();
            this.label_Activar_Cita = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.btn_inicio);
            this.panel1.Location = new System.Drawing.Point(1077, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 752);
            this.panel1.TabIndex = 1;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(28, 648);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 12;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.EliminarCitabtn);
            this.panel2.Controls.Add(this.ModificarCitabtn);
            this.panel2.Controls.Add(this.AgregarCitabtn);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 751);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_HoraFin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbx_HoraIn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_NombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Clientes);
            this.groupBox1.Controls.Add(this.cbx_Motivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Cedula_Cliente);
            this.groupBox1.Controls.Add(this.cbx_Macotas);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_Consultorio);
            this.groupBox1.Controls.Add(this.buscarClientebtn);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 594);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas";
            // 
            // cbx_HoraFin
            // 
            this.cbx_HoraFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.cbx_HoraFin.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_HoraFin.ForeColor = System.Drawing.Color.White;
            this.cbx_HoraFin.FormattingEnabled = true;
            this.cbx_HoraFin.Location = new System.Drawing.Point(417, 233);
            this.cbx_HoraFin.Name = "cbx_HoraFin";
            this.cbx_HoraFin.Size = new System.Drawing.Size(161, 31);
            this.cbx_HoraFin.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(335, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hora Fin";
            // 
            // cbx_HoraIn
            // 
            this.cbx_HoraIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.cbx_HoraIn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_HoraIn.ForeColor = System.Drawing.Color.White;
            this.cbx_HoraIn.FormattingEnabled = true;
            this.cbx_HoraIn.Location = new System.Drawing.Point(417, 185);
            this.cbx_HoraIn.Name = "cbx_HoraIn";
            this.cbx_HoraIn.Size = new System.Drawing.Size(161, 31);
            this.cbx_HoraIn.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(335, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Hora Inicio";
            // 
            // lb_NombreCliente
            // 
            this.lb_NombreCliente.AutoSize = true;
            this.lb_NombreCliente.Location = new System.Drawing.Point(370, 74);
            this.lb_NombreCliente.Name = "lb_NombreCliente";
            this.lb_NombreCliente.Size = new System.Drawing.Size(0, 38);
            this.lb_NombreCliente.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mascota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cédula Cliente";
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.label_Activar_Cita);
            this.Clientes.Controls.Add(this.labal_Cancelar_Cita);
            this.Clientes.Controls.Add(this.reprogramarCitabtn);
            this.Clientes.Controls.Add(this.dgv_Citas1);
            this.Clientes.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.Clientes.Location = new System.Drawing.Point(37, 302);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(994, 273);
            this.Clientes.TabIndex = 30;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Citas Programadas";
            // 
            // reprogramarCitabtn
            // 
            this.reprogramarCitabtn.BackgroundImage = global::PL.Properties.Resources.compras2;
            this.reprogramarCitabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reprogramarCitabtn.FlatAppearance.BorderSize = 0;
            this.reprogramarCitabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reprogramarCitabtn.Location = new System.Drawing.Point(879, 170);
            this.reprogramarCitabtn.Name = "reprogramarCitabtn";
            this.reprogramarCitabtn.Size = new System.Drawing.Size(40, 35);
            this.reprogramarCitabtn.TabIndex = 1;
            this.reprogramarCitabtn.UseVisualStyleBackColor = true;
            this.reprogramarCitabtn.Click += new System.EventHandler(this.reprogramarCitabtn_Click);
            // 
            // dgv_Citas1
            // 
            this.dgv_Citas1.AllowUserToAddRows = false;
            this.dgv_Citas1.AllowUserToDeleteRows = false;
            this.dgv_Citas1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.dgv_Citas1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Citas1.Location = new System.Drawing.Point(15, 41);
            this.dgv_Citas1.Name = "dgv_Citas1";
            this.dgv_Citas1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Citas1.Size = new System.Drawing.Size(834, 186);
            this.dgv_Citas1.TabIndex = 0;
            // 
            // cbx_Motivo
            // 
            this.cbx_Motivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.cbx_Motivo.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Motivo.ForeColor = System.Drawing.Color.White;
            this.cbx_Motivo.FormattingEnabled = true;
            this.cbx_Motivo.Location = new System.Drawing.Point(138, 185);
            this.cbx_Motivo.Name = "cbx_Motivo";
            this.cbx_Motivo.Size = new System.Drawing.Size(161, 31);
            this.cbx_Motivo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(703, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Día";
            // 
            // txt_Cedula_Cliente
            // 
            this.txt_Cedula_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cedula_Cliente.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula_Cliente.ForeColor = System.Drawing.Color.White;
            this.txt_Cedula_Cliente.Location = new System.Drawing.Point(138, 82);
            this.txt_Cedula_Cliente.Name = "txt_Cedula_Cliente";
            this.txt_Cedula_Cliente.Size = new System.Drawing.Size(161, 26);
            this.txt_Cedula_Cliente.TabIndex = 24;
            // 
            // cbx_Macotas
            // 
            this.cbx_Macotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.cbx_Macotas.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Macotas.ForeColor = System.Drawing.Color.White;
            this.cbx_Macotas.FormattingEnabled = true;
            this.cbx_Macotas.ItemHeight = 23;
            this.cbx_Macotas.Location = new System.Drawing.Point(138, 129);
            this.cbx_Macotas.Name = "cbx_Macotas";
            this.cbx_Macotas.Size = new System.Drawing.Size(161, 31);
            this.cbx_Macotas.TabIndex = 31;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(758, 116);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Consultorio";
            // 
            // cbx_Consultorio
            // 
            this.cbx_Consultorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.cbx_Consultorio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Consultorio.FormattingEnabled = true;
            this.cbx_Consultorio.Location = new System.Drawing.Point(138, 233);
            this.cbx_Consultorio.Name = "cbx_Consultorio";
            this.cbx_Consultorio.Size = new System.Drawing.Size(161, 31);
            this.cbx_Consultorio.TabIndex = 27;
            // 
            // buscarClientebtn
            // 
            this.buscarClientebtn.BackgroundImage = global::PL.Properties.Resources.search;
            this.buscarClientebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarClientebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarClientebtn.ForeColor = System.Drawing.Color.Gray;
            this.buscarClientebtn.Location = new System.Drawing.Point(305, 79);
            this.buscarClientebtn.Name = "buscarClientebtn";
            this.buscarClientebtn.Size = new System.Drawing.Size(41, 29);
            this.buscarClientebtn.TabIndex = 28;
            this.buscarClientebtn.UseVisualStyleBackColor = true;
            this.buscarClientebtn.Click += new System.EventHandler(this.buscarClientebtn_Click);
            // 
            // EliminarCitabtn
            // 
            this.EliminarCitabtn.BackgroundImage = global::PL.Properties.Resources.cancelar;
            this.EliminarCitabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EliminarCitabtn.FlatAppearance.BorderSize = 0;
            this.EliminarCitabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCitabtn.Location = new System.Drawing.Point(636, 668);
            this.EliminarCitabtn.Name = "EliminarCitabtn";
            this.EliminarCitabtn.Size = new System.Drawing.Size(47, 44);
            this.EliminarCitabtn.TabIndex = 35;
            this.EliminarCitabtn.UseVisualStyleBackColor = true;
            // 
            // ModificarCitabtn
            // 
            this.ModificarCitabtn.BackgroundImage = global::PL.Properties.Resources.editar;
            this.ModificarCitabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModificarCitabtn.FlatAppearance.BorderSize = 0;
            this.ModificarCitabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarCitabtn.Location = new System.Drawing.Point(475, 668);
            this.ModificarCitabtn.Name = "ModificarCitabtn";
            this.ModificarCitabtn.Size = new System.Drawing.Size(56, 50);
            this.ModificarCitabtn.TabIndex = 34;
            this.ModificarCitabtn.UseVisualStyleBackColor = true;
            this.ModificarCitabtn.Click += new System.EventHandler(this.ModificarCitabtn_Click);
            // 
            // AgregarCitabtn
            // 
            this.AgregarCitabtn.BackgroundImage = global::PL.Properties.Resources.Guardar;
            this.AgregarCitabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarCitabtn.FlatAppearance.BorderSize = 0;
            this.AgregarCitabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarCitabtn.Location = new System.Drawing.Point(325, 674);
            this.AgregarCitabtn.Name = "AgregarCitabtn";
            this.AgregarCitabtn.Size = new System.Drawing.Size(54, 38);
            this.AgregarCitabtn.TabIndex = 33;
            this.AgregarCitabtn.UseVisualStyleBackColor = true;
            // 
            // labal_Cancelar_Cita
            // 
            this.labal_Cancelar_Cita.AutoSize = true;
            this.labal_Cancelar_Cita.LinkColor = System.Drawing.Color.White;
            this.labal_Cancelar_Cita.Location = new System.Drawing.Point(875, 122);
            this.labal_Cancelar_Cita.Name = "labal_Cancelar_Cita";
            this.labal_Cancelar_Cita.Size = new System.Drawing.Size(93, 23);
            this.labal_Cancelar_Cita.TabIndex = 2;
            this.labal_Cancelar_Cita.TabStop = true;
            this.labal_Cancelar_Cita.Text = "Cancelar Cita";
            this.labal_Cancelar_Cita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labal_Cancelar_Cita_LinkClicked);
            // 
            // label_Activar_Cita
            // 
            this.label_Activar_Cita.AutoSize = true;
            this.label_Activar_Cita.LinkColor = System.Drawing.Color.White;
            this.label_Activar_Cita.Location = new System.Drawing.Point(875, 70);
            this.label_Activar_Cita.Name = "label_Activar_Cita";
            this.label_Activar_Cita.Size = new System.Drawing.Size(80, 23);
            this.label_Activar_Cita.TabIndex = 3;
            this.label_Activar_Cita.TabStop = true;
            this.label_Activar_Cita.Text = "Activar Cita";
            this.label_Activar_Cita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_Activar_Cita_LinkClicked);
            // 
            // Frm_Citas_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Citas_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Frm_Citas_PL_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dgv_Citas1;
        private System.Windows.Forms.Button buscarClientebtn;
        private System.Windows.Forms.ComboBox cbx_Consultorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cedula_Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.ComboBox cbx_Motivo;
        private System.Windows.Forms.ComboBox cbx_Macotas;
        private System.Windows.Forms.Button EliminarCitabtn;
        private System.Windows.Forms.Button ModificarCitabtn;
        private System.Windows.Forms.Button AgregarCitabtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reprogramarCitabtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_NombreCliente;
        private System.Windows.Forms.ComboBox cbx_HoraIn;
        private System.Windows.Forms.ComboBox cbx_HoraFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel label_Activar_Cita;
        private System.Windows.Forms.LinkLabel labal_Cancelar_Cita;
    }
}