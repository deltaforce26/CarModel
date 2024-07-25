using CarModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarModel.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Model(string year, string name)
        {
            Car car = new Car
            {

                Name = string.IsNullOrEmpty(name) ? "No model" : name,
                Year = string.IsNullOrEmpty(year) ? "N/A" : year
            };
            return View(car);
        }
        
    }
}
