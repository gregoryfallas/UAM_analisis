using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class Clientes_BLL
    {

        public static List<CLIENTES> ConsultarClientes(string Nombre )
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CLIENTES @Nombre";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Nombre;
                paramC.ParameterName = "@Nombre";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarClientes(sentencia);             

                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

                     
    }


}
