using System.ComponentModel.DataAnnotations;

namespace POS.Api.Modelos.Request
{
    public class InventoryRequest : Inventory
    {
        public int Id { get; set; }
    }
}
