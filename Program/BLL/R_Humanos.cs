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

        public static bool AgregarReclutamiento(RECLUTAMIENTO R_recluta)
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

        public static bool AgregarPruebas(PRUEBAS P_prueba)
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

        public static List<ESTADOS> ConsultaTipoEstadoPersonal()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_Tipo_Estado_Personal ";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoEstado(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool AgregarPersonal(PERSONAL P_persona)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_PERSONAL @ID_Puesto, @Cedula, @Nombre, @Apellido_1,
                                       @Apellido_2, @Salario_Hora, @Salario_Mensual, @Fecha_Contratacion,
                                       @Estado, @Direccion, @Correo_Electronico, @Telefono";

                //Crear los parametros
                SqlParameter parametroIdPuesto = new SqlParameter();
                parametroIdPuesto.ParameterName = "@ID_Puesto";
                parametroIdPuesto.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdPuesto.Value = P_persona.ID_Puesto;

                SqlParameter parametrocedula = new SqlParameter();
                parametrocedula.ParameterName = "@Cedula";
                parametrocedula.SqlDbType = System.Data.SqlDbType.VarChar;
                parametrocedula.Value = P_persona.Cedula;

                SqlParameter parametroNombre = new SqlParameter();
                parametroNombre.ParameterName = "@Nombre";
                parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNombre.Value = P_persona.Nombre;

                SqlParameter parametroApellido1 = new SqlParameter();
                parametroApellido1.ParameterName = "@Apellido_1";
                parametroApellido1.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroApellido1.Value = P_persona.Apellido_1;

                SqlParameter parametroApellido2 = new SqlParameter();
                parametroApellido2.ParameterName = "@Apellido_2";
                parametroApellido2.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroApellido2.Value = P_persona.Apellido_2;

                SqlParameter parametroSalarioH = new SqlParameter();
                parametroSalarioH.ParameterName = "@Salario_Hora";
                parametroSalarioH.SqlDbType = System.Data.SqlDbType.Decimal;
                parametroSalarioH.Value = P_persona.Salario_Hora;

                SqlParameter parametroSalarioM = new SqlParameter();
                parametroSalarioM.ParameterName = "@Salario_Mensual";
                parametroSalarioM.SqlDbType = System.Data.SqlDbType.Decimal;
                parametroSalarioM.Value = P_persona.Salario_Mensual;

                SqlParameter parametroFechaC = new SqlParameter();
                parametroFechaC.ParameterName = "@Fecha_Contratacion";
                parametroFechaC.SqlDbType = System.Data.SqlDbType.Date;
                parametroFechaC.Value = P_persona.Fecha_Contratacion;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@Estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Int;
                parametroEstado.Value = P_persona.Estado;

                SqlParameter parametroDireccion = new SqlParameter();
                parametroDireccion.ParameterName = "@Direccion";
                parametroDireccion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDireccion.Value = P_persona.Direccion;

                SqlParameter parametroCorreoE = new SqlParameter();
                parametroCorreoE.ParameterName = "@Correo_Electronico";
                parametroCorreoE.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroCorreoE.Value = P_persona.Correo_Electronico;

                SqlParameter parametroTelefono = new SqlParameter();
                parametroTelefono.ParameterName = "@Telefono";
                parametroTelefono.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroTelefono.Value = P_persona.Telefono;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroIdPuesto);
                objpeticion.lstParametros.Add(parametrocedula);
                objpeticion.lstParametros.Add(parametroNombre);
                objpeticion.lstParametros.Add(parametroApellido1);
                objpeticion.lstParametros.Add(parametroApellido2);
                objpeticion.lstParametros.Add(parametroSalarioH);
                objpeticion.lstParametros.Add(parametroSalarioM);
                objpeticion.lstParametros.Add(parametroFechaC);
                objpeticion.lstParametros.Add(parametroEstado);
                objpeticion.lstParametros.Add(parametroDireccion);
                objpeticion.lstParametros.Add(parametroCorreoE);
                objpeticion.lstParametros.Add(parametroTelefono);

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool AgregarNomina(NOMINA N_nomina)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_NOMINA @Nombre, @Fecha_Inicio, @Fecha_Fin, @Descripcion";

                //Crear los parametros
                SqlParameter parametroNombre = new SqlParameter();
                parametroNombre.ParameterName = "@Nombre";
                parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNombre.Value = N_nomina.Nombre;

                SqlParameter parametroFechaI = new SqlParameter();
                parametroFechaI.ParameterName = "@Fecha_Inicio";
                parametroFechaI.SqlDbType = System.Data.SqlDbType.Date;
                parametroFechaI.Value = N_nomina.Fecha_Inicio;

                SqlParameter parametroFechaF = new SqlParameter();
                parametroFechaF.ParameterName = "@Fecha_Fin";
                parametroFechaF.SqlDbType = System.Data.SqlDbType.Date;
                parametroFechaF.Value = N_nomina.Fecha_Fin;

                SqlParameter parametroDescripcion = new SqlParameter();
                parametroDescripcion.ParameterName = "@Descripcion";
                parametroDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDescripcion.Value = N_nomina.Descripcion;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroNombre);
                objpeticion.lstParametros.Add(parametroFechaI);
                objpeticion.lstParametros.Add(parametroFechaF);

                objpeticion.lstParametros.Add(parametroDescripcion);

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PERSONAL> ConsultarTablaPersonal()
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();
                objpeticion.Peticion = @"SELECT * FROM PERSONAL";

                /*ID_Personal, ID_Puesto, Cedula, Nombre, Apellido_1, 
                                        Apellido_2, Salario_Hora, Salario_Mensual, Fecha_Contratacion, 
                                        Estado, Direccion, Correo_Electronico, Telefono*/

                DA objacceso = new DA();
                return objacceso.ConsultarTablaPersonal(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
