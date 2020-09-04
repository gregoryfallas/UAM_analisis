using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;


namespace BLL
{
   public class R_Humanos
    {
        #region RECLUTAMIENTO

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

        public static bool AgregarPostulantes(PARTICIPANTES P_postulantes)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_PARTICIPANTES @ID_Reclutamiento, @Cedula_, @Nombre,
                                       @Apellido_1, @Apellido_2, @Correo, @Telefono, @ID_Provincia, @ID_Canton,
                                       @ID_Distrito, @Direccion, @Estado ";

                //Crear los parametros
                SqlParameter parametroIdreclutamiento = new SqlParameter();
                parametroIdreclutamiento.ParameterName = "@ID_Reclutamiento";
                parametroIdreclutamiento.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdreclutamiento.Value = P_postulantes.ID_Reclutamiento;

                SqlParameter parametroCedula = new SqlParameter();
                parametroCedula.ParameterName = "@Cedula_";
                parametroCedula.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroCedula.Value = P_postulantes.Cedula_;

                SqlParameter parametroNombre = new SqlParameter();
                parametroNombre.ParameterName = "@Nombre";
                parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNombre.Value = P_postulantes.Nombre;

                SqlParameter parametroApellido1 = new SqlParameter();
                parametroApellido1.ParameterName = "@Apellido_1";
                parametroApellido1.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroApellido1.Value = P_postulantes.Apellido_1;

                SqlParameter parametroApellido2 = new SqlParameter();
                parametroApellido2.ParameterName = "@Apellido_2";
                parametroApellido2.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroApellido2.Value = P_postulantes.Apellido_2;

                SqlParameter parametroCorreo = new SqlParameter();
                parametroCorreo.ParameterName = "@Correo";
                parametroCorreo.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroCorreo.Value = P_postulantes.Correo;

                SqlParameter parametroTelefono = new SqlParameter();
                parametroTelefono.ParameterName = "@Telefono";
                parametroTelefono.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroTelefono.Value = P_postulantes.Telefono;

                SqlParameter parametroProvincia = new SqlParameter();
                parametroProvincia.ParameterName = "@ID_Provincia";
                parametroProvincia.SqlDbType = System.Data.SqlDbType.Int;
                parametroProvincia.Value = P_postulantes.ID_Provincia;

                SqlParameter parametroCanton = new SqlParameter();
                parametroCanton.ParameterName = "@ID_Canton";
                parametroCanton.SqlDbType = System.Data.SqlDbType.Int;
                parametroCanton.Value = P_postulantes.ID_Canton;

                SqlParameter parametroDistrito = new SqlParameter();
                parametroDistrito.ParameterName = "@ID_Distrito";
                parametroDistrito.SqlDbType = System.Data.SqlDbType.Int;
                parametroDistrito.Value = P_postulantes.ID_Distrito;

                SqlParameter parametroDireccion = new SqlParameter();
                parametroDireccion.ParameterName = "@Direccion";
                parametroDireccion.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroDireccion.Value = P_postulantes.Direccion;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@Estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroEstado.Value = P_postulantes.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroIdreclutamiento);
                objpeticion.lstParametros.Add(parametroCedula);
                objpeticion.lstParametros.Add(parametroNombre);
                objpeticion.lstParametros.Add(parametroApellido1);
                objpeticion.lstParametros.Add(parametroApellido2);
                objpeticion.lstParametros.Add(parametroCorreo);
                objpeticion.lstParametros.Add(parametroTelefono);
                objpeticion.lstParametros.Add(parametroProvincia);
                objpeticion.lstParametros.Add(parametroCanton);
                objpeticion.lstParametros.Add(parametroDistrito);
                objpeticion.lstParametros.Add(parametroDireccion);
                objpeticion.lstParametros.Add(parametroEstado);


                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ModificarPostulantes(PARTICIPANTES P_postulantes)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                objpeticion.Peticion = @"UPDATE PARTICIPANTES SET Cedula_ = '"
                + P_postulantes.Cedula_ + "', Nombre = '" + P_postulantes.Nombre + "', Apellido_1 = '"
                + P_postulantes.Apellido_1 + "', Apellido_2 = '" + P_postulantes.Apellido_2 + "', Correo = '"
                + P_postulantes.Correo + "', Telefono = '" + P_postulantes.Telefono + "', ID_Provincia = '"
                + P_postulantes.ID_Provincia + "', ID_Canton = '" + P_postulantes.ID_Canton + "', ID_Distrito = '"
                + P_postulantes.ID_Distrito + "', Direccion = '" + P_postulantes.Direccion + "',  Estado = '"
                + P_postulantes.Estado + "' WHERE ID_Reclutamiento = '" + P_postulantes.ID_Reclutamiento + "'";

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<RECLUTAMIENTO> ConsultarIDReclutamiento()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_IDRECLUTAMIENTO_POSTULANTES";

