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
       
        public static bool SP_CREAR_ingreso_suministro(Suministros_BLL in_sumi)
        {
            #region
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CREAR_ingreso_suministro @ID_Solicitud_Articulos, @ID_Articulo_Proveedor, @ID_Solicitud_Compra, @Descripcion, @Cantidad";
                
                SqlParameter parametroid_solicitudarticulo = new sqlparameter();
                parametroid_solicitudarticulo.ParameterName = "@ID_Solicitud_Articulos";
                parametroid_solicitudarticulo.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_solicitudarticulo.Value = in_sumi.ingreso_solicitudarticulo;

                SqlParameter parametroid_ArticuloProveedor = new sqlparameter();
                parametroid_ArticuloProveedor.ParameterName = "@ID_Articulo_Proveedor";
                parametroid_ArticuloProveedor.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_ArticuloProveedor.Value = in_sumi.ingreso_articuloproveedor;

                SqlParameter parametroid_Solicitud_Compra = new sqlparameter();
                parametroid_Solicitud_Compra.ParameterName = "@ID_Solicitud_Compra";
                parametroid_Solicitud_Compra.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_Solicitud_Compra.Value = in_sumi.ingreso_Solicitudcompra;

                SqlParameter parametroCantidad = new sqlparameter();
                parametroCantidad.ParameterName = "@Cantidad";
                parametroCantidad.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroCantidad.Value = in_sumi.ingreso_Cantidad;

                SqlParameter parametrodescripcion = new sqlparameter();
                parametrodescripcion.ParameterName = "@Descripcion";
                parametrodescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametrodescripcion.Value = in_sumi.ingreso_Descripcion;

                SQLSentencia.listparametros.add(parametroid_solicitudarticulo);
                SQLSentencia.listparametros.add(parametroid_ArticuloProveedor);
                SQLSentencia.listparametros.add(parametroid_Solicitud_Compra);
                SQLSentencia.listparametros.add(parametroCantidad);
                SQLSentencia.listparametros.add(parametrodescripcion);

                DA acceso = new DA();
                return acceso.SP_CREAR_ingreso_suministro(sentencia);

            }
            catch (Exception e)

            {
                throw e;
            }
        }
        #endregion
 
    }
}