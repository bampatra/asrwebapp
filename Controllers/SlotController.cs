using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASRWebApp.Models;

namespace ASRWebApp.Controllers
{
    public class SlotController : Controller
    {
        private readonly AsrContext _context;

        public SlotController(AsrContext context)
        {
            _context = context;
        }


        // GET: Slot
        public async Task<IActionResult> Index()
        {
            var asrContext = _context.Slot.Include(s => s.Room).Include(s => s.Staff).Include(s => s.Student);

            return View(await asrContext.ToListAsync());
        }

        // GET: Slot/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slot
                .Include(s => s.Room)
                .Include(s => s.Staff)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // GET: Slot/Create
        public IActionResult Create()
        {
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID");
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID");
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID");
            return View();
        }

        // POST: Slot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomID,StartTime,StaffID,StudentID")] Slot slot)
        {
            if (ModelState.IsValid)
            {
                if (CheckMaxSlot(slot.StartTime, slot.StaffID, slot.RoomID) == true)
                {
                    _context.Add(slot);
                    await _context.SaveChangesAsync();
                    ViewData["Message"] = "A new slot is created!";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewData["ErrorMessage"] = "Unable to create slot";
                }
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID", slot.StudentID);
            return View(slot);
        }

        // GET: Slot/Edit/5
        public async Task<IActionResult> Edit(string roomID, DateTime time)
        {
            if (roomID == null && time == null)
            {
                return NotFound();
            }

            var slot = await _context.Slot.FindAsync(roomID, time);
            if (slot == null)
            {
                return NotFound();
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID", slot.StudentID);
            return View(slot);
        }

        // POST: Slot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RoomID,StartTime,StaffID,StudentID")] Slot slot)
        {
            if (id != slot.RoomID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlotExists(slot.RoomID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "RoomID", "RoomID", slot.RoomID);
            ViewData["StaffID"] = new SelectList(_context.Staff, "StaffID", "StaffID", slot.StaffID);
            ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID", slot.StudentID);
            return View(slot);
        }

        // GET: Slot/Delete/5
        public async Task<IActionResult> Delete(string roomID, DateTime time)
        {
            if (roomID == null || time == null)
            {
                return NotFound();
            }

            var slot = await _context.Slot
                .Include(s => s.Room)
                .Include(s => s.Staff)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.RoomID == roomID && m.StartTime == time);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // POST: Slot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string RoomID, DateTime StartTime)
        { 
            var slot = await _context.Slot.FindAsync(RoomID, StartTime);

            if (slot.StudentID == null)
            {
                _context.Slot.Remove(slot);
                await _context.SaveChangesAsync();
                ViewData["Message"] = "Slot is successfully removed";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["ErrorMessage"] = "Unable to delete slot";
                slot = await _context.Slot
                .Include(s => s.Room)
                .Include(s => s.Staff)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.RoomID == RoomID && m.StartTime == StartTime);
                return View(slot);
            }

        }

        private bool SlotExists(string id)
        {
            return _context.Slot.Any(e => e.RoomID == id);
        }

        public bool CheckMaxSlot(DateTime date, string StaffID, string RoomID)
        {
            int countStaffBookings = 0;
            int countRoomBookings = 0;

            foreach (var x in _context.Slot)
            {
                // THIS DATE DOES NOT START FROM 12:00AM
                if(date.Date <= x.StartTime && x.StartTime <= date.Date.AddHours(23).AddMinutes(59).AddSeconds(59) && x.StaffID == StaffID)
                {
                    countStaffBookings += 1;
                }

                if (date.Date <= x.StartTime && x.StartTime <= date.Date.AddHours(23).AddMinutes(59).AddSeconds(59) && x.RoomID == RoomID)
                {
                    countRoomBookings += 1;
                }
            }

            if (countStaffBookings < 4 && countRoomBookings < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
