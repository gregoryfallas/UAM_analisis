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
using PL.Pantallas.Principales;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Ingreso_Suministros_PL : Form
    {
        public Frm_Ingreso_Suministros_PL()
        {
            InitializeComponent();

        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void CARGAR_ingreso_suministros()
        {

            try
            {
                this.tb_cant = null;
                this.tb_descrip = null;
                this.tb_idarticulo = null;
                this.tb_idformulario = null;
                this.tb_idproveedor = null;
                this.dataGrid_ingresosumi.DataSource = null;

                this.dataGrid_ingresosumi.DataSource = Suministros_BLL.SP_CREAR_ingreso_suministro();
                // this.cantidad = tb_cant;
                this.tb_descrip = null;
                this.tb_idarticulo = null;
                this.tb_idformulario = null;
                this.tb_idproveedor = null;
                this.dataGrid_ingresosumi.DataSource = null;


                this.dataGrid_ingresosumi.Refresh();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
                Grua grua = new Grua();
                grua.idChofer = Convert.ToInt32(cbIdChofer.Text.Substring(0, 1));
                grua.ubicacion = tbUbicacion.Text.Trim();
                grua.estadoGrua = cbEstadogGrua.Text.Trim();
                LN.agregarGrua(grua);
                MessageBox.Show("Informacion Grua Agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridGruas();
                cargarBoxChoferes();

            Articulo ingreso = new 
                ID_Solicitud_Articulos = new ID_Solicitud_Articulos

            ID_Articulo_Proveedor
			ID_Solicitud_Compra 
			Cantidad ,
			Descripcion
            }
        }
    }
}
