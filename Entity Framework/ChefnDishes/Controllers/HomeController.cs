using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefnDishes.Models;

namespace ChefnDishes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("ChefsHome","Chef");
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
