using Inventory.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Inventory.DataAccess
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Device>().HasData(
                new Device
                {
                    Id = 1,
                    Name = "RTX 2080",
                    Price = 1500,
                    ReleaseDate = new DateTime(2021, 10, 10),
                    ExpirationDate = new DateTime(2031, 10, 10),
                    RoomId = 1
                },
                new Device
                {
                    Id = 2,
                    Name = "Ball",
                    Price = 3,
                    ReleaseDate = new DateTime(2015, 5, 15),
                    ExpirationDate = new DateTime(2017, 3, 4),
                    RoomId = 3
                },
                new Device
                {
                    Id = 3,
                    Name = "Adidas Super Star",
                    Price = 300,
                    ReleaseDate = new DateTime(2020, 1, 1),
                    ExpirationDate = null,
                    RoomId = 2
                },
                new Device
                {
                    Id = 4,
                    Name = "Intel i9",
                    Price = 800,
                    ReleaseDate = new DateTime(2019, 7, 8),
                    ExpirationDate = new DateTime(2040, 5, 20),
                    RoomId = 1
                },
                new Device
                {
                    Id = 5,
                    Name = "Logitec G-102",
                    Price = 150,
                    ReleaseDate = new DateTime(2015, 1, 17),
                    ExpirationDate = new DateTime(2035, 1, 15),
                    RoomId = 1
                }
                );
            builder.Entity<Room>().HasData(
                new Room()
                {
                    Id = 1,
                    Name = "Computer devices",
                },
                new Room()
                {
                    Id = 2,
                    Name = "Clothes"
                },
                new Room()
                {
                    Id = 3,
                    Name = "Sport devices"
                }
                );
        }
    }
}
