﻿namespace PL.Pantallas.Adicionales
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIngresarPruebas = new System.Windows.Forms.Button();
            this.btnCrearReclutamiento = new System.Windows.Forms.Button();
            this.btnIngresarParticipantes = new System.Windows.Forms.Button();
            this.btnConsultarPruebas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 207);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.btnIngresarPruebas);
            this.panel3.Controls.Add(this.btnCrearReclutamiento);
            this.panel3.Controls.Add(this.btnIngresarParticipantes);
            this.panel3.Controls.Add(this.btnConsultarPruebas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 207);
            this.panel3.TabIndex = 44;
            // 
            // btnIngresarPruebas
            // 
            this.btnIngresarPruebas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPruebas.Location = new System.Drawing.Point(25, 105);
            this.btnIngresarPruebas.Name = "btnIngresarPruebas";
            this.btnIngresarPruebas.Size = new System.Drawing.Size(100, 78);
            this.btnIngresarPruebas.TabIndex = 44;
            this.btnIngresarPruebas.Text = "Ingresar Pruebas";
            this.btnIngresarPruebas.UseVisualStyleBackColor = true;
            this.btnIngresarPruebas.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCrearReclutamiento
            // 
            this.btnCrearReclutamiento.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReclutamiento.Location = new System.Drawing.Point(25, 17);
            this.btnCrearReclutamiento.Name = "btnCrearReclutamiento";
            this.btnCrearReclutamiento.Size = new System.Drawing.Size(100, 78);
            this.btnCrearReclutamiento.TabIndex = 43;
            this.btnCrearReclutamiento.Text = "Crear Reclutamiento";
            this.btnCrearReclutamiento.UseVisualStyleBackColor = true;
            // 
            // btnIngresarParticipantes
            // 
            this.btnIngresarParticipantes.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarParticipantes.Location = new System.Drawing.Point(131, 17);
            this.btnIngresarParticipantes.Name = "btnIngresarParticipantes";
            this.btnIngresarParticipantes.Size = new System.Drawing.Size(100, 78);
            this.btnIngresarParticipantes.TabIndex = 42;
            this.btnIngresarParticipantes.Text = "Ingresar Participantes";
            this.btnIngresarParticipantes.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPruebas
            // 
            this.btnConsultarPruebas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPruebas.Location = new System.Drawing.Point(131, 105);
            this.btnConsultarPruebas.Name = "btnConsultarPruebas";
            this.btnConsultarPruebas.Size = new System.Drawing.Size(100, 78);
            this.btnConsultarPruebas.TabIndex = 41;
            this.btnConsultarPruebas.Text = "Consultar Pruebas de Participantes";
            this.btnConsultarPruebas.UseVisualStyleBackColor = true;
            this.btnConsultarPruebas.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 56);
            this.button2.TabIndex = 43;
            this.button2.Text = "Agregar Nueva Vacante";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 42;
            this.button1.Text = "Ingresar Postulantes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(276, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 56);
            this.button3.TabIndex = 41;
            this.button3.Text = "Consultar Postulantes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btninicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 207);
            this.panel2.TabIndex = 2;
            // 
            // btninicio
            // 
            this.btninicio.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Location = new System.Drawing.Point(21, 148);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(51, 35);
            this.btninicio.TabIndex = 52;
            this.btninicio.Text = "Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Menu_Reclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 207);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Menu_Reclutamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Reclutamiento";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIngresarPruebas;
        private System.Windows.Forms.Button btnCrearReclutamiento;
        private System.Windows.Forms.Button btnIngresarParticipantes;
        private System.Windows.Forms.Button btnConsultarPruebas;
    }
}