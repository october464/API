using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DragonFin_API.Models;
using Finportal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DragonFin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseholdsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public HouseholdsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Household from the Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllHouseholds")]
        public IEnumerable<Household> GetHouseholds()
        {
            return _dbContext.GetAllHouseholds(_configuration);
        }
    }
}
