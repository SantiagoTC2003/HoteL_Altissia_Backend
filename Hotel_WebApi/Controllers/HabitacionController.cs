using Entidades.Entidades_SQL;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Collections.Generic;

namespace Hotel_WebApi.Controllers
{
    [ApiController]
    [Route("api/Habitaciones")]
    public class HabitacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarHabitacion))]
        public bool AgregarHabitacion(Habitacion P_Habitacion)
        {
            return Logica.AgregarHabitacion(P_Habitacion);
        }

        [HttpPut]
        [Route(nameof(ModificarHabitacion))]
        public bool ModificarHabitacion([FromHeader] short P_ID_Habitacion ,[FromBody] Habitacion P_Habitacion)
        {
            return Logica.ModificarHabitacion(new Habitacion { ID_Habitacion = P_ID_Habitacion, Tipo = P_Habitacion.Tipo, Capacidad = P_Habitacion.Capacidad, Estado = P_Habitacion.Estado});
        }

        [HttpDelete]
        [Route(nameof(EliminarHabitacion))]
        public bool EliminarHabitacion([FromHeader] short P_ID_Habitacion)
        {
            return Logica.EliminarHabitacion(new Habitacion { ID_Habitacion = P_ID_Habitacion });
        }

        [HttpGet]
        [Route(nameof(ConsultarHabitaciones))]
        public List<Habitacion> ConsultarHabitaciones()
        {
            return Logica.ConsultarHabitaciones();
        }

        [HttpGet]
        [Route(nameof(ConsultarHabitacionesXFiltro))]
        public List<Habitacion> ConsultarHabitacionesXFiltro([FromHeader] short P_ID_Habitacion)
        {
            return Logica.ConsultarHabitacionesXFiltro(new Habitacion { ID_Habitacion = P_ID_Habitacion });
        }

    }
}
