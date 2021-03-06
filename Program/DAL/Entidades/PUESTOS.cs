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
    
    public partial class PUESTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PUESTOS()
        {
            this.PERSONAL = new HashSet<PERSONAL>();
            this.REQUISITOS_PUESTO = new HashSet<REQUISITOS_PUESTO>();
        }
    
        public int ID_Puestos { get; set; }
        public int ID_Departamento { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Salario_Base { get; set; }
        public string Descripcion { get; set; }
    
        public virtual DEPARTAMENTOS DEPARTAMENTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONAL> PERSONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISITOS_PUESTO> REQUISITOS_PUESTO { get; set; }
    }
}
