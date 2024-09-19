using System.Collections.Generic;

namespace Entidades.Entidades_SQL
{
    public class Habitacion
    {

        #region Atributos

        public short ID_Habitacion { get; set; }
        public string Tipo { get; set; }
        public short Capacidad { get; set; }
        public string Estado { get; set; }

        #endregion

        #region Constructor

        public Habitacion()
        {
            ID_Habitacion = 0;
            Tipo = string.Empty;
            Capacidad = 0;
            Estado = string.Empty;
        }

        #endregion

    }
}
