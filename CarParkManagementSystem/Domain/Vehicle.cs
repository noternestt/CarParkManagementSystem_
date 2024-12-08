using System.ComponentModel.DataAnnotations;

namespace CarParkManagementSystem.Domain
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }
        public string? LicensePlate { get; set; }
        public string? VehicleType { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public int UserID { get; set; }
    }
}
