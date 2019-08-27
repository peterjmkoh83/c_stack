using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wedding_planner.Models
{
   public class LoginUser
   {
      [Required (ErrorMessage = "Please enter your login email")]
      [EmailAddress]
      public string LoginEmail {get;set;}

      [Required (ErrorMessage = "Please enter your password")]
      [DataType (DataType.Password)]

      public string LoginPassword {get;set;}
   }
}