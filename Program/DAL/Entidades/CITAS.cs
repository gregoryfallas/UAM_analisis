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
    
    public partial class CITAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CITAS()
        {
            this.DETALLE_SERVICIO = new HashSet<DETALLE_SERVICIO>();
            this.OBSERVACIONES = new HashSet<OBSERVACIONES>();
            this.RECETAS = new HashSet<RECETAS>();
            this.RESULTADO_LABORATORIO = new HashSet<RESULTADO_LABORATORIO>();
        }
    
        public int ID_Cita { get; set; }
        public int ID_Mascota { get; set; }
        public string Nombre_Mascota { get; set; }
        public int ID_Consultorio { get; set; }
        public int ID_Motivo_Cita { get; set; }
        public string Motivo_Cita { get; set; }
        public System.DateTime Fecha_Inicio { get; set; }
        public System.DateTime Fecha_Fin { get; set; }
        public System.TimeSpan Hora_Inicio { get; set; }
        public System.TimeSpan Hora_Fin { get; set; }
        public int ID_Estado { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_SERVICIO> DETALLE_SERVICIO { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBSERVACIONES> OBSERVACIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETAS> RECETAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTADO_LABORATORIO> RESULTADO_LABORATORIO { get; set; }
        public virtual CONSULTORIO CONSULTORIO { get; set; }
        public virtual MASCOTAS MASCOTAS { get; set; }
        public virtual MOTIVO_CITA MOTIVO_CITA { get; set; }
    }
}
