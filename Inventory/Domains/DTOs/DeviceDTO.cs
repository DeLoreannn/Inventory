using Inventory.Domains.Entities;
using System;

namespace Inventory.Domains.DTOs
{
    public class DeviceDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int RoomId { get; set; }
    }
}
