using System;

namespace Inventory.Domains.Entities
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public bool IsInUse { get; set; }
    }
}
