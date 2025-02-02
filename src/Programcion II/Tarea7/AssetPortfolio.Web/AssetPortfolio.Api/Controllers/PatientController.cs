using DentalClinic.Domain;
using DentalClinic.Domain.Entities;
using DentalClinic.Api.Dto;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Azure.Core;
using DentalClinic.Persistence;
using DentalClinic.Infraestructure.Repositories;
using DentalClinic.Infraestructure.Models;

namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly PatientRepository _repository;

        public PatientController(PatientRepository repository)
        {
            _repository = repository;
            this._repository = repository;
        }

        [HttpGet(nameof(GetAllPatients))]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _repository.GetPatient();
            return Ok(patients);
        }

        [HttpGet("GetPatient/{id}")]
        public async Task<ActionResult<PatientModel>> GetPatientById(int id)
        {
            var patient = await _repository.GetPatientById(id);
            if (patient == null)
            {
                return NotFound("Paciente no encontrado.");
            }
            return patient;
        }



        [HttpPost(nameof(AddPatients))]
        public async Task<ActionResult<PatientDto>> AddPatients(PatientDto request)
        {
            
            return await _repository.AddPatients(request);
        }


        [HttpPut("EditPatient/{id}")]
        public async Task<IActionResult> UpdatePatient(int id, PatientDto request)
        {
            if(request.Id != id)
            {
                return BadRequest();
            }
            var succes = await _repository.UpdatePatients(request);
            if (succes)
            {
                return NoContent();
            }
            
            return NoContent();
            
            
        }

        [HttpDelete("DeletePatient/{id}")]
        public async Task<IActionResult> DeletePantient(int id, PatientDto request)
        {
            if (request.Id != id)
            {
                return BadRequest();
            }
            var succes = await _repository.DeletePatients(request);
            if (succes)
            {
                return NoContent();
            }

            return NoContent();
        }

    }

}

