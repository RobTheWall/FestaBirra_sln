using FestaBirra.Server.Data;
using FestaBirra.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestaBirra.Server.Controllers
{
    
    [ApiController]
    [Route("api")]
    public class CassaController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<CassaController> _logger;
       
        private readonly CassaContext _context;

        public CassaController(ILogger<CassaController> logger, CassaContext context)
        {
            _logger = logger;            
            _context = context;
        }
        [HttpGet("portate")]
        public async Task<ActionResult<IEnumerable<Portate>>> GetPortates()
        {
            try
            {
                return await _context.Portates.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost("venditedettagli")]
        public async Task<ActionResult<VenditeDettagli>> AddPortata(VenditeDettagli _vendita)
        {
            try
            {
                throw new Exception();
                //return await _context.VenditeDettaglis.AddAsync(_vendita);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
    }
}
