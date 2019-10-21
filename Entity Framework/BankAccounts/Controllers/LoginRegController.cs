using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
{
    public class LoginRegController : Controller
    {

        private MyContext db;

        // here we can "inject" our context service into the constructor
        public LoginRegController(MyContext context)
        {
            db = context;
        }
        ///////////////////////////////////////////////////////////////////////
        [HttpGet("")]
        public IActionResult Registration()
        {
            return View("Registration");
        }
        ///////////////////////////////////////////////////////////////////////
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
        ///////////////////////////////////////////////////////////////////////
        [HttpGet("home/login")]
        public IActionResult Login()
        {
            return View();
        }
        ///////////////////////////////////////////////////////////////////////
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

            //  User db = db.User.FirstOrDefault(user => loginUser.LoginEmail == user.Email);
            // ViewBag.ThisUser = 
            return RedirectToAction("success");
        }
        ///////////////////////////////////////////////////////////////////////
        [HttpGet("home/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }
        ///////////////////////////////////////////////////////////////////////

        [HttpGet("success")]
        public IActionResult Success()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                int? UID = HttpContext.Session.GetInt32("UserId");
                User thisUser = db.Users
                    .Include(user => user.Transactions)
                    .FirstOrDefault(user => user.UserId == UID);

                ViewBag.thisUser = thisUser;
                return View();
            }

        }
        ///////////////////////////////////////////////////////////////////////
        [HttpPost("transactions")]
        public IActionResult Transactions(Transactions newTrans)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
            int? UID = HttpContext.Session.GetInt32("UserId");
            int sess = (int)UID;
            db.Add(newTrans);
            newTrans.UserId = sess;
            db.SaveChanges();
            User dbUser = db.Users.FirstOrDefault(user => user.UserId == UID);
            dbUser.Balance = dbUser.Balance + newTrans.Amount;
            db.SaveChanges();


            return RedirectToAction("success");
            }
        }
    }
}
