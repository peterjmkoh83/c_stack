using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace wedding_planner.Models
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

      [Required (ErrorMessage = "Please enter your email")]
      [EmailAddress (ErrorMessage ="Please enter valid email address")]
      public string Email {get;set;}

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

      public List<RSVP> WeddingRsvpList {get;set;}

      public List<Wedding> WeddingList {get;set;}
   }
}