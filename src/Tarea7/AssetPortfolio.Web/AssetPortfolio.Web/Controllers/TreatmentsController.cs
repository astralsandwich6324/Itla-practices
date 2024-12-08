using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Domain;
using DentalClinic.Domain.Entities;
using DentalClinic.Persistence;

namespace DentalClinic.Web.Controllers
{
    public class TreatmentsController : Controller
    {
        private readonly DentalClinicWebContext _context;

        public TreatmentsController(DentalClinicWebContext context)
        {
            _context = context;
        }

        // GET: Treatments
        public async Task<IActionResult> Index()
        {
            return View();
        }

        

        // GET: Treatments/Create
        public IActionResult Create()
        {
            return View();
        }

        
        // GET: Treatments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        

        private bool TreatmentExists(int id)
        {
            return _context.Treatment.Any(e => e.Id == id);
        }
    }
}
