using Microsoft.AspNetCore.Mvc;
using System;

namespace portfolio_ii.Controllers
{
   public class HomeController : Controller
   {
      [HttpGet("")]
      public ViewResult Index()
      {
         return View();
      }

      [HttpGet("projects")]
      public IActionResult Projects()
      {
         return View();
      }
      
      [HttpGet("contact")]
      public IActionResult Contact()
      {
         return View();
      }



   }
}