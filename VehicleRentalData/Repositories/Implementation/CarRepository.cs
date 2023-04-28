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
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _dbContext;
        public CarRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse<List<Car>>> GetAll()
        {
            return new ServiceResponse<List<Car>> 
            {
                Data = await _dbContext.Cars.ToListAsync()
            };
        }
    }
}
