using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;


namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public int fullness1 { get; set; } = 20;
        public int happiness1 { get; set; } = 20;
        public int meals1 { get; set; } = 3;
        public int energy1 { get; set; } = 20;
        public string desc1 { get; set; } = "THe Dojocahci is just chilling rn";
        public int temp { get; set; } 
////////////////////////////////////////////////////////////////////////
        [HttpGet("")]
        public IActionResult Index()
        {

            if ((HttpContext.Session.GetInt32("fullness1") >= 100) && (HttpContext.Session.GetInt32("energy1") >= 100) && (HttpContext.Session.GetInt32("happiness1") >= 100))
            {
                return View("Win");
            }

            else if ((HttpContext.Session.GetInt32("fullness1") <= 0) || (HttpContext.Session.GetInt32("happiness1") <= 0) || (HttpContext.Session.GetInt32("energy1") <= 0))

            {
                return View("Lose");
            }

            else if (HttpContext.Session.GetInt32("fullness1") == null)
            {
                HttpContext.Session.SetInt32("fullness1", fullness1);
                HttpContext.Session.SetInt32("happiness1", happiness1);
                HttpContext.Session.SetInt32("meals1", meals1);
                HttpContext.Session.SetInt32("energy1", energy1);
                HttpContext.Session.SetString("desc1", desc1);
                HttpContext.Session.SetInt32("temp", temp);


            }
            else
            {
                ViewBag.fullness = HttpContext.Session.GetInt32("fullness1");
                ViewBag.happiness = HttpContext.Session.GetInt32("happiness1");
                ViewBag.meals = HttpContext.Session.GetInt32("meals1");
                ViewBag.energy = HttpContext.Session.GetInt32("energy1");
                ViewBag.desc = HttpContext.Session.GetString("desc1");
                ViewBag.temp = HttpContext.Session.GetInt32("temp");

            }
            return View();
        }

////////////////////////////////////////////////////////////////////////

        [HttpPost("fullness")]
        public IActionResult fullness()
        {
            Random rand1 = new Random();
            int prob = rand1.Next(1, 100);

            if (HttpContext.Session.GetInt32("meals1") <= 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

                int? full = HttpContext.Session.GetInt32("fullness1");
                int? meal = HttpContext.Session.GetInt32("meals1");
                string desc = HttpContext.Session.GetString("desc1");
                int? temp = HttpContext.Session.GetInt32("temp");
                if (prob >= 25)
                {
                    Random rand = new Random();
                    full += rand.Next(5, 10);
                    int full1 = full.GetValueOrDefault();
                    HttpContext.Session.SetInt32("fullness1", full1);
                    HttpContext.Session.SetInt32("temp", full1);

                    meal -= 1;
                    int meal1 = meal.GetValueOrDefault();
                    HttpContext.Session.SetInt32("meals1", meal1);
                    string desc2 = "YOU FED THE DOJOACHI!!!";
                    HttpContext.Session.SetString("desc1", desc2);
                }
                else
                {
                    meal -= 1;
                    int meal1 = meal.GetValueOrDefault();
                    HttpContext.Session.SetInt32("energy1", meal1);
                }
            }
            return RedirectToAction("Index");
        }


////////////////////////////////////////////////////////////////////////

        [HttpPost("happiness")]
        public IActionResult happiness()
        {
            Random rand1 = new Random();
            int prob = rand1.Next(1, 100);

            if (HttpContext.Session.GetInt32("meals1") <= 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                int? happiness = HttpContext.Session.GetInt32("happiness1");
                int? energy = HttpContext.Session.GetInt32("energy1");
                if (prob >= 25)
                {
                    Random rand = new Random();
                    happiness += rand.Next(5, 10);
                    int happiness1 = happiness.GetValueOrDefault();
                    HttpContext.Session.SetInt32("happiness1", happiness1);
                    HttpContext.Session.SetInt32("temp", happiness1);

                    energy -= 5;
                    int energy1 = energy.GetValueOrDefault();
                    HttpContext.Session.SetInt32("energy1", energy1);
                    string desc2 = "YOU PLAYED WITH THE DOJOACHI!!";

                    HttpContext.Session.SetString("desc1", desc2);
                }
                else
                {
                    energy -= 5;
                    int energy1 = energy.GetValueOrDefault();
                    HttpContext.Session.SetInt32("energy1", energy1);
                }
            }
            return RedirectToAction("Index");
        }


////////////////////////////////////////////////////////////////////////

        [HttpPost("working")]
        public IActionResult working()
        {
            int? meals = HttpContext.Session.GetInt32("meals1");
            int? energy = HttpContext.Session.GetInt32("energy1");

            Random rand = new Random();
            meals += rand.Next(1, 3);
            int meals1 = meals.GetValueOrDefault();
            HttpContext.Session.SetInt32("meals1", meals1);
            HttpContext.Session.SetInt32("temp", meals1);

            energy -= 5;
            int energy1 = energy.GetValueOrDefault();
            HttpContext.Session.SetInt32("energy1", energy1);
            string desc2  = "THE DOJOACHI ID GETTING THAT BREADDDDD!!! ";
            HttpContext.Session.SetString("desc1", desc2);
            // }
            return RedirectToAction("Index");

        }

////////////////////////////////////////////////////////////////////////

        [HttpPost("sleep")]
        public IActionResult sleep()
        {
            int? happiness = HttpContext.Session.GetInt32("happiness1");
            int? energy = HttpContext.Session.GetInt32("energy1");
            int? fullness = HttpContext.Session.GetInt32("fullness1");


            happiness -= 5;
            int happiness1 = happiness.GetValueOrDefault();
            HttpContext.Session.SetInt32("happiness1", happiness1);

            energy += 15;
            int energy1 = energy.GetValueOrDefault();
            HttpContext.Session.SetInt32("energy1", energy1);

            fullness -= 5;
            int fullness1 = fullness.GetValueOrDefault();
            HttpContext.Session.SetInt32("fullness1", fullness1);
            string desc2  = "THE DOJOACHI SLEEPING";
            HttpContext.Session.SetInt32("temp", fullness1);
            HttpContext.Session.SetString("desc1", desc2);

            // }
            return RedirectToAction("Index");
        }

////////////////////////////////////////////////////////////////////////


        [HttpPost("reset")]
        public IActionResult reset()
        {
            HttpContext.Session.Clear();
            // }
            return RedirectToAction("Index");
        }
////////////////////////////////////////////////////////////////////////

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
