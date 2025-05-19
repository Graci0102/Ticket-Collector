using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Entites.DTO
{
    public class ProblemGetDTO
    {
        public string Description { get; set; } = "";
        public string CreatorId { get; set; } = "";

        public string CreatorName { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
