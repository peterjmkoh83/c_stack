using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace chefs.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            // var chefs = dbContext.Chefs.FirstOrDefault(c => c.ChefId);
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.chefs = AllChefs;
            return View();
        }

        [HttpGet("new")]
        public IActionResult AddChefPage()
        {
            return View("AddChef");
        }

        [HttpPost("new/create")]
        public IActionResult CreateChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult DishList()
        {
            return View("DishList");
        }

        [HttpGet("dishes/new")]
        public IActionResult AddDishPage()
        {
            return View("AddDish");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
