using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Entites.DTO.Auth
{
    public class LoginUserDTO
    {
        public required string Email { get; set; } = "";

        public required string Password { get; set; } = "";
    }
}
