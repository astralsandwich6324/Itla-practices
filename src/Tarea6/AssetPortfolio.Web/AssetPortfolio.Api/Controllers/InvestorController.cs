using AssetPortfolio.Domain;
using AssetPortfolio.Domain.Entities;
using AssetPortfolio.Api.Dto;
using AssetPortfolio.Api.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssetPortfolio.Api.Responses;
using Azure.Core;

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
            dbInvestor.Birthdate = request.birthdate;
            dbInvestor.Nationality = request.Nationality;
            dbInvestor.PhoneNumber = request.PhoneNumber;
            dbInvestor.Salary = request.Salary;
            _context.Investor.Add(dbInvestor);
            
            await _context.SaveChangesAsync();

            var response = new AddInvestorResponse { Id = dbInvestor.Id };
            return Ok(request);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInvestor(int id, AddInvestorsRequest updateRequest)
        {
            var existingInvestor = await _context.Investor.FindAsync(id);
            if (existingInvestor == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            
            existingInvestor.Name = updateRequest.Name;
            existingInvestor.LastName = updateRequest.LastName;
            existingInvestor.Age = updateRequest.Age;
            existingInvestor.Sex = updateRequest.Sex;
            existingInvestor.Birthdate = updateRequest.birthdate;
            existingInvestor.Nationality = updateRequest.Nationality;
            existingInvestor.PhoneNumber = updateRequest.PhoneNumber;
            existingInvestor.Salary = updateRequest.Salary;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(existingInvestor);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar el usuario.");
            }
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvestor(int id)
        {
            var investor = await _context.Investor.FindAsync(id);
            if (investor == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            try
            {
                _context.Investor.Remove(investor);
                await _context.SaveChangesAsync();
                return Ok("Usuario eliminado correctamente.");
            }
            catch (DbUpdateException)
            {
                return BadRequest("No se puede eliminar el usuario porque tiene datos relacionados.");
            }
        }



    }



}

