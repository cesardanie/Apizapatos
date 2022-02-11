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
    public class HistoryProducts : ControllerBase
    {
        [HttpPost]
        public IActionResult Historico(HistoricoRequest History)
        {
            int NuevoNumero = Int32.Parse(History.Id);
            long Newnumber = NuevoNumero;
            RespuestaHistorico resp = new RespuestaHistorico();
            try
            {
                using (TiendaZapatillasContext db = new TiendaZapatillasContext())
                {
                    Historicodeproducto Historyid = new Historicodeproducto();
                    Historyid.IdProductomascomprado = NuevoNumero;
                    db.Historicodeproductos.Add(Historyid);
                    db.SaveChanges();
                    resp.Estado = true;
                    return Ok(resp);

                }


            }
            catch(Exception ex)
            {
                resp.Mensaje = ex.Message;
                resp.Estado = false;
            }

            return Ok(resp);

        }
        [HttpGet]
        public IActionResult Productomaspopular()
        {
            PopularProducto productomascomprado = new PopularProducto();
            try {
                using (TiendaZapatillasContext db = new TiendaZapatillasContext())
                {
                    
                    var lst1 = db.Historicodeproductos.ToList();
                   

                }
            
            }catch(Exception e)
            {
                productomascomprado.Mensaje = e.Message;
                productomascomprado.Exito = false;

            }
            return Ok(productomascomprado);

        }
    }
}
