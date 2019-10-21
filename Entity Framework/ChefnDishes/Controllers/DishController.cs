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
    public class DishController : Controller
    {
        private MyContext db;
     
        // here we can "inject" our context service into the constructor
        public DishController(MyContext context)
        {
            db = context;
        }
     
        public IActionResult DishHome()
        {
                List<Dish> allDishes = db.Dishes
                .Include(d => d.Chef)
                .ToList();

            return View("DishHome", allDishes);
        }

        /////////////////////////////////////////////////////////
        [HttpGet("/CreateDish")]
        public IActionResult CreateDish()
        {
            List<Chefs> allChefs = db.Chefs.ToList();
            ViewBag.allchefs = allChefs;
            return View("AddNewDish");
        }
        //////////////////////////////////////////////////////////
        [HttpPost("Dish/Creating")]
        public IActionResult Creating(Dish NewDish)
        {
            db.Dishes.Add(NewDish);
            db.SaveChanges();
            return RedirectToAction("DishHome");
        }

      
    }
}
