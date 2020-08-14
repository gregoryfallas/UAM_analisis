namespace PL.Pantallas.Adicionales
{
    partial class Form_Menu_Personal
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
            this.creaciónDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaciónDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 525);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciónDePersonalToolStripMenuItem,
            this.creaciónDeUsuariosToolStripMenuItem,
            this.creaciónDeRolesToolStripMenuItem,
            this.consultaDeRolesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creaciónDePersonalToolStripMenuItem
            // 
            this.creaciónDePersonalToolStripMenuItem.Name = "creaciónDePersonalToolStripMenuItem";
            this.creaciónDePersonalToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.creaciónDePersonalToolStripMenuItem.Text = "Creación de Personal";
            this.creaciónDePersonalToolStripMenuItem.Click += new System.EventHandler(this.creaciónDePersonalToolStripMenuItem_Click);
            // 
            // creaciónDeUsuariosToolStripMenuItem
            // 
            this.creaciónDeUsuariosToolStripMenuItem.Name = "creaciónDeUsuariosToolStripMenuItem";
            this.creaciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.creaciónDeUsuariosToolStripMenuItem.Text = "Creación de Usuarios";
            this.creaciónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.creaciónDeUsuariosToolStripMenuItem_Click);
            // 
            // creaciónDeRolesToolStripMenuItem
            // 
            this.creaciónDeRolesToolStripMenuItem.Name = "creaciónDeRolesToolStripMenuItem";
            this.creaciónDeRolesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.creaciónDeRolesToolStripMenuItem.Text = "Creación de Roles";
            this.creaciónDeRolesToolStripMenuItem.Click += new System.EventHandler(this.creaciónDeRolesToolStripMenuItem_Click);
            // 
            // consultaDeRolesToolStripMenuItem
            // 
            this.consultaDeRolesToolStripMenuItem.Name = "consultaDeRolesToolStripMenuItem";
            this.consultaDeRolesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.consultaDeRolesToolStripMenuItem.Text = "Consulta de Roles";
            this.consultaDeRolesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeRolesToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(756, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 525);
            this.panel2.TabIndex = 2;
            // 
            // Form_Menu_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Menu_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Personal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creaciónDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaciónDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeRolesToolStripMenuItem;
    }
}