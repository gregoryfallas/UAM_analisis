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
    public class Articulos
    {

        public static List<ARTICULOS> ConsultarArticulos(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = "";

                DA acceso = new DA();
                return acceso.ConsultarArticulos(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable ConsultarInventarioArticulos(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_INVENTARIO";

                DA acceso = new DA();
                return acceso.consultarInventarioConArticulos(sentencia).Copy();


            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
