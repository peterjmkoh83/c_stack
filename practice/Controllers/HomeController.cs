using Microsoft.AspNetCore.Mvc;
using System;

namespace practice.Controllers
{
   public class HomeController : Controller
   {
      [HttpGet("")]
      public IActionResult Index()
      {
         return View("Index");
      }

      [HttpPost("addpro")]
      public IActionResult AddProduct(Product product) 
      {
         if (ModelState.IsValid)
         {
            return RedirectToAction("Index");
         }
         else
         {
            return View("Index");
         }
      }


      // [HttpGet("")]
      // public IActionResult Index()
      // {
      //    ViewBag.CurrentTime = DateTime.Now;
      //    ViewBag.Message = "The Time is:";
      //    return View("Index");
      // }

   }


}