using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace activity.Models
{
   public class User
   {
      [Key]
      public int UserId {get;set;}

      [Required]
      [MinLength(2, ErrorMessage = "Name needs to be at least 2 characters") ]
      public string Name {get;set;}

      [Required]
      [EmailAddress]
      public string Email {get;set;}
      
      [Required]
      [MinLength(8, ErrorMessage = "Password needs to be at least 8 characters")]
      [DataType(DataType.Password)]
      public string Password {get;set;}

      public DateTime CreatedAt {get;set;} = DateTime.Now;
      public DateTime UpdatedAt {get;set;} = DateTime.Now;

      [NotMapped]
      [Required]
      [Compare("Password")]
      [DataType(DataType.Password)]
      public string Confirm {get;set;}

      public List<Join> joinActivities {get;set;}

   }
}