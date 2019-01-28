using System.Collections.Generic;
using System.Threading.Tasks;
using ASRWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASRWebApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AsrContext _context;

        public StudentController(AsrContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Student.ToListAsync();
        }

        // GET: api/<controller>/<id>
        [HttpGet("{studentID}")]
        public async Task<ActionResult<Student>> GetStudentItem(string studentID)
        {
            var studentItem = await _context.Student.FindAsync(studentID);

            if (studentItem == null)
            {
                return NotFound();
            }

            return studentItem;
        }
    }
}
