using VehicleRentalData.Entities;

namespace VehicleRentalData.Repositories.Interface
{
    public interface IVehicleRepository
    {
        public Task<ServiceResponse<List<Truck>>> GetAllTrucks();
        public Task<ServiceResponse<List<Car>>> GetAllCars();
        public Task<ServiceResponse<List<FuelConsumptionReport>>> GetAllReports();
        public void Caca(int vId, int mil, string name, bool isCar);
    }
}
