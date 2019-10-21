using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        // [HttpPost("")]
        public IActionResult Index()
        {
            
         if (HttpContext.Session.GetInt32("UserAge") == null){
                HttpContext.Session.SetInt32("UserAge", 1);
         }
         else
         {
            int num1;
            int? num = HttpContext.Session.GetInt32("UserAge");
            num += 1;
            num1 = num.Value;
            HttpContext.Session.SetInt32("UserAge", num1);
         }
            ViewBag.count = HttpContext.Session.GetInt32("UserAge");
            ViewBag.password = GenerateRandomPassword();

            return View("index");

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

public static string GenerateRandomPassword(PasswordOptions opts = null)
{
    if (opts == null) opts = new PasswordOptions()
    {
        RequiredLength = 14,
        RequiredUniqueChars = 0,
        RequireDigit = true,
        RequireLowercase = true,
        RequireNonAlphanumeric = false,
        RequireUppercase = true
    };
 
    string[] randomChars = new [] {
        "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
        "abcdefghijkmnopqrstuvwxyz",    // lowercase
        "0123456789",                   // digits
        "!@$?_-"                        // non-alphanumeric
    };
    Random rand = new Random(Environment.TickCount);
    List<char> chars = new List<char>();
 
    if (opts.RequireUppercase)
        chars.Insert(rand.Next(0, chars.Count), 
            randomChars[0][rand.Next(0, randomChars[0].Length)]);
 
    if (opts.RequireLowercase)
        chars.Insert(rand.Next(0, chars.Count),
            randomChars[1][rand.Next(0, randomChars[1].Length)]);
 
    if (opts.RequireDigit)
        chars.Insert(rand.Next(0, chars.Count),
            randomChars[2][rand.Next(0, randomChars[2].Length)]);
 
    if (opts.RequireNonAlphanumeric)
        chars.Insert(rand.Next(0, chars.Count),
            randomChars[3][rand.Next(0, randomChars[3].Length)]);
 
    for (int i = chars.Count; i < opts.RequiredLength 
        || chars.Distinct().Count() < opts.RequiredUniqueChars; i++)
    {
        string rcs = randomChars[rand.Next(0, randomChars.Length)];
        chars.Insert(rand.Next(0, chars.Count), 
            rcs[rand.Next(0, rcs.Length)]);
    }
 
    return new string(chars.ToArray());
}







    }
}
