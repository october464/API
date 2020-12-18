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
    //Takes localhost:80/BankAccounts to
    //Localhost:80/api/BankAccounts
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public BankAccountsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Bank Accounts from the Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllBankAccounts")]
        public IEnumerable<BankAccount> GetBankAccounts()
        {
            return _dbContext.GetAllBankAccounts(_configuration);
        }
    }
}
