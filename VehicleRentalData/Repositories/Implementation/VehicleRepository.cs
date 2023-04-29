using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalData.Entities;
using VehicleRentalData.Repositories.Interface;

namespace VehicleRentalData.Repositories.Implementation
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _dbContext;
        private readonly IMapper _mapper;
        public VehicleRepository(DataContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Caca(int vId, int mil, string name)
        {
            throw new NotImplementedException();
        }

        public Task<FuelConsumptionReport> GenerateReport(int vehicleId, int currentMileage, string customerName)
        {
           
              throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Car>>> GetAllCars()
        {
            return new ServiceResponse<List<Car>>
            {
                Data = await _dbContext.Cars.ToListAsync()
            };
        }

        public async Task<ServiceResponse<List<Truck>>> GetAllTrucks()
        {
            return new ServiceResponse<List<Truck>>
            {
                Data = await _dbContext.Trucks.ToListAsync()
            };
        }


    }
}
