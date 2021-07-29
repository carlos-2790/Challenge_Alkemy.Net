using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlkemyChallenge.Data;
using AlkemyChallenge.Models;
using DbContextAlkemy = AlkemyChallenge.Data.DbContextAlkemy;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AlkemyChallenge.Controllers
{
    public class PersonajeController : Controller
    {
        private readonly DbContextAlkemy _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PersonajeController(DbContextAlkemy context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Personaje
        public async Task<IActionResult> Index()
        {
            return View(await _context.Personajes.ToListAsync());
        }

        // GET: Personaje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personaje = await _context.Personajes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (personaje == null)
            {
                return NotFound();
            }

            return View(personaje);
        }

        // GET: Personaje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personaje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ImagenNombre,Nombre,Edad,Peso,Historia,ImagenFile")] Personaje personaje)
        {
            if (ModelState.IsValid)
            {
                string wwwRoothPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(personaje.ImagenNombre);
                string extension = Path.GetExtension(personaje.ImagenFile.FileName);
                personaje.ImagenNombre = fileName = fileName + extension;
                string path = Path.Combine(wwwRoothPath + "/Image/", fileName);

                using (var filStream = new FileStream(path, FileMode.Create))
                {
                    await personaje.ImagenFile.CopyToAsync(filStream);
                }

                _context.Add(personaje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personaje);
        }

        // GET: Personaje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personaje = await _context.Personajes.FindAsync(id);
            if (personaje == null)
            {
                return NotFound();
            }
            return View(personaje);
        }

        // POST: Personaje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ImagenNombre,Nombre,Edad,Peso,Historia")] Personaje personaje)
        {
            if (id != personaje.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personaje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonajeExists(personaje.ID))
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
            return View(personaje);
        }

        // GET: Personaje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personaje = await _context.Personajes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (personaje == null)
            {
                return NotFound();
            }

            return View(personaje);
        }

        // POST: Personaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personaje = await _context.Personajes.FindAsync(id);
            _context.Personajes.Remove(personaje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonajeExists(int id)
        {
            return _context.Personajes.Any(e => e.ID == id);
        }
    }
}
