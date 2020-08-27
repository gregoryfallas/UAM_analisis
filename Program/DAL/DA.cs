using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DA
    {
        private int _iPrueba;

        #region Atributos 
        private string cadenaconexion = Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;

        public int iPrueba { get => _iPrueba; set => _iPrueba = value; }
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
                {
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                }
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

                        tipo.ID_Tipo_Animal = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Tipo = item.ItemArray[1].ToString();
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

        /// <summary>
        /// Metodo para consultar los datos del cliente en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>

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
                        tipo.Nombre = item.ItemArray[2].ToString();
                        tipo.Apellido_1 = item.ItemArray[3].ToString();
                        tipo.Apellido_2 = item.ItemArray[4].ToString();
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

        /// <summary>
        /// Metodo para consultar los datos del cliente en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
        public List<CLIENTES> ConsultarClientesPantallaClientes(SQLSentencia P_Peticion)
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
                        tipo.Nombre = item.ItemArray[2].ToString();
                        tipo.Apellido_1 = item.ItemArray[3].ToString();
                        tipo.Apellido_2 = item.ItemArray[4].ToString();
                        tipo.Correo = item.ItemArray[5].ToString();
                        tipo.Telefono = item.ItemArray[6].ToString();
                        tipo.ID_Provincias = Convert.ToInt32(item.ItemArray[7].ToString());
                        tipo.ID_Cantones = Convert.ToInt32(item.ItemArray[8].ToString());
                        tipo.ID_Distritos = Convert.ToInt32(item.ItemArray[9].ToString());
                        tipo.Direccion = item.ItemArray[10].ToString();
                        tipo.Credito = Convert.ToBoolean(item.ItemArray[11].ToString());
                        tipo.Estado = Convert.ToInt32(item.ItemArray[12].ToString());

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



        /// <summary>
        /// Metodo para consultar los esatdos de la mascota en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
        public List<ESTADOS> ConsultarEstadosCliente(SQLSentencia P_Peticion)
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

        /// <summary>
        /// Metodo para consultar las provincias en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
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

        /// <summary>
        /// Metodo para consultar las provincias en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
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


        /// <summary>
        /// Metodo para consultar las provincias en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
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

        #endregion

        #region ARTICULOS
        public DataTable CREAR_ingreso_estados(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Estado");
            dt.Columns.Add("Nombre");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }
        }

        public DataTable CREAR_ingreso_articulos(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Despacho");
            dt.Columns.Add("ID Factura");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Estado");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetDateTime(2), resultado.GetInt32(3));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }
        }

        public List<ARTICULOS> ConsultarArticulos(SQLSentencia P_Peticion)
        {
            List<ARTICULOS> lstresultados = new List<ARTICULOS>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                {
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                    SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                    objconsultar.Fill(dt);
                }  //elena
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ARTICULOS tipo = new ARTICULOS();

                        tipo.ID_Articulos = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        tipo.Descripcion = item.ItemArray[2].ToString();
                        tipo.Precio = Convert.ToDecimal(item.ItemArray[3].ToString());
                        tipo.Estado = Convert.ToInt32(item.ItemArray[4].ToString());

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


        public DataTable consultarInventarioConArticulos(SQLSentencia peticion)
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

        #endregion

        #region SUMINISTROS 

        public DataTable SP_CONSULTAR_INVENTARIO_MENOR_CANTIDAD(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                {  //elena
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                    SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);

                    da.Fill(dt);
                } //elena
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

        public DataTable CREAR_ingreso_suministros(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Articulo");
            dt.Columns.Add("ID Articulo Proveedor");
            dt.Columns.Add("ID Solicitud");
            dt.Columns.Add("Descripión");
            dt.Columns.Add("Cantidad");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetInt32(2), resultado.GetString(3), resultado.GetDecimal(4));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }
        }

        public DataTable CREAR_ingreso_suministros_proveedor(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Descripcion");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }
        }
        #endregion

        #region PROMOCIONES
        public DataTable consultar_promociones(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Promocion");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Descripión");
            dt.Columns.Add("Estado");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1), resultado.GetDateTime(2), resultado.GetDateTime(3), resultado.GetDecimal(4), resultado.GetString(5), resultado.GetInt32(6));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }
        }

        #endregion

        #region CAMPANAS
        public DataTable consultar_campanas(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Promocion");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");
            dt.Columns.Add("ID distritos");
            dt.Columns.Add("Descripión");
            dt.Columns.Add("Estado");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1), resultado.GetDateTime(2), resultado.GetDateTime(3), resultado.GetInt32(4), resultado.GetString(5), resultado.GetInt32(6));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }
        }
        #endregion

        #region ANUNCIOS

        public DataTable consultar_anuncios(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();
            ////////////////////////////////////////////////////////
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                {  //elena
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                    SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);

                    da.Fill(dt);
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
            return dt;
        }


        public DataTable agregar_anuncios(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Anuncios");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripión");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetInt32(3), resultado.GetString(4), resultado.GetInt32(5));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }

        }

        public DataTable actualizar_anuncios(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Anuncios");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripión");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetInt32(3), resultado.GetString(4), resultado.GetInt32(5));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }

        }

        public DataTable eliminar_anuncios(SQLSentencia peticion)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID Anuncios");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripión");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Fecha Inicio");
            dt.Columns.Add("Fecha Fin");

            try
            {
                objconexion.Open();
                SqlCommand cmd = new SqlCommand(peticion.Peticion, objconexion);
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                while (resultado.Read())
                {
                    dt.Rows.Add(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetInt32(3), resultado.GetString(4), resultado.GetInt32(5));
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objconexion.Close();
            }

        }
        #endregion
        #endregion
    }
}
