using Microsoft.EntityFrameworkCore;
using P.Final.Components.Modelos;

public class Contexto: DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Inventory> ProductosDB {get; set;}
    
    public DbSet<Proveedor> ProveedorsDB { get; set; }
    public DbSet<Sells> VentasDB {get; set;}

    public DbSet<Users> UsuarioDb {get; set;}

    

}




