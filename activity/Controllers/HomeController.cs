using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using activity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace activity.Controllers
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
            return View();
        }

        [HttpGet("signin")]
        public IActionResult RegLog()
        {
            return View("LoginAct");
        }

        [HttpPost("signin/register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))  
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("LoginAct");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

                    
                    HttpContext.Session.SetInt32("id", userInDb.UserId);

                    return RedirectToAction("Home");
                }

            }

            return View("LoginAct");
        }

        [HttpPost("signin/login")]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("LoginAct");
                } 
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                }   
                else
                {
                    HttpContext.Session.SetInt32("id", userInDb.UserId);
                    
                    return RedirectToAction("Home");
                }
            
            }
            return View("LoginAct");
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            int? userid = HttpContext.Session.GetInt32("id");
            ViewBag.id = userid;
            
            return View("ListAct");
        }

        [HttpGet("activity/{id}")]
        public IActionResult ShowOneAct(int id)
        {
            var act = dbContext.Activities.FirstOrDefault(a => a.ActivityId == id);
            ViewBag.act = act;

           

            return View("ShowOneAct");
        }

        [HttpGet("new")]
        public IActionResult NewActPage()
        {
            return View("CreateAct");
        }

        [HttpPost("new/activity")]
        public IActionResult NewAct(activity.Models.Activity activity)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(activity);
                dbContext.SaveChanges();

                var activityId = dbContext.Activities.FirstOrDefault(a => a.ActivityId == activity.ActivityId);

                return RedirectToAction("ShowOneAct", new {id = activityId.ActivityId});
            }
            return View("CreateAct");
        }

    }
}
