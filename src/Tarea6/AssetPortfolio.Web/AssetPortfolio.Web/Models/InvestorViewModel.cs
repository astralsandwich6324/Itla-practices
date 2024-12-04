using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Web.Models
{
    public class InvestorViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        public int? Age { get; set; } = null;

        public char Sex { get; set; }

        public DateTime Birthdate { get; set; }

        public string Nationality { get; set; }

        public string PhoneNumber { get; set; }

        public int? Salary { get; set; } = null;
    }
}
