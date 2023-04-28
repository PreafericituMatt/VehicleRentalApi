using Microsoft.AspNetCore.Mvc;

namespace VehicleRentalApi.Controllers
{
    public class TruckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
