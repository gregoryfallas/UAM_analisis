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
using PL.Pantallas.Principales;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Ingreso_Suministros_PL : Form
    {
        private int ID_Solicitud_Articulos = 0;
        private int ID_Articulo_Proveedor = 0;
        private int ID_Solicitud_Compra = 0;
        private int Cantidad = 0;
        private String Descripcion = null;

        public List<Suministros_BLL> listingreso_suministros { get; set; }
        public bool esError { get; set; }
        
        public Frm_Ingreso_Suministros_PL()
        {
            InitializeComponent();
            listingreso_suministros = new list<Suministros_BLL>();
            crear_ingreso_suministros();
            cargardatos_ingreso_sumi();
        }

        private void crear_ingreso_suministros()
        {
                this.tb_cant = null;
                this.tb_descrip = null;
                this.tb_idarticulo = null;
                this.tb_idformulario = null;
                this.tb_idproveedor = null;
                this.dataGrid_ingresosumi.DataSource = null;

                this.dataGrid_ingresosumi.DataSource = Suministros_BLL.SP_CREAR_ingreso_suministro(in_sumi: SOLICITUD_ARTICULOS);
                this.tb_descrip = null;
                this.tb_idarticulo = null;
                this.tb_idformulario = null;
                this.tb_idproveedor = null;
                this.dataGrid_ingresosumi.DataSource = null;

                this.dataGrid_ingresosumi.Refresh();
        }

         public cargardatos_ingreso_sumi(SQLSentencia)
         {
            List<ARTICULOS_PROVEEDOR> listingreso_suministros = in_sin_sumi.ingreso_articuloproveedor;
            List<SOLICITUD_COMPRA> listingreso_suministros = in_sumi.ingreso_Solicitudcompra;
            List<SOLICITUD_ARTICULOS> listingreso_suministros = in_sumi.ingreso_Cantidad;
            List<DETALLE_ARTICULOS> listingreso_suministros = in_sumi.ingreso_Descripcion;
            //DUDAS EN LAS DOS ULTIMAS LINEAS
         }


          
        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {

        }
    }
}
