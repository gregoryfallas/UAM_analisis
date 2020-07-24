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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCreacionRoles = new System.Windows.Forms.Button();
            this.btnConsultaRoles = new System.Windows.Forms.Button();
            this.btnCreacionPersonal = new System.Windows.Forms.Button();
            this.btnCreacionUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btninicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 180);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.btnCreacionRoles);
            this.panel3.Controls.Add(this.btnConsultaRoles);
            this.panel3.Controls.Add(this.btnCreacionPersonal);
            this.panel3.Controls.Add(this.btnCreacionUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 180);
            this.panel3.TabIndex = 40;
            // 
            // btnCreacionRoles
            // 
            this.btnCreacionRoles.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacionRoles.Location = new System.Drawing.Point(27, 93);
            this.btnCreacionRoles.Name = "btnCreacionRoles";
            this.btnCreacionRoles.Size = new System.Drawing.Size(90, 56);
            this.btnCreacionRoles.TabIndex = 41;
            this.btnCreacionRoles.Text = "Creación de Roles";
            this.btnCreacionRoles.UseVisualStyleBackColor = true;
            this.btnCreacionRoles.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnConsultaRoles
            // 
            this.btnConsultaRoles.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaRoles.Location = new System.Drawing.Point(123, 93);
            this.btnConsultaRoles.Name = "btnConsultaRoles";
            this.btnConsultaRoles.Size = new System.Drawing.Size(90, 56);
            this.btnConsultaRoles.TabIndex = 40;
            this.btnConsultaRoles.Text = "Consulta de Roles";
            this.btnConsultaRoles.UseVisualStyleBackColor = true;
            this.btnConsultaRoles.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCreacionPersonal
            // 
            this.btnCreacionPersonal.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacionPersonal.Location = new System.Drawing.Point(27, 31);
            this.btnCreacionPersonal.Name = "btnCreacionPersonal";
            this.btnCreacionPersonal.Size = new System.Drawing.Size(90, 56);
            this.btnCreacionPersonal.TabIndex = 39;
            this.btnCreacionPersonal.Text = "Creación de Personal";
            this.btnCreacionPersonal.UseVisualStyleBackColor = true;
            // 
            // btnCreacionUsuarios
            // 
            this.btnCreacionUsuarios.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacionUsuarios.Location = new System.Drawing.Point(123, 31);
            this.btnCreacionUsuarios.Name = "btnCreacionUsuarios";
            this.btnCreacionUsuarios.Size = new System.Drawing.Size(90, 56);
            this.btnCreacionUsuarios.TabIndex = 38;
            this.btnCreacionUsuarios.Text = "Creación de Usuarios";
            this.btnCreacionUsuarios.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 39;
            this.button1.Text = "Creación de Personal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 56);
            this.button2.TabIndex = 38;
            this.button2.Text = "Creación de Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btninicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 180);
            this.panel2.TabIndex = 2;
            // 
            // btninicio
            // 
            this.btninicio.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Location = new System.Drawing.Point(35, 114);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(51, 35);
            this.btninicio.TabIndex = 51;
            this.btninicio.Text = "Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Menu_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 180);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Menu_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Personal";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreacionRoles;
        private System.Windows.Forms.Button btnConsultaRoles;
        private System.Windows.Forms.Button btnCreacionPersonal;
        private System.Windows.Forms.Button btnCreacionUsuarios;
    }
}