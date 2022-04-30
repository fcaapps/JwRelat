using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWRELAT.API.Data;
using JWRELAT.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JWRELAT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicadoresController : ControllerBase
    {
        private readonly DataContext _context;
        
        public PublicadoresController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Publicador> Get()
        {
            return _context.Publicadores;
        }

        [HttpGet("{id}")]
        public IEnumerable<Publicador> GetById(int id)
        {
            return _context.Publicadores.Where(publicador => publicador.PublicadorId == id);
        }

    }
}
