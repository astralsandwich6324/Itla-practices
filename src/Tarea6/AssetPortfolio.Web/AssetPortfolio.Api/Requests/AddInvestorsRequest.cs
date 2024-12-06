using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Api.Requests
{
    public class AddInvestorsRequest
    {
        
        public string? Name { get; set; }
        //[Required]
        
        public string? LastName { get; set; }

        public int? Age { get; set; } = null;

        public string? Sex { get; set; }

        public DateTime birthdate { get; set; }

        public string? Nationality { get; set; }

        public string? PhoneNumber { get; set; }

        public int? Salary { get; set; } = null;
    }
}
