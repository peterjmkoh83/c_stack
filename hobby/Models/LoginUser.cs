using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hobby.Models
{
   public class LoginUser
   {
      [Required (ErrorMessage = "Please enter your username")]
      public string LoginUsername {get;set;}

      [Required (ErrorMessage = "Please enter your password")]
      [DataType (DataType.Password)]

      public string LoginPassword {get;set;}
   }
}