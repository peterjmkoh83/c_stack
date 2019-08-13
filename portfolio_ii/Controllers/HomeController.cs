using Microsoft.AspNetCore.Mvc;
using System;

namespace portfolio_ii.Controllers
{
   public class HomeController : Controller
   {
      [Route("")]
      [HttpGet]
      public ViewResult Index()
      {
         return View();
      }

      [HttpGet("hello")]
      public RedirectToActionResult hello()
      {
         Console.WriteLine("Redirecting to HOme");
         var param = new{User="peter"};
         return RedirectToAction("HelloUser", param);
      }
      
      [HttpGet("{user}")]
      public string HelloUser(string user)
      {
         return $"Hello {user}";
      }

   }
}