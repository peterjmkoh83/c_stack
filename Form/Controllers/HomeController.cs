using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Form.Models;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
            

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            } 
            else
            {
                return View("Index");
            }
        }
        
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
       
    }
}
