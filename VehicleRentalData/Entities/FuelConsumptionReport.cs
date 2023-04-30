using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace VehicleRentalData.Entities
{
    public class FuelConsumptionReport
    {
        [Key]
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public int VehicleId { get; set; }
        public bool VehicleCar { get; set; }
        public int CurrentMileage { get; set; }
        public int LitersOfFuelConsumed { get; set; }
        public int DaysRented { get; set; }
    }
}
