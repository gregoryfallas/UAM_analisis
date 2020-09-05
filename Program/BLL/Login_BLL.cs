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
    public class Login_BLL
    {
        public List<USUARIOS> ConsultaUsuarios()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_consulta_usuarios";
                SqlParameter paramC = new SqlParameter();
                DA acceso = new DA();
                return acceso.ConsultaUsuarios(sentencia);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public USUARIOS Validar_Usuario (ref List<USUARIOS> list, string user, string pass)
        {
            foreach (var item in list)
            {
                if (user.Equals(item.UserName) && pass.Equals(item.Pass))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
