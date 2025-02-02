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
    public class AppointmentController : ControllerBase
    {
        private readonly DentalClinicWebContext _context;

        public AppointmentController(DentalClinicWebContext context)
        {
            _context = context;
        }

        // Obtener todas las citas
        [HttpGet(nameof(GetAllAppointments))]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _context.Appointment.ToListAsync();
            return Ok(appointments);
        }

        // Obtener una cita por Id
        [HttpGet("GetAppointment/{id}")]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var appointment = await _context.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound("Cita no encontrada.");
            }
            return Ok(appointment);
        }

        // Agregar una nueva cita
        [HttpPost(nameof(AddAppointment))]
        public async Task<IActionResult> AddAppointment(AppointmentDto request)
        {
            var dbAppointment = new Appointment
            {
                Id = request.Id,
                FechaHora = request.FechaHora,
                Estado = request.Estado,
                PacienteId = request.PacienteId,
                DentistaId = request.DentistaId,
                TratamientoId = request.TratamientoId
            };

            _context.Appointment.Add(dbAppointment);
            await _context.SaveChangesAsync();
            return Ok(request);
        }

        // Editar una cita existente
        [HttpPut("EditAppointment/{id}")]
        public async Task<IActionResult> UpdateAppointment(int id, AppointmentDto updateRequest)
        {
            var appointment = await _context.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound("Cita no encontrada.");
            }

            appointment.FechaHora = updateRequest.FechaHora;
            appointment.Estado = updateRequest.Estado;
            appointment.PacienteId = updateRequest.PacienteId;
            appointment.DentistaId = updateRequest.DentistaId;
            appointment.TratamientoId = updateRequest.TratamientoId;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(appointment);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar la cita.");
            }
        }

        // Eliminar una cita
        [HttpDelete("DeleteAppointment/{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var appointment = await _context.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound("Cita no encontrada.");
            }

            try
            {
                _context.Appointment.Remove(appointment);
                await _context.SaveChangesAsync();
                return Ok("Cita eliminada correctamente.");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest("No se puede eliminar la cita porque tiene datos relacionados.");
            }
        }
    }
}
