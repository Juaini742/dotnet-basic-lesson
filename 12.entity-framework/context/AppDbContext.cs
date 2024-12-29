using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _12.entity_framework.entity;
using Microsoft.EntityFrameworkCore;

namespace _12.entity_framework.context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=test;User Id=sa;Password=123;");
        }
    }
}
