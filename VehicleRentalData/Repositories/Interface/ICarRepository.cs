using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalData.Entities;

namespace VehicleRentalData.Repositories.Interface
{
    public interface ICarRepository
    {
       public Task<ServiceResponse<List<Car>>> GetAll();
    }
}
