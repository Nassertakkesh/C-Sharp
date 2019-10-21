using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefnDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefnDishes.Controllers
{
    public class ChefController : Controller
    {
         private MyContext db;
     
        // here we can "inject" our context service into the constructor
        public ChefController(MyContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult ChefsHome()
        {
                List<Chefs> allChefs = db.Chefs
                .Include (d=>d.Dishes)
                .ToList();      
                      
                
                return View("ChefsHome",allChefs);
        }
        //////////////////////////////////////////////////////////
        [HttpGet("/dish")]
        public IActionResult DishHome()
        {
            System.Console.WriteLine("this is a party");
            return RedirectToAction("DishHome","Dish");
        }
        //////////////////////////////////////////////////////////
        [HttpGet("/CreateChef")]
        public IActionResult CreateChef()
        {
            return View("AddNewChef");
        }
        //////////////////////////////////////////////////////////
        [HttpPost("Chef/Creating")]
        public IActionResult Creating(Chefs NewChef)
        {
            db.Chefs.Add(NewChef);
            db.SaveChanges();
            return RedirectToAction("ChefsHome");
        }

      
    }
}
