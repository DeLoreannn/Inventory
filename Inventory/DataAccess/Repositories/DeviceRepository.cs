using Inventory.DataAccess.Interfaces;
using Inventory.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.DataAccess.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        public readonly InventoryContext _context;
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

        public Task<Device> GetById(int id)
        {
            return devices.AsNoTracking().SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task Insert(Device device)
        {
            await _context.AddAsync(device);
        }

        public void Update(Device deviceToUpdate)
        {
            if (_context.Entry(deviceToUpdate).State == EntityState.Detached)
            {
                _context.Attach(deviceToUpdate);
            }
            _context.Entry(deviceToUpdate).State = EntityState.Modified;
        }

        public void Delete(Device deviceToDelete)
        {
            if (_context.Entry(deviceToDelete).State == EntityState.Detached)
            {
                _context.Attach(deviceToDelete);
            }
            _context.Remove(deviceToDelete);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
