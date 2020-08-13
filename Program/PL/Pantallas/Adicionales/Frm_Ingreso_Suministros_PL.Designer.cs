namespace PL.Pantallas.Adicionales
{
    partial class Frm_Ingreso_Suministros_PL
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
            this.tb_idproveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idarticulo = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_cant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_descrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_idformulario = new System.Windows.Forms.TextBox();
            this.dataGrid_ingresosumi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ingresosumi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.tb_idproveedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_idarticulo);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Crear);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tb_cant);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_descrip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_idformulario);
            this.panel1.Controls.Add(this.dataGrid_ingresosumi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 477);
            this.panel1.TabIndex = 0;
            // 
            // tb_idproveedor
            // 
            this.tb_idproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tb_idproveedor.Location = new System.Drawing.Point(229, 131);
            this.tb_idproveedor.Name = "tb_idproveedor";
            this.tb_idproveedor.Size = new System.Drawing.Size(120, 20);
            this.tb_idproveedor.TabIndex = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 175;
            this.label1.Text = "Id Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 174;
            this.label2.Text = "Id Proveedor:";
            // 
            // tb_idarticulo
            // 
            this.tb_idarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tb_idarticulo.Location = new System.Drawing.Point(29, 131);
            this.tb_idarticulo.Name = "tb_idarticulo";
            this.tb_idarticulo.Size = new System.Drawing.Size(135, 20);
            this.tb_idarticulo.TabIndex = 173;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::PL.Properties.Resources.editar;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Modificar.Location = new System.Drawing.Point(551, 120);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(60, 39);
            this.btn_Modificar.TabIndex = 170;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Crear.BackgroundImage = global::PL.Properties.Resources.Agregar;
            this.btn_Crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Crear.FlatAppearance.BorderSize = 0;
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.btn_Crear.Location = new System.Drawing.Point(471, 120);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(50, 40);
            this.btn_Crear.TabIndex = 169;
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PL.Properties.Resources.search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.button2.Location = new System.Drawing.Point(381, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 40);
            this.button2.TabIndex = 167;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(32, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 165;
            this.label12.Text = "Resumen";
            // 
            // tb_cant
            // 
            this.tb_cant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tb_cant.Location = new System.Drawing.Point(416, 45);
            this.tb_cant.Name = "tb_cant";
            this.tb_cant.Size = new System.Drawing.Size(120, 20);
            this.tb_cant.TabIndex = 164;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(226, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 163;
            this.label9.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(424, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 162;
            this.label8.Text = "Cantidad:";
            // 
            // tb_descrip
            // 
            this.tb_descrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tb_descrip.Location = new System.Drawing.Point(223, 45);
            this.tb_descrip.Name = "tb_descrip";
            this.tb_descrip.Size = new System.Drawing.Size(120, 20);
            this.tb_descrip.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 157;
            this.label6.Text = "Id Formulario Pedido:";
            // 
            // tb_idformulario
            // 
            this.tb_idformulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.tb_idformulario.Location = new System.Drawing.Point(29, 46);
            this.tb_idformulario.Name = "tb_idformulario";
            this.tb_idformulario.Size = new System.Drawing.Size(135, 20);
            this.tb_idformulario.TabIndex = 156;
            // 
            // dataGrid_ingresosumi
            // 
            this.dataGrid_ingresosumi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(88)))));
            this.dataGrid_ingresosumi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ingresosumi.Location = new System.Drawing.Point(35, 219);
            this.dataGrid_ingresosumi.Name = "dataGrid_ingresosumi";
            this.dataGrid_ingresosumi.Size = new System.Drawing.Size(626, 224);
            this.dataGrid_ingresosumi.TabIndex = 155;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btn_Inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(719, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 477);
            this.panel2.TabIndex = 1;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.Location = new System.Drawing.Point(25, 421);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(117, 35);
            this.btn_Inicio.TabIndex = 45;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // Frm_Ingreso_Suministros_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Ingreso_Suministros_PL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Suministros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ingresosumi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_cant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_descrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_idformulario;
        private System.Windows.Forms.DataGridView dataGrid_ingresosumi;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox tb_idproveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idarticulo;
    }
}