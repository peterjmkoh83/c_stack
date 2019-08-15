using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using viewmodel_fun.Models;

namespace viewmodel_fun.Controllers
{
   public class UserController : Controller
   {
      [HttpGet("")]
      public IActionResult UserDetail()
      {
         User someUser = new User()
         {
            FirstName = "Sally",
            LastName ="Anderson"
         };
         return View("UserDetail", someUser);
      }
   }


}