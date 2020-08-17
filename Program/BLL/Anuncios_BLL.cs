using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;

namespace BLL
{
    public class Anuncios_BLL
    {
        public static DataTable consultarAnuncios()
        {
            return null;
        }

        public static bool agregarAnuncios(ANUNCIOS anuncios)
        {
            return true;
        }

        public static bool modificarAnuncios(ANUNCIOS anuncios)
        {
            return true;
        }

        public static bool eliminarAnuncios(int id)
        {
            return true;
        }
    }
}
