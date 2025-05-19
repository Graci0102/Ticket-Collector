using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Data.Helper
{
    public class AppUser :IdentityUser
    {
        [StringLength(200)]
        public required string FirstName { get; set; } = "";

        [StringLength(200)]
        public required string LastName { get; set; } = "";
    }
}
