//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class candado
    {
        public int idcandado { get; set; }
        public double latitud { get; set; }
        public int longitud { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> usuario_idusuario { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
