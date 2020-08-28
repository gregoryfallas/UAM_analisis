using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entidades;

namespace BLL
{
    public class Anuncios_BLL
    {
        public static List<ANUNCIOS> consultar_anuncios()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_consultar_anuncios";

                DA acceso = new DA();
                return acceso.consultar_anuncios(sentencia);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static List<ANUNCIOS> agregar_anuncios()
        {
                try
                {
                    SQLSentencia sentencia = new SQLSentencia();
                    sentencia.Peticion = @"EXEC sp_agregar_anuncios";

                    DA acceso = new DA();
                    return acceso.agregar_anuncios(sentencia);

                }
                catch (Exception e)

                {
                    throw e;
                }

        }

        public static List<ANUNCIOS> actualizar_anuncios(ANUNCIOS anuncios)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_actualizar_anuncios";

                DA acceso = new DA();
                return acceso.actualizar_anuncios(sentencia);
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        public static List<ANUNCIOS> eliminar_anuncios(int id)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC sp_eliminar_anuncios";

                DA acceso = new DA();
                return acceso.eliminar_anuncios(sentencia);
            }
            catch (Exception e)

            {
                throw e;
            }

        }
    }
}
