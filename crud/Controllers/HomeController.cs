using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes
                .OrderByDescending(o => o.CreatedAt)
                .ToList();   
            ViewBag.Dishes = AllDishes; 
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet("new")]
        public IActionResult AddDish()
        {
            return View("New");
        }

        [HttpGet("{id}")]
        public IActionResult ShowDish(int id)
        {
            Dish GetOneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            ViewBag.OneDish = GetOneDish;
            return View("Show");
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteDish(int id)
        {
            
            Dish GetOneDish = dbContext.Dishes.SingleOrDefault(d => d.DishId == id);
            dbContext.Dishes.Remove(GetOneDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{id}")]
        public IActionResult EditDish(int id)
        {
            Dish EditOneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
            
            return View("Edit", EditOneDish);
        }

        [HttpPost("update/{id}")]
        public IActionResult UpdateOneDish(int id, Dish UpdatedDish)
        {
            
            if(ModelState.IsValid)
            {
                Dish oneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
                
                oneDish.Name = UpdatedDish.Name;
                oneDish.Chef = UpdatedDish.Chef;
                oneDish.Calories = UpdatedDish.Calories;
                oneDish.Tastiness = UpdatedDish.Tastiness;
                oneDish.Description = UpdatedDish.Description;
                oneDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }
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

                 
                
