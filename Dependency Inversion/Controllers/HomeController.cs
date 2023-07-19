using Dependency_Inversion.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Inversion.Controllers
{
    public class HomeController : Controller
    {
        private readonly Payment<Cash> _cash;
        private readonly Payment<Credit_Card> _creditcard;

        public HomeController(Payment<Cash> cash, Payment<Credit_Card> creditcard)
        {
            _cash = cash;
            _creditcard = creditcard;
        }

        public IActionResult Index()
        {

            TempData["cash"] = "Cash Status: " + _cash.Payment();
            TempData["creditcard"] = "Credit Card Status: " + _creditcard.Payment();
            return View();
        }
    }
}
