namespace PL.Pantallas.Adicionales
{
    partial class Frm_Control_Suministros_PL
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid_controlmeosdediez = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridV_controlsuministros = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_controlmeosdediez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_controlsuministros)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGrid_controlmeosdediez);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dataGridV_controlsuministros);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 475);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid_controlmeosdediez
            // 
            this.dataGrid_controlmeosdediez.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dataGrid_controlmeosdediez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_controlmeosdediez.Location = new System.Drawing.Point(431, 65);
            this.dataGrid_controlmeosdediez.Name = "dataGrid_controlmeosdediez";
            this.dataGrid_controlmeosdediez.Size = new System.Drawing.Size(269, 341);
            this.dataGrid_controlmeosdediez.TabIndex = 131;
            this.dataGrid_controlmeosdediez.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_controlmeosdediez_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(481, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 20);
            this.label16.TabIndex = 130;
            this.label16.Text = "Menos de 10 unidades";
            // 
            // dataGridV_controlsuministros
            // 
            this.dataGridV_controlsuministros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dataGridV_controlsuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_controlsuministros.Location = new System.Drawing.Point(33, 65);
            this.dataGridV_controlsuministros.Name = "dataGridV_controlsuministros";
            this.dataGridV_controlsuministros.Size = new System.Drawing.Size(364, 341);
            this.dataGridV_controlsuministros.TabIndex = 127;
            this.dataGridV_controlsuministros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridV_controlsuministros_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(144, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 104;
            this.label5.Text = "Control Totales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(748, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 475);
            this.panel2.TabIndex = 1;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Location = new System.Drawing.Point(23, 428);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(117, 35);
            this.btn_Inicio.TabIndex = 45;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // Frm_Control_Suministros_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Control_Suministros_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Suministros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_controlmeosdediez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_controlsuministros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_controlmeosdediez;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridV_controlsuministros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button button1;
    }
}