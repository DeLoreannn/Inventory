using Inventory.BusinessLogic.Interfaces;
using Inventory.Domains.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController: ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRooms()
        {
            var rooms = await _roomService.GetAll();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomById(int id)
        {
            var room = await _roomService.GetById(id);
            if (room != null)
                return Ok(room);
            else
                return NotFound($"Not found room with id {id}");
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(RoomDTO roomDTO)
        {
            var created = await _roomService.CreateRoom(roomDTO);
            if (created)
                return Ok(created);
            else
                return BadRequest("Room has not been created.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(int id, RoomDTO roomDTO)
        {
            var updated = await _roomService.UpdateRoom(id, roomDTO);
            if (updated)
                return Ok(updated);
            else
                return NotFound($"Not found room with id {id}");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var deleted = await _roomService.DeleteRoom(id);
            if (deleted)
                return Ok(deleted);
            else
                return NotFound($"Not found room with id {id}");
        }
    }
}
