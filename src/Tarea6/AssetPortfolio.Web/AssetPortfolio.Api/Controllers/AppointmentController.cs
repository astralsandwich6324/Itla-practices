using DentalClinic.Domain;
using DentalClinic.Domain.Entities;
using DentalClinic.Api.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



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

        [HttpGet(nameof(GetAllAppointment))]
        public async Task<IActionResult> GetAllAppointment()
        {
            var citas = await _context.Appointment.ToListAsync();
            return Ok(citas);
        }

        [HttpPost(nameof(AddAppointment))]
        public async Task<IActionResult> AddAppointment(AppointmentDto request)
        {
            var dbAppointment = new Appointment();

            dbAppointment.Id = request.Id;
            dbAppointment.FechaHora = request.FechaHora;
            dbAppointment.Estado = request.Estado;
            dbAppointment.PacienteId = request.PacienteId;
            dbAppointment.DentistaId = request.DentistaId;
            dbAppointment.TratamientoId = request.TratamientoId;

            _context.Appointment.Add(dbAppointment);
            await _context.SaveChangesAsync();


            return Ok(request);
        }



    }
}
