using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my index!";
        }
        
        [HttpGet]
        [Route("Contact/{name}")]
        public string Index(string name)
        {
            return $"Yo Dis {name}, Dis my contact page. DOjhfihsdiopifpisd fkasdgasgaskgh NOT contact me, B*TCH!!";
        }
        [HttpGet]
        [Route("projects")]
        public string projects()
        {
            return $"These are my mothereffin projects, B*tch";
        }

    }
}