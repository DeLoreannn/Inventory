using Inventory.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.BusinessLogic.Interfaces
{
    public interface IDeviceService
    {
        Task<IEnumerable<Device>> GetAll();
    }
}
