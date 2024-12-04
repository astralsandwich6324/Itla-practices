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
    public class StatusController : ControllerBase
    {
        private readonly AssetPortfolioWebContext _context;

        public StatusController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetStatus))]
        public async Task<IActionResult> GetStatus()
        {
            var status = await _context.Status.ToListAsync();
            return Ok(status);
        }

        [HttpPost(nameof(AddStatus))]
        public async Task<IActionResult> AddStatus(StatusDto request)
        {
            var dbStatus = new Status();
            
            dbStatus.Estado = request.Estado;
            
            
            _context.Status.Add(dbStatus);
            await _context.SaveChangesAsync();

            var response = new StatusDto { Id = dbStatus.Id };
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
