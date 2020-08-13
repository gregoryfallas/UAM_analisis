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
       
        public static SP_CREAR_ingreso_suministro(SQLSentencia Peticion)
        {
            #region
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CREAR_ingreso_suministro @ID_Solicitud_Articulos, @ID_Articulo_Proveedor, @ID_Solicitud_Compra, @Descripcion, @Cantidad";
                
                SqlParameter parametroid_solicitudarticulo = new sqlparameter();
                parametroid_solicitudarticulo.ParameterName = "@ID_Solicitud_Articulos";
                parametroid_solicitudarticulo.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_solicitudarticulo.Value = ingreso_solicitudarticulo;

                SqlParameter parametroid_solicitudarticulo = new sqlparameter();
                parametroid_solicitudarticulo.ParameterName = "@ID_Articulo_Proveedor";
                parametroid_solicitudarticulo.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_solicitudarticulo.Value = ingreso_articuloproveedor;

                SqlParameter parametroid_solicitudarticulo = new sqlparameter();
                parametroid_solicitudarticulo.ParameterName = "@ID_Solicitud_Compra";
                parametroid_solicitudarticulo.SqlDbType = System.Data.SqlDbType.Int;
                parametroid_solicitudarticulo.Value = ingreso_Solicitudcompra;

                SqlParameter parametroid_solicitudarticulo = new sqlparameter();
                parametroid_solicitudarticulo.ParameterName = "@Cantidad";
                parametroid_solicitudarticulo.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroid_solicitudarticulo.Value = ingreso_articuloproveedor;


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