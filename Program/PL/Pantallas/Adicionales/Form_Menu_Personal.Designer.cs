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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreacionRoles = new System.Windows.Forms.Button();
            this.btnConsultaRoles = new System.Windows.Forms.Button();
            this.btnCreacionPersonal = new System.Windows.Forms.Button();
            this.btnCreacionUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.btnCreacionRoles);
            this.panel1.Controls.Add(this.btnConsultaRoles);
            this.panel1.Controls.Add(this.btnCreacionPersonal);
            this.panel1.Controls.Add(this.btnCreacionUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 180);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 180);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(44, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 35);
            this.button3.TabIndex = 51;
            this.button3.Text = "Inicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreacionRoles
            // 
            this.btnCreacionRoles.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacionRoles.Location = new System.Drawing.Point(29, 89);
            this.btnCreacionRoles.Name = "btnCreacionRoles";
            this.btnCreacionRoles.Size = new System.Drawing.Size(90, 56);
            this.btnCreacionRoles.TabIndex = 45;
            this.btnCreacionRoles.Text = "Creación de Roles";
            this.btnCreacionRoles.UseVisualStyleBackColor = true;
            // 
            // btnConsultaRoles
            // 
            this.btnConsultaRoles.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaRoles.Location = new System.Drawing.Point(125, 89);
            this.btnConsultaRoles.Name = "btnConsultaRoles";
            this.btnConsultaRoles.Size = new System.Drawing.Size(90, 56);
            this.btnConsultaRoles.TabIndex = 44;
            this.btnConsultaRoles.Text = "Consulta de Roles";
            this.btnConsultaRoles.UseVisualStyleBackColor = true;
            // 
            // btnCreacionPersonal
            // 
            this.btnCreacionPersonal.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacionPersonal.Location = new System.Drawing.Point(29, 27);
            this.btnCreacionPersonal.Name = "btnCreacionPersonal";
            this.btnCreacionPersonal.Size = new System.Drawing.Size(90, 56);
            this.btnCreacionPersonal.TabIndex = 43;
            this.btnCreacionPersonal.Text = "Creación de Personal";
            this.btnCreacionPersonal.UseVisualStyleBackColor = true;
            // 
            // btnCreacionUsuarios
            // 
            this.btnCreacionUsuarios.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacionUsuarios.Location = new System.Drawing.Point(125, 27);
            this.btnCreacionUsuarios.Name = "btnCreacionUsuarios";
            this.btnCreacionUsuarios.Size = new System.Drawing.Size(90, 56);
            this.btnCreacionUsuarios.TabIndex = 42;
            this.btnCreacionUsuarios.Text = "Creación de Usuarios";
            this.btnCreacionUsuarios.UseVisualStyleBackColor = true;
            // 
            // Form_Menu_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 180);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Menu_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Personal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreacionRoles;
        private System.Windows.Forms.Button btnConsultaRoles;
        private System.Windows.Forms.Button btnCreacionPersonal;
        private System.Windows.Forms.Button btnCreacionUsuarios;
    }
}