using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using System.Data.SqlClient;
using DAL;
using System.Data;

namespace BLL
{
    public class Factura_BLL
    {

        public static List<CLIENTES> ConsultarClientesFactura(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CLIENTES_FACTURA @Nombre";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Nombre;
                paramC.ParameterName = "@Nombre";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarClientesFactura(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }






        public static bool agregarFactura(FACTURAS factura)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_AGREGAR_FACTURA @idCliente,@idCaja,@numeroFactura,@fecha, @descripcion,@total,@tipoPago,@estado";
                SqlParameter paramIdCliente = new SqlParameter();
                paramIdCliente.Value = factura.ID_Cliente;
                paramIdCliente.ParameterName = "@idCliente";
                paramIdCliente.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramIdCaja = new SqlParameter();
                paramIdCaja.Value = factura.ID_Caja;
                paramIdCaja.ParameterName = "@idCaja";
                paramIdCaja.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramnumeroFactura = new SqlParameter();
                paramnumeroFactura.Value = factura.Numero_Factura;
                paramnumeroFactura.ParameterName = "@numeroFactura";
                paramnumeroFactura.SqlDbType = System.Data.SqlDbType.Int;


                SqlParameter paramFecha = new SqlParameter();
                paramFecha.Value = factura.Fecha;
                paramFecha.ParameterName = "@fecha";
                paramFecha.SqlDbType = System.Data.SqlDbType.Date;

                SqlParameter paramdescripcion = new SqlParameter();
                paramdescripcion.Value = factura.Descripcion;
                paramdescripcion.ParameterName = "@descripcion";
                paramdescripcion.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramtotal = new SqlParameter();
                paramtotal.Value = factura.Total;
                paramtotal.ParameterName = "@total";
                paramtotal.SqlDbType = System.Data.SqlDbType.Decimal;

                SqlParameter paramtipoPago = new SqlParameter();
                paramtipoPago.Value = factura.Tipo_Pago;
                paramtipoPago.ParameterName = "@tipoPago";
                paramtipoPago.SqlDbType = System.Data.SqlDbType.TinyInt;

                SqlParameter paramestado = new SqlParameter();
                paramestado.Value = factura.Estado;
                paramestado.ParameterName = "@estado";
                paramestado.SqlDbType = System.Data.SqlDbType.Int;



                peticion.lstParametros.Add(paramIdCliente);
                peticion.lstParametros.Add(paramIdCaja);
                peticion.lstParametros.Add(paramnumeroFactura);
                peticion.lstParametros.Add(paramFecha);
                peticion.lstParametros.Add(paramdescripcion);
                peticion.lstParametros.Add(paramtotal);
                peticion.lstParametros.Add(paramtipoPago);
                peticion.lstParametros.Add(paramestado);

                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<FACTURAS> ConsultarNoFacturas()
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_NoFactura";               
                DA acceso = new DA();
                return acceso.ConsultarNoFacturas(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }




        public static bool agregarDetalleFactura(List<DETALLE_ARTICULOS> detalle)
        {
            
            try
            {
                foreach (DETALLE_ARTICULOS item in detalle)
                {
                    SQLSentencia peticion = new SQLSentencia();
                    peticion.Peticion = @"EXEC SP_INSERTAR_DETALLE_ARTICULOS @idFactura,@idArticulos,@idCantidad";
                    SqlParameter paramIdFactura = new SqlParameter();
                    paramIdFactura.Value = item.ID_Factura;
                    paramIdFactura.ParameterName = "@idFactura";
                    paramIdFactura.SqlDbType = System.Data.SqlDbType.Int;

                    SqlParameter paramIdArticulos = new SqlParameter();
                    paramIdArticulos.Value = item.ID_Articulos;
                    paramIdArticulos.ParameterName = "@idArticulos";
                    paramIdArticulos.SqlDbType = System.Data.SqlDbType.Int;

                    SqlParameter paramIdCantidad = new SqlParameter();
                    paramIdCantidad.Value = item.Cantidad;
                    paramIdCantidad.ParameterName = "@idCantidad";
                    paramIdCantidad.SqlDbType = System.Data.SqlDbType.Decimal;



                    peticion.lstParametros.Add(paramIdFactura);
                    peticion.lstParametros.Add(paramIdArticulos);
                    peticion.lstParametros.Add(paramIdCantidad);


                    DA acceso = new DA();

                    acceso.ejecutarSentecia(peticion);
                }

                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
               
            }
        }



        public static bool ModificarFacturas(int Numero_Factura, int Estado)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_MODIFICAR_FACTURAS '" + Numero_Factura + "','" + Estado + "'";


                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public static bool AnularFactura(int Numero_Factura, int Estado)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_MODIFICAR_FACTURAS '" + Numero_Factura + "','" + Estado + "'";


                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }








    }
}
