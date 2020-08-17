namespace PL.Pantallas.Extras
{
    partial class Frm_Cajas_PL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_AbrirCaja = new System.Windows.Forms.Button();
            this.btn_CerrarCaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 586);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_AbrirCaja);
            this.groupBox1.Controls.Add(this.btn_CerrarCaja);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(158, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 406);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(772, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 586);
            this.panel2.TabIndex = 1;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_inicio.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(44, 511);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(92, 41);
            this.btn_inicio.TabIndex = 12;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_AbrirCaja
            // 
            this.btn_AbrirCaja.FlatAppearance.BorderSize = 0;
            this.btn_AbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirCaja.ForeColor = System.Drawing.Color.Black;
            this.btn_AbrirCaja.Image = global::PL.Properties.Resources.abierto;
            this.btn_AbrirCaja.Location = new System.Drawing.Point(192, 51);
            this.btn_AbrirCaja.Name = "btn_AbrirCaja";
            this.btn_AbrirCaja.Size = new System.Drawing.Size(208, 143);
            this.btn_AbrirCaja.TabIndex = 0;
            this.btn_AbrirCaja.UseVisualStyleBackColor = true;
            this.btn_AbrirCaja.Click += new System.EventHandler(this.btn_AbrirCaja_Click);
            // 
            // btn_CerrarCaja
            // 
            this.btn_CerrarCaja.FlatAppearance.BorderSize = 0;
            this.btn_CerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarCaja.ForeColor = System.Drawing.Color.Black;
            this.btn_CerrarCaja.Image = global::PL.Properties.Resources.cerrado;
            this.btn_CerrarCaja.Location = new System.Drawing.Point(192, 222);
            this.btn_CerrarCaja.Name = "btn_CerrarCaja";
            this.btn_CerrarCaja.Size = new System.Drawing.Size(184, 133);
            this.btn_CerrarCaja.TabIndex = 1;
            this.btn_CerrarCaja.UseVisualStyleBackColor = true;
            this.btn_CerrarCaja.Click += new System.EventHandler(this.btn_CerrarCaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Abrir Cajas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cerrar Cajas:";
            // 
            // Frm_Cajas_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Cajas_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAJAS";
            this.Load += new System.EventHandler(this.Frm_Cajas_PL_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_CerrarCaja;
        private System.Windows.Forms.Button btn_AbrirCaja;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}