using DentalClinic.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Domain.Entities
{
    public class Treatment: BaseEntity
    {
         
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Costo { get; set; } = null;

        
        public ICollection<Appointment>? Citas { get; set; }
    }

}