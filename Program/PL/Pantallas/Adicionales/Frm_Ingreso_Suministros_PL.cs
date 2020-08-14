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
            List<ARTICULOS_PROVEEDOR> ingreso_articuloproveedor = Suministros_BLL.SP_CREAR_ingreso_suministro(ID_Articulo_Proveedor);

            ingreso_articuloproveedor.Add(Suministros_BLL.(ID_Articulo_Proveedor)) = this.tb_idproveedor;
             Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
             this.tb_idproveedor.Refresh();
        }

        public void cargar_SolCompra(SOLICITUD_ARTICULOS lstParametros)
        {
            List<SOLICITUD_COMPRA> sol_Compras = Suministros_BLL.SP_CREAR_ingreso_suministro(ID_Solicitud_Compra);

            sol_Compras.Add(Suministros_BLL.(ID_Solicitud_Compra)) = this.tb_idformulario;
            Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
            this.tb_idformulario.Refresh();
        }

        public void cargar_Descrip(SOLICITUD_ARTICULOS lstParametros)
        {
            List<DETALLE_ARTICULOS> descrip_Art = Suministros_BLL.SP_CREAR_ingreso_suministro(Descripcion);

            descrip_Art.Add(Suministros_BLL.(Descripcion)) = this.tb_descrip;
            Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
            this.tb_descrip.Refresh();
        }

        public void cargar_cant_Art(SOLICITUD_ARTICULOS lstParametros)
        {
            List<SOLICITUD_ARTICULOS> cant_art = Suministros_BLL.SP_CREAR_ingreso_suministro(Cantidad);

            cant_art.Add(Suministros_BLL.(Cantidad)) = this.tb_cant;
            Suministros_BLL.SP_CREAR_ingreso_suministro(lstParametros);
            this.tb_cant.Refresh();
        }

        public void cargar_datagv(SOLICITUD_ARTICULOS listingreso_suministros
            )
        {
            this.dataGrid_ingresosumi.DataSource = null;
            this.dataGrid_ingresosumi = Suministros_BLL.(listingreso_suministros);
            this.dataGrid_ingresosumi.Refresh();
        }

        //public void crear_ingreso_suministros(SOLICITUD_ARTICULOS lstParametros)
        //{
        //        
        //        

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
