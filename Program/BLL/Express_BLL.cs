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
    public class Express_BLL
    {
        public static bool AgregarExpress(SERVICIOS_EXPRESS express)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_INSERTAR_EXPRESS  @IDFactura,@Descripcion,@Estado";
                
                SqlParameter paramIdFactura = new SqlParameter();
                paramIdFactura.Value = express.ID_Factura;
                paramIdFactura.ParameterName = "@IDFactura";
                paramIdFactura.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramDescripcion = new SqlParameter();
                paramDescripcion.Value = express.Descripcion;
                paramDescripcion.ParameterName = "@Descripcion";
                paramDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramEstado= new SqlParameter();
                paramEstado.Value = express.Estado;
                paramEstado.ParameterName = "@Estado";
                paramEstado.SqlDbType = System.Data.SqlDbType.Int;




         
                peticion.lstParametros.Add(paramIdFactura);
                peticion.lstParametros.Add(paramDescripcion);
                peticion.lstParametros.Add(paramEstado);


                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
