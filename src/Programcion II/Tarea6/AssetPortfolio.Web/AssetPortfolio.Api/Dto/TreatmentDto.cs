using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Api.Dto
{
    public class TreatmentDto
    {
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Costo { get; set; } = null;
    }

}