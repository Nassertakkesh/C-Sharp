using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicous.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDelicous.Controllers
{
    public class HomeController : Controller
    {
///////////////////////////////////////////////////////////////////////////////////////////////////
        private ThisContext db;
        // here we can "inject" our context service into the constructor
        public HomeController(ThisContext context)
        {
            db = context;
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        public IActionResult Index()
        {
            List<Dish> AllDishes = db.Dishes
            // ToList();
            .OrderByDescending(dish =>dish.CreatedAt ).ToList();
            System.Console.WriteLine("HKJFHKAJSDHFKJASDHFKJSDHFJKHSDKFKDJFHGKJHFGDKJHJKFDHGKJSDGHDFHDLKDGFLJHKGDFJGDSFLKGHDSLFKSDHKJSDHDJFSHKDJSFHDKJLSFGHKDJJJFDJKDFHKSDHLJSDHFGKJSDHKLFGHKLSDJFHGKLSJDFH");
            System.Console.WriteLine(AllDishes);
            // db.Remove(AllDishes);
            // db.SaveChanges();
            ViewBag.ListOfDishes = AllDishes;

            return View();
  
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        public IActionResult New()
        {
            return View();
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost("create")]
        public IActionResult create(Dish thisDish)
        {
            db.Dishes.Add(thisDish);
            db.SaveChanges();
            System.Console.WriteLine(db.Dishes.Last());
            System.Console.WriteLine("Hello fghdkjfghkjdsfhgkjhdsfkghsdkfjhgkljdsfhgkj");
            return RedirectToAction("Index");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet("home/details/{id}")]
        public IActionResult Details(int id)
        {
            Dish SelectedDish = db.Dishes
                .FirstOrDefault(p => p.DishId == id);
            return View(SelectedDish);
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet("home/edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish SelectedDish = db.Dishes.FirstOrDefault(p => p.DishId == id);
            System.Console.WriteLine(SelectedDish);
            if (SelectedDish == null)
                return RedirectToAction("Index");
            return View(SelectedDish);
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost("home/update/{id}")]
        public IActionResult update(int id, Dish newDish)
        {
            Dish SelectedDish = db.Dishes.FirstOrDefault(p => p.DishId == id);
            SelectedDish.ChefsName = newDish.ChefsName;
            SelectedDish.DishName = newDish.DishName;
            SelectedDish.Calories = newDish.Calories;
            SelectedDish.Tastiness = newDish.Tastiness;
            SelectedDish.Description = newDish.Description;
            SelectedDish.UpdatedAt = DateTime.Now;
            db.SaveChanges();
            System.Console.WriteLine(SelectedDish);
            return RedirectToAction("Index");
        }

        [HttpGet("home/delete/{id}")]
        public IActionResult delete(int id)
        {
            Dish SelectedDish = db.Dishes.FirstOrDefault(p => p.DishId == id);
            if (SelectedDish != null)
            {
                db.Dishes.Remove(SelectedDish);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }






    }
}
