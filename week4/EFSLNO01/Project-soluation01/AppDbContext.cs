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
        public DbSet<student> students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; DataBase= Company-20 ; Trusted_Connection= True ; TrustServerCertificate= True");
        }

    }
}
