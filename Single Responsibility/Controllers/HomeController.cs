using Microsoft.AspNetCore.Mvc;
using Single_Responsibility.Models;

namespace Single_Responsibility.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Car> cars = new List<Car>()
            {
            new Car() { Id=1, Name ="BMW", Model=2023 },
            new Car() { Id = 2, Name = "Mercedes", Model = 2020 },
            new Car() { Id = 3, Name = "Audi", Model = 2021 }
            };
            return View(cars);
        }
    }
}
