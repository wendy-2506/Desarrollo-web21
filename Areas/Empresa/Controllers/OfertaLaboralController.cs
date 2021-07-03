using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tu_Nuevo_Trabajo2021.Models;

namespace Tu_Nuevo_Trabajo2021.Areas.Empresa.Controllers
{
    [Area("Empresa")]
    public class OfertaLaboralController : Controller
    {
        private readonly _10MOCICLOContext _context;

        public OfertaLaboralController(_10MOCICLOContext context)
        {
            _context = context;
        }

        // GET: Empresa/OfertaLaboral
        public async Task<IActionResult> Index()
        {
            var _10MOCICLOContext = _context.OfertaLaboral.Include(o => o.IdUsuarioNavigation);
            return View(await _10MOCICLOContext.ToListAsync());
        }

        // GET: Empresa/OfertaLaboral/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofertaLaboral = await _context.OfertaLaboral
                .Include(o => o.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdOferta == id);
            if (ofertaLaboral == null)
            {
                return NotFound();
            }

            return View(ofertaLaboral);
        }

        // GET: Empresa/OfertaLaboral/Create
        public IActionResult Create()
        {
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: Empresa/OfertaLaboral/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOferta,IdUsuario,PuestoOferta,FechaCreacion,FechaCancelacion,FechaInicio,FechaFin,Requisitos,Descripcion,Lugar,TipoContrato,EstadoOferta")] OfertaLaboral ofertaLaboral)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ofertaLaboral);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "IdUsuario", ofertaLaboral.IdUsuario);
            return View(ofertaLaboral);
        }

        // GET: Empresa/OfertaLaboral/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofertaLaboral = await _context.OfertaLaboral.FindAsync(id);
            if (ofertaLaboral == null)
            {
                return NotFound();
            }
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "IdUsuario", ofertaLaboral.IdUsuario);
            return View(ofertaLaboral);
        }

        // POST: Empresa/OfertaLaboral/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdOferta,IdUsuario,PuestoOferta,FechaCreacion,FechaCancelacion,FechaInicio,FechaFin,Requisitos,Descripcion,Lugar,TipoContrato,EstadoOferta")] OfertaLaboral ofertaLaboral)
        {
            if (id != ofertaLaboral.IdOferta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ofertaLaboral);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfertaLaboralExists(ofertaLaboral.IdOferta))
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
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "IdUsuario", ofertaLaboral.IdUsuario);
            return View(ofertaLaboral);
        }

        // GET: Empresa/OfertaLaboral/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ofertaLaboral = await _context.OfertaLaboral
                .Include(o => o.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdOferta == id);
            if (ofertaLaboral == null)
            {
                return NotFound();
            }

            return View(ofertaLaboral);
        }

        // POST: Empresa/OfertaLaboral/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ofertaLaboral = await _context.OfertaLaboral.FindAsync(id);
            _context.OfertaLaboral.Remove(ofertaLaboral);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfertaLaboralExists(int id)
        {
            return _context.OfertaLaboral.Any(e => e.IdOferta == id);
        }
    }
}
