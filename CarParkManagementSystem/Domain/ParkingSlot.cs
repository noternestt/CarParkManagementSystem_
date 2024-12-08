using System.ComponentModel.DataAnnotations;

namespace CarParkManagementSystem.Domain
{
    public class ParkingSlot
    {
        [Key]
        public int SlotID { get; set; }
        public string SlotNumber { get; set; }
        public Boolean InAvaliable { get; set; }
        public int FloorLevel { get; set; }
        public string? LocationName { get; set; }
    }
}
