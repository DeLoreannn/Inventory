using Inventory.BusinessLogic.Interfaces;
using Inventory.Domains.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController: ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDevices()
        {
            var devices = await _deviceService.GetAll();
            return Ok(devices);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeviceById(int id)
        {
            var device = await _deviceService.GetById(id);
            if (device != null)
                return Ok(device);
            else
                return NotFound($"Not found device with id {id}");
        }

        [HttpPost]
        public async Task<IActionResult> CreateDevice(DeviceDTO deviceDTO)
        {
            var created = await _deviceService.CreateDevice(deviceDTO);
            if (created)
                return Ok(created);
            else
                return BadRequest("Device has not been created.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDevice(int id, DeviceDTO deviceDTO)
        {
            var updated = await _deviceService.UpdateDevice(id, deviceDTO);
            if (updated)
                return Ok(updated);
            else
                return NotFound($"Not found device with id {id}");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoute(int id)
        {
            var deleted = await _deviceService.DeleteDevice(id);
            if (deleted)
                return Ok(deleted);
            else
                return NotFound($"Not found device with id {id}");
        }

        [HttpPut("usedevice/{id}")]
        public async Task<IActionResult> UseDevice(int id)
        {
            var used = await _deviceService.UseDevice(id);
            if (used)
                return Ok(used);
            else
                return BadRequest("Device can not be used");
        }
    }
}
