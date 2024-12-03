using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; 
using Microsoft.EntityFrameworkCore;

using AssetPortfolio.Domain.Entities;
using AssetPortfolio.Web.Models;
using Microsoft.DotNet.Scaffolding.Shared;
using AssetPortfolio.Domain;

namespace AssetPortfolio.Web.Controllers
{
    public class PortfoliosController : Controller
    {
        private readonly AssetPortfolioWebContext _context;

        public PortfoliosController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        // GET: Portfolios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolio.ToListAsync());
        }

        // GET: Portfolios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // GET: Portfolios/Create
        public IActionResult Create()
        {
            var vm = new PortfolioViewModel();
            return View(vm);
        }

        // POST: Portfolios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PortfolioViewModel portfolio)
        {
            if (ModelState.IsValid)
            {
                var dbPortfolio = new Portfolio();
                dbPortfolio.Id = portfolio.Id;
                dbPortfolio.UserName = portfolio.UserName;
                dbPortfolio.Asset = portfolio.Asset;
                dbPortfolio.TotalValue = portfolio.TotalValue;
                _context.Portfolio.Add(dbPortfolio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(portfolio);
        }

        // GET: Portfolios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio.FindAsync(id);
            if (portfolio == null)
            {
                return NotFound();
            }
            var vm = new PortfolioViewModel();
            vm.Id = portfolio.Id;
            vm.UserName = portfolio.UserName;
            vm.Asset = portfolio.Asset;
            vm.TotalValue = portfolio.TotalValue;
            return View(vm);
        }

        // POST: Portfolios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PortfolioViewModel portfolio)
        {
            if (id != portfolio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbPortfolio = new Portfolio();
                    dbPortfolio.Id = portfolio.Id;
                    dbPortfolio.UserName = portfolio.UserName;
                    dbPortfolio.Asset = portfolio.Asset;
                    dbPortfolio.TotalValue = portfolio.TotalValue;
                    _context.Portfolio.Update(dbPortfolio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PortfolioExists(portfolio.Id))
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
            return View(portfolio);
        }

        // GET: Portfolios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var portfolio = await _context.Portfolio.FindAsync(id);
            if (portfolio != null)
            {
                _context.Portfolio.Remove(portfolio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PortfolioExists(int id)
        {
            return _context.Portfolio.Any(e => e.Id == id);
        }
    }
}
