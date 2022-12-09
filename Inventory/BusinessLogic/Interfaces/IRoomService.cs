using Inventory.Domains.DTOs;
using Inventory.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.BusinessLogic.Interfaces
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> GetById(int id);
        Task<bool> CreateRoom(RoomDTO room);
        Task<bool> UpdateRoom(int id, RoomDTO room);
        Task<bool> DeleteRoom(int id);
    }
}
