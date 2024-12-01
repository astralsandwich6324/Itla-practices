using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssetPortfolio.Web.Data;
using AssetPortfolio.Web.Models.Entities;
using AssetPortfolio.Web.Models;

namespace AssetPortfolio.Web.Controllers
{
    public class InvestorsController : Controller
    {
        private readonly AssetPortfolioWebContext _context;

        public InvestorsController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        // GET: Investors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Investor.ToListAsync());
        }

        // GET: Investors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investor = await _context.Investor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (investor == null)
            {
                return NotFound();
            }

            return View(investor);
        }

        // GET: Investors/Create
        public IActionResult Create()
        {
            var vm = new InvestorCreateViewModel();
            return View(vm);
        }

        // POST: Investors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InvestorCreateViewModel investor)
        {
            if (ModelState.IsValid)
            {
                var dbInvestor = new Investor();
                dbInvestor.Id = investor.Id;
                dbInvestor.Name = investor.Name;
                dbInvestor.LastName = investor.LastName;
                dbInvestor.Age = investor.Age;
                dbInvestor.Sex = investor.Sex;
                dbInvestor.birthdate = investor.birthdate;
                dbInvestor.Nationality = investor.Nationality;
                dbInvestor.PhoneNumber = investor.PhoneNumber;
                dbInvestor.Salary = investor.Salary;
                _context.Investor.Add(dbInvestor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(investor);
        }

        // GET: Investors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investor = await _context.Investor.FindAsync(id);
            if (investor == null)
            {
                return NotFound();
            }
            var vm = new InvestorEditViewModel();
            vm.Id = investor.Id;
            vm.Name = investor.Name;
            vm.LastName = investor.LastName;
            vm.Age = investor.Age;
            vm.Sex = investor.Sex;
            vm.birthdate = investor.birthdate;
            vm.Nationality = investor.Nationality;
            vm.PhoneNumber = investor.PhoneNumber;
            vm.Salary = investor.Salary;
            return View(vm);
        }

        // POST: Investors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, InvestorEditViewModel investor)
        {
            if (id != investor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    var dbInvestor = new Investor();
                    dbInvestor.Name = investor.Name;
                    dbInvestor.LastName = investor.LastName;
                    dbInvestor.Age = investor.Age;
                    dbInvestor.Sex = investor.Sex;
                    dbInvestor.birthdate = investor.birthdate;
                    dbInvestor.Nationality = investor.Nationality;
                    dbInvestor.PhoneNumber = investor.PhoneNumber;
                    dbInvestor.Salary = investor.Salary;
                     _context.Investor.Update(dbInvestor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvestorExists(investor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(investor);
        }

        // GET: Investors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investor = await _context.Investor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (investor == null)
            {
                return NotFound();
            }
            

            return View(investor);
        }

        // POST: Investors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var investor = await _context.Investor.FindAsync(id);
            if (investor != null)
            {
                _context.Investor.Remove(investor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvestorExists(int id)
        {
            return _context.Investor.Any(e => e.Id == id);
        }
    }
}
