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
    public class IndexModel : PageModel
    {
        private readonly EfcoreTrialsContext _context;

        public IndexModel(EfcoreTrialsContext context)
        {
            _context = context;
        }

        public IList<Human> Human { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Humans != null)
            {
                Human = await _context.Humans.ToListAsync();
            }
        }
    }
}
