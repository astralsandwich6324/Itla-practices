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
    public class InvestorsController : ControllerBase
    {
        private readonly AssetPortfolioWebContext _context;

        public InvestorsController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllInvestors))]
        public async Task<IActionResult> GetAllInvestors()
        {
            var investor = await _context.Investor.ToListAsync();
            return Ok(investor);
        }

        [HttpPost(nameof(AddInvestors))]
        public async Task<IActionResult> AddInvestors(AddInvestorsRequest request)
        {
            var dbInvestor = new Investor();
            
            dbInvestor.Name = request.Name;
            dbInvestor.LastName = request.LastName;
            dbInvestor.Age = request.Age;
            dbInvestor.Sex = request.Sex;
            dbInvestor.birthdate = request.birthdate;
            dbInvestor.Nationality = request.Nationality;
            dbInvestor.PhoneNumber = request.PhoneNumber;
            dbInvestor.Salary = request.Salary;
            _context.Investor.Add(dbInvestor);
            await _context.SaveChangesAsync();

            var response = new AddInvestorResponse { Id = dbInvestor.Id };
            return Ok(request);
        }



    }
}
