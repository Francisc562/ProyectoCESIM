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

namespace Proyecto_Final_Registro_CESIM.Pages.Docentes
{
    public class EditModel : PageModel
    {
        private readonly Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext _context;

        public EditModel(Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Docente Docente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Docente = await _context.Docente.FirstOrDefaultAsync(m => m.docenteID == id);

            if (Docente == null)
            {
                return NotFound();
            }
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

            _context.Attach(Docente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocenteExists(Docente.docenteID))
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

        private bool DocenteExists(int id)
        {
            return _context.Docente.Any(e => e.docenteID == id);
        }
    }
}
