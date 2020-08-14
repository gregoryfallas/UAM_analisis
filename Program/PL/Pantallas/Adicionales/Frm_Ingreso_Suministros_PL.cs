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
        private int ID_Articulo_Proveedor = 0;
        private int ID_Solicitud_Compra = 0;
        private int Cantidad = 0;
        private String Descripcion = null;

        public List<Suministros_BLL> listingreso_suministros { get; set; }
        public bool esError { get; set; }
        
        public Frm_Ingreso_Suministros_PL()
        {
            DAL.Entidades.SOLICITUD_ARTICULOS sa = new SOLICITUD_ARTICULOS();
            InitializeComponent();
            //cargar textbox 
           
        }
        public void cargar_arProveedor(SOLICITUD_ARTICULOS lstParametros)
        {
            List<ARTICULOS_PROVEEDOR> ingreso_articuloproveedor = Suministros_BLL.SP_CREAR_ingreso_suministro(in_sumi);

            this.tb_cant.DataSource = lstParametros;
            this.tb_cant = Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
            this.tb_cant.Refresh();
        }

        public void cargar_SolCompra(SOLICITUD_ARTICULOS lstParametros)
        {
            List<SOLICITUD_COMPRA> ingreso_articuloproveedor = Suministros_BLL.SP_CREAR_ingreso_suministro(in_sumi);

            this.tb_idformulario.DataSource = lstParametros;
            this.tb_idformulario = Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
            this.tb_idformulario.Refresh();
        }
        
        
       
        //public void crear_ingreso_suministros(SOLICITUD_ARTICULOS lstParametros)
        //{
        //        
        //        this.dataGrid_ingresosumi.DataSource = null;

        //    this.dataGrid_ingresosumi.DataSource = Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
        //        this.tb_descrip = null;
        //        this.tb_idarticulo = null;
        //        this.tb_idformulario = null;
        //        this.tb_idproveedor = null;
        //        this.dataGrid_ingresosumi.DataSource = null;

        //        this.dataGrid_ingresosumi.Refresh();
        //}

        //public void cargardatos_ingreso_sumi()
        //{
        //    List<ARTICULOS_PROVEEDOR> aRTICULOS_PROVEEDORs = in_sumi.ingreso_articuloproveedor;
        //    List<SOLICITUD_COMPRA> sOLICITUD_COMPRAs = in_sumi.ingreso_Solicitudcompra;
        //    List<SOLICITUD_ARTICULOS> sOLICITUD_ARTICULOs = in_sumi.ingreso_Cantidad;
        //    List<DETALLE_ARTICULOS> dETALLE_ARTICULOs = in_sumi.ingreso_Descripcion;
        //}



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
