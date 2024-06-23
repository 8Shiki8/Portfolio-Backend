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
    public class JuegoController : ControllerBase
    {
        IJuegoService service;
        public JuegoController(IJuegoService context)
        {
            service = context;
        }

        [HttpPost]
        public IActionResult AddJuego(JuegoDTO juegoDto)
        {
            try
            {
                return new JsonResult(service.AddJuego(juegoDto)) { StatusCode = 201 };

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("All")]
        public IActionResult GetAllJuegos()
        {
            try
            {
                return new JsonResult(service.GetAllJuego()) { StatusCode = 200 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetJuegoById(int id)
        {
            try
            {
                return new JsonResult(service.GetJuegoById(id)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
}
}
