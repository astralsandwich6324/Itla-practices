using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Domain.Entities; 

namespace DentalClinic.Domain
{
    public class DentalClinicWebContext : DbContext
    {
        public DentalClinicWebContext (DbContextOptions<DentalClinicWebContext> options) 
            : base(options)
        {
        }

        public DbSet<DentalClinic.Domain.Entities.Appointment> Appointment { get; set; } = default!;
        public DbSet<DentalClinic.Domain.Entities.Bill> Bill { get; set; } = default!;
        public DbSet<DentalClinic.Domain.Entities.Dentist> Dentist { get; set; } = default!;
        public DbSet<DentalClinic.Domain.Entities.Patient> Patient { get; set; } = default!;

        public DbSet<DentalClinic.Domain.Entities.Treatment> Treatment { get; set; } = default!;

    }
}
