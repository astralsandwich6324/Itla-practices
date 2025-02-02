using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Api.Dto
{
    public class DentistDto
    {
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Especialidad { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
    }
}