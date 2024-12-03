using System.ComponentModel.DataAnnotations;
using AssetPortfolio.Domain.Entities;

namespace AssetPortfolio.Web.Models
{
    public class PortfolioViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string? Assets { get; set; }

        public decimal? TotalValue { get; set; } = null;

        public List<Asset> Asset { get; set; }
    }
}
