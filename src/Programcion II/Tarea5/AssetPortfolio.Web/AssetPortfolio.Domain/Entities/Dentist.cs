using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Domain.Entities
{
    public class Dentist
    {
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Especialidad { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }

        
        public ICollection<Appointment>? Citas { get; set; }
    }
}