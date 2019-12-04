using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext _context;

        public IndexModel(Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiante { get;set; }

        public async Task OnGetAsync()
        {
            Estudiante = await _context.Estudiante
                .Include(e => e.Tutor).ToListAsync();
        }
    }
}
