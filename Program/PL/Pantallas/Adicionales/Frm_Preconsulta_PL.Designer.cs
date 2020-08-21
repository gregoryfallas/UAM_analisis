namespace PL.Pantallas.Adicionales
{
    partial class Frm_Preconsulta_PL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarRecetabtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edadtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tamaniotxt = new System.Windows.Forms.TextBox();
            this.pesotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.observacionestxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.btn_Inicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(843, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 643);
            this.panel1.TabIndex = 1;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Location = new System.Drawing.Point(37, 533);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(117, 35);
            this.btn_Inicio.TabIndex = 45;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 643);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AgregarRecetabtn);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.observacionestxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(32, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 534);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 31;
            this.label1.Text = "PreConsulta";
            // 
            // AgregarRecetabtn
            // 
            this.AgregarRecetabtn.BackgroundImage = global::PL.Properties.Resources.Guardar;
            this.AgregarRecetabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarRecetabtn.FlatAppearance.BorderSize = 0;
            this.AgregarRecetabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarRecetabtn.Location = new System.Drawing.Point(82, 433);
            this.AgregarRecetabtn.Name = "AgregarRecetabtn";
            this.AgregarRecetabtn.Size = new System.Drawing.Size(42, 36);
            this.AgregarRecetabtn.TabIndex = 23;
            this.AgregarRecetabtn.UseVisualStyleBackColor = true;
            this.AgregarRecetabtn.Click += new System.EventHandler(this.AgregarRecetabtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edadtxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nombretxt);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tamaniotxt);
            this.groupBox1.Controls.Add(this.pesotxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 300);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mascota";
            // 
            // edadtxt
            // 
            this.edadtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.edadtxt.ForeColor = System.Drawing.Color.White;
            this.edadtxt.Location = new System.Drawing.Point(102, 126);
            this.edadtxt.Name = "edadtxt";
            this.edadtxt.Size = new System.Drawing.Size(133, 26);
            this.edadtxt.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Id";
            // 
            // nombretxt
            // 
            this.nombretxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.nombretxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.ForeColor = System.Drawing.Color.White;
            this.nombretxt.Location = new System.Drawing.Point(102, 87);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(133, 26);
            this.nombretxt.TabIndex = 27;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.idtxt.ForeColor = System.Drawing.Color.White;
            this.idtxt.Location = new System.Drawing.Point(102, 48);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(133, 26);
            this.idtxt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Peso";
            // 
            // tamaniotxt
            // 
            this.tamaniotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tamaniotxt.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamaniotxt.ForeColor = System.Drawing.Color.White;
            this.tamaniotxt.Location = new System.Drawing.Point(102, 216);
            this.tamaniotxt.Name = "tamaniotxt";
            this.tamaniotxt.Size = new System.Drawing.Size(115, 25);
            this.tamaniotxt.TabIndex = 18;
            // 
            // pesotxt
            // 
            this.pesotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.pesotxt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesotxt.ForeColor = System.Drawing.Color.White;
            this.pesotxt.Location = new System.Drawing.Point(102, 169);
            this.pesotxt.Name = "pesotxt";
            this.pesotxt.Size = new System.Drawing.Size(133, 26);
            this.pesotxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 31);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(427, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Citas por Atender";
            // 
            // observacionestxt
            // 
            this.observacionestxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.observacionestxt.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionestxt.ForeColor = System.Drawing.Color.White;
            this.observacionestxt.Location = new System.Drawing.Point(431, 229);
            this.observacionestxt.Multiline = true;
            this.observacionestxt.Name = "observacionestxt";
            this.observacionestxt.Size = new System.Drawing.Size(328, 109);
            this.observacionestxt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(427, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Observaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(431, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(328, 79);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Frm_Preconsulta_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Preconsulta_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preconsulta";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox observacionestxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tamaniotxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pesotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button AgregarRecetabtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edadtxt;
        private System.Windows.Forms.Label label9;
    }
}