using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiZapatosone.Models.Request
{
    public class ProductoRequest
    {
        public long Id { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
    }
}
