using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hobby.Models
{
   public class Join
   {
      [Key]
      public int JoinId {get;set;}

      public int UserId {get;set;}

      public int HobbyId {get;set;}
      
      public User User {get;set;}

      public Hobby hobby {get;set;}

   }
}