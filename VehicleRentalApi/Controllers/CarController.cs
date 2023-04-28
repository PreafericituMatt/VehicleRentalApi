using Microsoft.AspNetCore.Mvc;
using VehicleRentalData;
using VehicleRentalData.Entities;
using VehicleRentalData.Repositories.Interface;

namespace VehicleRentalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Car>>>> GetAll()
        {
            return Ok(await _carRepository.GetAll());
        }
    }
}
