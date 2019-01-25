using System;
using Microsoft.AspNetCore.Identity;

namespace ASRWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional columns in dbo.AspNetUsers
        public string StaffID { get; set; }
        public virtual Staff Staff { get; set; }

        public string StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
