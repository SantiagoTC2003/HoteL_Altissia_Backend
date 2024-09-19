using System.Collections.Generic;

namespace Entidades.Entidades_SQL
{
    public class Huesped
    {

        #region Atributos

        public string Nombre_H { get; set; }
        public string Cedula_H { get; set; }
        public string Telefono_H { get; set; }
        public string Correo_H { get; set; }

        #endregion

        #region Constructor

        public Huesped()
        {
            Nombre_H = string.Empty;
            Cedula_H = string.Empty;
            Telefono_H = string.Empty;
            Correo_H = string.Empty;
        }

        #endregion

    }
}
