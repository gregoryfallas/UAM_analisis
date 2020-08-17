using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entidades;
using System.Data.SqlClient;

namespace BLL
{
    public class Credito_BLL
    {

        DA Obj_Dal = new DA();

        public static bool ModificaCreditos(CLIENTES cliente)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"SP_MODIFICAR_CREDITOS @Cedula,@Credito";
                SqlParameter paramCedula = new SqlParameter();
                paramCedula.Value = cliente.Cedula;
                paramCedula.ParameterName = "@Cedula";
                paramCedula.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramCredito = new SqlParameter();
                paramCredito.Value = cliente.Credito;
                paramCredito.ParameterName = "@Credito";
                paramCredito.SqlDbType = System.Data.SqlDbType.Int;

                

                peticion.lstParametros.Add(paramCedula);
                peticion.lstParametros.Add(paramCredito);
                
                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public static bool AgregarCreditos(CREDITOS creditos)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC SP_INSERTAR_CREDITOS  @IDFactura,@MontoAnterior,@MontoActual";

                SqlParameter paramIdFactura = new SqlParameter();
                paramIdFactura.Value = creditos.ID_Factura;
                paramIdFactura.ParameterName = "@IDFactura";
                paramIdFactura.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramMontoAnterior = new SqlParameter();
                paramMontoAnterior.Value = creditos.Monto_Anterior;
                paramMontoAnterior.ParameterName = "@MontoAnterior";
                paramMontoAnterior.SqlDbType = System.Data.SqlDbType.Decimal;

                SqlParameter paramMontoActual = new SqlParameter();
                paramMontoActual.Value = creditos.Monto_Actual;
                paramMontoActual.ParameterName = "@MontoActual";
                paramMontoActual.SqlDbType = System.Data.SqlDbType.Decimal;





                peticion.lstParametros.Add(paramIdFactura);
                peticion.lstParametros.Add(paramMontoAnterior);
                peticion.lstParametros.Add(paramMontoActual);


                DA acceso = new DA();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static bool ModificarAbonos(CREDITOS creditos)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC MODIFICAR_ABONOS  @IDFactura,@MontoAnterior,@Abono,@MontoActual";

                SqlParameter paramIdFactura = new SqlParameter();
                paramIdFactura.Value = creditos.ID_Factura;
                paramIdFactura.ParameterName = "@IDFactura";
                paramIdFactura.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter paramMontoAnterior = new SqlParameter();
                paramMontoAnterior.Value = creditos.Monto_Anterior;
                paramMontoAnterior.ParameterName = "@MontoAnterior";
                paramMontoAnterior.SqlDbType = System.Data.SqlDbType.Decimal;


                SqlParameter paramAbono = new SqlParameter();
                paramAbono.Value = creditos.Abono;
                paramAbono.ParameterName = "@Abono";
                paramAbono.SqlDbType = System.Data.SqlDbType.Decimal;


                SqlParameter paramMontoActual = new SqlParameter();
                paramMontoActual.Value = creditos.Monto_Actual;
                paramMontoActual.ParameterName = "@MontoActual";
                paramMontoActual.SqlDbType = System.Data.SqlDbType.Decimal;





                peticion.lstParametros.Add(paramIdFactura);
                peticion.lstParametros.Add(paramMontoAnterior);
                peticion.lstParametros.Add(paramAbono);
                peticion.lstParametros.Add(paramMontoActual);


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
