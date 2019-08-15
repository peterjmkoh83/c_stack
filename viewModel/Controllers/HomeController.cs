using Microsoft.AspNetCore.Mvc;
using System;
using viewModel.Models;
using System.Collections.Generic;

namespace viewModel.Controllers
{
   public class HomeController : Controller 
   {
      [HttpGet("")]
      public IActionResult Index()
      {
         Message content = new Message()
         {
            paragraph = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Libero hic dicta voluptatem ab pariatur cumque assumenda aperiam rem itaque neque quasi in quibusdam perspiciatis quod minus odit porro, ratione iusto."
         };
         return View(content);
      }

      [HttpGet("numbers")]
      public IActionResult Number()
      {
         Number newNum = new Number()
         {
            nums = new int[] { 1, 8, 3, 10, 43, 5 }
         };
      
         return View("Number", newNum);
      }

      [HttpGet("users")]
      public IActionResult Names()
      {
         string[] FirstName = new string[]
         {
            "Sally", "Billy", "Joey", "Moose"
         }; 
         return View("Names", FirstName);
      }

      [HttpGet("user")]
      public IActionResult Name()
      {
         User oneUser = new User()
         {
            FirstName = "Heidi",
            LastName = "Jung"
         };
         return View("Name", oneUser);
      }

      
   }


}