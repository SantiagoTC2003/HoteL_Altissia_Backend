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
    [Route("api/Reservas")]
    public class ReservaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarReserva))]
        public bool AgregarReserva(Reserva P_Reserva)
        {
            return Logica.AgregarReserva(P_Reserva);
        }

        [HttpPut]
        [Route(nameof(ModificarReserva))]
        public bool ModificarReserva([FromHeader] int P_ID_Reserva, [FromBody] Reserva P_Reserva)
        {
            return Logica.ModificarReserva(new Reserva { ID_Reserva = P_ID_Reserva, Fecha_Hora_Entrada = P_Reserva.Fecha_Hora_Entrada, Fecha_Hora_Salida = P_Reserva.Fecha_Hora_Salida, Adultos = P_Reserva.Adultos, Menores = P_Reserva.Menores, Cedula_H = P_Reserva.Cedula_H, ID_Habitacion =P_Reserva.ID_Habitacion, Precio_Habitacion = P_Reserva.Precio_Habitacion, ID_Usuario = P_Reserva.ID_Usuario });
        }

        [HttpDelete]
        [Route(nameof(EliminarReserva))]
        public bool EliminarReserva([FromHeader] int P_ID_Reserva)
        {
            return Logica.EliminarReserva(new Reserva { ID_Reserva = P_ID_Reserva });
        }

        [HttpGet]
        [Route(nameof(ConsultarReservas))]
        public List<Reserva> ConsultarReservas()
        {
            return Logica.ConsultarReservas();
        }

        [HttpGet]
        [Route(nameof(ConsultarReservasXFiltro))]
        public List<Reserva> ConsultarReservasXFiltro([FromHeader] int P_ID_Reserva)
        {
            return Logica.ConsultarReservasXFiltro(new Reserva { ID_Reserva = P_ID_Reserva });
        }

    }
}
