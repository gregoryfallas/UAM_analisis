namespace PL.Pantallas.Extras
{
    partial class Frm_Revision_Planilla_PL
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
            this.dtg_Planilla = new System.Windows.Forms.DataGridView();
            this.codigoEmpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedulaide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpb_Planilla = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Aplica_Planilla = new System.Windows.Forms.Button();
            this.gpb_Datos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_FechaFin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FechaInicio = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Planilla)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpb_Planilla.SuspendLayout();
            this.gpb_Datos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Planilla
            // 
            this.dtg_Planilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dtg_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Planilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpl,
            this.Cedulaide,
            this.nombreEmpl,
            this.Primape,
            this.SegundoApe,
            this.Salario,
            this.Estado,
            this.Comprobante});
            this.dtg_Planilla.Location = new System.Drawing.Point(49, 155);
            this.dtg_Planilla.Name = "dtg_Planilla";
            this.dtg_Planilla.Size = new System.Drawing.Size(847, 441);
            this.dtg_Planilla.TabIndex = 4;
            // 
            // codigoEmpl
            // 
            this.codigoEmpl.HeaderText = "Codigo Empleado";
            this.codigoEmpl.Name = "codigoEmpl";
            // 
            // Cedulaide
            // 
            this.Cedulaide.HeaderText = "Cedula";
            this.Cedulaide.Name = "Cedulaide";
            // 
            // nombreEmpl
            // 
            this.nombreEmpl.HeaderText = "Nombre ";
            this.nombreEmpl.Name = "nombreEmpl";
            // 
            // Primape
            // 
            this.Primape.HeaderText = "Primer Apellido";
            this.Primape.Name = "Primape";
            // 
            // SegundoApe
            // 
            this.SegundoApe.HeaderText = "Segundo Apellido";
            this.SegundoApe.Name = "SegundoApe";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Comprobante
            // 
            this.Comprobante.HeaderText = "Comprobante Bancario";
            this.Comprobante.Name = "Comprobante";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.gpb_Planilla);
            this.panel1.Controls.Add(this.gpb_Datos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtg_Planilla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 627);
            this.panel1.TabIndex = 5;
            // 
            // gpb_Planilla
            // 
            this.gpb_Planilla.Controls.Add(this.textBox2);
            this.gpb_Planilla.Controls.Add(this.btn_Aplica_Planilla);
            this.gpb_Planilla.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Planilla.ForeColor = System.Drawing.Color.White;
            this.gpb_Planilla.Location = new System.Drawing.Point(794, 17);
            this.gpb_Planilla.Name = "gpb_Planilla";
            this.gpb_Planilla.Size = new System.Drawing.Size(125, 132);
            this.gpb_Planilla.TabIndex = 10;
            this.gpb_Planilla.TabStop = false;
            this.gpb_Planilla.Text = "Aplicar Pago";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox2.Location = new System.Drawing.Point(7, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 30);
            this.textBox2.TabIndex = 2;
            // 
            // btn_Aplica_Planilla
            // 
            this.btn_Aplica_Planilla.ForeColor = System.Drawing.Color.Black;
            this.btn_Aplica_Planilla.Location = new System.Drawing.Point(31, 71);
            this.btn_Aplica_Planilla.Name = "btn_Aplica_Planilla";
            this.btn_Aplica_Planilla.Size = new System.Drawing.Size(71, 45);
            this.btn_Aplica_Planilla.TabIndex = 1;
            this.btn_Aplica_Planilla.Text = "Aplicar";
            this.btn_Aplica_Planilla.UseVisualStyleBackColor = true;
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Controls.Add(this.button1);
            this.gpb_Datos.Controls.Add(this.txt_FechaFin);
            this.gpb_Datos.Controls.Add(this.label5);
            this.gpb_Datos.Controls.Add(this.textBox3);
            this.gpb_Datos.Controls.Add(this.label4);
            this.gpb_Datos.Controls.Add(this.txt_FechaInicio);
            this.gpb_Datos.Controls.Add(this.textBox1);
            this.gpb_Datos.Controls.Add(this.label3);
            this.gpb_Datos.Controls.Add(this.label2);
            this.gpb_Datos.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Datos.ForeColor = System.Drawing.Color.White;
            this.gpb_Datos.Location = new System.Drawing.Point(204, 10);
            this.gpb_Datos.Name = "gpb_Datos";
            this.gpb_Datos.Size = new System.Drawing.Size(551, 139);
            this.gpb_Datos.TabIndex = 9;
            this.gpb_Datos.TabStop = false;
            this.gpb_Datos.Text = "Datos";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PL.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(485, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 32);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_FechaFin
            // 
            this.txt_FechaFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_FechaFin.Location = new System.Drawing.Point(330, 74);
            this.txt_FechaFin.Name = "txt_FechaFin";
            this.txt_FechaFin.Size = new System.Drawing.Size(125, 32);
            this.txt_FechaFin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Final";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox3.Location = new System.Drawing.Point(330, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 32);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cédula";
            // 
            // txt_FechaInicio
            // 
            this.txt_FechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_FechaInicio.Location = new System.Drawing.Point(112, 74);
            this.txt_FechaInicio.Name = "txt_FechaInicio";
            this.txt_FechaInicio.Size = new System.Drawing.Size(125, 32);
            this.txt_FechaInicio.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.textBox1.Location = new System.Drawing.Point(112, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id. Nómina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Revisión de Planilla";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Regresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(942, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 627);
            this.panel2.TabIndex = 6;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(35, 555);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(92, 41);
            this.btn_Regresar.TabIndex = 2;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Frm_Revision_Planilla_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Revision_Planilla_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisión Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Planilla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_Planilla.ResumeLayout(false);
            this.gpb_Planilla.PerformLayout();
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Planilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedulaide;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primape;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprobante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_Datos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FechaInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpb_Planilla;
        private System.Windows.Forms.Button btn_Aplica_Planilla;
        private System.Windows.Forms.TextBox textBox2;
    }
}