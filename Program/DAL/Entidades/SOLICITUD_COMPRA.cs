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
    
    public partial class SOLICITUD_COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOLICITUD_COMPRA()
        {
            this.FACTURA_COMPRA = new HashSet<FACTURA_COMPRA>();
            this.SOLICITUD_ARTICULOS = new HashSet<SOLICITUD_ARTICULOS>();
        }
    
        public int ID_Solicitud_Compra { get; set; }
        public string Encabezado { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public string Nombre { get; set; }
    
        public virtual ESTADOS ESTADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_COMPRA> FACTURA_COMPRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD_ARTICULOS> SOLICITUD_ARTICULOS { get; set; }
    }
}
