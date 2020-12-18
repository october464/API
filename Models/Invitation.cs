using Finportal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{

    /// <summary>
    /// The Model responsable for creating an invitation to allow someone to join a house hold
    /// </summary>
    public class Invitation
    {

        /// <summary>
        /// Primary key 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The house hold associated with the invitations sent
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Date the invitation was created
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Date the the user is able to set before the user can no longer accept the invite to the house hold
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// Shows if the person that was invited accepted the invite to the house hold
        /// </summary>
        public bool Accepted { get; set; }

        /// <summary>
        /// Tells if the invite is valid
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// The email that the invite will be set to
        /// </summary>
        public string EmailTo { get; set; }

        /// <summary>
        /// Preview about the email sent
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Where the sender tells the recipient what the email is about
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Role that each user is asigned 
        /// </summary>
        public PortalRole RoleName { get; set; }

        /// <summary>
        /// Guid that is sent with the invite for that particular person
        /// </summary>
        public Guid Code { get; set; }//check this whole class

    
    }
}
