using Finportal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    /// <summary>
    /// This model helps create a transaction show the user knows spending habits
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets the category item that the transaction was made in
        /// </summary>
        public int? CategoryItemId { get; set; }

        /// <summary>
        /// Gets the bank account associated when the transaction was made
        /// </summary>
        public int BankAccountId { get; set; }

        /// <summary>
        /// Particular user that made the transaction
        /// </summary>
        public string FPUserId { get; set; }

        /// <summary>
        /// Date that the transactions were made 
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Transaction type "Checking and Savings"  account that the users adds to the house
        /// </summary>
        public TransactionType Type { get; set; }

        /// <summary>
        /// Notes on what the user buys
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// The transactions amount (Spending amount)
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Can mark the transaction as deleted
        /// </summary>
        public bool IsDeleted { get; set; }


    }

        
}
