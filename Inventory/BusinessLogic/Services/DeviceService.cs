using Inventory.BusinessLogic.Interfaces;
using Inventory.DataAccess.Interfaces;
using Inventory.Domains.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.BusinessLogic.Services
{
    public class DeviceService: IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public async Task<IEnumerable<Device>> GetAll()
        {
            return await _deviceRepository.GetAll();
        }
    }
}
