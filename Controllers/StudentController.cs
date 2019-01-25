using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASRWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using ASRWebApp.Data;
using System.Security.Principal;
using System.Security.Claims;

namespace ASRWebApp.Controllers
{

    public class StudentController : Controller
    {
        private readonly AsrContext _context;

        public StudentController(AsrContext context)
        {
            _context = context;
        }

        // GET: Student/Home
        [Authorize(Roles = Constants.StudentRole)]
        public IActionResult Home()
        {
            return View();
        }

        // GET: Student
        [Authorize(Roles = Constants.StaffRole)]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,Name,Email")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StudentID,Name,Email")] Student student)
        {
            if (id != student.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentID))
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
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.StudentID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.StudentID == id);
        }

        // GET: Student/MyBookings
        [Authorize(Roles = Constants.StudentRole)]
        public async Task<IActionResult> MyBookings(string roomID, DateTime time, string studentID)
        {
            var slot = await _context.Slot.FindAsync(roomID, time);
            var asrContext = await _context.Slot.Include(s => s.Room).Include(s => s.Staff).Include(s => s.Student).ToListAsync();

            if (slot!= null)
            {
                slot.StudentID = studentID;
                _context.Slot.Update(slot);
                await _context.SaveChangesAsync();
                ViewData["SuccessMessage"] = "Your booking has been cancelled";
            }

            return View(asrContext);
        }

        // GET: Student/Booking
        [Authorize(Roles = Constants.StudentRole)]
        public async Task<IActionResult> Booking(string roomID, DateTime time, string studentID, DateTime searchTime, string staffID)
        {
            var viewModel = new SlotAndStaff();
            var slot = await _context.Slot.FindAsync(roomID, time);
            var asrContext = await _context.Slot.Include(s => s.Room).Include(s => s.Staff).Include(s => s.Student).ToListAsync();

            viewModel.Slots = asrContext;
            viewModel.Staffs = await _context.Staff.ToListAsync();

            if (slot != null)
            {
                if (CheckMaxBooking(time, studentID, roomID) == true)
                {
                    slot.StudentID = studentID;
                    _context.Slot.Update(slot);
                    if (studentID != null)
                    {
                        ViewData["SuccessMessage"] = "Slot is successfully booked!";
                    }
                    else
                    {
                        ViewData["SuccessMessage"] = "Your booking has been cancelled";
                    }
                    await _context.SaveChangesAsync();
                }
                else
                {
                    ViewData["ErrorMessage"] = "Unable to book slot. Maximum booking limit has been reached.";
                }
            }

            if (searchTime != DateTime.MinValue)
            {
                ViewData["FromDate"] = searchTime;
                ViewData["ToDate"] = searchTime.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            ViewData["StaffID"] = staffID;

            return View(viewModel);
        }

        // Checks if a slot exists or not
        private bool SlotExists(string id)
        {
            return _context.Slot.Any(e => e.RoomID == id);
        }

        // Checks the maximum booking
        private bool CheckMaxBooking(DateTime date, string studentID, string roomID)
        {
            int countStudentBookings = 0;
            foreach (var x in _context.Slot)
            {
                if (date.Date <= x.StartTime && x.StartTime <= date.Date.AddHours(23).AddMinutes(59).AddSeconds(59))
                {
                    if (x.StudentID == studentID && x.StudentID != null) { countStudentBookings += 1; }
                }
            }

            if (countStudentBookings < 1){return true;}
            else {return false;}
        }

    }

}
