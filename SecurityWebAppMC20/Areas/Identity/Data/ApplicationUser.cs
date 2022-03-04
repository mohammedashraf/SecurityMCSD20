using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SecurityWebAppMC20.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "varchar(30)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }
    }
}
