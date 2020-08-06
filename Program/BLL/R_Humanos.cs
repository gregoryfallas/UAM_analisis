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
                SQLParametros objpeticion = new SQLParametros();
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

        //public static bool VerificarPuestos(PUESTOS P_Puesto)
        //{
        //    try
        //    {
        //        SQLParametros objpeticion = new SQLParametros();
        //        objpeticion.Peticion = @"SELECT ID_Puestos, ID_Departamento, Nombre, Salario_Base, Descripcion FROM PUESTOS";
        //        objpeticion.Peticion += @"WHERE ID_Puestos = '" + P_Puesto.ID_Puestos + "' AND ";
        //        objpeticion.Peticion += @"ID_Departamento = '" + P_Puesto.ID_Departamento + "' AND ";
        //        objpeticion.Peticion += @"Nombre = '" + P_Puesto.Nombre + "'";
        //        objpeticion.Peticion += @"Salario_Base = '" + P_Puesto.Salario_Base + "'";
        //        objpeticion.Peticion += @"Descripcion = '" + P_Puesto.Descripcion + "'";



        //        DA objacceso = new DA();
        //        List<PUESTOS> lstresultados = objacceso.Consultar_Puestos(objpeticion);

        //        if (lstresultados.Count > 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        #endregion

        #region Reclutamiento

        public static int AgregarReclutamiento(RECLUTAMIENTO m_reclutamiento)
        {
            try
            {
                SQLParametros objpeticion = new SQLParametros();

                objpeticion.Peticion = @"INSERT INTO RECLUTAMIENTO VALUES ('" + m_reclutamiento.ID_Reclutamiento + "','" + m_reclutamiento.ID_Puestos + "','" + m_reclutamiento.Nombre + "','" + m_reclutamiento.Descripcion + m_reclutamiento.Estado + "')";
               // objpeticion.Peticion = @"INSERT INTO RECLUTAMIENTO VALUES ('" + m_reclutamiento.Nombre + "','" + m_reclutamiento.Descripcion + m_reclutamiento.Estado + "')";

                DA objacceso = new DA();
                return objacceso.Ejecutar_Peticiones(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion 

    }
}
