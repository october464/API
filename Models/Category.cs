using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    /// <summary>
    /// Shows the Category that the user wants to set up a budget for
    /// </summary>
    public class Category
    {/// <summary>
    /// Primary Key
    /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Shows what Category belongs to a household
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Shows the Category Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Shows the description for the category a person creates
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Able to get from household model
        /// </summary>
        public virtual Household Household { get; set; }

        /// <summary>
        /// Able to get from transactions model
        /// </summary>
        public virtual ICollection<Transaction> Transactions { get; set; }


        /// <summary>
        /// Able to get from category items model
        /// </summary>
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        /// <summary>
        /// Constructor for transactions and category items
        /// </summary>
        public Category()
        {
            Transactions = new HashSet<Transaction>();
            CategoryItems = new HashSet<CategoryItem>();
        }
    }
}
