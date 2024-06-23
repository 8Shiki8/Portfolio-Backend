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
    public class CategoriaController : ControllerBase
    {
    private readonly ICategoriaService service;
    public CategoriaController(ICategoriaService context)
    {
        service = context;
    }
    [HttpPost]
        public IActionResult AddCategoria(CategoriaDTO categoriaDto)
        {
        try 
        {
            return new JsonResult(service.AddCategoria(categoriaDto)) { StatusCode = 200 };
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        }
        [HttpGet]
        public IActionResult GetAllCategoria()
        {
            try
            {
                return new JsonResult(service.GetAllCategoria()) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
