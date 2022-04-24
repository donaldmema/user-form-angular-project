#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserFormAPI.Models;

namespace UserFormAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly UserFormContext _context;

        public TestController(UserFormContext context)
        {
            _context = context;
        }

        // GET: api/Test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserForm>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Test/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserForm>> GetUserForm(int id)
        {
            var userForm = await _context.Users.FindAsync(id);

            if (userForm == null)
            {
                return NotFound();
            }

            return userForm;
        }

        // PUT: api/Test/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserForm(int id, UserForm userForm)
        {
            if (id != userForm.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserFormExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Test
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserForm>> PostUserForm(UserForm userForm)
        {
            _context.Users.Add(userForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserForm", new { id = userForm.UserId }, userForm);
        }

        // DELETE: api/Test/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserForm(int id)
        {
            var userForm = await _context.Users.FindAsync(id);
            if (userForm == null)
            {
                return NotFound();
            }

            _context.Users.Remove(userForm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserFormExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
