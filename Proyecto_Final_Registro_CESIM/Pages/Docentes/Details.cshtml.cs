using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Pages.Docentes
{
    public class DetailsModel : PageModel
    {
        private readonly Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext _context;

        public DetailsModel(Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext context)
        {
            _context = context;
        }

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
    }
}
