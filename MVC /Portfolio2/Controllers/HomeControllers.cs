    using Microsoft.AspNetCore.Mvc;
    namespace Project1.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public ViewResult Index()
            {
                 return View();            
        }
    }
    }


        //     public ViewResult Info()
        // {
        //     // Same logic for serving a view applies
        //     // if we provide the the exact view name
        //     return View("Info");