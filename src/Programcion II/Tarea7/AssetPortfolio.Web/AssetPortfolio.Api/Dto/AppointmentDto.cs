using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Api.Dto
{
    public class AppointmentDto
    {
        public int Id { get; set; } 
        public DateTime? FechaHora { get; set; }
        public string? Estado { get; set; } // Ejemplo: "Pendiente", "Realizada", "Cancelada"

        public int PacienteId { get; set; }
        
        public int DentistaId { get; set; }
       
        public int TratamientoId { get; set; }
        
    }

    
}