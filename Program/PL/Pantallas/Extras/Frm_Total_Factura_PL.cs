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

namespace PL.Pantallas.Extras
{
    public partial class Frm_Total_Factura_PL : Form
    {
        public Frm_Total_Factura_PL()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
                           

        }


            
        

        private void Frm_Total_Factura_PL_Load(object sender, EventArgs e)
        {
            
        }

        private void gpb_Metodo_Enter(object sender, EventArgs e)
        {
            
           

        }

        

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
            e.Graphics.DrawString("---Total: ¢", font, Brushes.Black, new RectangleF(x, y+= 20, ancho, 20));
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
