using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASRWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASRWebApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private readonly AsrContext _context;

        public SlotController(AsrContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slot>>> GetSlots()
        {
            return await _context.Slot.ToListAsync();
        }

        // GET: /<controller>/
        [HttpGet("byStaff/{staffID}")]
        public async Task<ActionResult<IEnumerable<Slot>>> GetSlotsByStaff(string staffID)
        {
            return await _context.Slot.Where(m => m.StaffID == staffID).ToListAsync();
        }

        // GET: /<controller>/
        [HttpGet("byStudent/{studentID}")]
        public async Task<ActionResult<IEnumerable<Slot>>> GetSlotsByStudent(string studentID)
        {
            return await _context.Slot.Where(m => m.StudentID == studentID).ToListAsync();
        }

        // GET: api/<controller>/<id>
        [HttpGet("{roomID}/{time}")]
        public async Task<ActionResult<Slot>> GetSlotItem(string roomID, DateTime time)
        {
            var slotItem = await _context.Slot.FindAsync(roomID, time);

            if (slotItem == null)
            {
                return NotFound();
            }

            return slotItem;
        }

        // POST: api/<controller>
        [HttpPost]
        public async Task<ActionResult<Slot>> CreateSlot(Slot item)
        {
            _context.Slot.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Slot), new { item.RoomID, item.StartTime, item.StaffID, item.StudentID });
        }

        // PUT: api/<controller>/<id>
        [HttpPut("{roomID}/{time}")]
        public async Task<IActionResult> PutSlotItem(string roomID, DateTime time, Slot item)
        {
            if (roomID != item.RoomID && time != item.StartTime)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/<controller>/<id>
        [HttpDelete("{roomID}/{time}")]
        public async Task<IActionResult> DeleteSlotItem(string roomID, DateTime time)
        {
            var slotItem = await _context.Slot.FindAsync(roomID, time);

            if (slotItem == null)
            {
                return NotFound();
            }

            _context.Slot.Remove(slotItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
