using System;
using Microsoft.EntityFrameworkCore;

namespace activity.Models
{
    
   public class MyContext : DbContext
   {
      public MyContext(DbContextOptions options) : base(options) { }

      public DbSet<User> Users {get;set;}
      public DbSet<Activity> Activities {get;set;}
      public DbSet<Join> Joins {get;set;}
   }
}