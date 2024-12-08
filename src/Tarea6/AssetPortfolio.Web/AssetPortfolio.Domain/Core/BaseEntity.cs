using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Domain.Core
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime? CreateDate { get; set; } = null;

        public DateTime? UpdateDate { get; set; } = null;

        public string? CreatedBy { get; set; } = null;

        public string? UpdateBy { get; set; } = null;
    }


}
