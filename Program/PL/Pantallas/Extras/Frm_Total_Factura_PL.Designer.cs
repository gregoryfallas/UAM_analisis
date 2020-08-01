namespace PL.Pantallas.Extras
{
    partial class Frm_Total_Factura_PL
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
            this.gpb_Factura = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cambio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Factura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.Imprimir = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.gpb_Factura.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.gpb_Factura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 424);
            this.panel1.TabIndex = 0;
            // 
            // gpb_Factura
            // 
            this.gpb_Factura.Controls.Add(this.label1);
            this.gpb_Factura.Controls.Add(this.txt_Cambio);
            this.gpb_Factura.Controls.Add(this.label2);
            this.gpb_Factura.Controls.Add(this.txt_Monto);
            this.gpb_Factura.Controls.Add(this.label3);
            this.gpb_Factura.Controls.Add(this.txt_Total);
            this.gpb_Factura.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Factura.ForeColor = System.Drawing.Color.White;
            this.gpb_Factura.Location = new System.Drawing.Point(31, 24);
            this.gpb_Factura.Name = "gpb_Factura";
            this.gpb_Factura.Size = new System.Drawing.Size(332, 357);
            this.gpb_Factura.TabIndex = 6;
            this.gpb_Factura.TabStop = false;
            this.gpb_Factura.Text = "Total Facturación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Factura";
            // 
            // txt_Cambio
            // 
            this.txt_Cambio.Location = new System.Drawing.Point(69, 299);
            this.txt_Cambio.Name = "txt_Cambio";
            this.txt_Cambio.ReadOnly = true;
            this.txt_Cambio.Size = new System.Drawing.Size(208, 30);
            this.txt_Cambio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto de Pago";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(69, 196);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(208, 30);
            this.txt_Monto.TabIndex = 4;
            this.txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cambio";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(69, 97);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(208, 30);
            this.txt_Total.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.txt_Factura);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_Imprimir);
            this.panel2.Controls.Add(this.btn_Confirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(390, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 424);
            this.panel2.TabIndex = 1;
            // 
            // txt_Factura
            // 
            this.txt_Factura.Location = new System.Drawing.Point(15, 46);
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.ReadOnly = true;
            this.txt_Factura.Size = new System.Drawing.Size(100, 20);
            this.txt_Factura.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "#Factura";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackgroundImage = global::PL.Properties.Resources.print;
            this.btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Location = new System.Drawing.Point(32, 355);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 57);
            this.btn_Imprimir.TabIndex = 4;
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackgroundImage = global::PL.Properties.Resources.confirmar;
            this.btn_Confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Location = new System.Drawing.Point(44, 270);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(56, 51);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // Imprimir
            // 
            this.Imprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir_PrintPage);
            // 
            // Frm_Total_Factura_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Total_Factura_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Factura";
            this.Load += new System.EventHandler(this.Frm_Total_Factura_PL_Load);
            this.panel1.ResumeLayout(false);
            this.gpb_Factura.ResumeLayout(false);
            this.gpb_Factura.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cambio;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.GroupBox gpb_Factura;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.TextBox txt_Factura;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument Imprimir;
    }
}