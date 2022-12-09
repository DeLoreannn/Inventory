using Inventory.DataAccess.Interfaces;
using Inventory.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.DataAccess.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly InventoryContext _context;
        private readonly DbSet<Device> devices;
        public DeviceRepository(InventoryContext context)
        {
            _context = context;
            devices = _context.Devices;
        }
        public Task<List<Device>> GetAll()
        {
            return devices.AsNoTracking().ToListAsync();
        }
    }
}
