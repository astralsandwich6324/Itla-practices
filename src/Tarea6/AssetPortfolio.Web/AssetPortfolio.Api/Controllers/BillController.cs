using DentalClinic.Domain;
using DentalClinic.Domain.Entities;
using DentalClinic.Api.Dto;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Azure.Core;
using System;


namespace DentalClinic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillController : ControllerBase
    {
        private readonly DentalClinicWebContext _context;

        public BillController(DentalClinicWebContext context)
        {
            _context = context;
        }

        [HttpGet(nameof(GetAllBills))]
        public async Task<IActionResult> GetAllBills()
        {
            var bill = await _context.Bill.ToListAsync();
            return Ok(bill);
        }

        [HttpPost(nameof(AddBills))]
        public async Task<IActionResult> AddBills(BillDto request)
        {
            var dbBill = new Bill();

            dbBill.Id = request.Id;
            dbBill.FechaEmision = request.FechaEmision;
            dbBill.Total = request.Total;
            dbBill.MetodoPago = request.MetodoPago;
            dbBill.PacienteId = request.PacienteId;


            _context.Bill.Add(dbBill);
            await _context.SaveChangesAsync();


            return Ok(request);
        }

        [HttpGet("GetBill/{id}")]
        public async Task<IActionResult> GetBilltById(int id)
        {
            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
            {
                return NotFound("Medico no encontrado.");
            }
            return Ok(bill);
        }


        [HttpPut("EditBill/{id}")]
        public async Task<IActionResult> UpdateBill(int id, BillDto updateRequest)
        {
            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            bill.Id = updateRequest.Id;
            bill.FechaEmision = updateRequest.FechaEmision;
            bill.Total = updateRequest.Total;
            bill.MetodoPago = updateRequest.MetodoPago;
            bill.PacienteId = updateRequest.PacienteId;

            try
            {
                await _context.SaveChangesAsync();
                return Ok(bill);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar la factura.");
            }
        }

        [HttpDelete("DeleteBill/{id}")]
        public async Task<IActionResult> DeleteBill(int id)
        {
            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
            {
                return NotFound("Item no encontrado.");
            }

            try
            {
                _context.Bill.Remove(bill);
                await _context.SaveChangesAsync();
                return Ok("Item eliminado correctamente.");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest("No se puede eliminar porque tiene datos relacionados.");
            }

        }


    }
}
