using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Domain.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}