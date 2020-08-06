using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Entidades;
using DAL;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Contado_PL : Form
    {
        int EnviarFecha = 0;


        ARTICULOS Obj_Dal = new ARTICULOS();        
        FACTURAS facturas = new FACTURAS();
        CLIENTES clientes = new CLIENTES();
      

        string nombre;

        public Frm_Contado_PL()
        {
            InitializeComponent();
           Cargar();
            Cargar2();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            double imp=0.13;

            if (Obj_Dal.Cantidad>0)
            {
                dtg_Factura.Rows.Add(new string[] {
             Convert.ToString(dtg_Articulos[2, dtg_Articulos.CurrentRow.Index].Value),
             Convert.ToString(Obj_Dal.Cantidad),
            Convert.ToString(dtg_Articulos[3, dtg_Articulos.CurrentRow.Index].Value),
            Convert.ToString(Obj_Dal.Temporal_descuento),
            Convert.ToString(Obj_Dal.Importe)});

                for (int i = 0; i < dtg_Factura.RowCount; i++)
                {
                    Obj_Dal.Subtotal += decimal.Parse(dtg_Factura.Rows[i].Cells[4].Value.ToString());
                }

                txt_SubTotal.Text = ("¢") + Obj_Dal.Subtotal.ToString();
                Obj_Dal.Impuesto = Obj_Dal.Subtotal * Convert.ToDecimal(0.13);
                facturas.Total = Obj_Dal.Subtotal + Obj_Dal.Impuesto;
                txt_Impuesto.Text = ("¢") + Obj_Dal.Impuesto.ToString();
                txt_Total.Text = ("¢") + facturas.Total.ToString();
                Obj_Dal.Dprecio = facturas.Total;

                Obj_Dal.Subtotal = 0;

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("¡Tiene que seleccionar una cantidad!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cantidad.Focus();
            }



            
            

            }

            private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_Nombre.Text==string.Empty)
                {
                    MessageBox.Show("¡Tiene que seleccionar un Cliente!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }                
                else
                {
                    if (facturas.Total < 1)
                    {
                        MessageBox.Show("¡Tiene que seleccionar un Producto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        if (rdb_Contado.Checked==false && rdb_Credito.Checked==false)
                        {
                            MessageBox.Show("¡Tiene que seleccionar un metodo de pago!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (rdb_Efectivo.Checked==false && rdb_Tarjeta.Checked==false)
                            {
                                MessageBox.Show("¡Tiene que seleccionar una forma de pago!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Frm_Total_Factura_PL factura = new Frm_Total_Factura_PL();
                                factura.txt_Total2.Text = facturas.Total.ToString();
                                factura.ShowDialog();



                            }
                        }
                            
                    }
                    
                }
                




            }
        }

        private void btn_Orden_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Cargar orden de Médico ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string orden;
                orden = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de orden:", "Orden de Médico");
                MessageBox.Show("Orden Cargada con Exito: " + orden, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_Orden.Text = orden;

            }
        }

        private void Frm_Contado_PL_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();     
            Cargar();
            Cargar2();            

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar();
                       
        }
       
        private void Cargar ()
        {
            Clientes_BLL Clientes = new Clientes_BLL();

            List<CLIENTES> LS = Clientes_BLL.ConsultarClientes(txt_Cliente.Text.Trim());

            DataTable dt = new DataTable();

            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Primer_Apellido");
            dt.Columns.Add("Segundo_Apellido");           

            foreach (CLIENTES item in LS)
            {
                dt.Rows.Add
                    (
                    item.Cedula,
                    item.Nombre,
                    item.Apellido_1,
                    item.Apellido_2              
                    );
            }

            dtg_Clientes.DataSource = null;
            dtg_Clientes.Refresh();
            dtg_Clientes.DataSource = dt;
            dtg_Clientes.Refresh();
                     

        }

        private void Cargar2()
        {

            try
            {

                this.dtg_Articulos.DataSource = null;
                this.dtg_Articulos.Refresh();
                string a = txt_Producto.Text.Trim();
                this.dtg_Articulos.DataSource = Articulos_BLL.ConsultarInventarioArticulos(a);
                this.dtg_Articulos.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void dtg_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            nombre= dtg_Clientes.CurrentRow.Cells[1].Value.ToString()+" "+ dtg_Clientes.CurrentRow.Cells[2].Value.ToString()+" "+ dtg_Clientes.CurrentRow.Cells[3].Value.ToString();
            txt_Nombre.Text = nombre;
        }


        private void CargarDatos()
        {
            try
            {

                this.dtg_Factura.DataSource = null;
                this.dtg_Factura.Refresh();
                string a = txt_Nombre.Text.Trim();
                this.dtg_Factura.DataSource = Articulos_BLL.ConsultarInventarioArticulos(a);
                this.dtg_Factura.Refresh();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Cargar2();
        }

        private void dtg_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Obj_Dal.Precio = Convert.ToDecimal(dtg_Articulos.CurrentRow.Cells[3].Value.ToString());
            txt_Precio.Text = Obj_Dal.Precio.ToString();
        }

        

        private void txt_Cantidad_Leave(object sender, EventArgs e)
        {
            
            if (txt_Cantidad.Text==string.Empty)
            {
                MessageBox.Show ("Debe digitar una cantidad");
                txt_Cantidad.Focus();
            }
            else
            {
                                  
                    Obj_Dal.Cantidad= Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                    Obj_Dal.Importe = Obj_Dal.Precio * Obj_Dal.Cantidad;
                    Obj_Dal.Descuento = Obj_Dal.Importe * Obj_Dal.Temporal_descuento / 100;
                    Obj_Dal.Importe = Obj_Dal.Importe - Obj_Dal.Descuento;                    
                    txt_Importe.Text = Obj_Dal.Importe.ToString();
                                
            }           
        }

        private void LimpiarCampos()
        {
            txt_Cantidad.Text = "";
            txt_Precio.Text = "";
            txt_Importe.Text = "";
            txt_Descuento.Text = "0";

        }

        private void txt_Descuento_Leave(object sender, EventArgs e)
        {
            Obj_Dal.Temporal_descuento = Convert.ToDecimal(txt_Descuento.Text.ToString().Trim());

            if (Obj_Dal.Temporal_descuento >= 1)
            {

                Obj_Dal.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                Obj_Dal.Importe = Obj_Dal.Precio * Obj_Dal.Cantidad;
                Obj_Dal.Descuento = Obj_Dal.Importe * Obj_Dal.Temporal_descuento / 100;
                Obj_Dal.Importe = Obj_Dal.Importe - Obj_Dal.Descuento;
                txt_Importe.Text = Obj_Dal.Importe.ToString();
            }
            else
            {

                Obj_Dal.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                Obj_Dal.Importe = Obj_Dal.Precio * Obj_Dal.Cantidad;
                txt_Importe.Text = Obj_Dal.Importe.ToString();
            }

        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

               
        

        private void CapturarFechaSistema()
        {
            txt_Fecha_Doc.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
                switch (EnviarFecha)
                {
                    case 0: CapturarFechaSistema(); break;
                }
            
        }
    }
}
