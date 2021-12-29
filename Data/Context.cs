using Microsoft.EntityFrameworkCore;
using studentEFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentEFConsole.Data
{
    class Context : DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=studentEFConsole; Trusted_Connection=true;User Id=student; Password=student");
            }                               //Things you need to fill to connect to Mssql
        }
    }
}
