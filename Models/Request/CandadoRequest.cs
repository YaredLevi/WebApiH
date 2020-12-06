using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiH.Models.Request
{
    public class CandadoRequest
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