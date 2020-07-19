namespace PL.Pantallas.Extras
{
    partial class Frm_Cuentas_Cobrar_PL
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
            this.dtg_Cobrar = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura_Cobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpb_Cobros = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Aplica_Cobros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cobrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpb_Cobros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Cobrar
            // 
            this.dtg_Cobrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Cobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Cobrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Telefono,
            this.Correo,
            this.Factura_Cobrar,
            this.Fecha_Factura,
            this.Monto_Anterior,
            this.Monto_Actual,
            this.Abono});
            this.dtg_Cobrar.Location = new System.Drawing.Point(33, 76);
            this.dtg_Cobrar.Name = "dtg_Cobrar";
            this.dtg_Cobrar.Size = new System.Drawing.Size(965, 427);
            this.dtg_Cobrar.TabIndex = 2;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo Electronico";
            this.Correo.Name = "Correo";
            // 
            // Factura_Cobrar
            // 
            this.Factura_Cobrar.HeaderText = "Factura";
            this.Factura_Cobrar.Name = "Factura_Cobrar";
            // 
            // Fecha_Factura
            // 
            this.Fecha_Factura.HeaderText = "Fecha Factura";
            this.Fecha_Factura.Name = "Fecha_Factura";
            // 
            // Monto_Anterior
            // 
            this.Monto_Anterior.HeaderText = "Monto Anterior ";
            this.Monto_Anterior.Name = "Monto_Anterior";
            // 
            // Monto_Actual
            // 
            this.Monto_Actual.HeaderText = "Monto Actual";
            this.Monto_Actual.Name = "Monto_Actual";
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuentas por Cobrar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.gpb_Cobros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtg_Cobrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 671);
            this.panel1.TabIndex = 4;
            // 
            // gpb_Cobros
            // 
            this.gpb_Cobros.Controls.Add(this.btn_Buscar);
            this.gpb_Cobros.Controls.Add(this.txt_Monto);
            this.gpb_Cobros.Controls.Add(this.txt_Cedula);
            this.gpb_Cobros.Controls.Add(this.label3);
            this.gpb_Cobros.Controls.Add(this.label2);
            this.gpb_Cobros.Controls.Add(this.btn_Aplica_Cobros);
            this.gpb_Cobros.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Cobros.ForeColor = System.Drawing.Color.White;
            this.gpb_Cobros.Location = new System.Drawing.Point(330, 509);
            this.gpb_Cobros.Name = "gpb_Cobros";
            this.gpb_Cobros.Size = new System.Drawing.Size(440, 150);
            this.gpb_Cobros.TabIndex = 6;
            this.gpb_Cobros.TabStop = false;
            this.gpb_Cobros.Text = "Abono";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::PL.Properties.Resources.search;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(337, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(44, 36);
            this.btn_Buscar.TabIndex = 9;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_Monto
            // 
            this.txt_Monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Monto.Location = new System.Drawing.Point(110, 71);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(150, 30);
            this.txt_Monto.TabIndex = 4;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_Cedula.Location = new System.Drawing.Point(110, 33);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(150, 30);
            this.txt_Cedula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula:";
            // 
            // btn_Aplica_Cobros
            // 
            this.btn_Aplica_Cobros.ForeColor = System.Drawing.Color.Black;
            this.btn_Aplica_Cobros.Location = new System.Drawing.Point(326, 70);
            this.btn_Aplica_Cobros.Name = "btn_Aplica_Cobros";
            this.btn_Aplica_Cobros.Size = new System.Drawing.Size(71, 45);
            this.btn_Aplica_Cobros.TabIndex = 0;
            this.btn_Aplica_Cobros.Text = "Aplicar";
            this.btn_Aplica_Cobros.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Regresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1033, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 671);
            this.panel2.TabIndex = 5;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(42, 583);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(92, 41);
            this.btn_Regresar.TabIndex = 2;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Frm_Cuentas_Cobrar_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Cuentas_Cobrar_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cobrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_Cobros.ResumeLayout(false);
            this.gpb_Cobros.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Cobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura_Cobrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.GroupBox gpb_Cobros;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Aplica_Cobros;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}