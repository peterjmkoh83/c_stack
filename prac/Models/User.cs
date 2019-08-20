using System.ComponentModel.DataAnnotations;
using System;

namespace prac.Models
{
   public class User
   {
      [Key]
      public int UserId {get;set;}
      public string FirstName {get;set;}
      public string LastName {get;set;}
      public string Email {get;set;}
      public string Password {get;set;}
      public DateTime created_at {get;set;}
      public DateTime updated_at {get;set;}
   }
}