using System;
using Microsoft.EntityFrameworkCore;

namespace hobby.Models
{
   public class MyContext : DbContext
   {
      public MyContext(DbContextOptions options) : base(options) {}

      public DbSet<User> Users {get;set;}
      public DbSet<Hobby> Hobbies {get;set;}
      public DbSet<Join> Joins {get;set;}
      
   }
}