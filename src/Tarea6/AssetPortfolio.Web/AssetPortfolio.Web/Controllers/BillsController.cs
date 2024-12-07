using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Domain;
using DentalClinic.Domain.Entities;

namespace DentalClinic.Web.Controllers
{
    public class BillsController : Controller
    {
        private readonly DentalClinicWebContext _context;

        public BillsController(DentalClinicWebContext context)
        {
            _context = context;
        }

        // GET: Bills
        public async Task<IActionResult> Index()
        {
            
            return View();
        }


        // GET: Bills/Create
        public IActionResult Create()
        {
            
            return View();
        }

        

        // GET: Bills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        

        private bool BillExists(int id)
        {
            return _context.Bill.Any(e => e.Id == id);
        }
    }
}
