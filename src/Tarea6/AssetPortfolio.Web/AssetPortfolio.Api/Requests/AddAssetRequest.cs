﻿using System.ComponentModel.DataAnnotations;
using AssetPortfolio.Domain.Entities;

namespace AssetPortfolio.Api.Requests
{
    public class AddAssetRequest
    {
        [StringLength(10)]
        public string? Symbol { get; set; }
        [StringLength(30)]
        public string? Name { get; set; }

        public int? Quantity { get; set; } = null;
        public decimal? PurchasePrice { get; set; } = null;
        public decimal? CurrentPrice { get; set; } = null;
        [StringLength(80)]
        public string? Description { get; set; }
        public int StatusId { get; set; }
        //public Status? Status { get; set; }

        public int InvestorId { get; set; }
        //public Investor? Investor { get; set; }

        public int PortfolioId { get; set; }

        //public Portfolio? Portfolio { get; set; }
    }
}