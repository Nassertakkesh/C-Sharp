using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            db = context;
        }
     
        [HttpGet("")]
        public IActionResult Register()
        {
            return View("Registration");
        }

        [HttpPost("home/CreateRegister")]
        public IActionResult CreateRegister(User newUser)
        {

            if (ModelState.IsValid)
            {
                bool isEmailTaken =
                    db.Users.Any(user => newUser.Email == user.Email);

                if (isEmailTaken)
                {
                    ModelState.AddModelError("Email", "Email Taken");
                }
            }

            if (ModelState.IsValid == false)
            {
                return View("Registration");
            }
            // No Errors
            // Hash pw
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("success");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }

        [HttpGet("home/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("home/loggingIN")]
        public IActionResult loggingIN(LoginUser loginUser)
        {
            string genericError = "Invalid Credentials";

            if (ModelState.IsValid == false)
            {
                return View("Login");
            }
            User dbUser = db.Users.FirstOrDefault(user => loginUser.LoginEmail == user.Email);
            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", genericError);
                return View("Login");
            }
            // dbUser is not null
            // Convert LoginUser to User for PasswordVerification
            User viewUser = new User
            {
                Email = loginUser.LoginEmail,
                Password = loginUser.LoginPassword
            };
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            PasswordVerificationResult passwordCheck =
                hasher.VerifyHashedPassword(viewUser, dbUser.Password, viewUser.Password);
            // failed pw match
            if (passwordCheck == 0)
            {
                ModelState.AddModelError("LoginEmail", genericError);
                return View("Login");
            }
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            return RedirectToAction("success");
        }
        [HttpGet("home/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }
   
    }
}
//  <span class="text-danger font-weight-bold" asp-validation-for="LoginEmail"></span>
//      <span class="text-danger font-weight-bold" asp-validation-for="LoginPassword"></span>