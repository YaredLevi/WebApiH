using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiH.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(Models.Request.UsuarioRequest usuarioRequest)
        {
            using (Models.mobikeEntities db = new Models.mobikeEntities())
            {

                var oUsuario = new Models.usuario();

                oUsuario.nombre = usuarioRequest.nombre;
                oUsuario.apellido = usuarioRequest.apellido;
                oUsuario.rut = usuarioRequest.rut;
                oUsuario.saldo = usuarioRequest.saldo;
                oUsuario.estado = usuarioRequest.estado;

                db.usuario.Add(oUsuario);
                db.SaveChanges();

            }

            return Ok("ok");
        }
    }
}
