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
    
    public partial class Asistencia
    {
        public System.DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int idAsistencia { get; set; }
        public int idAlumnos_GrupoGimnasio { get; set; }
    
        public virtual Alumnos_GrupoGimnasio Alumnos_GrupoGimnasio { get; set; }
    }
}
