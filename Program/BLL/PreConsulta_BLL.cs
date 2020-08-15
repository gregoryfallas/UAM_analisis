using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;

namespace BLL
{
   public class PreConsulta_BLL
    {
        public static DataTable consultarCitaEnCursoPantalla()
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CITAS_EN_CURSO ";
                DA acceso = new DA();
                return acceso.consultarCitasEnCurso(sentencia);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
