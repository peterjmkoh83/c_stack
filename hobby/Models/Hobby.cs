using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hobby.Models
{
   public class Hobby
   {
      [Key]
      public int HobbyId {get;set;}

      public int UserId {get;set;}

      [Required (ErrorMessage="Please enter your hobby")]
      public string Name {get;set;}

      [Required (ErrorMessage="Please enter description of your hobby")]
      public string Description {get;set;}

      public DateTime CreatedAt {get;set;} = DateTime.Now;
      public DateTime UpdatedAt {get;set;} = DateTime.Now;

      public User Creator {get;set;}
      public List<Join> joinList {get;set;}

   }
}