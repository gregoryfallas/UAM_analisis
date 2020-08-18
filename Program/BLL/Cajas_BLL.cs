using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entidades;

namespace BLL
{
    public class Cajas_BLL
    {
        public void Cajas(ref DA Obj_DAL)
        {

            if (Obj_DAL.IPrueba == 1)
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
