using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entidades
{
   public class Constantes
    {
        public const string PatronID = "^[0-9]{9,10}$";
        public const string PatronNOMBRE = "^[A-Za-z ]*$";
        public const string PatronEDAD = "^[0-9]+$";
        public const string PatronFECHA = "^[0-9]{2,2}/[0-9]{2,2}/[0-9]{2,4}$";
        public const string PatronCORREO = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";

    }
}
