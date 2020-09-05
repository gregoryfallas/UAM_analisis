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

        public static bool modificarCitas(CITAS cita)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_Modidicar_Cita '" +
                    cita.ID_Cita + "','" +
                    cita.ID_Mascota + "','" +
                    cita.ID_Consultorio + "','" +
                    cita.ID_Motivo_Cita + "','" +
                    cita.Fecha_Inicio + "','" +
                    cita.Hora_Inicio + "','" +
                    cita.Hora_Fin + "','" +
                    cita.Estado + "'" ;
                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool modificarEstadoCitas(CITAS cita)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_Modificar_Estado_Cita '" +
                    cita.ID_Cita + "','" +
                    cita.ID_Estado + "'";
                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<MASCOTAS> load_mascotas(string Cedula)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_Consulta_Macota_Cliente @Cedula";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Cedula;
                paramC.ParameterName = @"@Cedula";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarMascotasClientes(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool agregarCita(CITAS citas)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_Insertar_Cita '" + citas.ID_Mascota +
                    "','" + citas.ID_Consultorio + "','" +
                    citas.ID_Motivo_Cita + "','" +
                    citas.Fecha_Inicio.ToShortDateString().ToString() + "','" +
                    citas.Hora_Inicio.ToString() + "','" +
                    citas.Hora_Fin.ToString() + "','" +
                    citas.ID_Estado + "'";

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
