﻿using GlobalGamesCet49.Dados;
using GlobalGamesCet49.Dados.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Controllers
{
    public class ContactosController : Controller
    {
        private readonly DataContext _context;

        public ContactosController(DataContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos
                .FirstOrDefaultAsync(i => i.Id == id);
            if (contactos == null)
            {
                return NotFound();
            }

            return View(contactos);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Contactos.ToListAsync());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Morada,Mensagem")] Contactos contactos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactos);
        }


        public IActionResult Create()
        {
            return View();
        }


        // GET: Contactos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos.FindAsync(id);
            if (contactos == null)
            {
                return NotFound();
            }
            return View(contactos);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactos == null)
            {
                return NotFound();
            }

            return View(contactos);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Morada,Mensagem")] Contactos contactos)
        {
            if (id != contactos.Id)
            {

                return NotFound();

            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactosExists(contactos.Id))
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
            return View(contactos);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactos = await _context.Contactos.FindAsync(id);
            _context.Contactos.Remove(contactos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactosExists(int id)
        {
            return _context.Contactos.Any(e => e.Id == id);
        }
    }
}
