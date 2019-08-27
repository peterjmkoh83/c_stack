using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wedding_planner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace wedding_planner.Controllers
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
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", $"The email {user.Email} is taken");
                    return View("Index");
                }
                else 
                {
                    PasswordHasher<User> hasher = new PasswordHasher<User>();
                    user.Password = hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);

                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", userInDb.UserId);

                    return RedirectToAction("Dashboard");
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
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.GetInt32("id");
                    HttpContext.Session.SetInt32("id", userInDb.UserId);
                    return RedirectToAction("Dashboard");
                }
            }
            else
            {
                return View("Index"); 
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? sessionId = HttpContext.Session.GetInt32("id");
            
            if (sessionId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.sessionId = (int)sessionId;
                var wedList = dbContext.Weddings
                            .Include(w => w.weddingCreator)
                            .Include(g => g.guestList)
                            .ThenInclude(u => u.User)
                            .Where(i => i.Date >= DateTime.Now)
                            .ToList();
                ViewBag.wedList = wedList;
                return View("Dashboard", wedList);
            }
        }


        [HttpGet("display/{id}")]
        public IActionResult Display(int id)
        {
            int? sessionId = HttpContext.Session.GetInt32("id");
            if (sessionId == null)
            {
                return RedirectToAction("Index");
            }

            Wedding wed = dbContext.Weddings
                        .Include(w => w.guestList)
                        .ThenInclude(u => u.User)
                        .FirstOrDefault(i => i.WeddingId == id);
            ViewBag.wed = wed;

            return View("Display", wed);
        }
        
        [HttpGet("newWedding")]
        public IActionResult NewWeddingPage()
        {
            int? sessionId = HttpContext.Session.GetInt32("id");
            if (sessionId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewWedding");
            }
        }

        [HttpPost("newWedding/create")]
        public IActionResult CreateWedding(Wedding wedding)
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
                    wedding.UserId = (int)sessionId;
                    dbContext.Add(wedding);
                    dbContext.SaveChanges();

                    Wedding wed = dbContext.Weddings.LastOrDefault();
                    return RedirectToAction("Display", new {id = wed.WeddingId});
                }
                else
                {
                    return View("NewWedding");
                }
            }
            
        }

        [HttpGet("join/{id}")]
        public IActionResult Join(int id)
        {
            int sessionId = (int)HttpContext.Session.GetInt32("id");
            RSVP rsvp = new RSVP();
            rsvp.UserId = sessionId;
            rsvp.WeddingId = id;
            dbContext.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("leave/{id}")]
        public IActionResult Leave(int id)
        {
            int sessionId = (int)HttpContext.Session.GetInt32("id");
            RSVP rsvp = dbContext.RSVPs.FirstOrDefault(w => w.WeddingId == id && w.UserId == sessionId);
            dbContext.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Wedding wed = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == id);
            dbContext.Remove(wed);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        } 

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
