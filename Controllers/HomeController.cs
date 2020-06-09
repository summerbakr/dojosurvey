using Form.Models;
using Microsoft.AspNetCore.Mvc;
    namespace Form.Controllers     //be sure to use your own project's namespace!
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
            
            
            [HttpPost]
            [Route("submit")]

            public IActionResult FormResult(Survey yoursurvey)
            {   
                ViewBag.Survey=yoursurvey;
                ;

                return View();
            }

    

        }
    }