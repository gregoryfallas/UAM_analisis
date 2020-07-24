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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCrearNomina = new System.Windows.Forms.Button();
            this.btnBuscarNomina = new System.Windows.Forms.Button();
            this.btnIngresoMarcas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 210);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.btnCrearNomina);
            this.panel3.Controls.Add(this.btnBuscarNomina);
            this.panel3.Controls.Add(this.btnIngresoMarcas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 210);
            this.panel3.TabIndex = 39;
            // 
            // btnCrearNomina
            // 
            this.btnCrearNomina.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNomina.Location = new System.Drawing.Point(12, 12);
            this.btnCrearNomina.Name = "btnCrearNomina";
            this.btnCrearNomina.Size = new System.Drawing.Size(93, 57);
            this.btnCrearNomina.TabIndex = 38;
            this.btnCrearNomina.Text = "Crear Nómina";
            this.btnCrearNomina.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNomina
            // 
            this.btnBuscarNomina.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNomina.Location = new System.Drawing.Point(12, 75);
            this.btnBuscarNomina.Name = "btnBuscarNomina";
            this.btnBuscarNomina.Size = new System.Drawing.Size(93, 57);
            this.btnBuscarNomina.TabIndex = 37;
            this.btnBuscarNomina.Text = "Buscar Nómina";
            this.btnBuscarNomina.UseVisualStyleBackColor = true;
            // 
            // btnIngresoMarcas
            // 
            this.btnIngresoMarcas.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoMarcas.Location = new System.Drawing.Point(12, 138);
            this.btnIngresoMarcas.Name = "btnIngresoMarcas";
            this.btnIngresoMarcas.Size = new System.Drawing.Size(93, 57);
            this.btnIngresoMarcas.TabIndex = 36;
            this.btnIngresoMarcas.Text = "Ingreso de Marcas";
            this.btnIngresoMarcas.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 57);
            this.button3.TabIndex = 38;
            this.button3.Text = "Crear Nómina";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 57);
            this.button1.TabIndex = 37;
            this.button1.Text = "Buscar Nómina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 57);
            this.button2.TabIndex = 36;
            this.button2.Text = "Ingreso de Marcas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btninicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(120, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 210);
            this.panel2.TabIndex = 2;
            // 
            // btninicio
            // 
            this.btninicio.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Location = new System.Drawing.Point(37, 160);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(51, 35);
            this.btninicio.TabIndex = 53;
            this.btninicio.Text = "Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Pago_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 210);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Pago_Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Nomina";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCrearNomina;
        private System.Windows.Forms.Button btnBuscarNomina;
        private System.Windows.Forms.Button btnIngresoMarcas;
    }
}