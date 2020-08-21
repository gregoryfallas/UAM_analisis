using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entidades
{
    public class Formato
    {
        public string Texto { get; set; }
        public string PatronValidacion { get; set; }

        public Formato()
        {
            Texto = string.Empty;
            PatronValidacion = string.Empty;
        }
    }
}
