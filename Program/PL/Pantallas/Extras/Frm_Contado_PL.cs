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
        ARTICULOS Obj_Dal = new ARTICULOS();
        FACTURA_COMPRA fact = new FACTURA_COMPRA();
        FACTURAS facturas = new FACTURAS();

        public Frm_Contado_PL()
        {
            InitializeComponent();
           Cargar();
            Cargar2();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            double imp=0.13;   

            dtg_Factura.Rows.Add(new string[] {
             Convert.ToString(dtg_Articulos[2, dtg_Articulos.CurrentRow.Index].Value),
             Convert.ToString(Obj_Dal.Cantidad),
            Convert.ToString(dtg_Articulos[3, dtg_Articulos.CurrentRow.Index].Value),
            Convert.ToString(Obj_Dal.Descuento),
            Convert.ToString(Obj_Dal.Importe)});

            for (int i = 0; i < dtg_Factura.RowCount ; i++)
            {
                Obj_Dal.Subtotal += decimal.Parse(dtg_Factura.Rows[i].Cells[4].Value.ToString());
            }
            txt_SubTotal.Text = Obj_Dal.Subtotal.ToString();


            Obj_Dal.Impuesto = Obj_Dal.Subtotal * Convert.ToDecimal(0.13);
            facturas.Total = Obj_Dal.Subtotal + Obj_Dal.Impuesto;

            txt_Total.Text = ("¢")+facturas.Total.ToString();

            Obj_Dal.Dprecio = facturas.Total;

             Obj_Dal.Subtotal = 0;
             
            LimpiarCampos();
            

            }

            private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Total_Factura_PL factura = new Frm_Total_Factura_PL();
                factura.ShowDialog();
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

            fact.Fecha = DateTime.Today;
            txt_Fecha_Doc.Text = fact.Fecha.ToString();

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
            txt_Nombre.Text = dtg_Clientes.CurrentRow.Cells[1].Value.ToString()+" "+ dtg_Clientes.CurrentRow.Cells[2].Value.ToString()+" "+ dtg_Clientes.CurrentRow.Cells[3].Value.ToString();
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
            }
            else
            {
                if (Obj_Dal.Descuento >= 1)
                {
                    Obj_Dal.Descuento = Convert.ToDecimal(txt_Descuento.Text.ToString().Trim());
                    Obj_Dal.Cantidad= Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                    Obj_Dal.Temporal_descuento = (Obj_Dal.Precio* Obj_Dal.Cantidad) * Obj_Dal.Descuento;
                    Obj_Dal.Importe = Obj_Dal.Importe - Obj_Dal.Temporal_descuento;
                    txt_Importe.Text = Obj_Dal.Importe.ToString();
                }
                else
                {
                    Obj_Dal.Descuento = Convert.ToDecimal(txt_Descuento.Text.ToString().Trim());
                    Obj_Dal.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                    Obj_Dal.Importe = Obj_Dal.Precio * Obj_Dal.Cantidad;
                    txt_Importe.Text = Obj_Dal.Importe.ToString();
                }
                
            }           
        }

        private void LimpiarCampos()
        {
            txt_Cantidad.Text = "";
            txt_Precio.Text = "";
            txt_Importe.Text = "";
            txt_Descuento.Text = "0";

        }

















    }
}
