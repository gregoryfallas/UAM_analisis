﻿using DAL.Entidades;
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
        public int ejecutarSentecia(SQLSentencia peticion)
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
                return cmd.ExecuteNonQuery();
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

        #region Puestos
        //public int Ejecutar_Peticiones(SQLSentencia P_Peticion)
        //{
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = objconexion;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = P_Peticion.Peticion;

        //        this.ABRIR();

        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        this.CERRAR();
        //    }
        //}

        public List<PUESTOS> Consultar_Puestos(SQLSentencia P_Peticion)
        {

            List<PUESTOS> lstresultados = new List<PUESTOS>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;


                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow fila in dt.Rows)
                    {
                        PUESTOS u = new PUESTOS();


                        u.ID_Puestos = Convert.ToInt32(fila.ItemArray[0].ToString());
                        u.ID_Departamento = Convert.ToInt32(fila.ItemArray[1].ToString());
                        u.Nombre = fila.ItemArray[2].ToString();
                      //  u.Salario_Base = Convert.ToDecimal(fila.ItemArray[3].ToString());
                      //  u.Descripcion = fila.ItemArray[4].ToString();
                       

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
        #endregion

        public List<RECLUTAMIENTO> Consultar_Reclutamiento(SQLSentencia P_Peticion)
        {

            List<RECLUTAMIENTO> lstresultados = new List<RECLUTAMIENTO>();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = P_Peticion.Peticion;


                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow fila in dt.Rows)
                    {
                        RECLUTAMIENTO u = new RECLUTAMIENTO();


                      //  u.ID_Reclutamiento = Convert.ToInt32(fila.ItemArray[0].ToString());
                      //  u.ID_Puestos = Convert.ToInt32(fila.ItemArray[1].ToString());
                        u.Nombre = fila.ItemArray[0].ToString();
                        u.Descripcion = fila.ItemArray[1].ToString();
                        u.Estado = Convert.ToInt32(fila.ItemArray[2].ToString());



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
                        ESTADOS est = new ESTADOS();

                        est.ID_Estados = Convert.ToInt32(item.ItemArray[0].ToString());
                        est.Nombre = item.ItemArray[1].ToString();
                        lstresultados.Add(est);
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

        public List<PUESTOS> ConsultarTipoPuesto(SQLSentencia P_Peticion)
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
                        PUESTOS depa = new PUESTOS();

                        depa.ID_Puestos = Convert.ToInt32(item.ItemArray[0].ToString());
                        depa.Nombre = item.ItemArray[1].ToString();
                        lstresultados.Add(depa);
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



        #endregion

    }
}
