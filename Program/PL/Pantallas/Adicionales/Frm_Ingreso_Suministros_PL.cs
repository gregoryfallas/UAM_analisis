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
        private String Descripcion = " ";

        public List<Suministros_BLL> listingreso_suministros { get; set; }
        public bool esError { get; set; }

        public Frm_Ingreso_Suministros_PL()
        {
            DAL.Entidades.SOLICITUD_ARTICULOS sa = new SOLICITUD_ARTICULOS();
            InitializeComponent();
            cargarGridingreso_Suministros();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
            
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            SOLICITUD_ARTICULOS lstresultados = new SOLICITUD_ARTICULOS();
            lstresultados.ID_Articulo_Proveedor = ID_Articulo_Proveedor;
            lstresultados.ID_Solicitud_Compra = ID_Solicitud_Compra;
            lstresultados.Descripcion = Descripcion;
            lstresultados.Cantidad = Cantidad;

            Suministros_BLL.agregarSuministros(lstresultados);

            MessageBox.Show("Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cargarGridingreso_Suministros()
        {
            try
            {
                List<SOLICITUD_ARTICULOS> listingreso_suministros = Suministros_BLL.CREAR_ingreso_suministros(ID_Solicitud_Compra);

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Articulo");
                dt.Columns.Add("ID Articulo Proveedor");
                dt.Columns.Add("ID Solicitud");
                dt.Columns.Add("Descripión");
                dt.Columns.Add("Cantidad");

                foreach (SOLICITUD_ARTICULOS item in listingreso_suministros)
                {
                    dt.Rows.Add
                        (
                        item.ID_Articulo_Proveedor,
                        item.ID_Solicitud_Articulos,
                        item.Descripcion,
                        item.Cantidad
                       );
                }
                this.dataGrid_ingresosumi.DataSource = null;
                this.dataGrid_ingresosumi.Refresh();
                this.dataGrid_ingresosumi.DataSource = dt;
                this.dataGrid_ingresosumi.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
