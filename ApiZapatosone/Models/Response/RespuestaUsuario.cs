using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiZapatosone.Models.Response
{
    public class RespuestaUsuario
    {
        public bool Validacion { get; set; }
        public string Mensaje { get; set; }
        public string TipodeRolAutenticado { get; set; }
    }
}
