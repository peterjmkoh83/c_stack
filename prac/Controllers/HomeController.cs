using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prac.Models;
using Microsoft.EntityFrameworkCore;


namespace prac.Controllers
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
            List<User> AllUsers = dbContext.Users.ToList();
            
            // Get Users with the LastName "Jefferson"
            List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson").ToList();

            // Get the 5 most recently added Users
            List<User> MostRecent = dbContext.Users
                .OrderByDescending(u => u.created_at)
                .Take(5)
                .ToList();
          
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            dbContext.Add(newUser);
            dbContext.SaveChanges();
            return View();
        }

        [HttpGet("update/{userId}")]
        public IActionResult UpdateUser(int userId)
        {
            User RetrievedUser = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            RetrievedUser.FirstName = "New name";
            RetrievedUser.updated_at = DateTime.Now;

            dbContext.SaveChanges();
            return View();
        }

        [HttpGet("delete/{userId}")]
        public IActionResult DeleteUser(int userid)
        {
            User RetrievedUser = dbContext.Users.SingleOrDefault(u => u.UserId == userid);
            dbContext.Users.Remove(RetrievedUser);
            dbContext.SaveChanges();
            return View();
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
