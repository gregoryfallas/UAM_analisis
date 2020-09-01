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
using DAL;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Contado_PL : Form
    {
        int EnviarFecha = 0;
        public static int cont_fila = 0;

        Articulos_BLL Obj_BLL = new Articulos_BLL();       
        DA Obj_Dal = new DA();        

        ARTICULOS ART = new ARTICULOS();        
        FACTURAS facturas = new FACTURAS();
        CLIENTES clientes = new CLIENTES();
        DETALLE_ARTICULOS Detalle = new DETALLE_ARTICULOS();
        SERVICIOS_EXPRESS express = new SERVICIOS_EXPRESS();
        CREDITOS Credito = new CREDITOS();
        
       
        bool bandera = false;
        int id;
        string producto;

        string nombre;
        string cedula;
        string idCliente;
        string tempcredito;


        public Frm_Contado_PL()
        {
            InitializeComponent();           

        }
      
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
             decimal cantidadproductos=0;

            cantidadproductos= Convert.ToDecimal(dtg_Articulos.SelectedRows[0].Cells[3].Value.ToString());
            ART.Cantidad = Convert.ToDecimal(txt_Cantidad.Text);

            ART.Subtotal = 0;            

            if (txt_Cantidad.Text==string.Empty || txt_Precio.Text == string.Empty)
            {

                MessageBox.Show("¡Debe ingresar un producto y cantidad !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (cantidadproductos<=0)
            {
                MessageBox.Show("¡Este producto se encuentra agotado !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
            }
            else if (ART.Cantidad>cantidadproductos)
            {
                MessageBox.Show("¡La cantidad seleccionada es mayor a la cantidad disponible del producto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cantidad.Focus();
            }
            else if (ART.Cantidad<1)
            {
                MessageBox.Show("¡No puede ingresar cantidades menores a 1 !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cantidad.Focus();
            }
            else
            {
                ART.Cantidad = Convert.ToDecimal(txt_Cantidad.Text);
                ART.Precio = Convert.ToDecimal(txt_Precio.Text);
                ART.Importe = ART.Precio * ART.Cantidad;
                txt_Importe.Text = ART.Importe.ToString();
                ART.Importe = Convert.ToDecimal(txt_Importe.Text);
                id = Convert.ToInt32(txt_Id_Articulo.Text);
                producto = txt_Nom_Produc.Text;
                

                if (ART.Importe > 0)
                {
                    dtg_Factura.Rows.Add(new string[] {
              Convert.ToString(id)/*dtg_Articulos[0,dtg_Articulos.CurrentRow.Index].Value)*/,
             Convert.ToString(producto/*dtg_Articulos[1, dtg_Articulos.CurrentRow.Index].Value*/),
             Convert.ToString(ART.Cantidad),
            Convert.ToString(ART.Precio/*dtg_Articulos[2, dtg_Articulos.CurrentRow.Index].Value*/),
            Convert.ToString(ART.Temporal_descuento),
            Convert.ToString(ART.Importe)});

                    for (int i = 0; i < dtg_Factura.RowCount; i++)
                    {
                        ART.Subtotal = ART.Subtotal + decimal.Parse(dtg_Factura.Rows[i].Cells[5].Value.ToString());

                        Math.Round(ART.Subtotal, 2);

                    }

                    txt_SubTotal.Text = ("¢") + Math.Round(ART.Subtotal).ToString();
                    ART.Impuesto = ART.Subtotal * Convert.ToDecimal(0.13);
                    txt_Impuesto.Text = ("¢") + Math.Round(ART.Impuesto).ToString();
                    facturas.Total = ART.Subtotal + ART.Impuesto;
                    txt_Total.Text = Math.Round(facturas.Total).ToString();


                    cont_fila++;

                    LimpiarCampos();

                }
            }
        }




            private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Frm_Contado_PL cont = new Frm_Contado_PL();
            FACTURAS factura = new FACTURAS();
            DETALLE_ARTICULOS detalle = new DETALLE_ARTICULOS();

                                                                           
            if (MessageBox.Show("¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_Nombre.Text==string.Empty)
                {
                    MessageBox.Show("¡Debe de seleccionar un Cliente!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }                
                else
                {
                    if (facturas.Total < 1)
                    {
                        MessageBox.Show("¡Debe de ingresar un Producto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        if (rdb_Contado.Checked==false && rdb_Credito.Checked==false)
                        {
                            MessageBox.Show("¡Debe de seleccionar un tipo de pago!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            if (txt_Descripcion.Text==string.Empty)
                            {
                                if (MessageBox.Show("¿Desea agregar una descripción a la factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    txt_Descripcion.Focus();
                                    factura.Descripcion = txt_Descripcion.Text;

                                }
                                else
                                {
                                    
                                    factura.ID_Cliente = Convert.ToInt32(txt_idCliente.Text);
                                    factura.ID_Caja = 1;
                                    factura.Numero_Factura = Convert.ToInt32(txt_Factura.Text);
                                    factura.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    factura.Total = Convert.ToDecimal(txt_Total.Text);
                                    factura.Descripcion = "Sin descripción";
                                    if (cb_Express.Checked==true)
                                    {
                                        factura.Estado = 21;
                                        Express_BLL.AgregarExpress(express);
                                    }
                                    else
                                    {
                                        factura.Estado = 1;
                                    }

                                    if (rdb_Contado.Checked == true)
                                    {
                                        factura.Tipo_Pago = 1;
                                    }
                                    else
                                    {
                                        factura.Tipo_Pago = 2;
                                    }

                                    
                                        bool result = Factura_BLL.agregarFactura(factura);

                                    ///EL DTG FACTURA ES EL QUE MUESTRA EL DETALLE DE LOS ARTICULOS INGRESADOS A LA FACTURA 
                                    if (result == true)
                                    {
                                        List<DETALLE_ARTICULOS> ListArticulos = new List<DETALLE_ARTICULOS>();

                                        for (int line = 0; line <= dtg_Factura.Rows.Count - 1; line++)
                                        {
                                            DETALLE_ARTICULOS obj_Articulos = new DETALLE_ARTICULOS();

                                            obj_Articulos.ID_Factura = factura.Numero_Factura;
                                            obj_Articulos.ID_Articulos = Convert.ToInt32(dtg_Factura.Rows[line].Cells[0].Value.ToString());
                                            obj_Articulos.Cantidad = Convert.ToInt32(dtg_Factura.Rows[line].Cells[2].Value.ToString());


                                            ListArticulos.Add(obj_Articulos);

                                        }
                                        Factura_BLL.agregarDetalleFactura(ListArticulos);


                                        if (tempcredito == "1")
                                        {
                                            //MessageBox.Show("Cliente cuenta con el crédito habilitado", "¡¡¡Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            Credito.ID_Factura = Convert.ToInt32(txt_Factura.Text);
                                            Credito.Monto_Anterior = Convert.ToDecimal(txt_Total.Text);
                                            Credito.Monto_Actual = Convert.ToDecimal(txt_Total.Text);

                                            Credito_BLL.AgregarCreditos(Credito);
                                        }



                                        MessageBox.Show("Factura agregada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        int articulo = Convert.ToInt32(dtg_Factura.SelectedRows[0].Cells[0].Value.ToString());
                                        decimal inventario = Convert.ToDecimal(dtg_Articulos.SelectedRows[0].Cells[3].Value.ToString());
                                        decimal ventas = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[2].Value.ToString());
                                        decimal total = inventario - ventas;

                                        Articulos_BLL.MODIFICAR_INVENTARIO(articulo, total);

                                        LimpiarCamposFactura();
                                        dtg_Articulos.Refresh();
                                        Cargar2();
                                        CargarNoFactura();
                                      
                                    }
                                                                        
                                }
                            }

                            else
                            {

                                factura.ID_Cliente = Convert.ToInt32(txt_idCliente.Text);
                                factura.ID_Caja = 1;
                                factura.Numero_Factura = Convert.ToInt32(txt_Factura.Text);
                                factura.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                factura.Total = Convert.ToDecimal(txt_Total.Text);
                                factura.Descripcion =txt_Descripcion.Text;

                                

                                if (rdb_Contado.Checked == true)
                                {
                                    factura.Tipo_Pago = 1;
                                }
                                else
                                {
                                    factura.Tipo_Pago = 2;
                                }
                                

                                //bool result = Factura_BLL.agregarFactura(factura);
                                if (cb_Express.Checked == true)
                                {

                                    factura.Estado = 21;
                                    bool result = Factura_BLL.agregarFactura(factura);
                                    if (result == true)
                                    {
                                        List<DETALLE_ARTICULOS> ListArticulos = new List<DETALLE_ARTICULOS>();

                                        for (int line = 0; line <= dtg_Factura.Rows.Count - 1; line++)
                                        {
                                            DETALLE_ARTICULOS obj_Articulos = new DETALLE_ARTICULOS();

                                            obj_Articulos.ID_Factura = factura.Numero_Factura;
                                            obj_Articulos.ID_Articulos = Convert.ToInt32(dtg_Factura.Rows[line].Cells[0].Value.ToString());
                                            obj_Articulos.Cantidad = Convert.ToInt32(dtg_Factura.Rows[line].Cells[2].Value.ToString());


                                            ListArticulos.Add(obj_Articulos);

                                        }
                                        Factura_BLL.agregarDetalleFactura(ListArticulos);


                                        MessageBox.Show("Factura agregada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                        int articulo = Convert.ToInt32(dtg_Factura.SelectedRows[0].Cells[0].Value.ToString());
                                        decimal inventario = Convert.ToDecimal(dtg_Articulos.SelectedRows[0].Cells[3].Value.ToString());
                                        decimal ventas = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[2].Value.ToString());
                                        decimal total = inventario - ventas;

                                        Articulos_BLL.MODIFICAR_INVENTARIO(articulo, total);

                                        LimpiarCamposFactura();
                                        dtg_Articulos.Refresh();
                                        Cargar2();
                                        CargarNoFactura();

                                    }
                                    Express_BLL.AgregarExpress(express);

                                }
                                else
                                {
                                    factura.Estado = 1;

                                    bool result = Factura_BLL.agregarFactura(factura);
                                    if (result == true)
                                    {
                                        List<DETALLE_ARTICULOS> ListArticulos = new List<DETALLE_ARTICULOS>();

                                        for (int line = 0; line <= dtg_Factura.Rows.Count - 1; line++)
                                        {
                                            DETALLE_ARTICULOS obj_Articulos = new DETALLE_ARTICULOS();

                                            obj_Articulos.ID_Factura = factura.Numero_Factura;
                                            obj_Articulos.ID_Articulos = Convert.ToInt32(dtg_Factura.Rows[line].Cells[0].Value.ToString());
                                            obj_Articulos.Cantidad = Convert.ToInt32(dtg_Factura.Rows[line].Cells[2].Value.ToString());


                                            ListArticulos.Add(obj_Articulos);

                                        }
                                        Factura_BLL.agregarDetalleFactura(ListArticulos);


                                        MessageBox.Show("Factura agregada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                        int articulo = Convert.ToInt32(dtg_Factura.SelectedRows[0].Cells[0].Value.ToString());
                                        decimal inventario = Convert.ToDecimal(dtg_Articulos.SelectedRows[0].Cells[3].Value.ToString());
                                        decimal ventas = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[2].Value.ToString());
                                        decimal total = inventario - ventas;

                                        Articulos_BLL.MODIFICAR_INVENTARIO(articulo, total);

                                        LimpiarCamposFactura();
                                        dtg_Articulos.Refresh();
                                        Cargar2();
                                        CargarNoFactura();

                                    }



                                }

                                ///EL DTG FACTURA ES EL QUE MUESTRA EL DETALLE DE LOS ARTICULOS INGRESADOS A LA FACTURA 
                               
                            }
                               
                         }                              

                     }
                }                

            }                             
            
     }

        private void btn_Orden_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Cargar Servicios Médicos ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Servicios_PL Servicios = new Frm_Servicios_PL();
                Servicios.ShowDialog();
                CargarServicios();

            }
            
        }


        private void Frm_Contado_PL_Load(object sender, EventArgs e)
        {

            timer1.Interval = 500;
            timer1.Start();
            Cargar();
            Cargar2();
            CargarNoFactura();

           

        }

        public  void CargarServicios()
        {
            bandera = Frm_Servicios_PL.bandera;
            if (bandera == true)
            {
                txt_Nom_Produc.Text = Frm_Servicios_PL.Servicio;
                txt_Cantidad.Text = Frm_Servicios_PL.cantidad.ToString();
                txt_Precio.Text = Frm_Servicios_PL.precio.ToString();
                txt_Id_Articulo.Text = Frm_Servicios_PL.idServicio.ToString();
            }

        }




        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

                   

        private void Cargar ()
        {
            try
            {
                List<CLIENTES> LS = Factura_BLL.ConsultarClientesFactura(txt_Cliente.Text.Trim());

                DataTable dt = new DataTable();

                dt.Columns.Add("Cedula");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Primer_Apellido");
                dt.Columns.Add("Segundo_Apellido");
                dt.Columns.Add("IdCliente");




                foreach (CLIENTES item in LS)
                {
                    dt.Rows.Add
                        (
                        item.Cedula,
                        item.Nombre,
                        item.Apellido_1,
                        item.Apellido_2,
                        item.ID_Cliente
                        );
                }


                dtg_Clientes.DataSource = null;
                dtg_Clientes.Refresh();
                dtg_Clientes.DataSource = dt;
                dtg_Clientes.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Se debe ingresar primero un cliente ");
            }



            

        }
                  


private void Cargar2()
        {

            try
            {

                this.dtg_Articulos.DataSource = null;
                this.dtg_Articulos.Refresh();
                string a = txt_Producto.Text.Trim();
                this.dtg_Articulos.DataSource = Articulos_BLL.ConsultarInventarioArticulos(a);
                this.dtg_Articulos.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }


        private void CargarDatos()
        {
            try
            {

                this.dtg_Factura.DataSource = null;
                this.dtg_Factura.Refresh();
                string a = txt_Nombre.Text.Trim();
                this.dtg_Factura.DataSource = Articulos_BLL.ConsultarInventarioArticulos(a);
                this.dtg_Factura.Refresh();

            }
            catch (Exception)
            {

                throw;
            }

        }



        private void txt_Cantidad_Leave(object sender, EventArgs e)
        {
            
           
            
        }


        private void LimpiarCampos()
        {
            txt_Cantidad.Text = "";
            txt_Precio.Text = "";
            txt_Importe.Text = "";
            txt_Descuento.Text = "0";
            txt_Nom_Produc.Text = "";
            txt_Id_Articulo.Text = "";
        }


        private void txt_Descuento_Leave(object sender, EventArgs e)
        {
            if (txt_Descuento.Text==string.Empty)
            {
                ART.Temporal_descuento = 0;
                txt_Descuento.Text = ART.Temporal_descuento.ToString();
            }
            else
            {
                ART.Temporal_descuento = Convert.ToDecimal(txt_Descuento.Text.ToString().Trim());
                if (ART.Temporal_descuento >= 1)
                {

                    ART.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                    ART.Importe = ART.Precio * ART.Cantidad;
                    ART.Descuento = ART.Importe * ART.Temporal_descuento / 100;
                    ART.Importe = ART.Importe - ART.Descuento;
                    txt_Importe.Text = ART.Importe.ToString();
                }
                else
                {

                    ART.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.ToString().Trim());
                    ART.Importe = ART.Precio * ART.Cantidad;
                    txt_Importe.Text = ART.Importe.ToString();
                }
            }

                        

        }


        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        private void txt_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
                             

        private void CapturarFechaSistema()
        {
            txt_Fecha_Doc.Text = DateTime.Now.ToShortDateString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {           
                switch (EnviarFecha)
                {
                    case 0: CapturarFechaSistema(); break;
                }
            
        }


        private void dtg_Factura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Factura.Rows.Count > 0)
            {
                ART.Cantidad = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[2].Value.ToString());
                ART.Descuento = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[4].Value.ToString());
                ART.Importe = Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[5].Value.ToString());
                ART.Precio= Convert.ToDecimal(dtg_Factura.SelectedRows[0].Cells[3].Value.ToString());
                ART.Nombre= dtg_Factura.SelectedRows[0].Cells[1].Value.ToString();
                ART.ID_Articulos= Convert.ToInt32(dtg_Factura.SelectedRows[0].Cells[0].Value.ToString());


                txt_Cantidad.Text = ART.Cantidad.ToString();
                txt_Descuento.Text = ART.Descuento.ToString();
                txt_Precio.Text = ART.Precio.ToString();
                txt_Importe.Text = ART.Importe.ToString();
                txt_Nom_Produc.Text = ART.Nombre.ToString();
                txt_Id_Articulo.Text = ART.ID_Articulos.ToString();
            }
            
        }

        

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
             try
            {

                if (cont_fila >= 0)
                {

                    ART.Subtotal = ART.Subtotal - (Convert.ToDecimal(dtg_Factura.CurrentRow.Cells[5].Value.ToString()));
                    txt_SubTotal.Text = Math.Round(ART.Subtotal).ToString();
                    ART.Impuesto = ART.Subtotal * Convert.ToDecimal(0.13);
                    txt_Impuesto.Text = Math.Round(ART.Impuesto).ToString();
                    dtg_Factura.Rows.RemoveAt(dtg_Factura.CurrentRow.Index);
                    facturas.Total = ART.Subtotal + ART.Impuesto;
                    txt_Total.Text = Math.Round(facturas.Total).ToString();

                    cont_fila--;

                    txt_Cantidad.Text = "";
                    txt_Importe.Text = "";
                    txt_Precio.Text = "";
                    txt_Descuento.Text = "0";
                    txt_Nom_Produc.Text = "";
                    txt_Id_Articulo.Text = "";


                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay líneas de productos por eliminar");
                
            }







        }

        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btn_Productos_Click_1(object sender, EventArgs e)
        {
            Cargar2();
        }

        private void dtg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dtg_Clientes.CurrentRow.Cells[1].Value.ToString() + " " + dtg_Clientes.CurrentRow.Cells[2].Value.ToString() + " " + dtg_Clientes.CurrentRow.Cells[3].Value.ToString();
            txt_Nombre.Text = nombre;

            cedula= dtg_Clientes.CurrentRow.Cells[0].Value.ToString();
            txt_NoCliente.Text = cedula;

            idCliente= dtg_Clientes.CurrentRow.Cells[4].Value.ToString();
            txt_idCliente.Text = idCliente;

            rdb_Credito.Checked =false;
            rdb_Contado.Checked = false;           

            
        }

        private void dtg_Articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id = Convert.ToInt32(dtg_Articulos.CurrentRow.Cells[0].Value.ToString());
            txt_Id_Articulo.Text = id.ToString();
            ART.Precio = Convert.ToDecimal(dtg_Articulos.CurrentRow.Cells[2].Value.ToString());
            txt_Precio.Text = ART.Precio.ToString();

            ART.Nombre = dtg_Articulos.CurrentRow.Cells[1].Value.ToString();
            txt_Nom_Produc.Text = ART.Nombre;

        }

        private void CargarNoFactura()
        {

            try
            {
                Factura_BLL Factura = new Factura_BLL();

                List<FACTURAS> LS = Factura_BLL.ConsultarNoFacturas();

                FACTURAS factura = new FACTURAS();


                foreach (var li in LS)
                {

                    factura.Numero_Factura = li.Numero_Factura;
                    factura.Numero_Factura = factura.Numero_Factura + 1;
                    txt_Factura.Text = factura.Numero_Factura.ToString();
                }


            }
            catch (Exception)
            {
                FACTURAS factura = new FACTURAS();
                factura.Numero_Factura = factura.Numero_Factura + 1;
                txt_Factura.Text = factura.Numero_Factura.ToString();
            }



          


        }


        private void LimpiarCamposFactura()
        {
            txt_NoCliente.Text = "";
            txt_Cantidad.Text = "";
            txt_Cliente.Text= "";
            txt_Descuento.Text= "";
            txt_Importe.Text= "";
            txt_Nombre.Text= "";
            txt_Precio.Text= "";
            txt_Producto.Text= "";
            txt_SubTotal.Text= "";
            txt_Total.Text= "";     
            txt_Impuesto.Text= "";
            dtg_Factura.Rows.Clear();
            rdb_Contado.Checked = false;
            rdb_Credito.Checked = false;
            txt_Factura.Text = "";
            cb_Express.Checked = false;
            txt_Descripcion.Text = "";
            txt_Id_Articulo.Text = "";
        }

        private void rdb_Credito_Click(object sender, EventArgs e)
        {


            try
            {
                string tempcedula;
                //string tempcredito;

                CLIENTES consulta = new CLIENTES();
                List<CLIENTES> resultado = new List<CLIENTES>();
                resultado = Factura_BLL.ConsultarClientesCreditos(txt_Cliente.Text);

                tempcedula = dtg_Clientes.CurrentRow.Cells[0].Value.ToString();


                if(txt_Nombre.Text==string.Empty)
                {
                    MessageBox.Show("Debe seleccionar primero un cliente", "¡¡¡Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (var li in resultado)
                    {
                        consulta.Cedula = li.Cedula;

                        if (tempcedula == li.Cedula)
                        {
                            tempcredito = li.Credito.ToString();

                            if (tempcredito == "1")
                            {
                                MessageBox.Show("Cliente cuenta con el crédito habilitado", "¡¡¡Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                //Credito.ID_Factura = Convert.ToInt32(txt_Factura.Text);
                                //Credito.Monto_Anterior = Convert.ToDecimal(txt_Total.Text);
                                //Credito.Monto_Actual = Convert.ToDecimal(txt_Total.Text);

                                //Credito_BLL.AgregarCreditos(Credito);


                            }
                            else
                            {
                                MessageBox.Show("Cliente NO cuenta con crédito habilitado", "¡¡¡Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }                               
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar todos los campos requeridos", "¡¡¡Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       


            }



        private void cb_Express_Click(object sender, EventArgs e)
        {
            if (cb_Express.Checked == true)
            {
                if (MessageBox.Show("¿Desea enviarlo por express?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rdb_Contado.Checked = true;
                    rdb_Credito.Checked = false;
                    express.ID_Factura = Convert.ToInt32(txt_Factura.Text);
                    express.Descripcion = txt_Nombre.Text;
                    express.Estado = 1;                    

                }
            }
            
        }
    }
}
