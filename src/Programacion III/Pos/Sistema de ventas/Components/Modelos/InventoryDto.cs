using POS.Api.Modelos;
using System.ComponentModel.DataAnnotations;

namespace P.Final.Components.Modelos
{
    public class InventoryDto
    {
        public enum Estados
        {
            Bueno,
            Danado,
            Defectuoso
        }

        [Key] public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public double Stock { get; set; } = 0;

        public string Estado { get; set; } = Estados.Bueno.ToString();

        public DateTime FechaCaducidad { get; set; } = DateTime.Now;

        public DateTime Fecha { get; set; } = DateTime.Now;

        public double BasePrice { get; set; } = 0;
        public string? Description { get; set; }

        public List<Sells>? Ventas { get; set; }

        public int ProvedorId { get; set; }
        public Proveedor? Proveedor { get; set; }

    }
}
