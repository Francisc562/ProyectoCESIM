using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Pages.Estudiantes
{
    public class CreateModel : PageModel
    {
        private readonly Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext _context;

        public CreateModel(Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["tutorID"] = new SelectList(_context.Set<Tutor>(), "tutorID", "tutorID");
            return Page();
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Estudiante.Add(Estudiante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
