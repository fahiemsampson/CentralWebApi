using CentralWebApi.Data;
using CentralWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CentralWebApi.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ComplaintsController : ControllerBase
    {
        private readonly CentralWebApiContext _context;
        public ComplaintsController(CentralWebApiContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetComplaints")]
        public async Task<IEnumerable<Complaint>> Get()
        {
            // loading async to prevent blocking while DB operations occur
            var test = await _context.Complaint.ToListAsync();
            return await _context.Complaint.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Complaint>> PostComplaint(Complaint complaint)
        {
            //set created at date
            complaint.CreatedDate = DateTime.UtcNow;

            _context.Complaint.Add(complaint);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComplaint), new { id = complaint.Id }, complaint);
        }

        // This is an example GET method for retrieving a complaint by id
        // GET api/complaint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Complaint>> GetComplaint(int id)
        {
            var complaint = await _context.Complaint.FindAsync(id);

            if (complaint == null)
            {
                return NotFound();
            }
            return complaint;
        }
    }
}
