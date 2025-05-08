using Microsoft.EntityFrameworkCore;
using Courier.web.Components.Models;

namespace Courier.Web.Components.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ClaseLogin> LoginDB { get; set; }

        public DbSet<Paquetes> PaquetesDB { get; set; }

        public DbSet<PreAlertas> PreaAlertasDb { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

       



        
    }
}
