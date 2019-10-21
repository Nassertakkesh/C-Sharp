    using Microsoft.AspNetCore.Mvc;
    namespace Project1.Controllers     //be sure to use your own project's namespace!
    {
        public class ContactsController : Controller   
        {
            [HttpGet("/contacts")]           
            public ViewResult contacts()
            {
                 return View();            
        }
    }
    }


