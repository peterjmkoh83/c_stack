using System.ComponentModel.DataAnnotations;

namespace bankAcct.Models
{
   public class LoginUser
   {
      [Required(ErrorMessage = "Email is required")]
      [EmailAddress]
      public string LoginEmail {get;set;}
      
      [Required(ErrorMessage = "Password is required")]
      public string LoginPassword {get;set;}
   }
}