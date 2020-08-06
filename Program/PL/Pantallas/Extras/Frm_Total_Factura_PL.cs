using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Extras;
using System.Drawing.Printing;
using DAL;
using DAL.Entidades;
using BLL;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Total_Factura_PL : Form
    {
        ARTICULOS Obj_Dal = new ARTICULOS();
        FACTURA_COMPRA fact = new FACTURA_COMPRA();
        FACTURAS facturas = new FACTURAS();


        public Frm_Total_Factura_PL()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

            Frm_Contado_PL cont = new Frm_Contado_PL();


            FACTURAS factura = new FACTURAS();

            factura.ID_Cliente = 7/*Convert.ToInt32(cont.txt_NoCliente.Text)*/;
            factura.ID_Caja =1 /*Convert.ToInt32(cont.txt_Caja.Text)*/;
            factura.Numero_Factura = Convert.ToInt32(txt_Factura.Text);
            factura.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            factura.Descripcion = "Compra";
            factura.Total =3 /*Convert.ToDecimal(cont.txt_Total.Text)*/;
            factura.Tipo_Pago = 1;
            factura.Estado = 20;          
              

            Factura_BLL.agregarFactura(factura);                    
          MessageBox.Show("Factura agregada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }



        private void Imprimir_PrintPage(object sender,PrintPageEventArgs e)
        {
            DataTable dt = new DataTable();


            Font font = new Font("Arial",14);
            int ancho = 350;
            int y = 20;
            int x = 250;

            e.Graphics.DrawString("---Veterinaria El Bosque----",font,Brushes.Black,new RectangleF(x,y+=40,ancho,20));
            e.Graphics.DrawString("Factura#:", font, Brushes.Black, new RectangleF(x, y+= 40, ancho, 20));
            e.Graphics.DrawString("IDCliente:", font, Brushes.Black, new RectangleF(x, y+= 20, ancho, 20));
            e.Graphics.DrawString("Cliente:", font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));
            e.Graphics.DrawString("FechaFactura:", font, Brushes.Black, new RectangleF(x, y+= 20, ancho, 20));
            

            e.Graphics.DrawString("---Productos/Servicios---", font, Brushes.Black, new RectangleF(x, y+= 40, ancho, 20));
            foreach(DataRow row in dt.Rows)
            {

                e.Graphics.DrawString(row["Codigo"].ToString()+" "+
                 row["Detalle"].ToString() + " " +
                 row["Cantidad"].ToString() + " " +
                 row["Precio Total"].ToString() 
               , font, Brushes.Black, new RectangleF(x, y+= 20, ancho, 20));

            }
            e.Graphics.DrawString("---SubTotal:", font, Brushes.Black, new RectangleF(x, y+= 30, ancho, 20));
            e.Graphics.DrawString("---Total: ¢"+facturas.Total, font, Brushes.Black, new RectangleF(x, y+= 20, ancho, 20));
            e.Graphics.DrawString("---GRACIAS POR VISITARNOS---", font, Brushes.Black, new RectangleF(x, y+= 50, ancho, 20));

        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            PrintDocument  printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir_PrintPage;
            printDocument1.Print();

            MessageBox.Show("Factura generada con exito");
            this.Hide();

        }
    }



}
