   using Microsoft.AspNetCore.Mvc;
    namespace TimeDisplay.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
 //associated route string (exclude the leading /)
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        }
    }