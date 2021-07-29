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
    public class GeneroController : Controller
    {
        private readonly DbContextAlkemy _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public GeneroController(DbContextAlkemy context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Genero
        public async Task<IActionResult> Index()
        {
            return View(await _context.Generos.ToListAsync());
        }

        // GET: Genero/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .FirstOrDefaultAsync(m => m.GeneroID == id);
            if (genero == null)
            {
                return NotFound();
            }

            return View(genero);
        }

        // GET: Genero/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genero/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GeneroID,Nombre,NombreImagen,ImagenFile")] Genero genero)
        {
            if (ModelState.IsValid)
            {

                //guarda imagen en la carpeta wwwRooth/Image
                string wwwRoothPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(genero.NombreImagen);
                string extension = Path.GetExtension(genero.ImagenFile.FileName);
                genero.NombreImagen = fileName = fileName + extension;
                string path = Path.Combine(wwwRoothPath + "/Image/", fileName);
                
                /*string fileName = genero.NombreImagen;
                string path = Path.Combine(wwwRoothPath, fileName);*/
                using(var filStream = new FileStream(path, FileMode.Create))
                {
                    await genero.ImagenFile.CopyToAsync(filStream);
                }
                _context.Add(genero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genero);
        }

        // GET: Genero/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos.FindAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return View(genero);
        }

        // POST: Genero/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GeneroID,Nombre,NombreImagen")] Genero genero)
        {
            if (id != genero.GeneroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneroExists(genero.GeneroID))
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
            return View(genero);
        }

        // GET: Genero/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .FirstOrDefaultAsync(m => m.GeneroID == id);
            if (genero == null)
            {
                return NotFound();
            }

            return View(genero);
        }

        // POST: Genero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genero = await _context.Generos.FindAsync(id);
            _context.Generos.Remove(genero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneroExists(int id)
        {
            return _context.Generos.Any(e => e.GeneroID == id);
        }
    }
}
