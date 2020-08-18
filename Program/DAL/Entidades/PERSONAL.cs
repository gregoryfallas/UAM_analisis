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
    
    public partial class PERSONAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONAL()
        {
            this.CAJAS = new HashSet<CAJAS>();
            this.CONSULTORIO = new HashSet<CONSULTORIO>();
            this.MARCAS = new HashSet<MARCAS>();
            this.NOMINA_PERSONAL = new HashSet<NOMINA_PERSONAL>();
            this.USUARIOS = new HashSet<USUARIOS>();
            this.VACACIONES = new HashSet<VACACIONES>();
        }
    
        public int ID_Personal { get; set; }
        public Nullable<int> ID_Puesto { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido_1 { get; set; }
        public string Apellido_2 { get; set; }
        public Nullable<decimal> Salario_Hora { get; set; }
        public Nullable<decimal> Salario_Mensual { get; set; }
        public Nullable<System.DateTime> Fecha_Contratacion { get; set; }
        public System.DateTime created_at { get; set; }
        public int Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJAS> CAJAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSULTORIO> CONSULTORIO { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MARCAS> MARCAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOMINA_PERSONAL> NOMINA_PERSONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VACACIONES> VACACIONES { get; set; }
        public virtual PUESTOS PUESTOS { get; set; }
    }
}