using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class SQLParametros
    {
        #region Propiedades

        public string Peticion { get; set; }
        public List<SqlParameter> LstParametros { get; set; }

        #endregion

        #region Constructor

        public SQLParametros()
        {
            Peticion = string.Empty;
            LstParametros = new List<SqlParameter>();
        }

        #endregion
    }
}
