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

        

       
    }
}
