using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Management.Domain;
using Project.Management.Domain.Entities;

namespace Project.Management.Api.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UsersController : ControllerBase
    {
        private readonly ProjectManagementWebContext _context;

        public UsersController(ProjectManagementWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllUsers))]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Users>>> GetAllUsers2()
        //{
        //    var users = await _context.Users.ToListAsync();
        //    return users;
        //}

        [HttpPost(nameof(AddUsers))]
        public async Task<IActionResult> AddUsers(Users users)
        {
            _context.Users.Add(users);
            await _context.SaveChangesAsync();
            return Ok(users);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, Users updatedUser)
        {
            if (id != updatedUser.Id) 
            {
                return BadRequest("El ID del usuario no coincide.");
            }

            _context.Entry(updatedUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(updatedUser);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(u => u.Id == id))
                {
                    return NotFound("Usuario no encontrado.");
                }
                else
                {
                    throw;
                }
            }
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok("Usuario eliminado correctamente.");
        }


    }


}
