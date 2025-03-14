using Microsoft.JSInterop;
using P.Final.Components.Pages;
using System.ComponentModel.DataAnnotations;

public class Sells 
{

    [Key] public int Id {get;set;}=0;

    public int Cantidad { get; set; }

    public double SalePrice { get; set; }

    public double Total { get; set; } = 0;

    public string? Description { get; set; }

    public DateTime FechaVenta { get; set; } = DateTime.Now;
    public int InventoryId { get; set; }
    public Inventory? Inventory { get; set; }


    




}