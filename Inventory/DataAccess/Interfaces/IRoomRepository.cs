using Inventory.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.DataAccess.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetAll();
        Task<Room> GetById(int id);
        Task Insert(Room room);
        void Update(Room roomToUpdate);
        void Delete(Room roomToDelete);
        Task Save();
    }
}
