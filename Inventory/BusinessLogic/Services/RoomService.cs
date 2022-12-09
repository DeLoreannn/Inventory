using AutoMapper;
using Inventory.BusinessLogic.Interfaces;
using Inventory.DataAccess.Interfaces;
using Inventory.Domains.DTOs;
using Inventory.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Inventory.BusinessLogic.Services
{
    public class RoomService: IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _roomRepository.GetAll();
        }

        public async Task<Room> GetById(int id)
        {
            return await _roomRepository.GetById(id);
        }

        public async Task<bool> CreateRoom(RoomDTO roomDTO)
        {
            try
            {
                var room = _mapper.Map<Room>(roomDTO);
                await _roomRepository.Insert(room);
                await _roomRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateRoom(int id, RoomDTO roomDTO)
        {
            var room = await _roomRepository.GetById(id);
            if (room != null)
            {
                _mapper.Map<RoomDTO, Room>(roomDTO, room);
                _roomRepository.Update(room);
                await _roomRepository.Save();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteRoom(int id)
        {
            var room = await _roomRepository.GetById(id);
            if (room != null)
            {
                _roomRepository.Delete(room);
                await _roomRepository.Save();
                return true;
            }
            return false;
        }
    }
}
