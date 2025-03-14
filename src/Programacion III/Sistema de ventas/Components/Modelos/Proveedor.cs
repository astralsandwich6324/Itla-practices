using System.ComponentModel.DataAnnotations;

namespace P.Final.Components.Modelos
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public DateTime FechaRegisro { get; set; } = DateTime.Now;

        public DateTime FechaVenta { get; set; }

        public double ProductosComprados { get; set; }

        public double IngresosProveedor { get; set; }
    }
}
