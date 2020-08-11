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
    }
}
