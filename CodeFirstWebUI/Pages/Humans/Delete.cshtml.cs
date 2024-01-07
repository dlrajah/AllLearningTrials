using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreFirstWebUI.Domain;

namespace CodeFirstWebUI.Pages.Humans
{
    public class DeleteModel : PageModel
    {
        private readonly EfcoreTrialsContext _context;

        public DeleteModel(EfcoreTrialsContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Human Human { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Humans == null)
            {
                return NotFound();
            }

            var human = await _context.Humans.FirstOrDefaultAsync(m => m.Id == id);

            if (human == null)
            {
                return NotFound();
            }
            else 
            {
                Human = human;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Humans == null)
            {
                return NotFound();
            }
            var human = await _context.Humans.FindAsync(id);

            if (human != null)
            {
                Human = human;
                _context.Humans.Remove(Human);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
