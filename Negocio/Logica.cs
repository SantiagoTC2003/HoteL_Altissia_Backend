using AccesoDatos;
using Entidades;
using Entidades.Entidades_SQL;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class Logica
    {

        #region MONGODB
        public static string AgregarAccion(Bitacora P_Accion)
        {
            string resultado = "Accion registrada correctamente";

            //Regla de negocio - Verificar si el ID de la accion ya existe, en caso de ser asi indicarlo como resultado
            Bitacora encontrado = AccesoMongoDB.ConsultarAcciones(P_Accion);
            if (encontrado == null)//Si no encuentra resultados en la coleccion, significa que puede agregarse a la misma
            {
                AccesoMongoDB.AgregarAccion(P_Accion); // Se envia a registrar la accion
            }
            else resultado = "Accion a registrar con el ID de: " + P_Accion.ID + " ya existe en base de datos";
            return resultado;
        }

        public static Bitacora ConsultarAccionPorFiltro(Bitacora P_Accion)
        {
            return AccesoMongoDB.ConsultarAcciones(P_Accion);
        }

        #endregion

        #region SQL

        #region Habitacion

        public static bool AgregarHabitacion(Habitacion P_Habitacion)
        {
            return AccesoSQLServer.AgregarHabitacion(P_Habitacion);
        }

        public static bool ModificarHabitacion(Habitacion P_Habitacion)
        {
            return AccesoSQLServer.ModificarHabitacion(P_Habitacion);
        }
        public static bool EliminarHabitacion(Habitacion P_Habitacion)
        {
            return AccesoSQLServer.EliminarHabitacion(P_Habitacion);
        }
        public static List<Habitacion> ConsultarHabitaciones()
        {
            return AccesoSQLServer.ConsultarHabitacion();
        }

        public static List<Habitacion> ConsultarHabitacionesXFiltro(Habitacion P_Habitacion)
        {
            return AccesoSQLServer.ConsultarHabitacionesXFiltro(P_Habitacion);
        }

        #endregion

        #region Huesped

        public static bool AgregarHuesped(Huesped P_Huesped)
        {
            return AccesoSQLServer.AgregarHuesped(P_Huesped);
        }

        public static bool ModificarHuesped(Huesped P_Huesped)
        {
            return AccesoSQLServer.ModificarHuesped(P_Huesped);
        }
        public static bool EliminarHuesped(Huesped P_Huesped)
        {
            return AccesoSQLServer.EliminarHuesped(P_Huesped);
        }
        public static List<Huesped> ConsultarHuespedes()
        {
            return AccesoSQLServer.ConsultarHuesped();
        }

        public static List<Huesped> ConsultarHuespedesXFiltro(Huesped P_Huesped)
        {
            return AccesoSQLServer.ConsultarHuespedesXFiltro(P_Huesped);
        }

        #endregion

        #region Reserva

        public static bool AgregarReserva(Reserva P_Reserva)
        {
            return AccesoSQLServer.AgregarReserva(P_Reserva);
        }

        public static bool ModificarReserva(Reserva P_Reserva)
        {
            return AccesoSQLServer.ModificarReserva(P_Reserva);
        }
        public static bool EliminarReserva(Reserva P_Reserva)
        {
            return AccesoSQLServer.EliminarReserva(P_Reserva);
        }
        public static List<Reserva> ConsultarReservas()
        {
            return AccesoSQLServer.ConsultarReservas();
        }

        public static List<Reserva> ConsultarReservasXFiltro(Reserva P_Reserva)
        {
            return AccesoSQLServer.ConsultarReservasXFiltro(P_Reserva);
        }

        #endregion

        #region Usuario

        public static bool AgregarUsuario(Usuario P_Usuario)
        {
            return AccesoSQLServer.AgregarUsuario(P_Usuario);
        }

        public static bool ModificarUsuario(Usuario P_Usuario)
        {
            return AccesoSQLServer.ModificarUsuario(P_Usuario);
        }
        public static bool EliminarUsuario(Usuario P_Usuario)
        {
            return AccesoSQLServer.EliminarUsuarios(P_Usuario);
        }
        public static List<Usuario> ConsultarUsuarios()
        {
            return AccesoSQLServer.ConsultarUsuarios();
        }

        public static List<Usuario> ConsultarUsuariosXFiltro(Usuario P_Usuario)
        {
            return AccesoSQLServer.ConsultarUsuariosXFiltro(P_Usuario);
        }

        #endregion

        #endregion

    }
}
