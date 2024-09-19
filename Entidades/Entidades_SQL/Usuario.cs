using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Entidades_SQL
{
    public class Usuario
    {

        #region Atributos

        public int ID_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo_Usuario { get; set; }
        public string Rango { get; set; }
        public string Comentarios { get; set; }

        #endregion

        #region Constructor

        public Usuario()
        {
            ID_Usuario = 0;
            Nombre_Usuario = string.Empty;
            Contraseña = string.Empty;
            Correo_Usuario = string.Empty;
            Rango = string.Empty;
            Comentarios = string.Empty;
        }

        #endregion

    }

}
