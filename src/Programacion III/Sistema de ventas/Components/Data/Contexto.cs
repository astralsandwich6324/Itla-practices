using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Inventory> ProductosDB {get; set;}
    public DbSet<Compra> ComprasDB { get; set; }
    public DbSet<Central> Centrales{get; set;}
    
    public DbSet<Sells> VentasDB {get; set;}

    public DbSet<Users> UsuarioDb {get; set;}

    

}




