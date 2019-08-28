using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hobby.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace hobby.Controllers
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

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", $"The Username {user.Username} is taken");
                    return View("Index");
                }
                else 
                {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Username == user.Username);

                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", userInDb.UserId);

                    return RedirectToAction("Hobby");
                }
            }
            else
            {
                return View("Index");
            }  
        } 

        [HttpPost("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Username == userSubmission.LoginUsername);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginUsername", "Invalid Username/Password");
                    return View("Index");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginUsername", "Invalid Username/Password");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", userInDb.UserId);
                    return RedirectToAction("Hobby");
                }
            }
            else
            {
                return View("Index"); 
            }
        }      

        [HttpGet("Hobby")]
        public IActionResult Hobby()
        {
            int? sessionId = HttpContext.Session.GetInt32("id");

            if (sessionId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                List<Hobby> hobbies = dbContext.Hobbies.ToList();
                ViewBag.hobList = hobbies;
                var hobbyList = dbContext.Hobbies
                            .Include(j => j.joinList)
                            .ToList();
                ViewBag.hobbyList = hobbyList;

                return View("Hobby");
            }
        }

        [HttpGet("Hobby/New")]
        public IActionResult CreatePage()
        {
            return View("New");
        }

        [HttpPost("Hobby/New/create")]
        public IActionResult CreateHobby(Hobby hobby)
        {
            int? sessionId = HttpContext.Session.GetInt32("id");
            if (sessionId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    hobby.UserId = (int)sessionId;
                    dbContext.Add(hobby);
                    dbContext.SaveChanges();

                    return RedirectToAction("Hobby");
                }
                else
                {
                    return View("New");
                }
            }
        }

        [HttpGet("Hobby/{id}")]
        public IActionResult OneHobby(int id)
        {
            int? sessionId = HttpContext.Session.GetInt32("id");
            
            if (sessionId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.sessionId = (int)sessionId;
                var oneHobby = dbContext.Hobbies.FirstOrDefault(o => o.HobbyId == id);
                ViewBag.oneHobby = oneHobby;

                Hobby hob = dbContext.Hobbies
                            .Include(g => g.joinList)
                            .ThenInclude(u => u.User)
                            .FirstOrDefault(i => i.HobbyId == id);
                ViewBag.hob = hob;

                return View("OneHobby", hob);
            }
            
        }

        [HttpGet("join/{id}")]
        public IActionResult Join(int id)
        {
            int sessionId = (int)HttpContext.Session.GetInt32("id");
            Join join = new Join();
            join.UserId = sessionId;
            join.HobbyId = id;
            dbContext.Add(join);
            dbContext.SaveChanges();
            return RedirectToAction("OneHobby");
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
