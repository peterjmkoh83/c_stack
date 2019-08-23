using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using products.Models;
using Microsoft.EntityFrameworkCore;

namespace products.Controllers
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

        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> products = dbContext.Products.ToList();
            ViewBag.pros = products;
            return View("Products");
        }

        [HttpPost("create/product")]
        public IActionResult CreateProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(product);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }
            return View("Products");
        }

        [HttpPost("products/category/{id}")]
        public IActionResult ProductAddCat(Association newAss, int id)
        {
            if(ModelState.IsValid)
            {
                newAss.ProductId = id;
                dbContext.Associations.Add(newAss);
                dbContext.SaveChanges();
            }
        
            // return RedirectToRoute($"/product/{id}");
            return RedirectToAction("AddCategory", new {id=id});
        }
        
        [HttpGet("product/{id}")]
        public IActionResult AddCategory(int id)
        {
            var pro = dbContext.Products.FirstOrDefault(p => p.ProductId == id); 
            ViewBag.pro = pro;
            
            var ind = dbContext.Categories.Where(c => c.ProAss.Any(a => a.ProductId == id));
            ViewBag.list = ind;

            var cat = dbContext.Categories.Where(c => !c.ProAss.Any(a => a.ProductId == id));
            ViewBag.cats = cat;

            return View("AddCategory");
        }

        [HttpGet("Categories")]
        public IActionResult Categories()
        {
            ViewBag.cats = dbContext.Categories.ToList();
            return View("Categories");
        }

        [HttpPost("create/category")]
        public IActionResult CreateCategory(Category cat)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(cat);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            return View("Categories");
        }

        [HttpGet("addProduct/{id}")]
        public IActionResult AddProduct(int id)
        {
            var catN = dbContext.Categories.Include(p => p.ProAss).ThenInclude(ass => ass.Product).FirstOrDefault(c => c.CategoryId == id);
            ViewBag.catName = catN;

            // var ind = dbContext.Products.Where(c => c.CatAss.Any(a => a.CategoryId == id));
            // ViewBag.list = ind;
            
            var cat = dbContext.Products.Where(c => !c.CatAss.Any(a => a.CategoryId == id)).ToList();
            ViewBag.pros = cat;
            return View("AddProduct");
        }

        [HttpPost("addProduct/add/{id}")]
        public IActionResult CatAddProduct(Association newAss, int id)
        {

            if(ModelState.IsValid)
            {
                newAss.CategoryId = id;
                dbContext.Associations.Add(newAss);
                dbContext.SaveChanges();
            }
        
            return RedirectToAction("AddProduct", new {id=id});
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
