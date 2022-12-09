using Inventory.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DataAccess
{
    public class InventoryContext: DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public InventoryContext()
        {
        }

        public InventoryContext(DbContextOptions<InventoryContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
        }
    }
}
