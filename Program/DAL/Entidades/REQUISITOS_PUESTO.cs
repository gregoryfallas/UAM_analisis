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
    
    public partial class REQUISITOS_PUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REQUISITOS_PUESTO()
        {
            this.REQUISITOS_PARTICIPANTES = new HashSet<REQUISITOS_PARTICIPANTES>();
        }
    
        public int ID_Requisitos { get; set; }
        public int ID_Puestos { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    
        public virtual PUESTOS PUESTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISITOS_PARTICIPANTES> REQUISITOS_PARTICIPANTES { get; set; }
    }
}
