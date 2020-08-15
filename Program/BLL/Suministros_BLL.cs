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

        public static bool agregarSuministros(SOLICITUD_ARTICULOS soliarticulos)
        {
            try
            {
                SQLSentencia Peticion = new SQLSentencia();
                Peticion.Peticion = @"EXE SP_CREAR_ingreso_suministro'" + soliarticulos.ID_Articulo_Proveedor + "','" + soliarticulos.ID_Solicitud_Compra + "','" + soliarticulos.Descripcion + "','" + soliarticulos.Cantidad;

                DA acceso = new DA();
                return acceso.ejecutarSentecia(Peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<SOLICITUD_ARTICULOS> consulta_ingreso_suministros(int ID_Solicitud_Compra)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CREAR_ingreso_suministro  @ID_Solicitud_Compra";
                SqlParameter parametroid_Solicitud_Compra = new SqlParameter();
                parametroid_Solicitud_Compra.Value = ID_Solicitud_Compra;
                parametroid_Solicitud_Compra.ParameterName = "@ID_Solicitud_Compra";
                parametroid_Solicitud_Compra.SqlDbType = System.Data.SqlDbType.Int;

                sentencia.lstParametros.Add(parametroid_Solicitud_Compra);

                DA acceso = new DA();
                return acceso.CREAR_ingreso_suministros(sentencia);
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        public static  Eliminar_solicitud_ingreso()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();

            }
            catch
            {

            }
        }
    }
}
//ingresar date y delete en bll return acceso.ejecutar sentencia