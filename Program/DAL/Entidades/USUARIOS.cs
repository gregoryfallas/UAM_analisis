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
    
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.USUARIO_ROL = new HashSet<USUARIO_ROL>();
        }
    
        public int ID_Usuario { get; set; }
        public int ID_Personal { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public System.DateTime Created_at { get; set; }
        public string Last_Login { get; set; }
        public int Estado { get; set; }
    
        public virtual ESTADOS ESTADOS { get; set; }
        public virtual PERSONAL PERSONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_ROL> USUARIO_ROL { get; set; }
    }
}