using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        // remember to use [HttpPost] attributes!
        [HttpPost("profile")]

        public IActionResult Profile(string name, string dojo, string langauge, string comment)
        {
            System.Console.WriteLine(langauge);
            System.Console.WriteLine(dojo);
            System.Console.WriteLine(comment);


            // Do something with form input
            ViewBag.name = name;
            ViewBag.dojo = dojo;
            ViewBag.langauge = langauge;
            ViewBag.comment = comment;
            return View();
        }
    }

}
