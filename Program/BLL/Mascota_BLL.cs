using DAL;
using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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



        public static bool agregarMascota(MASCOTAS mascota)
        {
            try
            {

                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CREAR_MASCOTA '" + mascota.ID_Cliente + "','" + mascota.Nombre + "','" + mascota.Tipo_Animal+ "','" + mascota.Raza + "','" + mascota.Sexo + "','" + mascota.Estado +  "'";

                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<MASCOTAS> ConsultarMascota(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_Mascotas @Nombre";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Nombre;
                paramC.ParameterName = "@Nombre";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarMascotas(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool eliminarMascota(int idMascota)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_Mascotas_Eliminar @idMascota";
                SqlParameter ids = new SqlParameter();
                ids.Value = idMascota;
                ids.ParameterName = "@idMascota";
                ids.SqlDbType = System.Data.SqlDbType.Int;
                sentencia.lstParametros.Add(ids);
                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }

        }


    }
}
