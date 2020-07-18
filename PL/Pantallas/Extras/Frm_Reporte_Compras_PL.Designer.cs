namespace PL.Pantallas.Extras
{
    partial class Frm_Reporte_Compras_PL
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
            this.gpb_Compras = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtg_Compras = new System.Windows.Forms.DataGridView();
            this.Numero_Factu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Factu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpb_Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Compras)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gpb_Compras);
            this.panel1.Controls.Add(this.dtg_Compras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 632);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Reporte Compras";
            // 
            // gpb_Compras
            // 
            this.gpb_Compras.Controls.Add(this.btn_Buscar);
            this.gpb_Compras.Controls.Add(this.textBox10);
            this.gpb_Compras.Controls.Add(this.label11);
            this.gpb_Compras.Controls.Add(this.textBox7);
            this.gpb_Compras.Controls.Add(this.label8);
            this.gpb_Compras.Controls.Add(this.textBox8);
            this.gpb_Compras.Controls.Add(this.textBox9);
            this.gpb_Compras.Controls.Add(this.label9);
            this.gpb_Compras.Controls.Add(this.label10);
            this.gpb_Compras.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Compras.ForeColor = System.Drawing.Color.White;
            this.gpb_Compras.Location = new System.Drawing.Point(206, 16);
            this.gpb_Compras.Name = "gpb_Compras";
            this.gpb_Compras.Size = new System.Drawing.Size(542, 124);
            this.gpb_Compras.TabIndex = 13;
            this.gpb_Compras.TabStop = false;
            this.gpb_Compras.Text = "Datos";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::PL.Properties.Resources.search;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(491, 28);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(44, 36);
            this.btn_Buscar.TabIndex = 8;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(340, 31);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 26);
            this.textBox10.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nombre";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(340, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 26);
            this.textBox7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fecha Final";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(118, 73);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 26);
            this.textBox8.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(118, 31);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 26);
            this.textBox9.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fecha Inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Codigo Proveedor";
            // 
            // dtg_Compras
            // 
            this.dtg_Compras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Factu,
            this.Fecha_Compra,
            this.Codigo_Proveedor,
            this.Nombre_Proveedor,
            this.Monto_Factu});
            this.dtg_Compras.Location = new System.Drawing.Point(140, 190);
            this.dtg_Compras.Name = "dtg_Compras";
            this.dtg_Compras.Size = new System.Drawing.Size(579, 409);
            this.dtg_Compras.TabIndex = 12;
            // 
            // Numero_Factu
            // 
            this.Numero_Factu.HeaderText = "No. Factura";
            this.Numero_Factu.Name = "Numero_Factu";
            // 
            // Fecha_Compra
            // 
            this.Fecha_Compra.HeaderText = "Fecha Compra";
            this.Fecha_Compra.Name = "Fecha_Compra";
            // 
            // Codigo_Proveedor
            // 
            this.Codigo_Proveedor.HeaderText = "Código Proveedor";
            this.Codigo_Proveedor.Name = "Codigo_Proveedor";
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Nombre Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            // 
            // Monto_Factu
            // 
            this.Monto_Factu.HeaderText = "Monto Factura";
            this.Monto_Factu.Name = "Monto_Factu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Regresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(815, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 632);
            this.panel2.TabIndex = 1;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(19, 558);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(92, 41);
            this.btn_Regresar.TabIndex = 2;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Frm_Reporte_Compras_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Reporte_Compras_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Compras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_Compras.ResumeLayout(false);
            this.gpb_Compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Compras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtg_Compras;
        private System.Windows.Forms.GroupBox gpb_Compras;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Factu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Factu;
        private System.Windows.Forms.Button btn_Buscar;
    }
}