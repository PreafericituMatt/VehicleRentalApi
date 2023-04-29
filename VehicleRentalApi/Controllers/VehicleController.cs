using Microsoft.AspNetCore.Mvc;
using VehicleRentalData.Entities;
using VehicleRentalData;
using VehicleRentalData.Repositories.Interface;

namespace VehicleRentalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet("GetAllTrucks")]
        public async Task<ActionResult<ServiceResponse<List<Truck>>>> GetAllTrucks()
        {
            return Ok(await _vehicleRepository.GetAllTrucks());
        }

        [HttpGet("GetAllCars")]
        public async Task<ActionResult<ServiceResponse<List<Car>>>> GetAllCars()
        {
            return Ok(await _vehicleRepository.GetAllCars());
        }

     //   [HttpPost("GenerateReport")]
     //   public async Task<ActionResult<ServiceResponse<FuelConsumptionReport>>> GenerateReport()
     //   {
      //      re
      //  }

    }
}
