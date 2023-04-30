using Microsoft.EntityFrameworkCore;
using VehicleRentalData.Entities;

namespace VehicleRentalData
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<FuelConsumptionReport> FuelConsumptionReports { get; set; }
    }
}
