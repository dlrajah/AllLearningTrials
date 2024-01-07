using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreFirstWebUI.Domain;

namespace CodeFirstWebUI.Pages.Humans
{
    public class CreateModel : PageModel
    {
        private readonly EfcoreTrialsContext _context;

        public CreateModel(EfcoreTrialsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Human Human { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Humans == null || Human == null)
            {
                return Page();
            }

            _context.Humans.Add(Human);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
