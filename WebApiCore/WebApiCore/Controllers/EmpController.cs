using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCore.EDM;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly CompanyContext _context;

        public EmpController(CompanyContext context)
        {
            _context = context;
        }

        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tblemployee>>> GetTblemployees()
        {
            return await _context.Tblemployees.ToListAsync();
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tblemployee>> GetTblemployee(int id)
        {
            var tblemployee = await _context.Tblemployees.FindAsync(id);

            if (tblemployee == null)
            {
                return NotFound();
            }

            return tblemployee;
        }

        // PUT: api/Emp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblemployee(int id, Tblemployee tblemployee)
        {
            if (id != tblemployee.EmpId)
            {
                return BadRequest();
            }

            //_context.Entry(tblemployee).State = EntityState.Modified;
            _context.Tblemployees.Update(tblemployee);
            await _context.SaveChangesAsync();

            return Ok("Record Updated.");
        }

        // POST: api/Emp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tblemployee>> PostTblemployee(Tblemployee tblemployee)
        {
            _context.Tblemployees.Add(tblemployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblemployee", new { id = tblemployee.EmpId }, tblemployee);
        }

        // DELETE: api/Emp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblemployee(int id)
        {
            var tblemployee = await _context.Tblemployees.FindAsync(id);
            if (tblemployee == null)
            {
                return NotFound();
            }

            _context.Tblemployees.Remove(tblemployee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblemployeeExists(int id)
        {
            return _context.Tblemployees.Any(e => e.EmpId == id);
        }
    }
}
