using System.ComponentModel.DataAnnotations;

public class Users
{

    [Key]public int Id { get; set; }
    public string? Nombre{get; set;}
    public string? Cedula {get; set;}
    public string? Clave {get; set;}
    public string? Tipo {get; set;}
    
}

