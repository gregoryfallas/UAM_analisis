using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using DAL.Entidades;
using System.Data;

namespace BLL
{
   public class Cls_Cobros_BLL
    {
        DA Obj_Dal = new DA();

        public static DataTable ConsultarCobros(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_COBROS '" + Nombre + "'";


                DA acceso = new DA();
                return acceso.ConsultarCobros(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static DataTable ConsultarCobrosContado(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_COBROS_CONTADO '" + Nombre + "'";


                DA acceso = new DA();
                return acceso.ConsultarCobros(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable ConsultarCobrosCredito(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_COBROS_Credito '" + Nombre + "'";


                DA acceso = new DA();
                return acceso.ConsultarCobros(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }
}
