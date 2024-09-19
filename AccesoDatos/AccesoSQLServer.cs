using Dapper;
using Entidades.Entidades_SQL;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace AccesoDatos
{
    public class AccesoSQLServer
    {

        #region Habitacion

        public static bool AgregarHabitacion(Habitacion P_Habitacion)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Habitacion", P_Habitacion.ID_Habitacion, DbType.Int32, ParameterDirection.Input, 5);
            parametros.Add("@Tipo", P_Habitacion.Tipo, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@Capacidad", P_Habitacion.Capacidad, DbType.Int32, ParameterDirection.Input, 2);
            parametros.Add("@Estado", P_Habitacion.Estado, DbType.String, ParameterDirection.Input, 20);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_AgregarHabitacion", parametros, commandType: CommandType.StoredProcedure) > 0;
            }

        }

        public static bool ModificarHabitacion(Habitacion P_Habitacion)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Habitacion", P_Habitacion.ID_Habitacion, DbType.Int32, ParameterDirection.Input, 5);
            parametros.Add("@Tipo", P_Habitacion.Tipo, DbType.String, ParameterDirection.Input, 50);
            parametros.Add("@Capacidad", P_Habitacion.Capacidad, DbType.Int32, ParameterDirection.Input, 2);
            parametros.Add("@Estado", P_Habitacion.Estado, DbType.String, ParameterDirection.Input, 20);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_ModificarHabitacion", parametros, commandType: CommandType.StoredProcedure) > 0;
            }

        }

        public static bool EliminarHabitacion(Habitacion P_Habitacion)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Habitacion", P_Habitacion.ID_Habitacion, DbType.Int32, ParameterDirection.Input, 5);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_EliminarHabitacion", parametros, commandType: CommandType.StoredProcedure) > 0;
            }

        }

        public static List<Habitacion> ConsultarHabitacion()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Habitacion>)conexionSQLServer.Query<Habitacion>("PA_ConsultarHabitaciones", parametros, commandType: CommandType.StoredProcedure);
            }

        }

        public static List<Habitacion> ConsultarHabitacionesXFiltro(Habitacion P_Habitacion)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Habitacion", P_Habitacion.ID_Habitacion, DbType.Int32, ParameterDirection.Input, 5);
            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Habitacion>)conexionSQLServer.Query<Habitacion>("PA_ConsultarHabitacionesPorFiltro", parametros, commandType: CommandType.StoredProcedure);
            }

        }

        #endregion

        #region Huesped

        public static bool AgregarHuesped(Huesped P_Huesped)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_H", P_Huesped.Nombre_H, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Cedula_H", P_Huesped.Cedula_H, DbType.String, ParameterDirection.Input, 25);
            parametros.Add("@Telefono_H", P_Huesped.Telefono_H, DbType.String, ParameterDirection.Input, 15);
            parametros.Add("@Correo_H", P_Huesped.Correo_H, DbType.String, ParameterDirection.Input, 50);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_AgregarHuesped", parametros, commandType: CommandType.StoredProcedure) > 0;
            }

        }

        public static bool ModificarHuesped(Huesped P_Huesped)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre_H", P_Huesped.Nombre_H, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Cedula_H", P_Huesped.Cedula_H, DbType.String, ParameterDirection.Input, 25);
            parametros.Add("@Telefono_H", P_Huesped.Telefono_H, DbType.String, ParameterDirection.Input, 15);
            parametros.Add("@Correo_H", P_Huesped.Correo_H, DbType.String, ParameterDirection.Input, 50);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_ModificarHuesped", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarHuesped(Huesped P_Huesped)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cedula_H", P_Huesped.Cedula_H, DbType.String, ParameterDirection.Input, 25);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_EliminarHuesped", parametros, commandType: CommandType.StoredProcedure) > 0;
            }

        }

        public static List<Huesped> ConsultarHuesped()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Huesped>)conexionSQLServer.Query<Huesped>("PA_ConsultarHuespedes", parametros, commandType: CommandType.StoredProcedure);
            }

        }

        public static List<Huesped> ConsultarHuespedesXFiltro(Huesped P_Huesped)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cedula_H", P_Huesped.Cedula_H, DbType.String, ParameterDirection.Input, 25);
            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Huesped>)conexionSQLServer.Query<Huesped>("PA_ConsultarHuespedesPorFiltro", parametros, commandType: CommandType.StoredProcedure);
            }

        }

        #endregion

        #region Reserva

        public static bool AgregarReserva(Reserva P_Reserva)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Reserva", P_Reserva.ID_Reserva, DbType.Int32, ParameterDirection.Input, 10);
            parametros.Add("@Fecha_Hora_Entrada", P_Reserva.Fecha_Hora_Entrada, DbType.DateTime, ParameterDirection.Input, 30);
            parametros.Add("@Fecha_Hora_Salida", P_Reserva.Fecha_Hora_Salida, DbType.DateTime, ParameterDirection.Input, 30);
            parametros.Add("@Adultos", P_Reserva.Adultos, DbType.Int32, ParameterDirection.Input, 2);
            parametros.Add("@Menores", P_Reserva.Menores, DbType.Int32, ParameterDirection.Input, 2);
            parametros.Add("@Cedula_H", P_Reserva.Cedula_H, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@ID_Habitacion", P_Reserva.ID_Habitacion, DbType.Int32, ParameterDirection.Input, 5);
            parametros.Add("@Precio_Habitacion", P_Reserva.Precio_Habitacion, DbType.Double, ParameterDirection.Input, 10);
            parametros.Add("@ID_Usuario", P_Reserva.ID_Usuario, DbType.Int32, ParameterDirection.Input, 10);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_AgregarReserva", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarReserva(Reserva P_Reserva)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Reserva", P_Reserva.ID_Reserva, DbType.Int32, ParameterDirection.Input, 10);
            parametros.Add("@Fecha_Hora_Entrada", P_Reserva.Fecha_Hora_Entrada, DbType.DateTime, ParameterDirection.Input, 30);
            parametros.Add("@Fecha_Hora_Salida", P_Reserva.Fecha_Hora_Salida, DbType.DateTime, ParameterDirection.Input, 30);
            parametros.Add("@Adultos", P_Reserva.Adultos, DbType.Int32, ParameterDirection.Input, 2);
            parametros.Add("@Menores", P_Reserva.Menores, DbType.Int32, ParameterDirection.Input, 2);
            parametros.Add("@Cedula_H", P_Reserva.Cedula_H, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@ID_Habitacion", P_Reserva.ID_Habitacion, DbType.Int32, ParameterDirection.Input, 5);
            parametros.Add("@Precio_Habitacion", P_Reserva.Precio_Habitacion, DbType.Double, ParameterDirection.Input, 10);
            parametros.Add("@ID_Usuario", P_Reserva.ID_Usuario, DbType.Int32, ParameterDirection.Input, 10);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_ModificarReserva", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarReserva(Reserva P_Reserva)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Reserva", P_Reserva.ID_Reserva, DbType.Int32, ParameterDirection.Input, 10);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_EliminarReserva", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Reserva> ConsultarReservas()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Reserva>)conexionSQLServer.Query<Reserva>("PA_ConsultarReservas", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Reserva> ConsultarReservasXFiltro(Reserva P_Reserva)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Reserva", P_Reserva.ID_Reserva, DbType.Int32, ParameterDirection.Input, 10);
            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Reserva>)conexionSQLServer.Query<Reserva>("PA_ConsultarReservasPorFiltro", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

        #region Usuario

        public static bool AgregarUsuario(Usuario P_Usuario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Usuario", P_Usuario.ID_Usuario, DbType.Int32, ParameterDirection.Input, 10);
            parametros.Add("@Nombre_Usuario", P_Usuario.Nombre_Usuario, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Contraseña", P_Usuario.Contraseña, DbType.String, ParameterDirection.Input, 40);
            parametros.Add("@Correo_Usuario", P_Usuario.Correo_Usuario, DbType.String, ParameterDirection.Input, 60);
            parametros.Add("@Rango", P_Usuario.Rango, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Comentarios", P_Usuario.Comentarios, DbType.String, ParameterDirection.Input, 200);
            
            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_AgregarUsuario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool ModificarUsuario(Usuario P_Usuario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Usuario", P_Usuario.ID_Usuario, DbType.Int32, ParameterDirection.Input, 10);
            parametros.Add("@Nombre_Usuario", P_Usuario.Nombre_Usuario, DbType.String, ParameterDirection.Input, 80);
            parametros.Add("@Contraseña", P_Usuario.Contraseña, DbType.String, ParameterDirection.Input, 40);
            parametros.Add("@Correo_Usuario", P_Usuario.Correo_Usuario, DbType.String, ParameterDirection.Input, 60);
            parametros.Add("@Rango", P_Usuario.Rango, DbType.String, ParameterDirection.Input, 20);
            parametros.Add("@Comentarios", P_Usuario.Comentarios, DbType.String, ParameterDirection.Input, 200);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_ModificarUsuario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static bool EliminarUsuarios(Usuario P_Usuario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Usuario", P_Usuario.ID_Usuario, DbType.Int32, ParameterDirection.Input, 10);

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return conexionSQLServer.Execute("PA_EliminarUsuario", parametros, commandType: CommandType.StoredProcedure) > 0;
            }
        }

        public static List<Usuario> ConsultarUsuarios()
        {
            DynamicParameters parametros = new DynamicParameters();

            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Usuario>)conexionSQLServer.Query<Usuario>("PA_ConsultarUsuarios", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<Usuario> ConsultarUsuariosXFiltro(Usuario P_Usuario)
        {
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@ID_Usuario", P_Usuario.ID_Usuario, DbType.Int32, ParameterDirection.Input, 10);
            using (var conexionSQLServer = new SqlConnection(@"Data Source=???; Initial Catalog=Hotel_Altissia; Persist Security info=true; user id = ???; password = ???;TrustServerCertificate=true"))
            {
                return (List<Usuario>)conexionSQLServer.Query<Usuario>("PA_ConsultarUsuariosPorFiltro", parametros, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

    }
}
