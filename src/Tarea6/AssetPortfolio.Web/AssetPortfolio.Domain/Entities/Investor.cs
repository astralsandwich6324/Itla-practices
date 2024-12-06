using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Domain.Entities
{
    public class Investor
    {
        public int Id { get; set; }
        
        [StringLength(30)]
        public string? Name { get; set; }
        
        [StringLength(50)]
        public string? LastName { get; set; }

        public int? Age { get; set; } = null;

        public string? Sex { get; set; }

        public DateTime Birthdate { get; set; }

        public string? Nationality { get; set; }

        public string? PhoneNumber { get; set; }

        public int? Salary { get; set; } = null;
    }
}