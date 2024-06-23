using _2Domain.DTOs;
using _2Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0GameStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
         IUsuarioService service;

        public UsuarioController(IUsuarioService context)
        {
            service = context;
        }
        [HttpPost]
        public IActionResult AddUsuario(UsuarioDTO usuarioDto)
        {
            try
            {
                return new JsonResult(service.AddUsuario(usuarioDto)) { StatusCode = 201 };
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("AllUsuarios")]
        public IActionResult AllUsuarios()
        {
            try 
            {
                return new JsonResult(service.GetAllUsuario()) { StatusCode = 200 } ;
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult JuegoById(int id)
        {
            try 
            {
                return new JsonResult(service.GetUsuarioById(id)) {StatusCode=200 };
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("NAD")]
        public IActionResult Especial([FromQuery] string nombre, [FromQuery] string apellido, [FromQuery] string dni)
        {

            try 
            {
                return new JsonResult(service.GetEspecial(nombre, apellido, dni)){ StatusCode = 200 };
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("carrito/{id}")]
        public IActionResult CarritoUsuario(int id) 
        {
            try 
            {
                return new JsonResult(service.GetCarritoUsuario(id)) {StatusCode=200 };
            }      
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }

}
}
