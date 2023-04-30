using System.ComponentModel.DataAnnotations;

namespace VehicleRentalData.Entities
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public int EnginePower { get; set; }
        public int TransportCapacity { get; set; }
        public string? RequiredDriverLicense { get; set; }
        public int FuelConsumption { get; set; }
        public int Mileage { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
