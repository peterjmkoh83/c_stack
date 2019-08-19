using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quoting_dojo.Models;
using DbConnection;  // You need this line if changed the namespace of DbConnectyor to your own namespace.

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            ViewBag.Users = AllUsers;
            return View();
        }

        [HttpPost("quotes")]
        public IActionResult AddQuote(string name, string quote)
        {
            string query = $"INSERT INTO users (Name, Quote) VALUES ('{name}', '{quote}')";
            DbConnector.Execute(query);
            return RedirectToAction("Quotes");
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM users");
            ViewBag.Quotes = AllQuotes;
            return View("Quotes");
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
