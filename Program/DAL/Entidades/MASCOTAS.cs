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
    
    public partial class MASCOTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MASCOTAS()
        {
   //         this.CITAS = new HashSet<CITAS>();
        }
        
        public int ID_Mascota { get; set; }
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public int Tipo_Animal { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<decimal> Peso { get; set; }
        public Nullable<decimal> Tamaño { get; set; }
        public int Estado { get; set; }
        public string Nombre_Cliente { get; set; }
    
    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
   //     public virtual ICollection<CITAS> CITAS { get; set; }
   //     public virtual CLIENTES CLIENTES { get; set; }
       // public virtual ESTADOS ESTADOS { get; set; }
       }

    }

