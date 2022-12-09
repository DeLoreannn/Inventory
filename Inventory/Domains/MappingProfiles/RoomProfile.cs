using AutoMapper;
using Inventory.Domains.DTOs;
using Inventory.Domains.Entities;

namespace Inventory.Domains.MappingProfiles
{
    internal sealed class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomDTO>();
            CreateMap<RoomDTO, Room>();
        }
    }
}
