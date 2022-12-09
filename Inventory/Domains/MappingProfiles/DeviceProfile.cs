using AutoMapper;
using Inventory.Domains.DTOs;
using Inventory.Domains.Entities;

namespace Inventory.Domains.MappingProfiles
{
    internal sealed class DeviceProfile: Profile
    {
        public DeviceProfile()
        {
            CreateMap<Device, DeviceDTO>();
            CreateMap<DeviceDTO, Device>();
        }
    }
}
