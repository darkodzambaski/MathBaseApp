﻿using Microsoft.AspNetCore.Identity;

namespace MathBase.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
    }
}
