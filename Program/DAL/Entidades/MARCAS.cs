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
    
    public partial class MARCAS
    {
        public int ID_Marcas { get; set; }
        public int ID_Personal { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora { get; set; }
        public Nullable<byte> Tipo { get; set; }
    
        public virtual PERSONAL PERSONAL { get; set; }
        public virtual TIPO_MARCA TIPO_MARCA { get; set; }
    }
}