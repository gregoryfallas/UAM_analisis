namespace PL.Pantallas.Adicionales
{
    partial class Form_Menu_Reclutamiento
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnIngresarPruebas = new System.Windows.Forms.Button();
            this.btnCrearReclutamiento = new System.Windows.Forms.Button();
            this.btnIngresarParticipantes = new System.Windows.Forms.Button();
            this.btnConsultarPruebas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.btnIngresarPruebas);
            this.panel1.Controls.Add(this.btnCrearReclutamiento);
            this.panel1.Controls.Add(this.btnIngresarParticipantes);
            this.panel1.Controls.Add(this.btnConsultarPruebas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 217);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 217);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(57, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 35);
            this.button4.TabIndex = 52;
            this.button4.Text = "Inicio";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnIngresarPruebas
            // 
            this.btnIngresarPruebas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPruebas.Location = new System.Drawing.Point(30, 111);
            this.btnIngresarPruebas.Name = "btnIngresarPruebas";
            this.btnIngresarPruebas.Size = new System.Drawing.Size(100, 78);
            this.btnIngresarPruebas.TabIndex = 48;
            this.btnIngresarPruebas.Text = "Ingresar Pruebas";
            this.btnIngresarPruebas.UseVisualStyleBackColor = true;
            // 
            // btnCrearReclutamiento
            // 
            this.btnCrearReclutamiento.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReclutamiento.Location = new System.Drawing.Point(30, 23);
            this.btnCrearReclutamiento.Name = "btnCrearReclutamiento";
            this.btnCrearReclutamiento.Size = new System.Drawing.Size(100, 78);
            this.btnCrearReclutamiento.TabIndex = 47;
            this.btnCrearReclutamiento.Text = "Crear Reclutamiento";
            this.btnCrearReclutamiento.UseVisualStyleBackColor = true;
            // 
            // btnIngresarParticipantes
            // 
            this.btnIngresarParticipantes.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarParticipantes.Location = new System.Drawing.Point(136, 23);
            this.btnIngresarParticipantes.Name = "btnIngresarParticipantes";
            this.btnIngresarParticipantes.Size = new System.Drawing.Size(100, 78);
            this.btnIngresarParticipantes.TabIndex = 46;
            this.btnIngresarParticipantes.Text = "Ingresar Participantes";
            this.btnIngresarParticipantes.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPruebas
            // 
            this.btnConsultarPruebas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPruebas.Location = new System.Drawing.Point(136, 111);
            this.btnConsultarPruebas.Name = "btnConsultarPruebas";
            this.btnConsultarPruebas.Size = new System.Drawing.Size(100, 78);
            this.btnConsultarPruebas.TabIndex = 45;
            this.btnConsultarPruebas.Text = "Consultar Pruebas de Participantes";
            this.btnConsultarPruebas.UseVisualStyleBackColor = true;
            // 
            // Form_Menu_Reclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 217);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Menu_Reclutamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Reclutamiento";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnIngresarPruebas;
        private System.Windows.Forms.Button btnCrearReclutamiento;
        private System.Windows.Forms.Button btnIngresarParticipantes;
        private System.Windows.Forms.Button btnConsultarPruebas;
    }
}