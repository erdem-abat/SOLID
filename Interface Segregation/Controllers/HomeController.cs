using Interface_Segregation.Data;
using Microsoft.AspNetCore.Mvc;

namespace Interface_Segregation.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Robot1 robot1 = new Robot1();
            robot1.Walk();
            robot1.Run();
            Robot2 robot2 = new Robot2();
            robot2.Walk();
            robot2.Carry();
            return View();
        }
    }
}
