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

        public void Caca(int vId, int mil, string name, bool isCar)
        {
            FuelConsumptionReport report = new();

            if (isCar)
            {
                var verify = _dbContext.Cars.Where(c => c.Id == vId).FirstOrDefaultAsync();
                
                if (verify != null)
                {
                    report.CurrentMileage = mil;
                    report.VehicleCar = true;
                    report.VehicleId = vId;
                    report.CustomerName = name;
                    report.LitersOfFuelConsumed =((mil-verify.Result.Mileage)% verify.Result.FuelConsumption);
                    report.DaysRented = 7;
                    

                    _dbContext.FuelConsumptionReports.AddAsync(report);
                    _dbContext.SaveChanges();
                }
            }
            else
            {
                var verify = _dbContext.Trucks.Where(c => c.Id == vId).FirstOrDefaultAsync();

                if (verify != null)
                {
                    report.CurrentMileage = mil;
                    report.VehicleCar = false;
                    report.VehicleId = vId;
                    report.CustomerName = name;
                    report.LitersOfFuelConsumed = ((mil - verify.Result.Mileage) % verify.Result.FuelConsumption);
                    report.DaysRented = 7;

                    _dbContext.FuelConsumptionReports.AddAsync(report);
                    _dbContext.SaveChanges();
                }
            }
        }     

        public async Task<ServiceResponse<List<Car>>> GetAllCars()
        {
            return new ServiceResponse<List<Car>>
            {
                Data = await _dbContext.Cars.ToListAsync()
            };
        }

        public async Task<ServiceResponse<List<FuelConsumptionReport>>> GetAllReports()
        {
            return new ServiceResponse<List<FuelConsumptionReport>>
            {
                Data = await _dbContext.FuelConsumptionReports.ToListAsync()
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
