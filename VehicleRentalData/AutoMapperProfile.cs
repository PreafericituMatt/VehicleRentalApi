using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalData.Entities;

namespace VehicleRentalData
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ServiceResponse<FuelConsumptionReport>,ServiceResponse<FuelConsumptionReport>>();
        }
    }
}
