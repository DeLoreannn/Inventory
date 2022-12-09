using Inventory.Domains.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.DataAccess.Interfaces
{
    public interface IDeviceRepository
    {
        Task<List<Device>> GetAll();
    }
}
