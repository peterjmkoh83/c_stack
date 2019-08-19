using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// Your Dojodachi should start with 20 happiness, 20 fullness, 50 energy, and 3 meals.
// After every button press, display a message showing how the Dojodachi reacted
// Feeding your Dojodachi costs 1 meal and gains a random amount of fullness between 5 and 10 (you cannot feed your Dojodachi if you do not have meals)
// Playing with your Dojodachi costs 5 energy and gains a random amount of happiness between 5 and 10
// Every time you play with or feed your dojodachi there should be a 25% chance that it won't like it. Energy or meals will still decrease, but happiness and fullness won't change.
// Working costs 5 energy and earns between 1 and 3 meals
// Sleeping earns 15 energy and decreases fullness and happiness each by 5
// If energy, fullness, and happiness are all raised to over 100, you win! a restart button should be displayed.
// If fullness or happiness ever drop to 0, you lose, and a restart button should be displayed.

namespace Dojodachi.Controllers
{ 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("fullness", 20);
            HttpContext.Session.SetInt32("happiness", 20);
            HttpContext.Session.SetInt32("meals", 3);
            HttpContext.Session.SetInt32("energy", 50);
            HttpContext.Session.SetString("message", "Happiness, Fullness, and Energy 100 to win this game");

            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            string message = HttpContext.Session.GetString("message");

            ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("meals");
            ViewBag.Message = HttpContext.Session.GetString("message");

            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            string message = HttpContext.Session.GetString("message");
            
            if (HttpContext.Session.GetInt32("meals") == 0)
            {
                HttpContext.Session.SetString("message", "You don't have enough Meal");
            }
            else
            {
               if (energy >= 100 && fullness >= 100 && happiness >= 100)
               {
                   HttpContext.Session.SetString("message", "Congratulation! You won!");
               }
               else
               {
                   var random = new Random();
                   int randInt = random.Next(5,11);

                   meals--;
                   HttpContext.Session.SetInt32("meals", (int)meals);
                   fullness += randInt;
                   HttpContext.Session.SetInt32("fullness", (int)fullness);
                   HttpContext.Session.SetString("message", $"You fed Lucian! Fullness + {randInt}, Meals - 1");
               }
            }
            
            ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("meals");
            ViewBag.Message = HttpContext.Session.GetString("message");

            

            return View("Index");
        }
        
        [HttpGet("play")]
        public IActionResult Play()
        {
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            string message = HttpContext.Session.GetString("message");

            if(HttpContext.Session.GetInt32("energy") <= 0)
            {
                HttpContext.Session.SetString("message", "You don't have enought energy to play with");
            }
            else 
            {
                if (energy >= 100 && fullness >= 100 && happiness >= 100)
                {
                    HttpContext.Session.SetString("message", "Congratulation! You won!");
                }
                else 
                {
                    var random = new Random();
                    int randInt = random.Next(5,11);

                    energy = energy - 5;
                    HttpContext.Session.SetInt32("energy", (int)energy);
                    happiness += randInt;
                    HttpContext.Session.SetInt32("happiness", (int)happiness);
                    HttpContext.Session.SetString("message", $"You played with Lucian! Happiness + {randInt}, Energy - 5");

                }
            }

            
            ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("meals");
            ViewBag.Message = HttpContext.Session.GetString("message");

           return View("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            string message = HttpContext.Session.GetString("message");

            if (HttpContext.Session.GetInt32("energy") <= 0)
            {
                HttpContext.Session.SetString("message", "You don't have energy to work... need to restore energy!");
            }
            else
            {

                var random = new Random();
                int randomInt = random.Next(1,4); 

                energy -= 5;
                HttpContext.Session.SetInt32("energy", (int)energy);
                meals += randomInt;
                HttpContext.Session.SetInt32("meals", (int)meals);

                HttpContext.Session.SetString("message", $"You have gained + {meals}, Energy - 5");
            }
            
            ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("meals");
            ViewBag.Message = HttpContext.Session.GetString("message");

           return View("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int? fullness = HttpContext.Session.GetInt32("fullness");
            int? happiness = HttpContext.Session.GetInt32("happiness");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");
            string message = HttpContext.Session.GetString("message");

            if (HttpContext.Session.GetInt32("fullness") <= 0 || HttpContext.Session.GetInt32("happiness") <= 0 )
            {
                HttpContext.Session.SetString("message","You Lose, try again");
            }
            else 
            {
                if (energy >= 100 && fullness >= 100 && happiness >= 100)
                {
                    HttpContext.Session.SetString("message", "Congratulation! You won!");
                }
                else
                {
                    energy += 15;
                    HttpContext.Session.SetInt32("energy", (int)energy);
                    fullness -= 5;
                    HttpContext.Session.SetInt32("fullness", (int)fullness);
                    happiness -= 5;
                    HttpContext.Session.SetInt32("happiness", (int)happiness);
                    HttpContext.Session.SetString("message", $"Sleeping.. You have earned + 15 Energy but lost - 5 Fullness and - 5 Happiness");
                }
            }
            
            ViewBag.Fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("meals");
            ViewBag.Message = HttpContext.Session.GetString("message");

           return View("Index");
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
