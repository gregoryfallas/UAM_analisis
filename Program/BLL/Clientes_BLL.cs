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

        public static List<CLIENTES> ConsultarClientes(string Cedula )
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CLIENTES @Cedula";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Cedula;
                paramC.ParameterName = "@Cedula";
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

        public static List<ESTADOS> ConsultaEstadosCliente()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_ESTADOSCLIENTES ";

                DA objacceso = new DA();
                return objacceso.ConsultarEstadosCliente(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PROVINCIAS> ConsultaProvincia()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_PROVINCIA ";

                DA objacceso = new DA();
                return objacceso.ConsultarProvincias(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<CANTONES> ConsultaCantones(int id)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_CANTONES_POR_PROVINCIA @id";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = id;
                paramC.ParameterName = "@id";
                paramC.SqlDbType = System.Data.SqlDbType.Int;
                peticion.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarCantonesPorProvincias(peticion);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<DISTRITOS> ConsultaDistritos(int id)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_DISTRITOS_POR_CANTON @id";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = id;
                paramC.ParameterName = "@id";
                paramC.SqlDbType = System.Data.SqlDbType.Int;
                peticion.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarDistritosPorCantones(peticion);

            }
            catch (Exception e)
            {
                throw e;
            }
        }











    }


}
