using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssetPortfolio.Web.Data;
using AssetPortfolio.Web.Models.Entities;

namespace AssetPortfolio.Web.Controllers
{
    public class AssetsController : Controller
    {
        private readonly AssetPortfolioWebContext _context;

        public AssetsController(AssetPortfolioWebContext context)
        {
            _context = context;
        }

        // GET: Assets
        public async Task<IActionResult> Index()
        {
            var assetPortfolioWebContext = _context.Asset.Include(a => a.Investor).Include(a => a.Portfolio).Include(a => a.Status);
            return View(await assetPortfolioWebContext.ToListAsync());
        }

        // GET: Assets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset
                .Include(a => a.Investor)
                .Include(a => a.Portfolio)
                .Include(a => a.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (asset == null)
            {
                return NotFound();
            }

            return View(asset);
        }

        // GET: Assets/Create
        public IActionResult Create()
        {
            ViewData["InvestorId"] = new SelectList(_context.Investor, "Id", "LastName");
            ViewData["PortfolioId"] = new SelectList(_context.Set<Portfolio>(), "Id", "Assets");
            ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "Id", "Id");
            return View();
        }

        // POST: Assets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Symbol,Name,Quantity,PurchasePrice,CurrentPrice,Description,StatusId,InvestorId,PortfolioId")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvestorId"] = new SelectList(_context.Investor, "Id", "LastName", asset.InvestorId);
            ViewData["PortfolioId"] = new SelectList(_context.Set<Portfolio>(), "Id", "Assets", asset.PortfolioId);
            ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "Id", "Id", asset.StatusId);
            return View(asset);
        }

        // GET: Assets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset.FindAsync(id);
            if (asset == null)
            {
                return NotFound();
            }
            ViewData["InvestorId"] = new SelectList(_context.Investor, "Id", "LastName", asset.InvestorId);
            ViewData["PortfolioId"] = new SelectList(_context.Set<Portfolio>(), "Id", "Assets", asset.PortfolioId);
            ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "Id", "Id", asset.StatusId);
            return View(asset);
        }

        // POST: Assets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Symbol,Name,Quantity,PurchasePrice,CurrentPrice,Description,StatusId,InvestorId,PortfolioId")] Asset asset)
        {
            if (id != asset.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetExists(asset.Id))
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
            ViewData["InvestorId"] = new SelectList(_context.Investor, "Id", "LastName", asset.InvestorId);
            ViewData["PortfolioId"] = new SelectList(_context.Set<Portfolio>(), "Id", "Assets", asset.PortfolioId);
            ViewData["StatusId"] = new SelectList(_context.Set<Status>(), "Id", "Id", asset.StatusId);
            return View(asset);
        }

        // GET: Assets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset
                .Include(a => a.Investor)
                .Include(a => a.Portfolio)
                .Include(a => a.Status)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (asset == null)
            {
                return NotFound();
            }

            return View(asset);
        }

        // POST: Assets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asset = await _context.Asset.FindAsync(id);
            if (asset != null)
            {
                _context.Asset.Remove(asset);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetExists(int id)
        {
            return _context.Asset.Any(e => e.Id == id);
        }
    }
}
