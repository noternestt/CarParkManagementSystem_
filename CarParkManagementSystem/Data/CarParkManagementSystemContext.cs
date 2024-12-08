using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarParkManagementSystem.Domain;

namespace CarParkManagementSystem.Data
{
    public class CarParkManagementSystemContext : DbContext
    {
        public CarParkManagementSystemContext (DbContextOptions<CarParkManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<CarParkManagementSystem.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.Location> Location { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.ParkingSlot> ParkingSlot { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.User> User { get; set; } = default!;
        public DbSet<CarParkManagementSystem.Domain.Vehicle> Vehicle { get; set; } = default!;
    }
}
