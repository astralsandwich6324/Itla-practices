
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Management.Web.Models.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Version { get; set; }
        public string Author { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int UsersId { get; set; }
        public ProjectUser Users { get; set; }

        public int EmployeeId { get; set; }
        
        public Employee Employee { get; set; }

    }
}
