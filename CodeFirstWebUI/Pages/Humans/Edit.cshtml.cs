using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreFirstWebUI.Domain;

namespace CodeFirstWebUI.Pages.Humans
{
    public class EditModel : PageModel
    {
        private readonly EfcoreTrialsContext _context;

        public EditModel(EfcoreTrialsContext context)
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

            var human =  await _context.Humans.FirstOrDefaultAsync(m => m.Id == id);
            if (human == null)
            {
                return NotFound();
            }
            Human = human;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Human).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HumanExists(Human.Id))
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

        private bool HumanExists(int id)
        {
          return (_context.Humans?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
