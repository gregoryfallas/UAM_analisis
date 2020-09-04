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
                SQLSentencia pet = new SQLSentencia();
                pet.Peticion = @"EXEC SP_INGRESO_SUMINISTROS " + soliarticulos.ID_Articulo_Proveedor +", " + soliarticulos.ID_Solicitud_Compra + ", '" + soliarticulos.Descripcion + "', " + soliarticulos.Cantidad;

                DA acceso = new DA();
                return acceso.ejecutarSentecia(pet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool modificarSuministros(SOLICITUD_ARTICULOS soliarticulos)
        {
            try
            {
                SQLSentencia pet = new SQLSentencia();
                pet.Peticion = @"EXEC sp_actualizar_articulo " + soliarticulos.ID_Solicitud_Articulos + ", " + soliarticulos.ID_Articulo_Proveedor + ", " + soliarticulos.ID_Solicitud_Compra + ", '" + soliarticulos.Descripcion + "', " + soliarticulos.Cantidad;

                DA acceso = new DA();
                return acceso.ejecutarSentecia(pet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta_suministros()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_consultar_todos_articulos";

                DA acceso = new DA();
                return acceso.CREAR_ingreso_suministros(sentencia).Copy();
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        public static DataTable consulta_suministros_id(int id)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_consultar_articulos_id " + id;

                DA acceso = new DA();
                return acceso.CREAR_ingreso_suministros(sentencia).Copy();
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        public static DataTable consulta_proveedores_suministros()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_consultar_articulo_proveedor";

                DA acceso = new DA();
                return acceso.CREAR_ingreso_suministros_proveedor(sentencia).Copy();
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        public static void Eliminar_solicitud_ingreso()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();

            }
            catch
            {

            }
        }

        //articulos 
        public static DataTable ConsultarEstados()
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = "EXEC sp_consultar_estados";

                DA acceso = new DA();
                return acceso.CREAR_ingreso_estados(sentencia).Copy();


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable ConsultarDespacho()
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = "EXEC sp_consultar_despacho";

                DA acceso = new DA();
                return acceso.CREAR_ingreso_articulos(sentencia).Copy();


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable consulta_despacho_id(int id)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_consultar_despacho_id " + id;

                DA acceso = new DA();
                return acceso.CREAR_ingreso_articulos(sentencia).Copy();
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        public static bool agregarDespacho(DESPACHO despacho)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = "EXEC sp_agregar_despacho " + despacho.ID_Factura + ", @fecha , " + despacho.Estado;
                SqlParameter param1 = new SqlParameter();
                param1.Value = despacho.Fecha;
                param1.ParameterName = "@fecha";
                param1.SqlDbType = System.Data.SqlDbType.Date;
                sentencia.lstParametros.Add(param1);
                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool modificardespacho(DESPACHO despacho)
        {
            try
            {
                SQLSentencia pet = new SQLSentencia();
                pet.Peticion = @"EXEC sp_actualizar_despacho " + despacho.ID_Despacho + ", " + despacho.ID_Factura + ", @fecha , " + despacho.Estado;
                SqlParameter param1 = new SqlParameter();
                param1.Value = despacho.Fecha;
                param1.ParameterName = "@fecha";
                param1.SqlDbType = System.Data.SqlDbType.Date;
                pet.lstParametros.Add(param1);
                DA acceso = new DA();
                return acceso.ejecutarSentecia(pet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
//ingresar date y delete en bll return acceso.ejecutar sentencia