using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA
    {
        #region Atributos 
        private string cadenaconexion = Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;        

        #endregion

        #region Constructor

        public DA()
        {
            try
            {
                objconexion = new SqlConnection(cadenaconexion);
                this.ABRIR();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }

        #endregion
       
        
        #region PRIVADOS

        private void ABRIR()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CERRAR()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }
        #endregion

        #region PUBLICOS

        #region Sentencias
        /// <summary>
        ///Metodo que ejecuta la sentencia para eliminar, modificar, agregar
        /// </summary>
        /// <param name="peticion"></param>
        /// <returns></returns>
        public bool ejecutarSentecia(SQLSentencia peticion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                this.ABRIR();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }
        #endregion

        #region Mascotas
        /// <summary>
        /// Metodo para consultar los tipos de mascotas en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
        public List<TIPO_ANIMAL> ConsultarTipoMascota(SQLSentencia P_Peticion)
        {
            List<TIPO_ANIMAL> lstresultados = new List<TIPO_ANIMAL>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        TIPO_ANIMAL tipo = new TIPO_ANIMAL();
                       
                        tipo.ID_Tipo_Animal= Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Tipo= item.ItemArray[1].ToString();
                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion


        #region CLIENTES
        public List<CLIENTES> ConsultarClientes(SQLSentencia P_Peticion)
        {
            List<CLIENTES> lstresultados = new List<CLIENTES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        CLIENTES tipo = new CLIENTES();

                        tipo.ID_Cliente = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Cedula = item.ItemArray[1].ToString();
                        tipo.Nombre= item.ItemArray[2].ToString();
                        tipo.Apellido_1= item.ItemArray[3].ToString();
                        tipo.Apellido_2= item.ItemArray[4].ToString();                       
                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }
        #endregion

        #region ARTICULOS

        //public List<ARTICULOS> ConsultarArticulos(SQLSentencia P_Peticion)
        //{
        //    List<ARTICULOS> lstresultados = new List<ARTICULOS>();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        //ASigna los valores del QUERY a ejecutar en SQL
        //        cmd.Connection = objconexion; //ASigna conexion
        //        cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
        //        cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

        //        if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
        //            cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

        //        SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
        //        objconsultar.Fill(dt);

        //        if (dt.Rows.Count > 0)
        //        {
        //            foreach (DataRow item in dt.Rows)
        //            {
        //               ARTICULOS tipo = new ARTICULOS();

        //                tipo.ID_Articulos=Convert.ToInt32(item.ItemArray[0].ToString());              
        //                tipo.Nombre = item.ItemArray[1].ToString();
        //                tipo.Descripcion= item.ItemArray[2].ToString();
        //                tipo.Precio= Convert.ToDecimal(item.ItemArray[3].ToString());
        //                tipo.Estado= Convert.ToInt32(item.ItemArray[4].ToString());

        //                lstresultados.Add(tipo);
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        this.CERRAR();
        //    }

        //    return lstresultados;
        //}



        public DataTable consultarInventarioConArticulos(SQLSentencia peticion)
        {
            //  List<Caso> listaResultado = new List<Caso>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);



                da.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return dt;



        }










        public DataTable consultarUsuariosYPerfilPorEstado(SQLSentencia  peticion)
        {
          //  List<Caso> listaResultado = new List<Caso>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);

                da.Fill(dt);

             

             
               
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return dt;

        }








        #endregion


        #region Stephanie

        #region Reclutamiento 

        public List<ESTADOS> ConsultarTipoEstado(SQLSentencia P_Peticion)
        {
            List<ESTADOS> lstresultados = new List<ESTADOS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ESTADOS tipo = new ESTADOS();

                        tipo.ID_Estados = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                     
                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<PUESTOS> ConsultarTipoCargo(SQLSentencia P_Peticion)
        {
            List<PUESTOS> lstresultados = new List<PUESTOS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PUESTOS tipo = new PUESTOS();

                        tipo.ID_Puestos = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<DEPARTAMENTOS> ConsultarTipoPuestos(SQLSentencia P_Peticion)
        {
            List<DEPARTAMENTOS> lstresultados = new List<DEPARTAMENTOS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        DEPARTAMENTOS tipo = new DEPARTAMENTOS();

                        tipo.ID_Departamento = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion

        #region NOMINA

        public List<NOMINA> ObtenerNomina(SQLSentencia P_Peticion)
        {
            List<NOMINA> lstresultados = new List<NOMINA>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        NOMINA tabla = new NOMINA();

                        tabla.ID_Nomina = Convert.ToInt32(item.ItemArray[0].ToString());
                        tabla.Nombre = item.ItemArray[1].ToString();
                        tabla.Fecha_Inicio = Convert.ToDateTime(item.ItemArray[2].ToString());
                        tabla.Fecha_Fin = Convert.ToDateTime(item.ItemArray[3].ToString());
                        tabla.Descripcion = item.ItemArray[4].ToString();

                        lstresultados.Add(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion

        #region USUARIOS

        public List<PERSONAL> ConsultarIDPersonal(SQLSentencia P_Peticion)
        {
            List<PERSONAL> lstresultados = new List<PERSONAL>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PERSONAL ID = new PERSONAL();

                        ID.ID_Personal = Convert.ToInt32(item.ItemArray[0].ToString());
                        ID.Cedula = item.ItemArray[1].ToString();

                        lstresultados.Add(ID);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<ESTADOS> ConsultarTipoEstadoUsuario(SQLSentencia P_Peticion)
        {
            List<ESTADOS> lstresultados = new List<ESTADOS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ESTADOS ID = new ESTADOS();

                        ID.ID_Estados = Convert.ToInt32(item.ItemArray[0].ToString());
                        ID.Nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(ID);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion

        #region ROLES

        public List<ROLES> ObtenerRoles(SQLSentencia P_Peticion)
        {
            List<ROLES> lstresultados = new List<ROLES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                //if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                //    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ROLES tabla = new ROLES();

                        tabla.ID_Roles = Convert.ToInt32(item.ItemArray[0].ToString());
                        tabla.Nombre = item.ItemArray[1].ToString();
                        //tabla.Descripcion = item.ItemArray[2].ToString();
                        //tabla.Estado = Convert.ToInt32(item.ItemArray[3].ToString());

                        lstresultados.Add(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion

        #region POSTULANTES

        public List<RECLUTAMIENTO> ConsultarIDReclutamiento(SQLSentencia P_Peticion)
        {
            List<RECLUTAMIENTO> lstresultados = new List<RECLUTAMIENTO>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        RECLUTAMIENTO ID = new RECLUTAMIENTO();

                        ID.ID_Reclutamiento = Convert.ToInt32(item.ItemArray[0].ToString());
                        ID.Nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(ID);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<ESTADOS> ConsultarTipoEstadoPostulantes(SQLSentencia P_Peticion)
        {
            List<ESTADOS> lstresultados = new List<ESTADOS>();
            DataTable dt = new DataTable();
            try

            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ESTADOS ID = new ESTADOS();

                        ID.ID_Estados = Convert.ToInt32(item.ItemArray[0].ToString());
                        ID.Nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(ID);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<PROVINCIAS> ConsultarProvincias(SQLSentencia P_Peticion)
        {
            List<PROVINCIAS> lstresultados = new List<PROVINCIAS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PROVINCIAS tipo = new PROVINCIAS();

                        tipo.ID_Provincias = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<CANTONES> ConsultarCantonesPorProvincias(SQLSentencia P_Peticion)
        {
            List<CANTONES> lstresultados = new List<CANTONES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        CANTONES tipo = new CANTONES();

                        tipo.ID_Cantones = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<DISTRITOS> ConsultarDistritosPorCantones(SQLSentencia P_Peticion)
        {
            List<DISTRITOS> lstresultados = new List<DISTRITOS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        DISTRITOS tipo = new DISTRITOS();

                        tipo.ID_Distritos = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<CANTONES> ConsultarIdCanton(SQLSentencia P_Peticion)
        {
            List<CANTONES> lstresultados = new List<CANTONES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        CANTONES tipo = new CANTONES();
                        tipo.ID_Cantones = Convert.ToInt32(item.ItemArray[0].ToString());


                        lstresultados.Add(tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public DataTable ObtenerParticipantes(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;

                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());

                SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return dt;
        }

        public List<PARTICIPANTES> ObtenerParticipantes2(SQLSentencia P_Peticion)
        {
            List<PARTICIPANTES> lstresultados = new List<PARTICIPANTES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PARTICIPANTES u = new PARTICIPANTES();

                        u.ID_Participantes = Convert.ToInt32(item.ItemArray[0].ToString());
                        u.ID_Reclutamiento = Convert.ToInt32(item.ItemArray[1].ToString());
                        u.Cedula_ = item.ItemArray[2].ToString();
                        u.Nombre = item.ItemArray[3].ToString();
                        u.Apellido_1 = item.ItemArray[4].ToString();
                        u.Apellido_2 = item.ItemArray[5].ToString();
                        u.Correo = item.ItemArray[6].ToString();
                        u.Telefono = item.ItemArray[7].ToString();
                        u.ID_Provincia = Convert.ToInt32(item.ItemArray[8].ToString());
                        u.ID_Canton = Convert.ToInt32(item.ItemArray[9].ToString());
                        u.ID_Distrito = Convert.ToInt32(item.ItemArray[10].ToString());
                        u.Direccion = item.ItemArray[11].ToString();
                        u.Estado = Convert.ToInt32(item.ItemArray[12].ToString());

                        lstresultados.Add(u);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<PRUEBAS> NotasIdPruebas(SQLSentencia P_Peticion)
        {
            List<PRUEBAS> lstresultados = new List<PRUEBAS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PRUEBAS ID = new PRUEBAS();

                        ID.ID_Pruebas = Convert.ToInt32(item.ItemArray[0].ToString());
                        ID.Nombre = item.ItemArray[1].ToString();

                        lstresultados.Add(ID);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<PARTICIPANTES> NotasIdParticipantes(SQLSentencia P_Peticion)
        {
            List<PARTICIPANTES> lstresultados = new List<PARTICIPANTES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PARTICIPANTES ID = new PARTICIPANTES();

                        ID.ID_Participantes = Convert.ToInt32(item.ItemArray[0].ToString());
                        ID.Cedula_ = item.ItemArray[1].ToString();

                        lstresultados.Add(ID);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        public List<PRUEBAS_PARTICIPANTES> ObtenerPruebasParticipantes(SQLSentencia P_Peticion)
        {
            List<PRUEBAS_PARTICIPANTES> lstresultados = new List<PRUEBAS_PARTICIPANTES>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        PRUEBAS_PARTICIPANTES tabla = new PRUEBAS_PARTICIPANTES();

                        tabla.ID_Pruebas_Participantes = Convert.ToInt32(item.ItemArray[0].ToString());
                        tabla.ID_Pruebas = Convert.ToInt32(item.ItemArray[1].ToString());
                        tabla.ID_Pruebas_Participantes = Convert.ToInt32(item.ItemArray[2].ToString());
                        tabla.Nota = Convert.ToDecimal(item.ItemArray[3].ToString());
                     

                        lstresultados.Add(tabla);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion

        #region PERSONAL

        public List<PERSONAL> ObtenerPersonal(SQLSentencia peticion)
        {
            List<PERSONAL> lstresultados = new List<PERSONAL>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;

                SqlDataAdapter objcargar = new SqlDataAdapter(cmd);
                objcargar.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    PERSONAL u = new PERSONAL();

                    u.ID_Personal = Convert.ToInt32(item.ItemArray[0].ToString());
                    u.ID_Puesto = Convert.ToInt32(item.ItemArray[1].ToString());
                    u.Cedula = item.ItemArray[2].ToString();
                    u.Nombre = item.ItemArray[3].ToString();
                    u.Apellido_1 = item.ItemArray[4].ToString();
                    u.Apellido_2 = item.ItemArray[5].ToString();
                    u.Salario_Hora = Convert.ToDecimal (item.ItemArray[6].ToString());
                    u.Salario_Mensual = Convert.ToDecimal(item.ItemArray[7].ToString());
                    u.Fecha_Contratacion = Convert.ToDateTime(item.ItemArray[8].ToString());
                    u.created_at = Convert.ToDateTime(item.ItemArray[9].ToString());
                    u.Estado = Convert.ToInt32(item.ItemArray[10].ToString());
                    u.Direccion = item.ItemArray[11].ToString();
                    u.Correo_Electronico = item.ItemArray[12].ToString();
                    u.Telefono = item.ItemArray[13].ToString();

                    lstresultados.Add(u);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }

        #endregion

        #endregion



        #endregion

    }
}
