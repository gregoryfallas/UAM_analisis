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

        public static List<ARTICULOS> consultarArticulosMedicos()
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_MEDICAMENTOS ";

                DA objacceso = new DA();
                return objacceso.ConsultarMEDICAMENTOS(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        //servicio completo
        public static List<SERVICIOS> ConsultaServicios(string id)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS '" + id+ "'";

                DA objacceso = new DA();
                return objacceso.ConsultarServicios(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        ////servicio cirujia completo
        //public static List<SERVICIOS> ConsultaServiciosCirujia(string id)
        //{

        //    try
        //    {
        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS '" + id + "'";

        //        DA objacceso = new DA();
        //        return objacceso.ConsultarServicios(peticion);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}




        ////servicio examen completo
        //public static List<SERVICIOS> ConsultaServiciosExamen(string id)
        //{

        //    try
        //    {
        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS '" + id + "'";

        //        DA objacceso = new DA();
        //        return objacceso.ConsultarServicios(peticion);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ////servicio vacunacion completo
        //public static List<SERVICIOS> ConsultaServiciosVacunacion(string id)
        //{

        //    try
        //    {
        //        SQLSentencia peticion = new SQLSentencia();
        //        peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS '" + id + "'";

        //        DA objacceso = new DA();
        //        return objacceso.ConsultarServicios(peticion);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}





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


        public static List<SERVICIOS> ConsultaServiciosVacunacion_IDNOMBRE()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS_VACUNAS_IDNOMBRE ";

                DA objacceso = new DA();
                return objacceso.ConsultarServicios_IDNOMBRE(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static List<SERVICIOS> ConsultaServiciosExamenes_IDNOMBRE()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS_EXAMENES_IDNOMBRE ";

                DA objacceso = new DA();
                return objacceso.ConsultarServicios_IDNOMBRE(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public static List<SERVICIOS> ConsultaServiciosCirujia_IDNOMBRE()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_SERVICIOS_CIRUJIAS_IDNOMBRE ";

                DA objacceso = new DA();
                return objacceso.ConsultarServicios_IDNOMBRE(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public static List<PRUEBAS_LABORATORIO> ConsultaPruebasLAB(string nom)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_PRUEBAS_LABORATORIO'" + nom + "'";

                DA objacceso = new DA();
                return objacceso.ConsultarPruebasLaboratorio(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




    }
}
