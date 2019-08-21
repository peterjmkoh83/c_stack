using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login.Models
{
   public class User
   {
      [Key]
      public int UserId {get;set;}

      [Required]
      [MinLength(2, ErrorMessage = "First name needs to be at least 2 characters") ]
      public string FirstName {get;set;}

      [Required]
      [MinLength(2, ErrorMessage = "Last name needs to be at least 2 characters")]
      public string LastName {get;set;}

      [Required]
      [EmailAddress]
      public string Email {get;set;}
      
      [Required]
      [MinLength(8, ErrorMessage = "Password needs to be at least 8 characters")]
      [DataType(DataType.Password)]
      public string Password {get;set;}

      public DateTime CreatedAt {get;set;}
      public DateTime UpdatedAt {get;set;}

      [NotMapped]
      [Compare("Password")]
      [DataType(DataType.Password)]
      public string Confirm {get;set;}

   }
}