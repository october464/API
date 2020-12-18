using System.Collections.Generic;
using DragonFin_API.Models;
using Finportal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DragonFin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public UsersController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Users section in Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllUsers")]
        public IEnumerable<FPUser> GetUsers()
        {
            return _dbContext.GetAllUsers(_configuration);
        }
    }
}
