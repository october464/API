using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{/// <summary>
/// Responsable for Housing category items
/// </summary>
    public class CategoryItem
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Shows what Category belongs to which house hold
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// This gives the name of the Category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of category Item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Amount that the user starts with for the item
        /// </summary>
        public decimal TargetAmount { get; set; }

        /// <summary>
        /// Amount that is the users actual amount that they are left with
        public decimal ActualAmount { get; set; }
        
    }
}
