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

        public static int AgregarReclutamiento(RECLUTAMIENTO R_recluta)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_RECLUTAMIENTO3 @ID_Puestos, @Nombre,@Descripcion, @Estado";

                //Crear los parametros
                SqlParameter parametroIdPuestos = new SqlParameter();
                parametroIdPuestos.ParameterName = "@ID_Puestos";
                parametroIdPuestos.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdPuestos.Value = R_recluta.ID_Puestos;

                SqlParameter parametroNombre = new SqlParameter();
                parametroNombre.ParameterName = "@Nombre";
                parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNombre.Value = R_recluta.Nombre;

                SqlParameter parametroDescripcion = new SqlParameter();
                parametroDescripcion.ParameterName = "@Descripcion";
                parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDescripcion.Value = R_recluta.Descripcion;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@Estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Int;
                parametroEstado.Value = R_recluta.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroIdPuestos);
                objpeticion.lstParametros.Add(parametroNombre);
                objpeticion.lstParametros.Add(parametroDescripcion);
                objpeticion.lstParametros.Add(parametroEstado);

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ESTADOS> ConsultaTipoEstado()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_Tipo_Estado ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoEstado(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PUESTOS> ConsultaTipoCargo()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_Tipo_Cargo ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoCargo(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<DEPARTAMENTOS> ConsultaTipoPuestos()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_Tipo_Puesto ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoPuestos(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int AgregarPruebas(PRUEBAS P_prueba)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_PRUEBAS @Nombre, @Descripcion";

                //Crear los parametros
                SqlParameter parametroNombre = new SqlParameter();
                parametroNombre.ParameterName = "@Nombre";
                parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNombre.Value = P_prueba.Nombre;

                SqlParameter parametroDescripcion = new SqlParameter();
                parametroDescripcion.ParameterName = "@Descripcion";
                parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDescripcion.Value = P_prueba.Descripcion;

                //Agrega a la lista de parametros los parametros creados
               
                objpeticion.lstParametros.Add(parametroNombre);
                objpeticion.lstParametros.Add(parametroDescripcion);
                

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
