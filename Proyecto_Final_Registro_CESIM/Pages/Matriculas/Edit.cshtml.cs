using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Pages.Matriculas
{
    public class EditModel : PageModel
    {
        private readonly Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext _context;

        public EditModel(Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Matricula Matricula { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Matricula = await _context.Matriculas
                .Include(m => m.Estudiante)
                .Include(m => m.Grado)
                .Include(m => m.Periodo).FirstOrDefaultAsync(m => m.matriculaID == id);

            if (Matricula == null)
            {
                return NotFound();
            }
           ViewData["estudianteID"] = new SelectList(_context.Estudiantes, "estudianteID", "estudianteID");
           ViewData["gradoID"] = new SelectList(_context.Grados, "gradoID", "gradoID");
           ViewData["periodoID"] = new SelectList(_context.Periodos, "periodoID", "periodoID");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Matricula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatriculaExists(Matricula.matriculaID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MatriculaExists(int id)
        {
            return _context.Matriculas.Any(e => e.matriculaID == id);
        }
    }
}
