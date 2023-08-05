using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ShelterApp.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Fullname => Firstname + " " + Lastname;
    }
}