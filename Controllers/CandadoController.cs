using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiH.Controllers
{
    public class CandadoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(Models.Request.UsuarioRequest usuarioRequest)
        {
            using (Models.mobikeEntities db = new Models.mobikeEntities())
            {

                var oUsuario = new Models.usuario();
                var oCandado = new Models.candado();


                oUsuario.nombre = usuarioRequest.nombre;
                oUsuario.apellido = usuarioRequest.apellido;
                oUsuario.rut = usuarioRequest.rut;
                oUsuario.saldo = usuarioRequest.saldo;
                oUsuario.estado = usuarioRequest.estado;
                db.usuario.Add(oUsuario);
                db.SaveChanges();
                oCandado.estado = false;
                oCandado.fecha = DateTime.Today;
                oCandado.latitud = 12;
                oCandado.longitud = 15;
                oCandado.usuario_idusuario = usuarioRequest.idusuario;
                db.candado.Add(oCandado);
                db.SaveChanges();

            }

            return Ok("ok");
        }
    }
}
