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
    public class Articulos_BLL
    {
        DA Obj_Dal = new DA();

        public static DataTable ConsultarInventarioArticulos(string Nombre)
        {
                       
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_INVENTARIO '" + Nombre + "'";

                                             
                DA acceso = new DA();
                return acceso.consultarInventarioConArticulos(sentencia);
                                             
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        

        public void Cajas (ref DA Obj_DAL)
        {
           
            if (Obj_DAL.IPrueba==1)
            {
                Obj_DAL.ITemporal = 1;
            }
            else
            {
                Obj_DAL.ITemporal = 0;
            }

        }
       

            public static List<CAJAS> ConsultarCajas(int Caja)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_CAJAS '" + Caja + "'";


                DA acceso = new DA();
                return acceso.ConsultarCajas(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool ModificarCajas(int IDcaja, int IDestado)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_MODIFICAR_ESTADO_CAJAS '" + IDcaja + "','" + IDestado + "'";


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
