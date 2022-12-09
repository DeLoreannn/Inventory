using AutoMapper;
using Inventory.BusinessLogic.Interfaces;
using Inventory.DataAccess.Interfaces;
using Inventory.Domains.DTOs;
using Inventory.Domains.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.BusinessLogic.Services
{
    public class DeviceService: IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IMapper _mapper;

        public DeviceService(IDeviceRepository deviceRepository, IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Device>> GetAll()
        {
            return await _deviceRepository.GetAll();
        }

        public async Task<Device> GetById(int id)
        {
            return await _deviceRepository.GetById(id);
        }

        public async Task<bool> CreateDevice(DeviceDTO deviceDTO)
        {
            try
            {
                var device = _mapper.Map<Device>(deviceDTO);
                await _deviceRepository.Insert(device);
                await _deviceRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateDevice(int id, DeviceDTO deviceDTO)
        {
            var device = await _deviceRepository.GetById(id);
            if (device != null)
            {
                _mapper.Map<DeviceDTO, Device>(deviceDTO, device);
                _deviceRepository.Update(device);
                await _deviceRepository.Save();
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteDevice(int id)
        {
            var device = await _deviceRepository.GetById(id);
            if (device != null)
            {
                _deviceRepository.Delete(device);
                await _deviceRepository.Save();
                return true;
            }
            return false;
        }

        public async Task<bool> UseDevice(int id)
        {
            var device = await _deviceRepository.GetById(id);
            if (device != null)
            {
                device.IsInUse = true;
                _deviceRepository.Update(device);
                await _deviceRepository.Save();
                return true;
            }
            return false;
        }
    }
}
