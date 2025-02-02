using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Domain.Entities
{
    public class Treatment
    {
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Costo { get; set; } = null;

        
        public ICollection<Appointment>? Citas { get; set; }
    }

}