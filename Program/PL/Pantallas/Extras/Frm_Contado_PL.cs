﻿using System;
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
using System.Drawing.Printing;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Contado_PL : Form
    {
        int EnviarFecha = 0;
        public static int cont_fila = 0;

        Articulos_BLL Obj_BLL = new Articulos_BLL();       
        DA Obj_Dal = new DA();        

        ARTICULOS ART = new ARTICULOS();        
        FACTURAS facturas = new FACTURAS();
        CLIENTES clientes = new CLIENTES();
        
      

        string nombre;
        string cedula;
        string idCliente;

        public Frm_Contado_PL()
        {
            InitializeComponent();           

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ART.Subtotal = 0;

            if (ART.Cantidad>=1)
            {
                dtg_Factura.Rows.Add(new string[] {
             Convert.ToString(dtg_Articulos[1, dtg_Articulos.CurrentRow.Index].Value),
             Convert.ToString(ART.Cantidad),
            Convert.ToString(dtg_Articulos[2, dtg_Articulos.CurrentRow.Index].Value),
            Convert.ToString(ART.Temporal_descuento),
            Convert.ToString(ART.Importe)});

                for (int i = 0; i < dtg_Factura.RowCount; i++)
                {
                    ART.Subtotal = ART.Subtotal+ decimal.Parse(dtg_Factura.Rows[i].Cells[4].Value.ToString());
                    
                    Math.Round(ART.Subtotal,2);                  

                }

                txt_SubTotal.Text = ("¢") + ART.Subtotal.ToString();
                ART.Impuesto = ART.Subtotal * Convert.ToDecimal(0.13);
                Math.Round(ART.Impuesto,2);
                txt_Impuesto.Text = ("¢") + ART.Impuesto.ToString();
                facturas.Total = ART.Subtotal + ART.Impuesto;
                Math.Round(facturas.Total, 2);
                txt_Total.Text =  facturas.Total.ToString();

                //Obj_Dal.Dprecio = facturas.Total;

               

                cont_fila++;

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
                                

                                Frm_Contado_PL cont = new Frm_Contado_PL();
                                FACTURAS factura = new FACTURAS();

                                factura.ID_Cliente = Convert.ToInt32(txt_idCliente.Text);/*Convert.ToInt32(cont.txt_NoCliente.Text)*/;
                                factura.ID_Caja = 1 /*Convert.ToInt32(cont.txt_Caja.Text)*/;
                                factura.Numero_Factura = Convert.ToInt32(txt_Factura.Text); /*Convert.ToInt32(txt_Factura.Text);*/
                                factura.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                factura.Descripcion = "Compra";
                                factura.Total = Convert.ToDecimal(txt_Total.Text); /*Convert.ToDecimal(cont.txt_Total.Text)*/;
                                factura.Tipo_Pago = 1;
                                factura.Estado = 20;


                                Factura_BLL.agregarFactura(factura);
                                MessageBox.Show("Factura agregada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btn_Imprimir.Enabled = true;


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
            CargarNoFactura();

           
           
           

        }


        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
                       
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
            dt.Columns.Add("IdCliente");
            dt.Columns.Add();

            

            foreach (CLIENTES item in LS)
            {
                dt.Rows.Add
                    (
                    item.Cedula,
                    item.Nombre,
                    item.Apellido_1,
                    item.Apellido_2,
                    item.ID_Cliente
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



        private void txt_Cantidad_Leave(object sender, EventArgs e)
        {
            
            if (txt_Cantidad.Text==string.Empty)
            {
                MessageBox.Show ("Debe digitar una cantidad");
                txt_Cantidad.Focus();
            }
            else
            {
                                  
                    ART.Cantidad= Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                    ART.Importe = ART.Precio * ART.Cantidad;
                    ART.Descuento = ART.Importe * ART.Temporal_descuento / 100;
                    ART.Importe = ART.Importe - ART.Descuento;                    
                    txt_Importe.Text = ART.Importe.ToString();
                                
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
            ART.Temporal_descuento = Convert.ToDecimal(txt_Descuento.Text.ToString().Trim());

            if (ART.Temporal_descuento >= 1)
            {

                ART.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                ART.Importe = ART.Precio * ART.Cantidad;
                ART.Descuento = ART.Importe * ART.Temporal_descuento / 100;
               ART.Importe = ART.Importe - ART.Descuento;
                txt_Importe.Text = ART.Importe.ToString();
            }
            else
            {

                ART.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                ART.Importe = ART.Precio * ART.Cantidad;
                txt_Importe.Text = ART.Importe.ToString();
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


        private void dtg_Factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Factura.Rows.Count > 0)
            {
                ART.Cantidad = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[1].Value.ToString());
                ART.Descuento = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[3].Value.ToString());
                ART.Importe = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[4].Value.ToString());
                ART.Precio= Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[2].Value.ToString());


                txt_Cantidad.Text = ART.Cantidad.ToString();
                txt_Descuento.Text = ART.Descuento.ToString();
                txt_Precio.Text = ART.Precio.ToString();
                txt_Importe.Text = ART.Importe.ToString();

            }

        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

            PrintDocument printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir_PrintPage;
            printDocument1.Print();

            MessageBox.Show("Factura generada con exito");
            this.Hide();
        }

        private void Imprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataTable dt = new DataTable();


            Font font = new Font("Arial", 14);
            int ancho = 350;
            int y = 20;
            int x = 250;

            e.Graphics.DrawString("---Veterinaria El Bosque----", font, Brushes.Black, new RectangleF(x, y += 40, ancho, 20));
            e.Graphics.DrawString("Factura#:"+txt_Factura.Text, font, Brushes.Black, new RectangleF(x, y += 40, ancho, 20));
            e.Graphics.DrawString("IDCliente:"+txt_idCliente.Text, font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));
            e.Graphics.DrawString("Cliente: " + txt_Nombre.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));            
            e.Graphics.DrawString("FechaFactura: "+txt_Fecha_Doc.Text, font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));


            e.Graphics.DrawString("---Productos/Servicios---", font, Brushes.Black, new RectangleF(x, y += 40, ancho, 20));
            foreach (DataRow row in dt.Rows)
            {

                e.Graphics.DrawString(row["Nombre"].ToString() +" "+
                 row["Cantidad"].ToString() +" " +
                 row["Precio"].ToString() + " "+
                 row["Total"].ToString()
               , font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));

            }
            e.Graphics.DrawString("---SubTotal: "+txt_SubTotal.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
            e.Graphics.DrawString("---Impuesto: " + txt_Impuesto.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
            e.Graphics.DrawString("---Total:"+"¢" + txt_Total.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
            e.Graphics.DrawString("---GRACIAS POR VISITARNOS---", font, Brushes.Black, new RectangleF(x, y += 50, ancho, 20));

        }

        

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                
                ART.Subtotal= ART.Subtotal- (Convert.ToDecimal(dtg_Factura.CurrentRow.Cells[4].Value.ToString()));
                txt_SubTotal.Text = ART.Subtotal.ToString();
                facturas.Total = facturas.Total - ART.Impuesto - (Convert.ToDecimal(dtg_Factura.CurrentRow.Cells[4].Value.ToString()));
                txt_Total.Text = facturas.Total.ToString();
                ART.Impuesto = ART.Subtotal * Convert.ToDecimal(0.13);
                txt_Impuesto.Text= ART.Impuesto.ToString();
                

                dtg_Factura.Rows.RemoveAt(dtg_Factura.CurrentRow.Index);

                cont_fila--;

            }



        }

        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_Productos_Click_1(object sender, EventArgs e)
        {
            Cargar2();
        }

        private void dtg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dtg_Clientes.CurrentRow.Cells[1].Value.ToString() + " " + dtg_Clientes.CurrentRow.Cells[2].Value.ToString() + " " + dtg_Clientes.CurrentRow.Cells[3].Value.ToString();
            txt_Nombre.Text = nombre;

            cedula= dtg_Clientes.CurrentRow.Cells[0].Value.ToString();
            txt_NoCliente.Text = cedula;

            idCliente= dtg_Clientes.CurrentRow.Cells[4].Value.ToString();
            txt_idCliente.Text = idCliente;

        }

        private void dtg_Articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ART.Precio = Convert.ToDecimal(dtg_Articulos.CurrentRow.Cells[2].Value.ToString());
            txt_Precio.Text = ART.Precio.ToString();
        }

        private void CargarNoFactura()
        {
           Factura_BLL Factura = new Factura_BLL();

            List<FACTURAS> LS = Factura_BLL.ConsultarNoFacturas();

            FACTURAS factura = new FACTURAS();
            
          
            foreach (var li in LS)
            {

                factura.Numero_Factura=li.Numero_Factura;
                factura.Numero_Factura = factura.Numero_Factura + 1;
               txt_Factura.Text = factura.Numero_Factura.ToString();
            }




        }





    }
}
