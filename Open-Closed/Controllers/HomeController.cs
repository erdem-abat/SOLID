using Microsoft.AspNetCore.Mvc;
using Open_Closed.Data;
using System.Data;

namespace Open_Closed.Controllers
{
    public class HomeController : Controller
    {

        private readonly Deci<Envelope> _envelope;
        private readonly Deci<Package> _package;

        public HomeController(Deci<Envelope> envelope, Deci<Package> package)
        {
            _envelope = envelope;
            _package = package;
        }
        public IActionResult Index()
        {
            int a = _envelope.CalculateDeci();
            int b = _package.CalculateDeci();
            TempData["Deci"] = a+"  "+b;
            return View();
        }
    }
}
