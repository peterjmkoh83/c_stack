using System;
using Microsoft.EntityFrameworkCore;

namespace chefs.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}

        public DbSet<Chef> Chefs {get;set;}
        public DbSet<Dish> Dishes {get;set;}
    }
}