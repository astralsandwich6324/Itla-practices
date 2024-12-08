using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Api.Dto
{
    public class PatientDto
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Direccion { get; set; }
    }

}
