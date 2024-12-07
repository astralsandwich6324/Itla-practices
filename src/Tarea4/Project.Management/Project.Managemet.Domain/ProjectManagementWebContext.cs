using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Management.Domain.Entities;

namespace Project.Management.Domain
{
    public class ProjectManagementWebContext : DbContext
    {
        public ProjectManagementWebContext (DbContextOptions<ProjectManagementWebContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Management.Domain.Entities.Users> Users { get; set; } = default!;
    }
}
