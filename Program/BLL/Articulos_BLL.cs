using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Articulos_BLL
    {
        DA Obj_Dal = new DA();

        public static DataTable ConsultarInventarioArticulos(string Nombre)
        {
                       
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_INVENTARIO '" + Nombre + "'";

                                             
                DA acceso = new DA();
                return acceso.consultarInventarioConArticulos(sentencia);
                                             
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public static bool MODIFICAR_INVENTARIO(int IdArticulo, decimal Cantidad)
        {
             SQLSentencia sentencia = new SQLSentencia();
            sentencia.Peticion = @"EXEC SP_MODIFICAR_INVENTARIO @IdArticulo, @Cantidad";
            

            SqlParameter paramId = new SqlParameter();
            paramId.Value = IdArticulo;
            paramId.ParameterName = "@IdArticulo";
            paramId.SqlDbType = System.Data.SqlDbType.Int;



            SqlParameter paramCantidad= new SqlParameter();
            paramCantidad.Value = Cantidad;
            paramCantidad.ParameterName = "@Cantidad";
            paramCantidad.SqlDbType = System.Data.SqlDbType.Decimal;



            sentencia.lstParametros.Add(paramId);
            sentencia.lstParametros.Add(paramCantidad);
            DA acceso = new DA();
            return acceso.ejecutarSentecia(sentencia);
        }

        
        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //sentencia.Peticion = @"EXEC SP_MODIFICAR_INVENTARIO '" + IdArticulo + "','" + Cantidad + "'";


        //        DA acceso = new DA();
        //        return acceso.ejecutarSentecia(sentencia);

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }


    }
}
