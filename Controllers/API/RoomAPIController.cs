using System.Collections.Generic;
using System.Threading.Tasks;
using ASRWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASRWebApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly AsrContext _context;

        public RoomController(AsrContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            return await _context.Room.ToListAsync();
        }

        // GET: api/<controller>/<id>
        [HttpGet("{roomID}")]
        public async Task<ActionResult<Room>> GetRoomItem(string roomID)
        {
            var roomItem = await _context.Room.FindAsync(roomID);

            if (roomItem == null)
            {
                return NotFound();
            }

            return roomItem;
        }

        // POST: api/<controller>
        [HttpPost]
        public async Task<ActionResult<Room>> CreateRoom(Room item)
        {
            _context.Room.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Room), new { id = item.RoomID }, item);
        }

        // PUT: api/<controller>/<id>
        [HttpPut("{roomID}")]
        public async Task<IActionResult> PutRoomItem(string roomID, Room item)
        {
            if (roomID != item.RoomID)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/<controller>/<id>
        [HttpDelete("{roomID}")]
        public async Task<IActionResult> DeleteRoomItem(string roomID)
        {
            var todoItem = await _context.Room.FindAsync(roomID);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Room.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
