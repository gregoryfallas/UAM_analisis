namespace PL.Pantallas.Adicionales
{
    partial class Form_Consultar_Pruebas_Participantes
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.dgvpruebas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpruebas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 353);
            this.panel3.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmostrar);
            this.groupBox1.Controls.Add(this.dgvpruebas);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 312);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Pruebas de los Participantes";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.ForeColor = System.Drawing.Color.Black;
            this.btnmostrar.Location = new System.Drawing.Point(27, 53);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(126, 37);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar ";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // dgvpruebas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpruebas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpruebas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpruebas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpruebas.Location = new System.Drawing.Point(27, 96);
            this.dgvpruebas.Name = "dgvpruebas";
            this.dgvpruebas.Size = new System.Drawing.Size(451, 184);
            this.dgvpruebas.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(564, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 353);
            this.panel2.TabIndex = 39;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 41);
            this.button4.TabIndex = 43;
            this.button4.Text = "Atrás";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Consultar_Pruebas_Participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Consultar_Pruebas_Participantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpruebas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.DataGridView dgvpruebas;
        private System.Windows.Forms.Button button4;
    }
}