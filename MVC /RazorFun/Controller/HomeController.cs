using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

    }
}