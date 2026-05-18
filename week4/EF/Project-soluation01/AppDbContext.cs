using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_soluation01
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> student { get; set; }
        public DbSet<Courses> courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database= Moon ; Trusted_Connection= True ; TrustServerCertificate= True");
        }
    }
}
