using Liskov_Substitution.Data;
using Microsoft.AspNetCore.Mvc;

namespace Liskov_Substitution.Controllers
{
    public class HomeController : Controller
    {

        private readonly Computer<Apple> _apple;
        private readonly Computer<Monster> _monster;

        public HomeController(Computer<Apple> apple, Computer<Monster> monster)
        {
            _apple = apple;
            _monster = monster;
        }
        public IActionResult Index()
        {
            Apple apple = new Apple();
            Monster monster = new Monster();
            TempData["apple"] = _apple.GetName() + "  " + apple.BatteryCapacity();
            TempData["monster"] = _monster.GetName() + "  " + monster.Cost();
            return   View();
        }
    }
}

