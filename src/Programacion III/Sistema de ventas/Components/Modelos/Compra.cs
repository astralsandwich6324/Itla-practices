
using System.ComponentModel.DataAnnotations;

public class Compra
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El proveedor es obligatorio.")]
    public string? Proveedor { get; set; }

    [Required(ErrorMessage = "La fecha de compra es obligatoria.")]
    public DateTime FechaCompra { get; set; }

    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0.")]
    public decimal Precio { get; set; }

    [Required(ErrorMessage = "Los ingresos del proveedor son obligatorios.")]
    [Range(0, double.MaxValue, ErrorMessage = "Los ingresos deben ser mayores o iguales a 0.")]
    public decimal IngresosProveedor { get; set; }
}