                DA objacceso = new DA();
                return objacceso.ConsultarIDReclutamiento(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<ESTADOS> ConsultarTipoEstadoPostulantes()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_PA_Tipo_Estado_Postulantes
";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoEstadoPostulantes(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PROVINCIAS> ConsultaProvincia()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_PROVINCIA ";

                DA objacceso = new DA();
                return objacceso.ConsultarProvincias(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<CANTONES> ConsultaCantones(int id)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_CANTONES_POR_PROVINCIA @id";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = id;
                paramC.ParameterName = "@id";
                paramC.SqlDbType = System.Data.SqlDbType.Int;
                peticion.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarCantonesPorProvincias(peticion);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<DISTRITOS> ConsultaDistritos(int id)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_DISTRITOS_POR_CANTON @id";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = id;
                paramC.ParameterName = "@id";
                paramC.SqlDbType = System.Data.SqlDbType.Int;
                peticion.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarDistritosPorCantones(peticion);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<CANTONES> ConsultarCanton(string nombreCanton)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_IdCanton @nombreCanton";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = nombreCanton;
                paramC.ParameterName = "@nombreCanton";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarIdCanton(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PARTICIPANTES> ObtenerParticipantes2(string Cedula_)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_PARTICIPANTES2 @Cedula";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Cedula_;
                paramC.ParameterName = "@Cedula";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ObtenerParticipantes2(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable Obtener_Participantes(string Cedula_)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_PARTICIPANTES '" + Cedula_ + "'";
                DA acceso = new DA();
                return acceso.ObtenerParticipantes(sentencia);




            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PRUEBAS> NotasIdPruebas()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_PA_NotasIdPruebas";

                DA objacceso = new DA();
                return objacceso.NotasIdPruebas(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<PARTICIPANTES> NotasIdParticipantes()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_PA_NotasIdParticipantes";

                DA objacceso = new DA();
                return objacceso.NotasIdParticipantes(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool AgregarNotaPruebas(PRUEBAS_PARTICIPANTES P_pruebap)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_PRUEBAS_PARTICIPANTES @ID_Pruebas, @ID_Participantes,
                @Nota";

                //Crear los parametros
                SqlParameter parametroIdPruebas = new SqlParameter();
                parametroIdPruebas.ParameterName = "@ID_Pruebas";
                parametroIdPruebas.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdPruebas.Value = P_pruebap.ID_Pruebas;

                SqlParameter parametroIdParticipantes = new SqlParameter();
                parametroIdParticipantes.ParameterName = "@ID_Participantes";
                parametroIdParticipantes.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdParticipantes.Value = P_pruebap.ID_Participantes;

                SqlParameter parametroNota = new SqlParameter();
                parametroNota.Value = P_pruebap.Nota;
                parametroNota.ParameterName = "@Nota";
                parametroNota.SqlDbType = System.Data.SqlDbType.Int;
                

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroIdPruebas);
                objpeticion.lstParametros.Add(parametroIdParticipantes);
                objpeticion.lstParametros.Add(parametroNota);

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PRUEBAS_PARTICIPANTES> ObtenerPruebasParticipantes()
        {
            try
            {   //Se crea objeto para armado sentencia
                SQLSentencia peticion = new SQLSentencia();
                //Arma la sentencia con los datos del parametro entrada
                peticion.Peticion = @"SELECT ID_Pruebas, ID_Participantes, Nota FROM PRUEBAS_PARTICIPANTES ";

                //Se hace el llamado al ACCESO DATOS
                DA objacceso = new DA();
                return objacceso.ObtenerPruebasParticipantes(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ModificarReclutamiento(RECLUTAMIENTO R_ecluta)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                objpeticion.Peticion = @"UPDATE RECLUTAMIENTO SET Nombre = '"
                + R_ecluta.Nombre + "', Descripcion = '" + R_ecluta.Descripcion + "', Estado = '"
                + R_ecluta.Estado + "' WHERE ID_Puestos = '" + R_ecluta.ID_Puestos + "'";

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region PERSONAL

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

        public static bool ModificarPersonal(PERSONAL P_persona)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                objpeticion.Peticion = @"UPDATE PERSONAL SET Cedula = '"
                + P_persona.Cedula + "', Nombre = '" + P_persona.Nombre + "', Apellido_1 = '"
                + P_persona.Apellido_1 + "', Apellido_2 = '" + P_persona.Apellido_2 + "', Salario_Hora = '"
                + P_persona.Salario_Hora + "', Salario_Mensual = '" + P_persona.Salario_Mensual + "', Fecha_Contratacion = '"
                + P_persona.Fecha_Contratacion + "', Estado = '" + P_persona.Estado + "', Direccion = '"
                + P_persona.Direccion + "', Correo_Electronico = '" + P_persona.Correo_Electronico + "', Telefono = '"
                + P_persona.Telefono + "' WHERE ID_Puesto = '" + P_persona.ID_Puesto + "'";

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PERSONAL> ConsultarIDPersonal()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_PA_USUARIOIDPERSONAL";

                DA objacceso = new DA();
                return objacceso.ConsultarIDPersonal(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<ESTADOS> ConsultarTipoEstadoUsuario()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_PA_Tipo_Estado_Usuario";

                DA objacceso = new DA();
                return objacceso.ConsultarTipoEstadoUsuario(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool AgregarUsuario(USUARIOS U_usuario)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_USUARIOS @ID_Personal, @UserName, @Pass, @Estado";

                //Crear los parametros
                SqlParameter parametroIdPersonal = new SqlParameter();
                parametroIdPersonal.ParameterName = "@ID_Personal";
                parametroIdPersonal.SqlDbType = System.Data.SqlDbType.Int;
                parametroIdPersonal.Value = U_usuario.ID_Personal;

                SqlParameter parametroUserName = new SqlParameter();
                parametroUserName.ParameterName = "@UserName";
                parametroUserName.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroUserName.Value = U_usuario.UserName;

                SqlParameter parametroPass = new SqlParameter();
                parametroPass.ParameterName = "@Pass";
                parametroPass.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroPass.Value = U_usuario.Pass;

                SqlParameter parametroEstado = new SqlParameter();
                parametroEstado.ParameterName = "@Estado";
                parametroEstado.SqlDbType = System.Data.SqlDbType.Int;
                parametroEstado.Value = U_usuario.Estado;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroIdPersonal);
                objpeticion.lstParametros.Add(parametroUserName);
                objpeticion.lstParametros.Add(parametroPass);
                objpeticion.lstParametros.Add(parametroEstado);


                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ModificarUsuario(USUARIOS U_usuario)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();
                /*@ID_Personal, @UserName, @Pass, @Estado */
                objpeticion.Peticion = @"UPDATE USUARIOS SET UserName = '"
                + U_usuario.UserName + "', Pass = '" + U_usuario.Pass + "',  Estado= '"
                + U_usuario.Estado + "' WHERE ID_Personal = '" + U_usuario.ID_Personal + "'";

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ROLES> Obtener_Roles()
        {
            try
            {   //Se crea objeto para armado sentencia
                SQLSentencia peticion = new SQLSentencia();
                //Arma la sentencia con los datos del parametro entrada
                peticion.Peticion = @"SELECT ID_Roles, Nombre, Descripcion, Estado FROM ROLES";

                //Se hace el llamado al ACCESO DATOS
                DA objacceso = new DA();
                return objacceso.ObtenerRoles(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<PERSONAL> Obtener_Personal()
        {
            try
            {   //Se crea objeto para armado sentencia
                SQLSentencia peticion = new SQLSentencia();
                //Arma la sentencia con los datos del parametro entrada
                peticion.Peticion = @"SELECT ID_Personal, ID_Puesto, Cedula, Nombre, Apellido_1, Apellido_2, 
                Salario_Hora, Salario_Mensual, Fecha_Contratacion, created_at, Estado, Direccion, Correo_Electronico,
                Telefono  FROM PERSONAL ";

                //Se hace el llamado al ACCESO DATOS
                DA objacceso = new DA();
                return objacceso.ObtenerPersonal(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Obtener_PersonalDGV(string Cedula)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_PERSONAL '" + Cedula + "'";
                DA acceso = new DA();
                return acceso.ObtenerPersonalDGV(sentencia);




            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region NOMINA

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

        public static List<NOMINA> Obtener_Nomina()
        {
            try
            {   //Se crea objeto para armado sentencia
                SQLSentencia peticion = new SQLSentencia();
                //Arma la sentencia con los datos del parametro entrada
                peticion.Peticion = @"SELECT ID_Nomina, Nombre, Fecha_Inicio, Fecha_Fin, Descripcion FROM NOMINA ";

                //Se hace el llamado al ACCESO DATOS
                DA objacceso = new DA();
                return objacceso.ObtenerNomina(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        #endregion

        #region VALIDACIONES

        public static bool ValidarTexto(Formato P_formato)
        {
            try
            {
                //Clase pertenciente al Framework de System.Text.RegularExpresion
                Regex regex = new Regex(P_formato.PatronValidacion);

                //Ejecución de método encapsulado donde se valida el texto recibido
                MatchCollection lstcoincidencias = regex.Matches(P_formato.Texto);

                //Respuesta del método con base a las coincidencias recibidas
                if (lstcoincidencias.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region MARCA

        public static bool AgregarMarcaPersonal(TIPO_MARCA marca)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_MARCAR_PERSONAL @ID_Tipo, @Nombre";

                //Crear los parametros
                SqlParameter parametroTipo = new SqlParameter();
                parametroTipo.ParameterName = "@ID_Tipo";
                parametroTipo.SqlDbType = System.Data.SqlDbType.Int;
                parametroTipo.Value = marca.ID_Tipo;

                SqlParameter parametroNombre = new SqlParameter();
                parametroNombre.ParameterName = "@Nombre";
                parametroNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                parametroNombre.Value = marca.Nombre;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroTipo);
                objpeticion.lstParametros.Add(parametroNombre);

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<TIPO_MARCA> ConsultaTipoMarca()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_PA_CONSULTAR_TIPO_MARCA ";

                DA objacceso = new DA();
                return objacceso.ConsultarMarcaPersonal(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool AgregarMarcaTodos(MARCAS marca)
        {
            try
            {
                SQLSentencia objpeticion = new SQLSentencia();

                //Ajustar peticion para utilización con parametros
                objpeticion.Peticion = @"EXEC SP_AGREGAR_MARCAS @ID_Personal, @Fecha, @Hora, @Tipo";

                //Crear los parametros
                SqlParameter parametroidpersonal = new SqlParameter();
                parametroidpersonal.ParameterName = "@ID_Personal";
                parametroidpersonal.SqlDbType = System.Data.SqlDbType.Int;
                parametroidpersonal.Value = marca.ID_Personal;

                SqlParameter parametrofecha = new SqlParameter();
                parametrofecha.ParameterName = "@Fecha";
                parametrofecha.SqlDbType = System.Data.SqlDbType.Date;
                parametrofecha.Value = marca.Fecha;

                SqlParameter parametrohora = new SqlParameter();
                parametrohora.ParameterName = "@Hora";
                parametrohora.SqlDbType = System.Data.SqlDbType.Time;
                parametrohora.Value = marca.Hora;

                SqlParameter parametrotipo = new SqlParameter();
                parametrotipo.ParameterName = "@Tipo";
                parametrotipo.SqlDbType = System.Data.SqlDbType.Int;
                parametrotipo.Value = marca.Tipo;

                //Agrega a la lista de parametros los parametros creados
                objpeticion.lstParametros.Add(parametroidpersonal);
                objpeticion.lstParametros.Add(parametrofecha);
                objpeticion.lstParametros.Add(parametrohora);
                objpeticion.lstParametros.Add(parametrotipo);

                DA objacceso = new DA();
                return objacceso.ejecutarSentecia(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
