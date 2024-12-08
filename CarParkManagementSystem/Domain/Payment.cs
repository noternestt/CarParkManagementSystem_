using System.ComponentModel.DataAnnotations;

namespace CarParkManagementSystem.Domain
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public double Amount { get; set; }
        public int CardNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? PaymentStatus { get; set; }
        public string? BookingID { get; set; }
    }
}
