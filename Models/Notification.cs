using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    /// <summary>
    /// Notifications that the user will receive about overdraft
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The house hold that the notification is a part of 
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Date the the notification was created 
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Subject of the notifications
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Body of the notification
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Notification shows if it was read or not
        /// </summary>
        public bool IsRead { get; set; }

   

    }
}
