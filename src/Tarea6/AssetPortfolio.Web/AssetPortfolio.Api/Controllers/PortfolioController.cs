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
    public class PortfolioController : ControllerBase
    {
        private readonly AssetPortfolioWebContext _context;

        public PortfolioController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllPortfolios))]
        public async Task<IActionResult> GetAllPortfolios()
        {
            var portfolios = await _context.Portfolio.ToListAsync();
            return Ok(portfolios);
        }

        [HttpPost(nameof(AddPortfolios))]
        public async Task<IActionResult> AddPortfolios(AddPortfolioRequest request)
        {
            var dbPortfolio = new Portfolio();
            
            dbPortfolio.UserName = request.UserName;
            dbPortfolio.Assets = request.Assets;
            dbPortfolio.TotalValue = request.TotalValue;
            
            _context.Portfolio.Add(dbPortfolio);
            await _context.SaveChangesAsync();

            var response = new AddPortfolioResponses { Id = dbPortfolio.Id };
            return Ok(request);
        }


        //[HttpPut(nameof(DeleteInvestors))]
        //public async Task<IActionResult> DeleteInvestors(AddInvestorsRequest request)
        //{
        //    var dbInvestor = new Investor();

        //    dbInvestor.Name = request.Name;
        //    dbInvestor.LastName = request.LastName;
        //    dbInvestor.Age = request.Age;
        //    dbInvestor.Sex = request.Sex;
        //    dbInvestor.birthdate = request.birthdate;
        //    dbInvestor.Nationality = request.Nationality;
        //    dbInvestor.PhoneNumber = request.PhoneNumber;
        //    dbInvestor.Salary = request.Salary;
        //    _context.Investor.Add(dbInvestor);
        //    await _context.SaveChangesAsync();

        //    var response = new AddInvestorResponse { Id = dbInvestor.Id };
        //    return Ok(request);
        //}



    }
}
