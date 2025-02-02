using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Management.Web.Models.Entities;

namespace Project.Management.Web.Data
{
    public class ProjectManagementWebContext : DbContext
    {
        public ProjectManagementWebContext (DbContextOptions<ProjectManagementWebContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Management.Web.Models.Entities.Users> Users { get; set; } = default!;
    }
}
