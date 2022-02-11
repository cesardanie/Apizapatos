using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiZapatosone.Models.Response
{
    public class PopularProducto
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }

        public List<Producto> Productoszap { get; set; }
    }
}
