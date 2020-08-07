namespace PL.Pantallas.Extras
{
    partial class Frm_TipoAnimal_PL
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AgregarTipobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(350, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 187);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textBox1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(108, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 2;
            // 
            // AgregarTipobtn
            // 
            this.AgregarTipobtn.BackgroundImage = global::PL.Properties.Resources.Guardar;
            this.AgregarTipobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarTipobtn.FlatAppearance.BorderSize = 0;
            this.AgregarTipobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarTipobtn.Location = new System.Drawing.Point(169, 108);
            this.AgregarTipobtn.Name = "AgregarTipobtn";
            this.AgregarTipobtn.Size = new System.Drawing.Size(32, 25);
            this.AgregarTipobtn.TabIndex = 3;
            this.AgregarTipobtn.UseVisualStyleBackColor = true;
            this.AgregarTipobtn.Click += new System.EventHandler(this.AgregarTipobtn_Click);
            // 
            // Frm_TipoAnimal_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(408, 181);
            this.Controls.Add(this.AgregarTipobtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TipoAnimal_PL";
            this.Text = "Frm_TipoAnimal_PL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AgregarTipobtn;
    }
}