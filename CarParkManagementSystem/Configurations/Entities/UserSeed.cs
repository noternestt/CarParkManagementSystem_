﻿using CarParkManagementSystem.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarParkManagementSystem.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<CarParkManagementSystemUser>
    {
        public void Configure(EntityTypeBuilder<CarParkManagementSystemUser> builder)
        {
            var hasher = new PasswordHasher<CarParkManagementSystemUser>();
            builder.HasData(
            new CarParkManagementSystemUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}