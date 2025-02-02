using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; } 
        public DateTime? FechaHora { get; set; }
        public string? Estado { get; set; } // Ejemplo: "Pendiente", "Realizada", "Cancelada"

        
        public int PacienteId { get; set; }
        public Patient? Paciente { get; set; }

        public int DentistaId { get; set; }
        public Dentist? Dentista { get; set; }

        public int TratamientoId { get; set; }
        public Treatment? Tratamiento { get; set; }
    }

    
}