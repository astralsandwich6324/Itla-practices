using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Domain.Entities
{
    public class PortfolioDto
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public string? Assets { get; set; }

        public decimal? TotalValue { get; set; } = null;

        public List<Asset> Asset { get; set; }
    }
}