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
   public class R_Humanos
    {

        #region Puestos
        public static List<PUESTOS> Consultar_Puestos()
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();
               // objpeticion.Peticion = @"SELECT ID_Puestos, ID_Departamento, Nombre, Salario_Base, Descripcion FROM PUESTOS";
                objpeticion.Peticion = @"SELECT ID_Puestos, ID_Departamento, Nombre FROM PUESTOS";

                DA objacceso = new DA();

                return objacceso.Consultar_Puestos(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

       

        #endregion

        #region Reclutamiento

        public static int AgregarReclutamiento(RECLUTAMIENTO m_reclutamiento)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_AGREGAR_RECLUTAMIENTO @Nombre, @Descripcion, @Estado";
                SqlParameter paramreclu = new SqlParameter();
                paramreclu.Value = m_reclutamiento.Nombre;
                paramreclu.ParameterName = "@Nombre";
                paramreclu.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter paramdesc = new SqlParameter();
                paramdesc.Value = m_reclutamiento.Descripcion;
                paramdesc.ParameterName = "@Descripcion";
                paramdesc.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter paramEstado = new SqlParameter();
                paramEstado.Value = m_reclutamiento.Estado;
                paramEstado.ParameterName = "@Estado";
                paramEstado.SqlDbType = System.Data.SqlDbType.Int;
                peticion.lstParametros.Add(paramreclu);
                peticion.lstParametros.Add(paramdesc);
                peticion.lstParametros.Add(paramEstado);
                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<ESTADOS> ConsultaEstados()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_Tipo_Estado ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoEstado(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //SEGUNDA FORMA de hacerlo
        //public static List<ESTADOS> ListarEstado()
        //{

        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.Peticion = @"SELECT ID_Estados ,Nombre  FROM ESTADOS";

        //        DA objacceso = new DA();
        //        return objacceso.ConsultarTipoEstado(sentencia);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        public static List<PUESTOS> ConsultaPuesto()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_Tipo_Cargo ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoPuesto(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool VerificarReclutamiento(RECLUTAMIENTO R_Recluta)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();
                objpeticion.Peticion = @"SELECT Nombre, Descripcion, Estado FROM Reclutamiento";
               // objpeticion.Peticion += @"WHERE ID_Reclutamiento = '" + R_Recluta.ID_Reclutamiento + "' AND ";
               // objpeticion.Peticion += @"ID_Puesto = '" + R_Recluta.ID_Puestos + "' AND ";
                objpeticion.Peticion += @"WHERE Nombre = '" + R_Recluta.Nombre + "'";
                objpeticion.Peticion += @"Descripcion = '" + R_Recluta.Descripcion + "'";
                objpeticion.Peticion += @"Estado = '" + R_Recluta.Estado + "'";



                DA objacceso = new DA();
                List<RECLUTAMIENTO> lstresultados = objacceso.Consultar_Reclutamiento(objpeticion);

                if (lstresultados.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
