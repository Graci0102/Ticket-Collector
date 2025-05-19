using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Problems.Data.Helper;
using Problems.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problems.Data
{
    public class ProblemContext : IdentityDbContext
    {
        public DbSet<Problem> Problems { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public ProblemContext(DbContextOptions<ProblemContext> opt) : base(opt)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
