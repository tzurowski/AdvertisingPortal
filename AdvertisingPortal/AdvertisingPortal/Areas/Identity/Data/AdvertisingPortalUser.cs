using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AdvertisingPortal.Models;
using Microsoft.AspNetCore.Identity;

namespace AdvertisingPortal.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AdvertisingPortalUser class
    public class AdvertisingPortalUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [PersonalData]
        public ICollection<Advertisement> Advertisements { get; set; }
    }
}
