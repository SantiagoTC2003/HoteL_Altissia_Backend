using System;

namespace Entidades.Entidades_SQL
{
    public class Reserva
    {

        #region Atributos

        public int ID_Reserva { get; set; }
        public DateTime Fecha_Hora_Entrada { get; set; }
        public DateTime Fecha_Hora_Salida { get; set; }
        public short Adultos { get; set; }
        public short Menores { get; set; }
        public string Cedula_H { get; set; }
        public short ID_Habitacion { get; set; }
        public double Precio_Habitacion { get; set; }
        public int ID_Usuario { get; set; }

        #endregion

        #region Constructor

        public Reserva()
        {
            ID_Reserva = 0;
            Fecha_Hora_Entrada = DateTime.Now;
            Fecha_Hora_Salida = DateTime.Now;
            Adultos = 0;
            Menores = 0;
            Cedula_H = string.Empty;
            ID_Habitacion = 0;
            Precio_Habitacion = 0;
            ID_Usuario = 0;
        }

        #endregion

    }

}
