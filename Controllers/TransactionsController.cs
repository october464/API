﻿using System.Collections.Generic;
using API.Models;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public TransactionsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// Retrieves all the records from the Transactions section in Postgress DB
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllTransactions")]
        public IEnumerable<Transaction> GetTransactions()
        {
            return _dbContext.GetAllTransactions(_configuration);
        }
    }
}
