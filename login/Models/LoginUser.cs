using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login.Models
{
   public class LoginUser
   {
      [Required]
      [EmailAddress]
      public string LoginEmail {get;set;}
      
      [Required]
      public string LoginPassword {get;set;}
   }
}