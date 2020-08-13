using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entidades;
namespace BLL
{
    public class Suministros_BLL
    {

        public static DataTable ConsultarInventarioArticulos()
        {
            #region            
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_INVENTARIOTOTAL";

                DA acceso = new DA();
                return acceso.consultarInventarioConArticulos(sentencia);

            }
            catch (Exception e)

            {
                throw e;
            }
        }
        #endregion
        public static DataTable SP_CONSULTAR_INVENTARIO_MENOR_CANTIDAD()
        {
            #region
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_INVENTARIO_MENOR_CANTIDAD";

                DA acceso = new DA();
                return acceso.consultarInventarioConArticulos(sentencia);

            }
            catch (Exception e)

            {
                throw e;
            }
        }
        #endregion
       
        public static bool SP_CREAR_ingreso_suministro(SOLICITUD_ARTICULOS in_sumi)
        {
            #region
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CREAR_ingreso_suministro  @ID_Articulo_Proveedor, @ID_Solicitud_Compra, @Descripcion, @Cantidad";
                

                SqlParameter parametroid_ArticuloProveedor = new SqlParameter();
                parametroid_ArticuloProveedor.ParameterName = "@ID_Articulo_Proveedor";
                parametroid_ArticuloProveedor.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_ArticuloProveedor.Value = in_sumi.ID_Articulo_Proveedor;

                SqlParameter parametroid_Solicitud_Compra = new SqlParameter();
                parametroid_Solicitud_Compra.ParameterName = "@ID_Solicitud_Compra";
                parametroid_Solicitud_Compra.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_Solicitud_Compra.Value = in_sumi.ID_Solicitud_Compra;

                
                SqlParameter parametrodescripcion = new SqlParameter();
                parametrodescripcion.ParameterName = "@Descripcion";
                parametrodescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametrodescripcion.Value = in_sumi.Descripcion;

                SqlParameter parametroCantidad = new SqlParameter();
                parametroCantidad.ParameterName = "@Cantidad";
                parametroCantidad.SqlDbType = System.Data.SqlDbType.Decimal;
                parametroCantidad.Value = in_sumi.Cantidad;
                
                SQLSentencia.in_sumi.add(parametroid_ArticuloProveedor);
                SQLSentencia.listparametros.add(parametroid_Solicitud_Compra);
                SQLSentencia.listparametros.add(parametroCantidad);
                SQLSentencia.listparametros.add(parametrodescripcion);

                DA acceso = new DA();
                return acceso.SP_CREAR_ingreso_suministro(SQLSentencia, in_sumi);

            }
            catch (Exception e)

            {
                throw e;
            }
        }
        #endregion
 
    }
}