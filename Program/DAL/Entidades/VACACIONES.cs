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
    
    public partial class VACACIONES
    {
        public int ID_Vacaciones { get; set; }
        public int ID_Personal { get; set; }
        public decimal Cantidad { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    
        public virtual PERSONAL PERSONAL { get; set; }
    }
}
