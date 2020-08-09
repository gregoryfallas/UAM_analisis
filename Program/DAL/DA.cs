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
                        tipo.Correo= item.ItemArray[5].ToString();
                        tipo.Telefono=item.ItemArray[6].ToString();
                        tipo.ID_Provincias= Convert.ToInt32(item.ItemArray[7].ToString());

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



        #endregion


        #region 




        #endregion

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



    }

}
