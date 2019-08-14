using Microsoft.AspNetCore.Mvc;
using System;


namespace time_display.Controllers
{
   public class PageController : Controller
   {
      [HttpGet("")]
      public IActionResult Index()
      {
         DateTime CurrentDateTime = DateTime.Now;
         @ViewBag.Date = CurrentDateTime.ToString("MMMM dd, yyyy");
         @ViewBag.Time = CurrentDateTime.ToString("h:mm tt");
         return View();
      }
   }
  
   
}