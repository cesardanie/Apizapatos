using System;
using System.Collections.Generic;

#nullable disable

namespace ApiZapatosone.Models
{
    public partial class Usuario
    {
        public long Id { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
    }
}
