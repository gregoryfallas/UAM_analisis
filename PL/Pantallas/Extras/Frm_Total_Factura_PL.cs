using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (rdb_Contado.Checked==false && rdb_Credito.Checked==false)
            {
                MessageBox.Show("Tiene que seleccionar una forma de pago");

             }
            else
            {
                if (rdb_Efectivo.Checked==false && rdb_Tarjeta.Checked==false)
                {
                    MessageBox.Show("Tiene que seleccionar un método de pago");
                }
                else
                {                  

                    if (rdb_Efectivo.Checked==true)
                    {
                        MessageBox.Show("Su cambio es de:" + txt_Cambio.Text);
                    }
                    else
                    {
                        MessageBox.Show("Pago Realizado con exito:" + txt_Cambio.Text);
                    }

                }

               

            }


            
        }

        private void Frm_Total_Factura_PL_Load(object sender, EventArgs e)
        {
           
        }

        private void gpb_Metodo_Enter(object sender, EventArgs e)
        {
            
           

        }

        

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdb_Credito.Checked == true || rdb_Tarjeta.Checked == true)
            {
                txt_Monto.ReadOnly = true;
                txt_Monto.Text = "";
            }
            else
            {
                txt_Monto.ReadOnly = false;
            }
        }
    }



}
