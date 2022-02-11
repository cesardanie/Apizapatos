using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiZapatosone.Models;
using ApiZapatosone.Models.Response;
using ApiZapatosone.Models.Request;

namespace ApiZapatosone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Productos : ControllerBase
    {
        [HttpPost]
        public IActionResult IngresodeProductos(ProductoRequest modelPro)
        {
            RespuestaProducto res = new RespuestaProducto();

            try {
                using (TiendaZapatillasContext db = new TiendaZapatillasContext())
                {
                    Producto prod = new Producto();
                    prod.NombreProducto = modelPro.NombreProducto;
                    prod.Precio = modelPro.Precio;
                    prod.Descripcion = modelPro.Descripcion;
                    db.Productos.Add(prod);
                    db.SaveChanges();
                    res.Estado = true;
                    return Ok(res);
                }

            
            }catch(Exception ex)
            {
                res.Mensaje = ex.Message;
                res.Estado = false;

            }
            return Ok(res);

        }
        [HttpGet]
        public IActionResult Vistadeproductos()
        {
            ProductoRespuestaok Productosok = new ProductoRespuestaok();
            try {

                using (TiendaZapatillasContext db = new TiendaZapatillasContext())
                {
                    var lst = db.Productos.ToList();
                    Productosok.Exito = true;
                    Productosok.Productoszap = lst;

                }
            
            }catch(Exception ex)
            {
                Productosok.Mensaje = ex.Message;
            }
            return Ok(Productosok);
;        }
    }
}
