using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Configurations;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] {1,2}));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] {1,2}));
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
