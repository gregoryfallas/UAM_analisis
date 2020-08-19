using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;


namespace BLL
{
   public class Laboratorio_BLL
    {

        public static List<ESTADOS> ConsultaEstadosExamenes()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_ESTADOS_EXAMENES ";

                DA objacceso = new DA();
                return objacceso.ConsultarEstadosCliente(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        public static bool agregarResultadoLaboratorio(int idPrueba,int idCita,string resultado,int estado)
        {
            try
            {

                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_AGREGAR_RESULTADOS_EXAMENES '" + idPrueba + "','" + idCita +  "','" + resultado+"','" + estado + "'";

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
