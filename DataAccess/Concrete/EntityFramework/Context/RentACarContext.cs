using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
   public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=CarRent; Truseted_Connection = true" );
        }
        public DbSet<Car> Cars {get; set;}
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

        public DbSet<Order> Orders { get; set; }




    }
}
