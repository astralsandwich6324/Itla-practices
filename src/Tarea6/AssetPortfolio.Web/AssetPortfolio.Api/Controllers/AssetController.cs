using AssetPortfolio.Domain;
using AssetPortfolio.Domain.Entities;
using AssetPortfolio.Api.Dto;
using AssetPortfolio.Api.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssetPortfolio.Api.Responses;

namespace AssetPortfolio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly AssetPortfolioWebContext _context;

        public AssetController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllAssets))]
        public async Task<IActionResult> GetAllAssets()
        {
            var asset = await _context.Asset.ToListAsync();
            return Ok(asset);
        }

        [HttpPost(nameof(AddAssets))]
        public async Task<IActionResult> AddAssets(AddAssetRequest request)
        {
            var dbAsset = new Asset();
            
            
            dbAsset.Symbol = request.Symbol;
            dbAsset.Name = request.Name;
            dbAsset.Quantity = request.Quantity;
            dbAsset.PurchasePrice = request.PurchasePrice;
            dbAsset.CurrentPrice = request.CurrentPrice;
            dbAsset.Description = request.Description;
            dbAsset.StatusId = request.StatusId;
            dbAsset.InvestorId = request.InvestorId;
            dbAsset.PortfolioId = request.PortfolioId;
            _context.Asset.Add(dbAsset);
            await _context.SaveChangesAsync();

            var response = new AddAssetResponse { Id = dbAsset.Id };
            return Ok(request);
        }



    }
}
