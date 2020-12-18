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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public CategoriesController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Categories section in Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCategories")]
        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.GetAllCategories(_configuration);
        }
    }
}
