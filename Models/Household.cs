using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    /// <summary>
    /// This is the Type that models a household
    /// </summary>
    public class Household
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
       /// <summary>
       /// Household Name
       /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Household Greeting
        /// </summary>
        public string Greeting { get; set; }

        /// <summary>
        /// When household was created
        /// </summary>
        public DateTime Established { get; set; }
    }
}
