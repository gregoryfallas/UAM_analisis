using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entidades;
using System.Data.SqlClient;

namespace BLL
{
    public class Credito_BLL
    {

        DA Obj_Dal = new DA();

        public static bool ModificaCreditos(CLIENTES cliente)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_MODIFICAR_CREDITOS @Cedula,@Credito";
                SqlParameter paramCedula = new SqlParameter();
                paramCedula.Value = cliente.Cedula;
                paramCedula.ParameterName = "@Cedula";
                paramCedula.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramCredito = new SqlParameter();
                paramCredito.Value = cliente.Credito;
                paramCredito.ParameterName = "@Credito";
                paramCredito.SqlDbType = System.Data.SqlDbType.Int;

                

                peticion.lstParametros.Add(paramCedula);
                peticion.lstParametros.Add(paramCredito);
                
                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






    }
}
