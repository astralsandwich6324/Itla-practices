using DentalClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Api.Dto
{
        public class BillDto
        {

            public int Id { get; set; } 
            public DateTime? FechaEmision { get; set; }
            public decimal? Total { get; set; }
            public string? MetodoPago { get; set; } 
            public int PacienteId { get; set; }
           
        }
}
