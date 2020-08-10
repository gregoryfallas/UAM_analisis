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
    public class Articulos
    {
        public static List<ARTICULOS> ConsultarArticulos(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_Articulos @Nombre";
                SqlParameter paramC = new SqlParameter();
                paramC.Value = Nombre;
                paramC.ParameterName = "@Nombre";
                paramC.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramC);
                DA acceso = new DA();
                return acceso.ConsultarArticulos(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable ConsultarInventarioArticulos(string Nombre)
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC SP_CONSULTAR_INVENTARIO '" + Nombre+ "'";
                


                DA acceso = new DA();
                return acceso.consultarInventarioConArticulos(sentencia);


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static implicit operator System.Windows.Forms.DataGridView(Articulos v)
        {
            throw new NotImplementedException();
        }
    }
}
