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
    public class TruckRepository : ITruckRepository
    {
        private readonly DataContext _dbContext;
        public TruckRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse<List<Truck>>> GetAll()
        {
            return new ServiceResponse<List<Truck>>
            {
                Data = await _dbContext.Trucks.ToListAsync()
            };
        }
    }
}
