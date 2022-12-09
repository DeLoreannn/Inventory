using Inventory.Domains.DTOs;
using Inventory.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.BusinessLogic.Interfaces
{
    public interface IDeviceService
    {
        Task<IEnumerable<Device>> GetAll();
        Task<Device> GetById(int id);
        Task<bool> CreateDevice(DeviceDTO device);
        Task<bool> UpdateDevice(int id, DeviceDTO device);
        Task<bool> DeleteDevice(int id);
        Task<bool> UseDevice(int id);
    }
}
