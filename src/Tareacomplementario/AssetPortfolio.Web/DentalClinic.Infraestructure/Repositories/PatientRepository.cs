using Azure.Core;
using DentalClinic.Api.Dto;
using DentalClinic.Domain.Entities;
using DentalClinic.Infraestructure.Models;
using DentalClinic.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Infraestructure.Repositories
{
    public class PatientRepository
    {
        private readonly DentalClinicWebContext _context;
        public PatientRepository(DentalClinicWebContext context)
        {
            _context = context;
        }

        public async Task<List<PatientDto>> GetPatient()
        {
            var patients = new List<PatientDto>();
            var patientDb = await _context.Patient.ToListAsync();
            if (!patientDb.Any())
            {
                throw new Exception("Patient not found");

            }
            foreach(var patient in patientDb)
            {
                patients.Add(new PatientDto
                {
                    Id = patient.Id,
                    Name = patient.Name,
                    LastName = patient.LastName,
                    PhoneNumber = patient.PhoneNumber,
                    Email = patient.Email,
                    Birthdate = patient.Birthdate,
                    Direccion = patient.Direccion
                });
            }
            
            return patients;
        }

        public async Task<PatientDto> GetPatientById(int id)
        {
            var patientModel = new PatientDto();
            var patientDb = await _context.Patient.FindAsync(id);
            if (patientDb == null) 
            {
                 throw new Exception("Patient not found");
                    
            }
            patientModel.Id = patientDb.Id;
            patientModel.Name = patientDb.Name;
            patientModel.LastName = patientDb.LastName;
            patientModel.PhoneNumber = patientDb.PhoneNumber;
            patientModel.Email = patientDb.Email;
            patientModel.Birthdate = patientDb.Birthdate;
            patientModel.Direccion = patientDb.Direccion;
            return patientModel;
        }

        public async Task<DentalClinic.Api.Dto.PatientDto>AddPatients (PatientDto request)
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
            return new PatientDto { Id = dbpatients.Id };
        }

        public async Task<bool> UpdatePatients(PatientDto request)
        {
            var dbPatient = await _context.Patient.FindAsync(request.Id);
            if (dbPatient == null)
            {
                throw new Exception ("Paciente no encontrado");
            }

            dbPatient.Id = request.Id;
            dbPatient.Name = request.Name;
            dbPatient.LastName = request.LastName;
            dbPatient.PhoneNumber = request.PhoneNumber;
            dbPatient.Email = request.Email;
            dbPatient.Birthdate = request.Birthdate;
            dbPatient.Direccion = request.Direccion;


            

            _context.Patient.Update(dbPatient);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePatients(PatientDto request)
        {
            var dbPatient = await _context.Patient.FindAsync(request.Id);
            if (dbPatient == null)
            {
                throw new Exception("Paciente no encontrado");
            }
            try
            {
                dbPatient.Id = request.Id;
                dbPatient.Name = request.Name;
                dbPatient.LastName = request.LastName;
                dbPatient.PhoneNumber = request.PhoneNumber;
                dbPatient.Email = request.Email;
                dbPatient.Birthdate = request.Birthdate;
                dbPatient.Direccion = request.Direccion;

                _context.Patient.Remove(dbPatient);

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                
                throw new Exception("Paciente no encontrado");
            }

            




            
        }
    }
}
