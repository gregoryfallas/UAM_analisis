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
        private int _iTemporal;
        private int _iPrueba;



        #region Atributos 
        private string cadenaconexion = Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;

        public int ITemporal { get => _iTemporal; set => _iTemporal = value; }
        public int IPrueba { get => _iPrueba; set => _iPrueba = value; }

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

        #endregion
        
        #region CLIENTES
        public List<CLIENTES> ConsultarClientesPantallaCredito(SQLSentencia P_Peticion)
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
                        tipo.Credito = Convert.ToInt32(item.ItemArray[7].ToString());

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

        public List<CAJAS> ConsultarCajas(SQLSentencia P_Peticion)
        {
            List<CAJAS> lstresultados = new List<CAJAS>();
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
                        CAJAS tipo = new CAJAS();

                        tipo.ID_Caja = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Estado = Convert.ToInt32(item.ItemArray[1].ToString());


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



        public DataTable consultarUsuariosYPerfilPorEstado(SQLSentencia peticion)
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


        #region CONSULTAR NUMERO FACTURAS
        public List<FACTURAS> ConsultarNoFacturas(SQLSentencia P_Peticion)
        {
            List<FACTURAS> lstresultados = new List<FACTURAS>();
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
                        FACTURAS tipo = new FACTURAS();

                        tipo.Numero_Factura = Convert.ToInt32(item.ItemArray[0].ToString());

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


        #region MODIFICAR CREDITOS
        public List<CLIENTES> ModificaCreditos(SQLSentencia P_Peticion)
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

                        tipo.Cedula = item.ItemArray[0].ToString();
                        tipo.Credito = Convert.ToInt32(item.ItemArray[1].ToString());

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


        #region CONSULTARCOBROS
        public DataTable ConsultarCobros(SQLSentencia peticion)
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


        #region CONSULTAR EXPRESS CLIENTES

        public DataTable ConsultarExpressClientes(SQLSentencia peticion)
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


        #region CONSULTAR DETALLES FACTURA
        public DataTable ConsultarDetalles(SQLSentencia peticion)
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


        #region CONSULTARCLIENTESCREDITO
        public List<CLIENTES> ConsultarClientesCredito(SQLSentencia P_Peticion)
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
                        tipo.Credito= Convert.ToInt32(item.ItemArray[4].ToString());
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





        #region PreConsulta

        public DataTable consultarCitasEnCurso(SQLSentencia P_Peticion)
        {


            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;
                if (P_Peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(P_Peticion.Peticion, objconexion);

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






        public List<ESTADOS> ConsultarEstadosMascota(SQLSentencia P_Peticion)
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




        #endregion

        #region Consultas

        public List<OBSERVACIONES> ConsultarObservacionesPorCita(SQLSentencia P_Peticion)
        {
            List<OBSERVACIONES> lstresultados = new List<OBSERVACIONES>();
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
                        OBSERVACIONES tipo = new OBSERVACIONES();

                        tipo.ID_Cita = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Descripcion = item.ItemArray[1].ToString();
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



        public List<SERVICIOS> ConsultarServicios(SQLSentencia P_Peticion)
        {
            List<SERVICIOS> lstresultados = new List<SERVICIOS>();
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
                        SERVICIOS tipo = new SERVICIOS();

                        tipo.ID_Servicios = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        tipo.Descripcion = item.ItemArray[2].ToString();
                        tipo.Precio = Convert.ToDecimal(item.ItemArray[3].ToString());
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


        public List<SERVICIOS> ConsultarServicios_IDNOMBRE(SQLSentencia P_Peticion)
        {
            List<SERVICIOS> lstresultados = new List<SERVICIOS>();
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
                        SERVICIOS tipo = new SERVICIOS();

                        tipo.ID_Servicios = Convert.ToInt32(item.ItemArray[0].ToString());
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




        public List<PRUEBAS_LABORATORIO> ConsultarPruebasLaboratorio(SQLSentencia P_Peticion)
        {
            List<PRUEBAS_LABORATORIO> lstresultados = new List<PRUEBAS_LABORATORIO>();
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
                        PRUEBAS_LABORATORIO tipo = new PRUEBAS_LABORATORIO();

                        tipo.ID_Pruebas_Laboratorio = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        tipo.Descripcion = item.ItemArray[1].ToString();

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





        public List<ARTICULOS> ConsultarMEDICAMENTOS(SQLSentencia P_Peticion)
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
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        ARTICULOS tipo = new ARTICULOS();

                        tipo.ID_Articulos = Convert.ToInt32(item.ItemArray[0].ToString());
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





        //public List<SERVICIOS> ConsultarServiciosVacunacion_IDNOMBRE(SQLSentencia P_Peticion)
        //{
        //    List<SERVICIOS> lstresultados = new List<SERVICIOS>();
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
        //                SERVICIOS tipo = new SERVICIOS();

        //                tipo.ID_Servicios = Convert.ToInt32(item.ItemArray[0].ToString());
        //                tipo.Nombre = item.ItemArray[1].ToString();

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







        public DataTable consultarMascotasPantalla(SQLSentencia peticion)
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









        public List<MASCOTAS> ConsultarMascotas(SQLSentencia P_Peticion)
        {
            List<MASCOTAS> lstresultados = new List<MASCOTAS>();
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
                        MASCOTAS tipo = new MASCOTAS();






                        tipo.ID_Mascota = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.ID_Cliente = Convert.ToInt32(item.ItemArray[1].ToString());
                        tipo.Nombre = item.ItemArray[2].ToString();
                        tipo.Tipo_Animal = Convert.ToInt32(item.ItemArray[3].ToString());
                        tipo.Raza = item.ItemArray[4].ToString();
                        tipo.Sexo = item.ItemArray[5].ToString();
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

        

        public DataTable ConsultarClientesPantallaClientes(SQLSentencia P_Peticion)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;
                if (P_Peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(P_Peticion.Peticion, objconexion);

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


        /// <summary>
        /// Metodo para consultar el id del Canton en la base de datos
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
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









        public List<CONSULTORIO> ConsultarConsultorios(SQLSentencia P_Peticion)
        {
            List<CONSULTORIO> lstresultados = new List<CONSULTORIO>();
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
                        CONSULTORIO tipo = new CONSULTORIO();

                        tipo.ID_Consultorio = Convert.ToInt32(item.ItemArray[0].ToString());
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


        public List<MOTIVO_CITA> ConsultarMotivos(SQLSentencia P_Peticion)
        {
            List<MOTIVO_CITA> lstresultados = new List<MOTIVO_CITA>();
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
                        MOTIVO_CITA tipo = new MOTIVO_CITA();

                        tipo.ID_Motivo_Cita = Convert.ToInt32(item.ItemArray[0].ToString());
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

        public List<CITAS> ConsultarCitas(SQLSentencia P_Peticion)
        {
            List<CITAS> lstresultados = new List<CITAS>();
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
                        CITAS tipo = new CITAS();
                        tipo.ID_Cita = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.ID_Mascota = Convert.ToInt32(item.ItemArray[1].ToString());
                        tipo.Nombre_Mascota = item.ItemArray[2].ToString();
                        tipo.ID_Consultorio = Convert.ToInt32(item.ItemArray[3].ToString());
                        tipo.ID_Motivo_Cita = Convert.ToInt32(item.ItemArray[4].ToString());
                        tipo.Motivo_Cita = item.ItemArray[5].ToString();
                        tipo.Fecha_Inicio = DateTime.Parse(item.ItemArray[6].ToString());
                        tipo.Hora_Inicio = TimeSpan.Parse(item.ItemArray[7].ToString());
                        tipo.Hora_Fin = TimeSpan.Parse(item.ItemArray[8].ToString());
                        tipo.ID_Estado = Convert.ToInt32(item.ItemArray[9].ToString());
                        tipo.Estado = item.ItemArray[10].ToString();
                        tipo.Nombre = item.ItemArray[11].ToString();
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
        

        public DataTable ConsultarCitasPantallaCitas(SQLSentencia P_Peticion)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;
                if (P_Peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(P_Peticion.Peticion, objconexion);

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

        public List<MASCOTAS> ConsultarMascotasClientes(SQLSentencia P_Peticion)
        {
            List<MASCOTAS> lstresultados = new List<MASCOTAS>();
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
                        MASCOTAS tipo = new MASCOTAS();
                        tipo.ID_Mascota = Convert.ToInt32(item.ItemArray[0].ToString());
                        tipo.Nombre = item.ItemArray[1].ToString();
                        tipo.Nombre_Cliente = item.ItemArray[2].ToString();
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


        #region CONSULTAS EXAMENES POR CITA 
        public DataTable ConsultarExamenesporcita(SQLSentencia P_Peticion)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;
                if (P_Peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(P_Peticion.Peticion, objconexion);

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

                        //tabla.ID_Pruebas_Participantes = Convert.ToInt32(item.ItemArray[0].ToString());
                        tabla.ID_Pruebas = Convert.ToInt32(item.ItemArray[0].ToString());
                        tabla.ID_Pruebas_Participantes = Convert.ToInt32(item.ItemArray[1].ToString());
                        tabla.Nota = Convert.ToInt32(item.ItemArray[2].ToString());
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
                    u.Salario_Hora = Convert.ToDecimal(item.ItemArray[6].ToString());
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

        public DataTable ObtenerPersonalDGV(SQLSentencia peticion)
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

        public List<TIPO_MARCA> ConsultarMarcaPersonal(SQLSentencia P_Peticion)
        {
            List<TIPO_MARCA> lstresultados = new List<TIPO_MARCA>();
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
                        TIPO_MARCA tipo = new TIPO_MARCA();

                        tipo.ID_Tipo = Convert.ToInt32(item.ItemArray[0].ToString());
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


    }

}
