using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarParkManagementSystem.Data;

namespace CarParkManagementSystem.Data
{
    public class CarParkManagementSystemContext(DbContextOptions<CarParkManagementSystemContext> options) : IdentityDbContext<CarParkManagementSystemUser>(options)
    {

        public DbSet<CarParkManagementSystem.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.Location> Location { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.ParkingSlot> ParkingSlot { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.User> User { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.Vehicle> Vehicle { get; set; } = default!;
    }
}
