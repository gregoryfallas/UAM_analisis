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
            this.EliminarCitabtn = new System.Windows.Forms.Button();
            this.ModificarCitabtn = new System.Windows.Forms.Button();
            this.AgregarCitabtn = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Clientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscarClientebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Clientetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reprogramarCitabtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.comboBox3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(138, 182);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 31);
            this.comboBox3.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.comboBox2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 23;
            this.comboBox2.Location = new System.Drawing.Point(138, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 31);
            this.comboBox2.TabIndex = 31;
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.reprogramarCitabtn);
            this.Clientes.Controls.Add(this.dataGridView1);
            this.Clientes.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.Clientes.Location = new System.Drawing.Point(37, 336);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(948, 239);
            this.Clientes.TabIndex = 30;
            this.Clientes.TabStop = false;
            this.Clientes.Text = "Citas Programadas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 186);
            this.dataGridView1.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.comboBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 31);
            this.comboBox1.TabIndex = 27;
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
            // Clientetxt
            // 
            this.Clientetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.Clientetxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientetxt.ForeColor = System.Drawing.Color.White;
            this.Clientetxt.Location = new System.Drawing.Point(138, 82);
            this.Clientetxt.Name = "Clientetxt";
            this.Clientetxt.Size = new System.Drawing.Size(161, 26);
            this.Clientetxt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(407, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Día";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hora Inicio";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.monthCalendar1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(510, 132);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Transparent;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Motivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Clientes);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Clientetxt);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
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
            // reprogramarCitabtn
            // 
            this.reprogramarCitabtn.BackgroundImage = global::PL.Properties.Resources.compras2;
            this.reprogramarCitabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reprogramarCitabtn.FlatAppearance.BorderSize = 0;
            this.reprogramarCitabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reprogramarCitabtn.Location = new System.Drawing.Point(873, 54);
            this.reprogramarCitabtn.Name = "reprogramarCitabtn";
            this.reprogramarCitabtn.Size = new System.Drawing.Size(40, 35);
            this.reprogramarCitabtn.TabIndex = 1;
            this.reprogramarCitabtn.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Clientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buscarClientebtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Clientetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button EliminarCitabtn;
        private System.Windows.Forms.Button ModificarCitabtn;
        private System.Windows.Forms.Button AgregarCitabtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reprogramarCitabtn;
    }
}