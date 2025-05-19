using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Entites.DTO.Auth
{
    public class LoginResultDTO
    {
        public string Token { get; set; } = "";

        public DateTime Expiration { get; set; }
    }
}
