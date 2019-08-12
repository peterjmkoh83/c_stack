using Microsoft.AspNetCore.Mvc;
namespace portfolio_i.Controllers   // be sure to use your own project's namespace!
{
   public class HomeController : Controller  //remember inheritance??
   {
      // Request (for each route this controller is to handle):
      // localhost:5000/
      [HttpGet("")]   // type of request
      public string Index() 
      {
         return "This is my Index";
      }

      // localhost:5000/projects
      [HttpGet("projects")]
      public string Projects()
      {
         return "These are my projects";
      }
      
      // localhost: 5000/contact
      [Route("contact")]
      [HttpGet]
      public string contact()
      {
         return "This is my contact";
      }

      // localhost:5000/contact
      [HttpGet("users/contact")]
      public string HelloUser(string username, string location)
      {
         if (location == "buena park")
            return $"Hello {username} from {location} go Buena Park";
         return $"Hello {username} from {location}";
      }   

   }

}