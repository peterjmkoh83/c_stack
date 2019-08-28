using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace hobby.Models
{
   public class User
   {
      [Key]
      public int UserId {get;set;}

      [Required (ErrorMessage = "Please enter your first name")]
      [MinLength (2, ErrorMessage = "First Name needs to be at least 2 characters")]
      public string FirstName {get;set;}

      [Required (ErrorMessage = "Please enter your last name")]
      [MinLength (2, ErrorMessage = "Last Name needs to be at least 2 characters")]
      public string LastName {get;set;}

      [Required (ErrorMessage = "Please enter your username")]
      [MinLength (3, ErrorMessage = "Username needs to be between 3 to 15 characters")]
      [MaxLength (15, ErrorMessage = "Username needs to be between 3 to 15 characters")]
      public string Username {get;set;}

      [Required (ErrorMessage = "Please enter your password")]
      [MinLength (8, ErrorMessage = "Password needs to be at least 8 characters")]
      [DataType (DataType.Password)]
      public string Password {get;set;}

      public DateTime CreatedAt {get;set;} = DateTime.Now;
      public DateTime UpdatedAt {get;set;} = DateTime.Now;

      [NotMapped]
      [Required (ErrorMessage = "Please confirm your password")]
      [Compare("Password", ErrorMessage = "Passwords do not match")]
      [DataType(DataType.Password)]
      public string ConfirmPassword {get;set;}

      public List<Join> JoinList {get;set;}
   }
}