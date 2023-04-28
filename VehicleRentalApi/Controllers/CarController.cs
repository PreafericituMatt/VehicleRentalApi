using Microsoft.AspNetCore.Mvc;

namespace VehicleRentalApi.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
