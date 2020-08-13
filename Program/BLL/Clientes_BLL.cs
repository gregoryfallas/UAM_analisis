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
    public class Clientes_BLL
    {

        

        public static bool agregarCliente(CLIENTES cliente)
        {
            try
            {

                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_AGREGAR_CLIENTES '" + cliente.Cedula + "','" + cliente.Nombre + "','" + cliente.Apellido_1 + "','"+ cliente.Apellido_2 +"','"+cliente.Correo + "','" +cliente.Telefono  + "','"  +cliente.ID_Provincias+ "','" + cliente.ID_Cantones+ "','"+ cliente.ID_Distritos+ "','"+ cliente.Direccion+ "','"+cliente.Estado +   "'";
                
                //SQLSentencia peticion = new SQLSentencia();
                //peticion.Peticion = @"EXEC SP_AGREGAR_CLIENTES @ced, @nom, @ape1, @ape2, @correo, @tel, @provincia, @canton, @distrito, @dire , @credito, @est ";

                //SqlParameter paramced = new SqlParameter();
                //paramced.Value = cliente.Cedula;
                //paramced.ParameterName = "@ced";
                //paramced.SqlDbType = System.Data.SqlDbType.Int;

                //SqlParameter paramNom = new SqlParameter();
                //paramNom.Value = cliente.Nombre;
                //paramNom.ParameterName = "@nom";
                //paramNom.SqlDbType = System.Data.SqlDbType.VarChar;

                //SqlParameter paramApe1 = new SqlParameter();
                //paramApe1.Value = cliente.Apellido_1;
                //paramApe1.ParameterName = "@ape1";
                //paramApe1.SqlDbType = System.Data.SqlDbType.VarChar;

                //SqlParameter paramApe2 = new SqlParameter();
                //paramApe2.Value = cliente.Apellido_2;
                //paramApe2.ParameterName = "@ape2";
                //paramApe2.SqlDbType = System.Data.SqlDbType.VarChar;

                //SqlParameter paramCorreo= new SqlParameter();
                //paramCorreo.Value = cliente.Correo;
                //paramCorreo.ParameterName = "@correo";
                //paramCorreo.SqlDbType = System.Data.SqlDbType.VarChar;

                //SqlParameter paramTel = new SqlParameter();
                //paramTel.Value = cliente.Telefono;
                //paramTel.ParameterName = "@tel";
                //paramTel.SqlDbType = System.Data.SqlDbType.VarChar;

                //SqlParameter paramProvincia = new SqlParameter();
                //paramProvincia.Value = cliente.ID_Provincias;
                //paramProvincia.ParameterName = "@provincia";
                //paramProvincia.SqlDbType = System.Data.SqlDbType.Int;

                //SqlParameter paramCanton = new SqlParameter();
                //paramCanton.Value = cliente.ID_Cantones;
                //paramCanton.ParameterName = "@canton";
                //paramCanton.SqlDbType = System.Data.SqlDbType.Int;

                //SqlParameter paramDistrito = new SqlParameter();
                //paramDistrito.Value = cliente.ID_Distritos;
                //paramDistrito.ParameterName = "@distrito";
                //paramDistrito.SqlDbType = System.Data.SqlDbType.Int;


                //SqlParameter paramDire = new SqlParameter();
                //paramDire.Value = cliente.Direccion;
                //paramDire.ParameterName = "@direc";
                //paramDire.SqlDbType = System.Data.SqlDbType.VarChar;


                //SqlParameter paramCredito= new SqlParameter();
                //paramCredito.Value = cliente.Credito;
                //paramCredito.ParameterName = "@credito";
                //paramCredito.SqlDbType = System.Data.SqlDbType.Bit;


                //SqlParameter paramEst = new SqlParameter();
                //paramEst.Value = cliente.Estado;
                //paramEst.ParameterName = "@est";
                //paramEst.SqlDbType = System.Data.SqlDbType.Int;

                //peticion.lstParametros.Add(paramced);
                //peticion.lstParametros.Add(paramNom);
                //peticion.lstParametros.Add(paramApe1);
                //peticion.lstParametros.Add(paramApe2);
                //peticion.lstParametros.Add(paramCorreo);
                //peticion.lstParametros.Add(paramTel);
                //peticion.lstParametros.Add(paramProvincia);
                //peticion.lstParametros.Add(paramCanton);
                //peticion.lstParametros.Add(paramDistrito);
                //peticion.lstParametros.Add(paramDire);
                //peticion.lstParametros.Add(paramCredito);
                //peticion.lstParametros.Add(paramEst);


                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<CLIENTES> ConsultarClientes(string Cedula )
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CLIENTES @Cedula";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Cedula;
                paramC.ParameterName = "@Cedula";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarClientes(sentencia);             

                
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //public static List<CLIENTES> ConsultarClientesPantallaCliente(string Cedula)
        //{

        //    try
        //    {
        //        SQLSentencia sentencia = new SQLSentencia();
        //        sentencia.Peticion = @"EXEC SP_CONSULTAR_CLIENTES_PANTALLACLIENTE @Cedula";
        //        SqlParameter paramC = new SqlParameter();
        //        paramC.Value = Cedula;
        //        paramC.ParameterName = "@Cedula";
        //        paramC.SqlDbType = System.Data.SqlDbType.VarChar;
        //        sentencia.lstParametros.Add(paramC);
        //        DA acceso = new DA();
        //        return acceso.ConsultarClientesPantallaClientes(sentencia);


        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}




        public static DataTable ConsultarClientesPantallaCliente(string Cedula)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CLIENTES_PANTALLACLIENTE '" + Cedula + "'";
               DA acceso = new DA();
                return acceso.ConsultarClientesPantallaClientes(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static List<ESTADOS> ConsultaEstadosCliente()
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_CONSULTAR_ESTADOSCLIENTES ";

                DA objacceso = new DA();
                return objacceso.ConsultarEstadosCliente(peticion);
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



        public static bool eliminarCliente(string ced)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_Clientes_Eliminar @ced";
                SqlParameter ids = new SqlParameter();
                ids.Value = ced;
                ids.ParameterName = "@ced";
                ids.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(ids);
                DA acceso = new DA();
                return acceso.ejecutarSentecia(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static bool modificarCliente(CLIENTES cliente)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Clientes_Modificar '" + cliente.Cedula + "','" + cliente.Nombre + "','" + cliente.Apellido_1 + "','" + cliente.Apellido_2 + "','" + cliente.Correo + "','" + cliente.Telefono + "','" + cliente.ID_Provincias + "','" + cliente.ID_Cantones + "','" + cliente.ID_Distritos + "','" + cliente.Direccion + "','" + cliente.Credito + "','" + cliente.Estado + "'";
                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
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








    }


}
