//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class COBROS
    {
        public int ID_Cobro { get; set; }
        public int ID_Caja { get; set; }
        public int ID_Factura { get; set; }
        public byte Metodo_Pago { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual CAJAS CAJAS { get; set; }
        public virtual FACTURAS FACTURAS { get; set; }
        public virtual METODO_PAGO METODO_PAGO1 { get; set; }
    }
}
