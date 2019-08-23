using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bankAcct.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace bankAcct.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))  
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", userInDb.UserId);
                    return RedirectToAction("Account");
                }

            }

            return View("Index");
        }
       
        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View("Login");
        }
        
        [HttpPost("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Login");
                } 
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                }   
                else
                {
                    var id = userInDb.UserId;
                    // HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", id);
                    return RedirectToAction("Account", new {id});
                }
            
            }
            return View("Login");
        } 

        [HttpGet("account/{id}")]
        public IActionResult Account(int id)
        {
            
            if (HttpContext.Session.GetInt32("id") == null)
            {
                return View("Login");
            }
            
            var acct = dbContext.Users.Include(c => c.Transactions)
                .FirstOrDefault(a => a.UserId == id); 
            ViewBag.acctholder = acct;
            var balance = 0;
            ViewBag.x = balance;
            
            return View("Acct");
        }

        [HttpPost("transaction")]

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LoginPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
