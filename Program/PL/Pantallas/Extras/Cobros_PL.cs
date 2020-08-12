using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entidades;
using DAL;
using BLL;
using System.Drawing.Printing;

namespace PL.Pantallas.Extras
{
    public partial class Cobros_PL : Form
    {
        int EnviarFecha = 0;

        DA Dal = new DA();
        FACTURAS facturas = new FACTURAS();
        Factura_BLL factu = new Factura_BLL();

        string nombre;
        string cedula;
        string fechadocumento;
        string factura;
         string total;
        decimal pago;
        decimal cambio;


        public Cobros_PL()
        {
            InitializeComponent();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            //PrintDocument printDocument1 = new PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //printDocument1.PrinterSettings = ps;
            //printDocument1.PrintPage += Imprimir_PrintPage;
            //printDocument1.Print();

            MessageBox.Show("Factura generada con exito");
            
        }

        private void Cobros_PL_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();

            Cargar2();

        }

        private void Cargar2()
        {

            try
            {

                this.dtg_Cobros.DataSource = null;
                this.dtg_Cobros.Refresh();
                string a = txt_Cliente.Text.Trim();
                this.dtg_Cobros.DataSource = Cls_Cobros_BLL.ConsultarCobros(a);
                this.dtg_Cobros.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar2();

            txt_Nombre.Text ="";
            txt_NoCliente.Text ="";
            txt_Fecha_Doc.Text = "";
            txt_Factura.Text ="";
            txt_Total.Text = "";
        }

        private void CapturarFechaSistema()
        {
            txt_Fecha.Text = DateTime.Now.ToShortDateString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (EnviarFecha)
            {
                case 0: CapturarFechaSistema(); break;
            }
        }

        private void dtg_Cobros_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            nombre = dtg_Cobros.CurrentRow.Cells[1].Value.ToString() + " " + dtg_Cobros.CurrentRow.Cells[2].Value.ToString() + " " + dtg_Cobros.CurrentRow.Cells[3].Value.ToString();
            cedula = dtg_Cobros.CurrentRow.Cells[0].Value.ToString();
            fechadocumento= dtg_Cobros.CurrentRow.Cells[4].Value.ToString();
            factura= dtg_Cobros.CurrentRow.Cells[5].Value.ToString();
            total= dtg_Cobros.CurrentRow.Cells[6].Value.ToString();

            txt_Nombre.Text = nombre;
            txt_NoCliente.Text = cedula;
            txt_Fecha_Doc.Text = fechadocumento;
            txt_Factura.Text = factura;
            txt_Total.Text = total.ToString();


        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

            try
            {

                total = dtg_Cobros.CurrentRow.Cells[6].Value.ToString();
                pago = Convert.ToDecimal(txt_Pago.Text.ToString());
                cambio = Convert.ToDecimal(total) - (pago);
                txt_Cambio.Text = cambio.ToString();




                if (MessageBox.Show("¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_Nombre.Text == string.Empty)
                    {
                        MessageBox.Show("¡Tiene que seleccionar un Cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (rdb_Efectivo.Checked == false && rdb_Tarjeta.Checked == false)
                        {
                            MessageBox.Show("¡Tiene que seleccionar una forma de pago!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            if (rdb_Efectivo.Checked == true)
                            {
                                factura = "Compra Efectivo";
                            }
                            else
                            {
                                facturas.Descripcion = "Compra Tarjeta";
                            }

                            Factura_BLL.ModificarFacturas(Convert.ToInt32(txt_Factura.Text),1);                             

                            //facturas.Numero_Factura = Convert.ToInt32(txt_Factura.Text);
                            facturas.Estado = 21;

                            MessageBox.Show("Factura pagada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btn_Imprimir.Enabled = true;

                        }



                    }
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Falta de ingresar datos");
            }



        }

    }

}







        //private void Imprimir_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    DataTable dt = new DataTable();

        //    Font font = new Font("Arial", 14);
        //    int ancho = 350;
        //    int y = 20;
        //    int x = 250;

        //    e.Graphics.DrawString("---Veterinaria El Bosque----", font, Brushes.Black, new RectangleF(x, y += 40, ancho, 20));
        //    e.Graphics.DrawString("Factura#:" + txt_Factura.Text, font, Brushes.Black, new RectangleF(x, y += 40, ancho, 20));
        //    e.Graphics.DrawString("IDCliente:" + txt_idCliente.Text, font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));
        //    e.Graphics.DrawString("Cliente: " + txt_Nombre.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
        //    e.Graphics.DrawString("FechaFactura: " + txt_Fecha_Doc.Text, font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));


        //    e.Graphics.DrawString("---Productos/Servicios---", font, Brushes.Black, new RectangleF(x, y += 40, ancho, 20));



        //    foreach (DataGridViewColumn columna in this.dtg_Factura.Columns)
        //    {


        //        DataColumn col = new DataColumn(columna.Name);


        //        dt.Columns.Add(col);


        //    }
        //    string nombre;
        //    string cantidad;
        //    string precio;
        //    string descuento;
        //    string total;

        //    foreach (DataGridViewRow row in dtg_Factura.Rows)
        //    {

        //        DataRow dr = dt.NewRow();
        //        dr[0] = row.Cells[0].Value.ToString();
        //        dr[1] = row.Cells[1].Value.ToString();
        //        dr[2] = row.Cells[2].Value.ToString();
        //        dr[3] = row.Cells[3].Value.ToString();
        //        dr[4] = row.Cells[4].Value.ToString();


        //        nombre = dr[0].ToString();
        //        cantidad = dr[1].ToString();
        //        precio = dr[2].ToString();
        //        descuento = dr[3].ToString();
        //        total = dr[4].ToString();

        //        e.Graphics.DrawString(nombre + " " + cantidad + " " + precio + " " + descuento + " " + total, font, Brushes.Black, new RectangleF(x, y += 20, ancho, 20));


        //    }
        //    e.Graphics.DrawString("---SubTotal: " + txt_SubTotal.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
        //    e.Graphics.DrawString("---Impuesto: " + txt_Impuesto.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
        //    e.Graphics.DrawString("---Total:" + "¢" + txt_Total.Text, font, Brushes.Black, new RectangleF(x, y += 30, ancho, 20));
        //    e.Graphics.DrawString("---GRACIAS POR VISITARNOS---", font, Brushes.Black, new RectangleF(x, y += 50, ancho, 20));




        //}







