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
            var dentalClinicWebContext = _context.Appointment.Include(a => a.Dentista).Include(a => a.Paciente).Include(a => a.Tratamiento);
            return View(await dentalClinicWebContext.ToListAsync());
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment
                .Include(a => a.Dentista)
                .Include(a => a.Paciente)
                .Include(a => a.Tratamiento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            ViewData["DentistaId"] = new SelectList(_context.Dentist, "Id", "Id");
            ViewData["PacienteId"] = new SelectList(_context.Patient, "Id", "Id");
            ViewData["TratamientoId"] = new SelectList(_context.Set<Treatment>(), "Id", "Id");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaHora,Estado,PacienteId,DentistaId,TratamientoId")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DentistaId"] = new SelectList(_context.Dentist, "Id", "Id", appointment.DentistaId);
            ViewData["PacienteId"] = new SelectList(_context.Patient, "Id", "Id", appointment.PacienteId);
            ViewData["TratamientoId"] = new SelectList(_context.Set<Treatment>(), "Id", "Id", appointment.TratamientoId);
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            ViewData["DentistaId"] = new SelectList(_context.Dentist, "Id", "Id", appointment.DentistaId);
            ViewData["PacienteId"] = new SelectList(_context.Patient, "Id", "Id", appointment.PacienteId);
            ViewData["TratamientoId"] = new SelectList(_context.Set<Treatment>(), "Id", "Id", appointment.TratamientoId);
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaHora,Estado,PacienteId,DentistaId,TratamientoId")] Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.Id))
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
            ViewData["DentistaId"] = new SelectList(_context.Dentist, "Id", "Id", appointment.DentistaId);
            ViewData["PacienteId"] = new SelectList(_context.Patient, "Id", "Id", appointment.PacienteId);
            ViewData["TratamientoId"] = new SelectList(_context.Set<Treatment>(), "Id", "Id", appointment.TratamientoId);
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment
                .Include(a => a.Dentista)
                .Include(a => a.Paciente)
                .Include(a => a.Tratamiento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointment.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointment.Remove(appointment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointment.Any(e => e.Id == id);
        }
    }
}
