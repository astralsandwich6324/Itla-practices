using DentalClinic.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Domain.Entities
{
    public class Patient : BaseEntity
    {
         
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Direccion { get; set; }

        public ICollection<Appointment>? Citas { get; set; }
        public ICollection<Bill>? Facturas { get; set; }
    }

}
