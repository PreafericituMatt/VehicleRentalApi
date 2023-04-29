using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalData.Entities;

namespace VehicleRentalData.Repositories.Interface
{
    public interface IVehicleRepository
    {
        public Task<ServiceResponse<List<Truck>>> GetAllTrucks();
        public Task<ServiceResponse<List<Car>>> GetAllCars();
        public Task<FuelConsumptionReport> GenerateReport(int vehicleId, int currentMileage, string customerName);
        public void Caca(int vId, int mil, string name);
    }
}
