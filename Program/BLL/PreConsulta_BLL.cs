using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;

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

        public static bool ModificarMascotaPreConsulta(MASCOTAS mascota)
        {
            try
            {


                //SQLSentencia peticion = new SQLSentencia();
                //peticion.Peticion = @"EXEC SP_MODIFICAR_MASCOTAS_PRECONSULTA '" + mascota.ID_Mascota + "','" + mascota.Peso + "','" + mascota.Tamaño + "','" + mascota.Edad + "','" + mascota.Estado + "'";
                //DA acceso = new DA();
                //return acceso.ejecutarSentecia(peticion);







                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_MODIFICAR_MASCOTAS_PRECONSULTA  @id,@Tama,@Est ,@Edad , @Peso";

                SqlParameter paramid = new SqlParameter();
                paramid.Value = mascota.ID_Mascota;
                paramid.ParameterName = "@id";
                paramid.SqlDbType = System.Data.SqlDbType.Int;


                SqlParameter paramtam = new SqlParameter();
                paramtam.Value = mascota.Tamaño;
                paramtam.ParameterName = "@Tama";
                paramtam.SqlDbType = System.Data.SqlDbType.Decimal;


                SqlParameter parame = new SqlParameter();
                parame.Value = mascota.Estado;
                parame.ParameterName = "@Est";
                parame.SqlDbType = System.Data.SqlDbType.Int;



                SqlParameter paramedad = new SqlParameter();
                paramedad.Value = mascota.Edad;
                paramedad.ParameterName = "@Edad";
                paramedad.SqlDbType = System.Data.SqlDbType.Int;


                SqlParameter parampeso = new SqlParameter();
                parampeso.Value = mascota.Peso;
                parampeso.ParameterName = "@Peso";
                parampeso.SqlDbType = System.Data.SqlDbType.Decimal;


                sentencia.lstParametros.Add(paramid);
                sentencia.lstParametros.Add(paramtam);
                sentencia.lstParametros.Add(parame);

                sentencia.lstParametros.Add(paramedad);
                sentencia.lstParametros.Add(parampeso);
             
                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static bool agregarObservaciones(OBSERVACIONES observaciones)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_AGREGAR_OBSERVACIONES '" + observaciones.ID_Cita + "','" + observaciones.Descripcion+ "'";
                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static List<ESTADOS> consultarEstadosMascota() {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_ESTADOS_MASCOTAS ";

                DA objacceso = new DA();
                return objacceso.ConsultarEstadosMascota(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        






    }
}
