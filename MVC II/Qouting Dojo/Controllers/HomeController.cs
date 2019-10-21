using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Qouting_Dojo.Models;
using DbConnection;

namespace Qouting_Dojo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

[HttpGet]
	[Route("")]
	public IActionResult Index()
	{
    	    List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            ViewBag.Users = AllUsers;
            return View();
	}
        
        // Get One User
        [HttpGet]
        [Route("{userId}")]
        public IActionResult Show(int userId)
        {
            // One user will be represented as an item in the list of dictionaries, shown here by indexing 0
            Dictionary<string, object> User = DbConnector.Query($"SELECT * FROM users WHERE id = {userId}")[0];
            // Other code
        }
        // Create a User
        [HttpPost]
        [Route("create")]
        public IActionResult Create(User user)
        {
            // other code
            string query = $"INSERT INTO users (FirstName, LastName) VALUES ('{user.FirstName}', '{user.LastName}')";
            DbConnector.Execute(query);
            // other code
        }


        public IActionResult Privacy()
        {
            return View();
        }


    }
}
