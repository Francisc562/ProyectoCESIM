﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Pages.Periodos
{
    public class DetailsModel : PageModel
    {
        private readonly Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext _context;

        public DetailsModel(Proyecto_Final_Registro_CESIM.Data.Proyecto_Final_Registro_CESIMContext context)
        {
            _context = context;
        }

        public Periodo Periodo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Periodo = await _context.Periodos.FirstOrDefaultAsync(m => m.periodoID == id);

            if (Periodo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
