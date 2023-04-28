using Microsoft.AspNetCore.Mvc;
using VehicleRentalData.Entities;
using VehicleRentalData.Repositories.Interface;
using VehicleRentalData;

namespace VehicleRentalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TruckController : Controller
    {
        private readonly ITruckRepository _truckRepository;
        public TruckController(ITruckRepository truckRepository)
        {
            _truckRepository= truckRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Truck>>>> GetAll()
        {
            return Ok(await _truckRepository.GetAll());
        }
    }
}
