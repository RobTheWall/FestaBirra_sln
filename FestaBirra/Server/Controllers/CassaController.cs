using FestaBirra.Server.Interface;
using FestaBirra.Server.Models;
using FestaBirra.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestaBirra.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api")]
    public class CassaController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<CassaController> _logger;
        private readonly IIPortate _IIPortate;
        private readonly CassaContext _context;

        public CassaController(ILogger<CassaController> logger, IIPortate IIPortate, CassaContext context)
        {
            _logger = logger;
            _IIPortate = IIPortate;
            _context = context;
        }
        [HttpGet("portate")]
        public async Task<ActionResult<IEnumerable<Portate>>> GetPortates()
        {
            try
            {
                return await _IIPortate.GetPortateList ();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
    }
}
