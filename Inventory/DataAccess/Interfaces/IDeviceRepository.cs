using Inventory.Domains.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.DataAccess.Interfaces
{
    public interface IDeviceRepository
    {
        Task<List<Device>> GetAll();
        Task<Device> GetById(int id);
        Task Insert(Device device);
        void Update(Device deviceToUpdate);
        void Delete(Device deviceToDelete);
        Task Save();
    }
}
