using Microsoft.JSInterop;

using System.ComponentModel.DataAnnotations;

namespace POS.Api.Modelos
{
    public class Sells
    {

        [Key] public int Id { get; set; } = 0;

        public int Cantidad { get; set; }

        public double SalePrice { get; set; }

        public double Total { get; set; } = 0;

        public string? Description { get; set; }

        public DateTime FechaVenta { get; set; } = DateTime.Now;
        public int InventoryId { get; set; }
        public Inventory? Inventory { get; set; }


    }
}
