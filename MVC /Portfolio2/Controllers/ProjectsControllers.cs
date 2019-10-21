    using Microsoft.AspNetCore.Mvc;
    namespace Project1.Controllers     //be sure to use your own project's namespace!
    {
        public class ProjectsController : Controller   
        {
            [HttpGet("/projects")]           
            public ViewResult Projects()
            {
                 return View();             

        }
    }
    }


