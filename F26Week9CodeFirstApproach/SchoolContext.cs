using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace F26Week9CodeFirstApproach
{
    public class SchoolContext : DbContext
    {
        // entity sets - REQUIRED
        // declare DbSet<> properties
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }


        // define connection string - REQUIRED
        // override the OnConfiguring method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = ConfigurationManager.ConnectionStrings["SchoolCF"].ConnectionString;
            optionsBuilder.UseSqlServer(connStr);
        }


        // data seeding - OPTIONAL
        // override the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>().HasData(
                new Standard { StandardId = 1, StandardName = "Standard 1" },
                new Standard { StandardId = 2, StandardName = "Standard 2" },
                new Standard { StandardId = 3, StandardName = "Standard 3" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "John", StandardId = 1 },
                new Student { StudentId = 2, StudentName = "Anne", StandardId = 2 },
                new Student { StudentId = 3, StudentName = "Mark", StandardId = 3 },
                new Student { StudentId = 4, StudentName = "Lucy", StandardId = 3 }
            );
        }
    }
}
