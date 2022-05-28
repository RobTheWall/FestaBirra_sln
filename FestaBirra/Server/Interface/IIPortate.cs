using FestaBirra.Server.Data;
using FestaBirra.Server.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace FestaBirra.Server.Interface
{
    public interface IIPortate
    {
        public Task<List<Portate>> GetPortateList();

    }
    public class PortateService : IIPortate
    {
        private readonly ILogger<PortateService> _logger;
        private readonly CassaContext _dbContext;

        public PortateService(CassaContext dbContext, ILogger<PortateService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<List<Portate>> GetPortateList()
        {
            try
            {
                return _dbContext.Portates.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
