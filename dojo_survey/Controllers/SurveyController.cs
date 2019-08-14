using Microsoft.AspNetCore.Mvc;
using System;

namespace dojo_survey.Controllers
{
   public class SurveyController : Controller
   {
      
      [HttpGet("")]
      public IActionResult Index()
      {
         return View();
      }

      [HttpPost("result")]
      
      public IActionResult Result(string name, string location, string language, string comment)
      {
         ViewBag.name = name;
         ViewBag.location = location;
         ViewBag.language = language;
         ViewBag.comment = comment;
         


         return View("Result");
      }

      // [HttpGet("result")]
      // public IActionResult Result()
      // {
      //    return View("Result");
      // }
   }


}