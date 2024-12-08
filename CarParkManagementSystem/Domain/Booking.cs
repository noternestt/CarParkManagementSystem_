using System.ComponentModel.DataAnnotations;

namespace CarParkManagementSystem.Domain
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public int UserID { get; set; }
        public int SlotID { get; set; }
        public int VehicleID { get; set; }
    }
}
