namespace PL.Pantallas.Extras
{
    partial class Frm_Reporte_Ventas
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
            this.gpb_Ventas = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtg_Ventas = new System.Windows.Forms.DataGridView();
            this.Numero_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpb_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ventas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gpb_Ventas);
            this.panel1.Controls.Add(this.dtg_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 643);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reporte Ventas";
            // 
            // gpb_Ventas
            // 
            this.gpb_Ventas.Controls.Add(this.btn_Buscar);
            this.gpb_Ventas.Controls.Add(this.textBox4);
            this.gpb_Ventas.Controls.Add(this.label5);
            this.gpb_Ventas.Controls.Add(this.textBox5);
            this.gpb_Ventas.Controls.Add(this.textBox6);
            this.gpb_Ventas.Controls.Add(this.label6);
            this.gpb_Ventas.Controls.Add(this.label7);
            this.gpb_Ventas.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Ventas.ForeColor = System.Drawing.Color.White;
            this.gpb_Ventas.Location = new System.Drawing.Point(273, 26);
            this.gpb_Ventas.Name = "gpb_Ventas";
            this.gpb_Ventas.Size = new System.Drawing.Size(465, 134);
            this.gpb_Ventas.TabIndex = 12;
            this.gpb_Ventas.TabStop = false;
            this.gpb_Ventas.Text = "Datos";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::PL.Properties.Resources.search;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(391, 24);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(44, 36);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(328, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 26);
            this.textBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Final";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(112, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 26);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(112, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 26);
            this.textBox6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha Inicial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "No. Cédula";
            // 
            // dtg_Ventas
            // 
            this.dtg_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Factura,
            this.Nombre_Cliente,
            this.Primer_Apellido,
            this.Segundo_Apellido,
            this.Monto_Factura,
            this.Fecha_Fact,
            this.Tipo_Venta});
            this.dtg_Ventas.Location = new System.Drawing.Point(60, 194);
            this.dtg_Ventas.Name = "dtg_Ventas";
            this.dtg_Ventas.Size = new System.Drawing.Size(781, 417);
            this.dtg_Ventas.TabIndex = 11;
            // 
            // Numero_Factura
            // 
            this.Numero_Factura.HeaderText = "No. Factura";
            this.Numero_Factura.Name = "Numero_Factura";
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.HeaderText = "Nombre";
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            // 
            // Primer_Apellido
            // 
            this.Primer_Apellido.HeaderText = "Primer Apellido";
            this.Primer_Apellido.Name = "Primer_Apellido";
            // 
            // Segundo_Apellido
            // 
            this.Segundo_Apellido.HeaderText = "Segundo_Apellido";
            this.Segundo_Apellido.Name = "Segundo_Apellido";
            // 
            // Monto_Factura
            // 
            this.Monto_Factura.HeaderText = "Monto Factura";
            this.Monto_Factura.Name = "Monto_Factura";
            // 
            // Fecha_Fact
            // 
            this.Fecha_Fact.HeaderText = "Fecha Factura";
            this.Fecha_Fact.Name = "Fecha_Fact";
            // 
            // Tipo_Venta
            // 
            this.Tipo_Venta.HeaderText = "Tipo Venta";
            this.Tipo_Venta.Name = "Tipo_Venta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Regresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(913, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 643);
            this.panel2.TabIndex = 1;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(30, 550);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(92, 41);
            this.btn_Regresar.TabIndex = 2;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Frm_Reporte_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Reporte_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_Ventas.ResumeLayout(false);
            this.gpb_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ventas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg_Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_Ventas;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}