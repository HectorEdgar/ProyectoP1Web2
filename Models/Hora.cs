//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoP1Web2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hora()
        {
            this.HorarioGimnasio_Hora = new HashSet<HorarioGimnasio_Hora>();
        }
    
        public int IdHora { get; set; }
        public System.DateTime HoraInicio { get; set; }
        public System.DateTime HoraFin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HorarioGimnasio_Hora> HorarioGimnasio_Hora { get; set; }
    }
}
