using DentalClinic.Domain;
using DentalClinic.Domain.Entities;
using DentalClinic.Api.Dto;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Azure.Core;


namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DentistController : ControllerBase
    {
        private readonly DentalClinicWebContext _context;

        public DentistController(DentalClinicWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllDentist))]
        public async Task<IActionResult> GetAllDentist()
        {
            var dentists = await _context.Dentist.ToListAsync();
            return Ok(dentists);
        }

        [HttpGet("GetDentist/{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var dentists = await _context.Dentist.FindAsync(id);
            if (dentists == null)
            {
                return NotFound("Medico no encontrado.");
            }
            return Ok(dentists);
        }

        [HttpPost(nameof(AddDentist))]
        public async Task<IActionResult> AddDentist(DentistDto request)
        {
            var dbDentist = new Dentist();

            dbDentist.Id = request.Id;
            dbDentist.Nombre = request.Nombre;
            dbDentist.Apellido = request.Apellido;
            dbDentist.Especialidad = request.Especialidad;
            dbDentist.Telefono = request.Telefono;
            dbDentist.CorreoElectronico = request.CorreoElectronico;


            _context.Dentist.Add(dbDentist);
            await _context.SaveChangesAsync();


            return Ok(request);
        }


        [HttpPut("EditDentist/{id}")]
        public async Task<IActionResult> UpdateDentist(int id, DentistDto updateRequest)
        {
            var existingDentist = await _context.Dentist.FindAsync(id);
            if (existingDentist == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            existingDentist.Id = updateRequest.Id;
            existingDentist.Nombre = updateRequest.Nombre;
            existingDentist.Apellido = updateRequest.Apellido;
            existingDentist.Especialidad = updateRequest.Especialidad;
            existingDentist.Telefono = updateRequest.Telefono;
            existingDentist.CorreoElectronico = updateRequest.CorreoElectronico;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingDentist);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar el usuario.");
            }
        }

        [HttpDelete("DeleteDentist/{id}")]
        public async Task<IActionResult> DeleteDentist(int id)
        {
            var dentist = await _context.Dentist.FindAsync(id);
            if (dentist == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            try
            {
                _context.Dentist.Remove(dentist);
                await _context.SaveChangesAsync();
                return Ok("Usuario eliminado correctamente.");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest("No se puede eliminar el usuario porque tiene datos relacionados.");
            }
        }
    }
}
