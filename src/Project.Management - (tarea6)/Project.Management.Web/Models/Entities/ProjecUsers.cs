
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Management.Web.Models.Entities
{
    public class ProjectUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public bool Active { get; set; }

        public List<Work> Works { get; set; }   
    }
}
