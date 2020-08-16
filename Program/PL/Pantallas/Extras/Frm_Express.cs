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
using BLL;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Express : Form
    {


        private int estado;

        public Frm_Express()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Express_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_Estado.Text = cmb_Estado.SelectedIndex.ToString();
            estado = cmb_Estado.SelectedIndex+1;
            Cargar();

        }


        private void Cargar()
        {
            SERVICIOS_EXPRESS express = new SERVICIOS_EXPRESS();

            
            List<SERVICIOS_EXPRESS> LS = Express_BLL.ConsultarExpress(estado);

            DataTable dt = new DataTable();

            dt.Columns.Add("IdServicio");
            dt.Columns.Add("IdFactura");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Estado");



            foreach (SERVICIOS_EXPRESS item in LS)
            {
                dt.Rows.Add
                    (
                    item.ID_Servicios,
                    item.ID_Factura,
                    item.Descripcion,
                    item.Estado
                    );
            }


            dtg_Express.DataSource = null;
            dtg_Express.Refresh();
            dtg_Express.DataSource = dt;
            dtg_Express.Refresh();


        }



    }
}
