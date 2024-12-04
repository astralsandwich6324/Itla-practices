using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Domain.Entities
{
    public class AssetDto
    {
        public int Id { get; set; }
        
        public string? Symbol { get; set; }
        
        public string? Name { get; set; }

        public int? Quantity { get; set; } = null;
        public decimal? PurchasePrice { get; set; } = null;
        public decimal? CurrentPrice { get; set; } = null;
        
        public string? Description { get; set; }
        //public int StatusId { get; set; }
        //public Status? Status { get; set; }

        //public int InvestorId { get; set; }
        //public Investor? Investor { get; set; }

        //public int PortfolioId { get; set; }

        //public Portfolio? Portfolio { get; set; }
    }
}
