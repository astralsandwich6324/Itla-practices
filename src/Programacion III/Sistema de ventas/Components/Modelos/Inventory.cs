using System.ComponentModel.DataAnnotations;

public class Inventory
{
    public enum Estados
    {
        Bueno,
        Danado,
        Defectuoso
    }

    [Key]public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public double Stock { get; set; } = 0;

    public double TotalStock(){
         if (Ventas != null)
        {
        
            Stock -= Ventas.Sum(v => v.Cantidad);
        }

        return Stock;
    }
    public string Estado { get; set; } = Estados.Bueno.ToString();
    //public Agente? Agente { get; set; }
    //public int ConceptoId { get; set; }
    //public Concepto Concepto { get; set; } = new Concepto();
    public DateTime FechaV { get; set; } = DateTime.Now;
    public double PriceInicial { get; set; } = 0;
    public string? Description { get; set; }

    public List<Sells>? Ventas { get; set; }
    
    
}
