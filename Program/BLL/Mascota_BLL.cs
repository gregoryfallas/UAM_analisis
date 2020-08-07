using DAL;
using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Mascota_BLL
    {

        public static List<TIPO_ANIMAL> ConsultaTipoAnimal()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_TipoMascota_Consultar ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoMascota(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //SEGUNDA FORMA de hacerlo
        public static List<TIPO_ANIMAL> ListarTipos()
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"SELECT ID_Tipo_Animal ,Tipo  FROM TIPO_ANIMAL";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoMascota(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
