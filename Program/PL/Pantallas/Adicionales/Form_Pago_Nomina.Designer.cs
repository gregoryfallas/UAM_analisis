namespace PL.Pantallas.Adicionales
{
    partial class Form_Pago_Nomina
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 515);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNóminaToolStripMenuItem,
            this.buscarNóminaToolStripMenuItem,
            this.ingresoDeMarcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearNóminaToolStripMenuItem
            // 
            this.crearNóminaToolStripMenuItem.Name = "crearNóminaToolStripMenuItem";
            this.crearNóminaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.crearNóminaToolStripMenuItem.Text = "Crear Nómina";
            this.crearNóminaToolStripMenuItem.Click += new System.EventHandler(this.crearNóminaToolStripMenuItem_Click);
            // 
            // buscarNóminaToolStripMenuItem
            // 
            this.buscarNóminaToolStripMenuItem.Name = "buscarNóminaToolStripMenuItem";
            this.buscarNóminaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.buscarNóminaToolStripMenuItem.Text = "Buscar Nómina";
            this.buscarNóminaToolStripMenuItem.Click += new System.EventHandler(this.buscarNóminaToolStripMenuItem_Click);
            // 
            // ingresoDeMarcasToolStripMenuItem
            // 
            this.ingresoDeMarcasToolStripMenuItem.Name = "ingresoDeMarcasToolStripMenuItem";
            this.ingresoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.ingresoDeMarcasToolStripMenuItem.Text = "Ingreso de Marcas";
            this.ingresoDeMarcasToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeMarcasToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 515);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 41);
            this.button4.TabIndex = 16;
            this.button4.Text = "Inicio";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form_Pago_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Pago_Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Pago de Nomina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}