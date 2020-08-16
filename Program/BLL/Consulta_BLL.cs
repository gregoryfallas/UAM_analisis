using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;
namespace BLL
{
   public class Consulta_BLL
    {

        public static List<OBSERVACIONES> consultarObservaciones()
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_OBSERVACIONES_POR_CITAS ";

                DA objacceso = new DA();
                return objacceso.ConsultarObservacionesPorCita(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public static List<SERVICIOS> ConsultaServicios(string id)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS @nombre ";

                DA objacceso = new DA();
                return objacceso.ConsultarServicios(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static List<SERVICIOS> ConsultaServicios_IDNOMBRE()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS_IDNOMBRE ";

                DA objacceso = new DA();
                return objacceso.ConsultarServicios_IDNOMBRE(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




    }
}
