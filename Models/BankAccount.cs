using Finportal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

   
namespace DragonFin_API.Models
{
    /// <summary>
    /// The Bank Account of the house holds that the users create
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Shows what Bank Account belongs to the House Hold
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// This gives the Id of the associated user who is logged in
        /// </summary>
        public string FPUserId { get; set; }

        /// <summary>
        /// This gives the name of the Bank Account 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This shows which type of Bank Account the user select "Checking or Savings" 
        /// </summary>
        public AccountType Type { get; set; }

        /// <summary>
        /// This gives the Starting Balance that the user enters when creating a Bank Account 
        /// </summary>
        public decimal StartingBalance { get; set; }


        /// <summary>
        /// This gives the Current Balance  before and after transactions are made in the Bank Account
        /// </summary>
        public decimal CurrentBalance { get; set; }
    }
}
