using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssetPortfolio.Web.Models.Entities;

namespace AssetPortfolio.Web.Data
{
    public class AssetPortfolioWebContext : DbContext
    {
        public AssetPortfolioWebContext (DbContextOptions<AssetPortfolioWebContext> options)
            : base(options)
        {
        }

        public DbSet<AssetPortfolio.Web.Models.Entities.Investor> Investor { get; set; } = default!;
        public DbSet<AssetPortfolio.Web.Models.Entities.Asset> Asset { get; set; } = default!;
    }
}
