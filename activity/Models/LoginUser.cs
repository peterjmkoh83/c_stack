using System.ComponentModel.DataAnnotations;

namespace activity.Models
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