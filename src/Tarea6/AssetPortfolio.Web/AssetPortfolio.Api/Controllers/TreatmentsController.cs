using DentalClinic.Domain;
using DentalClinic.Domain.Entities;
using DentalClinic.Api.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Persistence;

namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreatmentController : ControllerBase
    {
        private readonly DentalClinicWebContext _context;

        public TreatmentController(DentalClinicWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllTreatments))]
        public async Task<IActionResult> GetAllTreatments()
        {
            var treatments = await _context.Treatment.ToListAsync();
            return Ok(treatments);
        }

        [HttpPost(nameof(AddTreatment))]
        public async Task<IActionResult> AddTreatment(TreatmentDto request)
        {
            var dbTreatment = new Treatment
            {
                Id = request.Id,
                Nombre = request.Nombre,
                Descripcion = request.Descripcion,
                Costo = request.Costo
            };

            _context.Treatment.Add(dbTreatment);
            await _context.SaveChangesAsync();

            return Ok(request);
        }

        [HttpGet("GetTreatment/{id}")]
        public async Task<IActionResult> GetTreatmentById(int id)
        {
            var treatment = await _context.Treatment.FindAsync(id);
            if (treatment == null)
            {
                return NotFound("Tratamiento no encontrado.");
            }
            return Ok(treatment);
        }

        [HttpPut("EditTreatment/{id}")]
        public async Task<IActionResult> UpdateTreatment(int id, TreatmentDto updateRequest)
        {
            var treatment = await _context.Treatment.FindAsync(id);
            if (treatment == null)
            {
                return NotFound("Tratamiento no encontrado.");
            }

            treatment.Nombre = updateRequest.Nombre;
            treatment.Descripcion = updateRequest.Descripcion;
            treatment.Costo = updateRequest.Costo;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(treatment);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar el tratamiento.");
            }
        }

        [HttpDelete("DeleteTreatment/{id}")]
        public async Task<IActionResult> DeleteTreatment(int id)
        {
            var treatment = await _context.Treatment.FindAsync(id);
            if (treatment == null)
            {
                return NotFound("Tratamiento no encontrado.");
            }

            try
            {
                _context.Treatment.Remove(treatment);
                await _context.SaveChangesAsync();
                return Ok("Tratamiento eliminado correctamente.");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest("No se puede eliminar porque tiene datos relacionados.");
            }
        }
    }
}
