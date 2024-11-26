using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Management.Web.Models.Entities;


namespace Project.Management.Web
{
    public class ProjectManagementWebContext : DbContext
    {
        public ProjectManagementWebContext (DbContextOptions<ProjectManagementWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectUser> Users { get; set; } = default!;

        public DbSet<Employee> Employees { get; set; } = default!;

        public DbSet<Status> Status { get; set; } = default!;

        public DbSet<Work> Works { get; set; } = default!;

        
    }
}
