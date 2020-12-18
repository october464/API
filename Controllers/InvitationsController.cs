using System.Collections.Generic;
using DragonFin_API.Models;
using Finportal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DragonFin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public InvitationsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Invitations section in Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllInvitations")]
        public IEnumerable<Invitation> GetInvitations()
        {
            return _dbContext.GetAllInvitations(_configuration);
        }
    }
}
