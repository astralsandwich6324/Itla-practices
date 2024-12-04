using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Api.Dto
{
    public class InvestorDto
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? LastName { get; set; }

        public int? Age { get; set; } = null;

        public char Sex { get; set; }

        public DateTime birthdate { get; set; }

        public string? Nationality { get; set; }

        public string? PhoneNumber { get; set; }

        public int? Salary { get; set; } = null;
    }
}
