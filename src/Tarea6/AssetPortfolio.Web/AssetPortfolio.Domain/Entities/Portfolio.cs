﻿using System.ComponentModel.DataAnnotations;

namespace AssetPortfolio.Domain.Entities
{
    public class Portfolio
    {
        
        public int Id { get; set; }

        [StringLength(50)]
        public string? UserName { get; set; }
        
        [StringLength(50)]
        public string? Assets { get; set; }

        public decimal? TotalValue { get; set; } = null;

        public List<Asset> Asset { get; set; }
    }
}