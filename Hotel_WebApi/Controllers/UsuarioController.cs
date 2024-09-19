using Entidades.Entidades_SQL;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_WebApi.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarUsuario))]
        public bool AgregarUsuario(Usuario P_Usuario)
        {
            return Logica.AgregarUsuario(P_Usuario);
        }

        [HttpPut]
        [Route(nameof(ModificarUsuario))]
        public bool ModificarUsuario([FromHeader] int P_ID_Usuario, [FromBody] Usuario P_Usuario)
        {
            return Logica.ModificarUsuario(new Usuario { ID_Usuario = P_ID_Usuario, Nombre_Usuario = P_Usuario.Nombre_Usuario, Contraseña = P_Usuario.Contraseña, Correo_Usuario = P_Usuario.Correo_Usuario, Rango = P_Usuario.Rango, Comentarios = P_Usuario.Comentarios });
        }

        [HttpDelete]
        [Route(nameof(EliminarUsuario))]
        public bool EliminarUsuario([FromHeader] int P_ID_Usuario)
        {
            return Logica.EliminarUsuario(new Usuario { ID_Usuario = P_ID_Usuario });
        }

        [HttpGet]
        [Route(nameof(ConsultarUsuarios))]
        public List<Usuario> ConsultarUsuarios()
        {
            return Logica.ConsultarUsuarios();
        }

        [HttpGet]
        [Route(nameof(ConsultarUsuariosXFiltro))]
        public List<Usuario> ConsultarUsuariosXFiltro([FromHeader] int P_ID_Usuario)
        {
            return Logica.ConsultarUsuariosXFiltro(new Usuario { ID_Usuario = P_ID_Usuario });
        }

    }
}
