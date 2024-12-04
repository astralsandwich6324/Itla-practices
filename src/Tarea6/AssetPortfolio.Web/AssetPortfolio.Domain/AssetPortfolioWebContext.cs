using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssetPortfolio.Domain.Entities; 

namespace AssetPortfolio.Domain
{
    public class AssetPortfolioWebContext : DbContext
    {
        public AssetPortfolioWebContext (DbContextOptions<AssetPortfolioWebContext> options)
            : base(options)
        {
        }

        public DbSet<AssetPortfolio.Domain.Entities.Investor> Investor { get; set; } = default!;
        public DbSet<AssetPortfolio.Domain.Entities.Asset> Asset { get; set; } = default!;
        public DbSet<AssetPortfolio.Domain.Entities.Portfolio> Portfolio { get; set; } = default!;
        public DbSet<AssetPortfolio.Domain.Entities.Status> Status { get; set; } = default!;
    }
}
