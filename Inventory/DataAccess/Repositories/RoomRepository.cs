using Inventory.DataAccess.Interfaces;
using Inventory.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.DataAccess.Repositories
{
    public class RoomRepository: IRoomRepository
    {
        public readonly InventoryContext _context;
        private readonly DbSet<Room> rooms;
        public RoomRepository(InventoryContext context)
        {
            _context = context;
            rooms = _context.Rooms;
        }
        public Task<List<Room>> GetAll()
        {
            return rooms.AsNoTracking().ToListAsync();
        }

        public Task<Room> GetById(int id)
        {
            return rooms.AsNoTracking().SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task Insert(Room room)
        {
            await _context.AddAsync(room);
        }

        public void Update(Room roomToUpdate)
        {
            if (_context.Entry(roomToUpdate).State == EntityState.Detached)
            {
                _context.Attach(roomToUpdate);
            }
            _context.Entry(roomToUpdate).State = EntityState.Modified;
        }

        public void Delete(Room roomToDelete)
        {
            if (_context.Entry(roomToDelete).State == EntityState.Detached)
            {
                _context.Attach(roomToDelete);
            }
            _context.Remove(roomToDelete);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
