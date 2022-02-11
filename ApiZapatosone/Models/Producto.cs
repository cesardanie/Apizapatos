using System;
using System.Collections.Generic;

#nullable disable

namespace ApiZapatosone.Models
{
    public partial class Producto
    {
        public long Id { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
    }
}
