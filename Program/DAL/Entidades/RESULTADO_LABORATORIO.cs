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
    
    public partial class RESULTADO_LABORATORIO
    {
        public int ID_Resultado_Laboratorio { get; set; }
        public int ID_Pruebas_Laboratorio { get; set; }
        public int ID_Cita { get; set; }
        public string Resultado { get; set; }
        public Nullable<int> Estado { get; set; }
        public System.DateTime CreateAt { get; set; }
    
        public virtual CITAS CITAS { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
        public virtual PRUEBAS_LABORATORIO PRUEBAS_LABORATORIO { get; set; }
    }
}