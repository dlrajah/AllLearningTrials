﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreFirstWebUI.Domain;

namespace CodeFirstWebUI.Pages.Foods
{
    public class DeleteModel : PageModel
    {
        private readonly EfcoreTrialsContext _context;

        public DeleteModel(EfcoreTrialsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Food Food { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Foods == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.FirstOrDefaultAsync(m => m.Id == id);

            if (food == null)
            {
                return NotFound();
            }
            else 
            {
                Food = food;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Foods == null)
            {
                return NotFound();
            }
            var food = await _context.Foods.FindAsync(id);

            if (food != null)
            {
                Food = food;
                _context.Foods.Remove(Food);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
