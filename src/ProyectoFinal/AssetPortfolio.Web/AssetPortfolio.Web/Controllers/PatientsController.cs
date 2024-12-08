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
    public class PatientsController : Controller
    {
        private readonly DentalClinicWebContext _context;

        public PatientsController(DentalClinicWebContext context)
        {
            _context = context;
        }

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            return View();
        }

        

        // GET: Patients/Create
        public IActionResult Create()
        {
            return View();
        }

        
        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            return View();
        }

        

        private bool PatientExists(int id)
        {
            return _context.Patient.Any(e => e.Id == id);
        }
    }
}
