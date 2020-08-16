namespace PL.Pantallas.Adicionales
{
    partial class Frm_Despacho_Suministros_PL
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
            this.label_estado = new System.Windows.Forms.Label();
            this.tb_id_articulo = new System.Windows.Forms.Label();
            this.txt_id_factura = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_resumen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id_despacho = new System.Windows.Forms.TextBox();
            this.dataGridV_resumen = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_resumen)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.cb_estado);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.label_estado);
            this.panel1.Controls.Add(this.tb_id_articulo);
            this.panel1.Controls.Add(this.txt_id_factura);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label_resumen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_id_despacho);
            this.panel1.Controls.Add(this.dataGridV_resumen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 487);
            this.panel1.TabIndex = 0;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(31, 259);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(60, 20);
            this.label_estado.TabIndex = 200;
            this.label_estado.Text = "Estado";
            // 
            // tb_id_articulo
            // 
            this.tb_id_articulo.AutoSize = true;
            this.tb_id_articulo.Location = new System.Drawing.Point(31, 108);
            this.tb_id_articulo.Name = "tb_id_articulo";
            this.tb_id_articulo.Size = new System.Drawing.Size(89, 20);
            this.tb_id_articulo.TabIndex = 198;
            this.tb_id_articulo.Text = "ID Factura:";
            // 
            // txt_id_factura
            // 
            this.txt_id_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_id_factura.Location = new System.Drawing.Point(35, 134);
            this.txt_id_factura.Name = "txt_id_factura";
            this.txt_id_factura.Size = new System.Drawing.Size(120, 26);
            this.txt_id_factura.TabIndex = 197;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PL.Properties.Resources.editar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Location = new System.Drawing.Point(335, 433);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(60, 42);
            this.btn_Modificar.TabIndex = 195;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Location = new System.Drawing.Point(241, 433);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(54, 42);
            this.btn_Agregar.TabIndex = 194;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PL.Properties.Resources.search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.button2.Location = new System.Drawing.Point(627, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 42);
            this.button2.TabIndex = 191;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_resumen
            // 
            this.label_resumen.AutoSize = true;
            this.label_resumen.Location = new System.Drawing.Point(237, 33);
            this.label_resumen.Name = "label_resumen";
            this.label_resumen.Size = new System.Drawing.Size(78, 20);
            this.label_resumen.TabIndex = 189;
            this.label_resumen.Text = "Resumen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 186;
            this.label8.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 181;
            this.label6.Text = "ID Despacho:";
            // 
            // txt_id_despacho
            // 
            this.txt_id_despacho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_id_despacho.Location = new System.Drawing.Point(35, 59);
            this.txt_id_despacho.Name = "txt_id_despacho";
            this.txt_id_despacho.ReadOnly = true;
            this.txt_id_despacho.Size = new System.Drawing.Size(120, 26);
            this.txt_id_despacho.TabIndex = 180;
            // 
            // dataGridV_resumen
            // 
            this.dataGridV_resumen.AllowUserToAddRows = false;
            this.dataGridV_resumen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dataGridV_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_resumen.Location = new System.Drawing.Point(228, 65);
            this.dataGridV_resumen.Name = "dataGridV_resumen";
            this.dataGridV_resumen.ReadOnly = true;
            this.dataGridV_resumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridV_resumen.Size = new System.Drawing.Size(468, 351);
            this.dataGridV_resumen.TabIndex = 179;
            this.dataGridV_resumen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridV_resumen_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(728, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 487);
            this.panel2.TabIndex = 1;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Location = new System.Drawing.Point(27, 424);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(117, 35);
            this.btn_Inicio.TabIndex = 45;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_buscar.Location = new System.Drawing.Point(501, 441);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(120, 26);
            this.txt_buscar.TabIndex = 203;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(35, 295);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 28);
            this.cb_estado.TabIndex = 204;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.txt_fecha.Location = new System.Drawing.Point(36, 218);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(120, 26);
            this.txt_fecha.TabIndex = 205;
            // 
            // Frm_Despacho_Suministros_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Despacho_Suministros_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despacho Suministros";
            this.Load += new System.EventHandler(this.Frm_Despacho_Suministros_PL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_resumen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_resumen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id_despacho;
        private System.Windows.Forms.DataGridView dataGridV_resumen;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label tb_id_articulo;
        private System.Windows.Forms.TextBox txt_id_factura;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_fecha;
    }
}