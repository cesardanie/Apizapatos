using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiZapatosone.Models.Response;
using ApiZapatosone.Models;

namespace ApiZapatosone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuarios : ControllerBase
    {
        [HttpPost]
        public IActionResult PostValidacionUsuario(Usuario modelUsuer)
        {
            RespuestaUsuario valit = new RespuestaUsuario();
            try {

                using (TiendaZapatillasContext db= new TiendaZapatillasContext())
                {
                    var lst = db.Usuarios.ToList();
                    foreach (var vp in lst)
                    {
                        if ((vp.Correo == modelUsuer.Correo) && (vp.Contraseña == modelUsuer.Contraseña))
                        {
                           if(vp.Rol== "Administrador")
                            {
                                valit.TipodeRolAutenticado = "Administrador";
                                valit.Validacion = true;
                                return Ok(valit);
                            }
                            if (vp.Rol == "Comprador")
                            {
                                valit.TipodeRolAutenticado = "Comprador";
                                valit.Validacion = true;
                                return Ok(valit);
                            }


                        }
                    }

                    valit.Validacion = false;

                }

                }catch(Exception e)
                {

                    valit.Mensaje = e.Message;



            }
            return Ok(valit);
        }



    }
}
