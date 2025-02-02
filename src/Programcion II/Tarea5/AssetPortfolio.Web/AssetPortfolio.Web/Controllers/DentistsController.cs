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
    public class DentistsController : Controller
    {
        private readonly DentalClinicWebContext _context;

        public DentistsController(DentalClinicWebContext context)
        {
            _context = context;
        }

        // GET: Dentists
        public async Task<IActionResult> Index()
        {
            return View();
        }

        

        // GET: Dentists/Create
        public IActionResult Create()
        {
            return View();
        }

        

        // GET: Dentists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            return View();
        }

        private bool DentistExists(int id)
        {
            return _context.Dentist.Any(e => e.Id == id);
        }
    }
}
