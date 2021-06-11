using System;
using System.Collections.Generic;
using KS.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace KS.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
    }
}
