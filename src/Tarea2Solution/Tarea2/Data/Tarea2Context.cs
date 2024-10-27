using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea2.Models.Entities;

namespace Tarea2.Data
{
    public class Tarea2Context : DbContext
    {
        public Tarea2Context (DbContextOptions<Tarea2Context> options)
            : base(options)
        {
        }

        public DbSet<Tarea2.Models.Entities.Customer> Customers { get; set; }
    }
}
