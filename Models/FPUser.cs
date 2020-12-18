using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    /// <summary>
    /// User that is logged in
    /// </summary>
    public class FPUser : IdentityUser
    {
         /// <summary>
         /// First Name of the user who is logged in
         /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the user who is logged in
        /// </summary>
        public string LastName { get; set; }

    

        /// <summary>
        /// service for avatar
        /// </summary>
        public IFormFile FormFile { get; set; }

        /// <summary>
        /// Name for the image file
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Data of the file that is loaded into the application
        /// </summary>
        public byte[] FileData { get; set; }

        /// <summary>
        /// The house hold Id that is associated with the users whow are logged in
        /// </summary>
        public int? HouseholdId { get; set; }

    }
}
