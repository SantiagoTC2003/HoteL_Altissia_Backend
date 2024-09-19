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
    [Route("api/Huespedes")]
    public class HuespedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarHuesped))]
        public bool AgregarHuesped(Huesped P_Huesped)
        {
            return Logica.AgregarHuesped(P_Huesped);
        }

        [HttpPut]
        [Route(nameof(ModificarHuesped))]
        public bool ModificarHuesped([FromHeader] string P_Cedula, [FromBody] Huesped P_Huesped)
        {
            return Logica.ModificarHuesped(new Huesped { Cedula_H = P_Cedula, Nombre_H = P_Huesped.Nombre_H, Correo_H = P_Huesped.Correo_H, Telefono_H = P_Huesped.Telefono_H });
        }

        [HttpDelete]
        [Route(nameof(EliminarHuesped))]
        public bool EliminarHuesped([FromHeader] string P_Cedula)
        {
            return Logica.EliminarHuesped(new Huesped { Cedula_H = P_Cedula });
        }

        [HttpGet]
        [Route(nameof(ConsultarHuespedes))]
        public List<Huesped> ConsultarHuespedes()
        {
            return Logica.ConsultarHuespedes();
        }

        [HttpGet]
        [Route(nameof(ConsultarHuespedesXFiltro))]
        public List<Huesped> ConsultarHuespedesXFiltro([FromHeader] string P_Cedula)
        {
            return Logica.ConsultarHuespedesXFiltro(new Huesped { Cedula_H = P_Cedula });
        }

    }
}
