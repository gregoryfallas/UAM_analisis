using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Citas_BLL
    {
        public List<CONSULTORIO> load_consultorios()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_Consulta_Consultorios";
                SqlParameter paramC = new SqlParameter();
                DA acceso = new DA();
                return acceso.ConsultarConsultorios(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<MOTIVO_CITA> loadmotivos()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_Consulta_Motivos";
                SqlParameter paramC = new SqlParameter();
                DA acceso = new DA();
                return acceso.ConsultarMotivos(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void load_hours(ref List<DateTime> hours)
        {
            DateTime date_horas = new DateTime(2020, 01, 01, 07, 0, 0);
            do
            {
                hours.Add(date_horas);
                date_horas = date_horas.AddMinutes(30);


            } while (date_horas.Hour < 17);
        }

        public List<CITAS> load_citas()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_Consulta_Citas";
                SqlParameter paramC = new SqlParameter();
                DA acceso = new DA();
                return acceso.ConsultarCitas(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
