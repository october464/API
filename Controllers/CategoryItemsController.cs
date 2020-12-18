using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public CategoryItemsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Category Items section in Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCategoryItems")]
        public IEnumerable<CategoryItem> GetCategoryItems()
        {
            return _dbContext.GetAllCategoryItems(_configuration);
        }
    }
}
