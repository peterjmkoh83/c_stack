using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using re_survey.Models;

namespace re_survey.Controllers
{
    public class HomeController : Controller
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
        public IActionResult Survey(Survey NewSurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", NewSurvey);
            }
            else
            {
                return View("Index");
            }
        }
       
    }
}
