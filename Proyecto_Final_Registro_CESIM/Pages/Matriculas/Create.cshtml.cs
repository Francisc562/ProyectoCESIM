using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Pages.Matriculas
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
        ViewData["estudianteID"] = new SelectList(_context.Estudiantes, "estudianteID", "estudianteID");
        ViewData["gradoID"] = new SelectList(_context.Grados, "gradoID", "gradoID");
        ViewData["periodoID"] = new SelectList(_context.Periodos, "periodoID", "periodoID");
            return Page();
        }

        [BindProperty]
        public Matricula Matricula { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Matriculas.Add(Matricula);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
