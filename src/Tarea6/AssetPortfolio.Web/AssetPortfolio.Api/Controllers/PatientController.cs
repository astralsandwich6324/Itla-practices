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
    public class PatientController : ControllerBase
    {
        private readonly DentalClinicWebContext _context;

        public PatientController(DentalClinicWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllPatients))]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _context.Patient.ToListAsync();
            return Ok(patients);
        }

        [HttpGet("GetPatient/{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _context.Patient.FindAsync(id);
            if (patient == null)
            {
                return NotFound("Paciente no encontrado.");
            }
            return Ok(patient);
        }



        [HttpPost(nameof(AddPatients))]
        public async Task<IActionResult> AddPatients(PatientDto request)
        {
            var dbpatients = new Patient();

            dbpatients.Id = request.Id;
            dbpatients.Name = request.Name;
            dbpatients.LastName = request.LastName;
            dbpatients.PhoneNumber = request.PhoneNumber;
            dbpatients.Email = request.Email;
            dbpatients.Birthdate = request.Birthdate;
            dbpatients.Direccion = request.Direccion;

            _context.Patient.Add(dbpatients);

            await _context.SaveChangesAsync();


            return Ok(request);
        }


        [HttpPut("EditPatient/{id}")]
        public async Task<IActionResult> UpdatePatient(int id, PatientDto updateRequest)
        {
            var existingPatient = await _context.Patient.FindAsync(id);
            if (existingPatient == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            existingPatient.Id = updateRequest.Id;
            existingPatient.Name = updateRequest.Name;
            existingPatient.LastName = updateRequest.LastName;
            existingPatient.PhoneNumber = updateRequest.PhoneNumber;
            existingPatient.Email = updateRequest.Email;
            existingPatient.Birthdate = updateRequest.Birthdate;
            existingPatient.Direccion = updateRequest.Direccion;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingPatient);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar el usuario.");
            }
        }

        [HttpDelete("DeletePatient/{id}")]
        public async Task<IActionResult> DeletePantient(int id)
        {
            var investor = await _context.Patient.FindAsync(id);
            if (investor == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            try
            {
                _context.Patient.Remove(investor);
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

