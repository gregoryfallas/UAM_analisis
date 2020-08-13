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
using DAL.Entidades;using PL.Pantallas.Principales;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Ingreso_Suministros_PL : Form
    {
        public Frm_Ingreso_Suministros_PL()
        {
            InitializeComponent();
            crear_ingreso_suministros();
            listingreso_suministros = new list<Frm_Ingreso_Suministros_PL>();

        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void crear_ingreso_suministros()
        {
                this.tb_cant = null;
                this.tb_descrip = null;
                this.tb_idarticulo = null;
                this.tb_idformulario = null;
                this.tb_idproveedor = null;
                this.dataGrid_ingresosumi.DataSource = null;

                this.dataGrid_ingresosumi.DataSource = Suministros_BLL.SP_CREAR_ingreso_suministro();
                this.tb_descrip = null;
                this.tb_idarticulo = null;
                this.tb_idformulario = null;
                this.tb_idproveedor = null;
                this.dataGrid_ingresosumi.DataSource = null;

                 this.dataGrid_ingresosumi.Refresh();
        }
                public partial List<Frm_Ingreso_Suministros_PL> listingreso_suministros { get; set; }
                public bool esError { get; set; }
    }
                public cargardatos_ingreso_sumi()
                {
                    List<Frm_Ingreso_Suministros_PL>listingreso_suministros = sp_

                }

}
