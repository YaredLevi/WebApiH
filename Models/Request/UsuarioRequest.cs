using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiH.Models.Request
{
    public class UsuarioRequest
    {
        public int idusuario { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int saldo { get; set; }
        public bool estado { get; set; }
    }
}