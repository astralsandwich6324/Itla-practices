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
    public class AppointmentsController : Controller
    {
        private readonly DentalClinicWebContext _context;

        public AppointmentsController(DentalClinicWebContext context)
        {
            _context = context;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        

        // GET: Appointments/Create
        public IActionResult Create()
        {
            return View();
        }

        

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        
        private bool AppointmentExists(int id)
        {
            return _context.Appointment.Any(e => e.Id == id);
        }
    }
}
