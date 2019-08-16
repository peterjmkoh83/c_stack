using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using random_passcode.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;   

namespace random_passcode.Controllers
{

public class RandomGenerator    
{    
    // Generate a random number between two numbers    
    public int RandomNumber(int min, int max)    
    {    
        Random random = new Random();    
        return random.Next(min, max);    
    }    
    
    // Generate a random string with a given size    
    public string RandomString(int size, bool lowerCase)    
    {    
        StringBuilder builder = new StringBuilder();    
        Random random = new Random();    
        char ch;    
        for (int i = 0; i < size; i++)    
        {    
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));    
            builder.Append(ch);    
        }    
        if (lowerCase)    
            return builder.ToString().ToLower();    
        return builder.ToString();    
    }    
    
    // Generate a random password    
    public string RandomPassword()    
    {    
        StringBuilder builder = new StringBuilder();    
        builder.Append(RandomString(4, false));    
        builder.Append(RandomNumber(1000, 9999));    
        builder.Append(RandomString(2, false));   
        builder.Append(RandomNumber(1000, 9999)); 
        return builder.ToString();    
    }    
}        
    public class HomeController : Controller
    {
   
        public IActionResult Index()
        {
            var random = new RandomGenerator();
            ViewBag.Passcode = random.RandomPassword();
            ViewBag.Count = 1; 

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

    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }   









}
