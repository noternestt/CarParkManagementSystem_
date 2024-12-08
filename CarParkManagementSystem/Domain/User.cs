using System.ComponentModel.DataAnnotations;

namespace CarParkManagementSystem.Domain
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
