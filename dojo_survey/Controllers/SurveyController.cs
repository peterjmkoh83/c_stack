using Microsoft.AspNetCore.Mvc;
using System;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
   public class SurveyController : Controller
   {
      
      [HttpGet("")]
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet("result")] 
      public IActionResult Result(Survey NewSurvey)
      {
         return View("Result", NewSurvey);
      }

      [HttpPost("survey")]
      public IActionResult Submission(Survey NewSurvey)
      {
         return RedirectToAction("Result", NewSurvey);
      }
   
   }


}