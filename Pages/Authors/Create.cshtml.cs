using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Farcas_Razvan_lab2.Data;
using Farcas_Razvan_lab2.Models;

namespace Farcas_Razvan_lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Farcas_Razvan_lab2.Data.Farcas_Razvan_lab2Context _context;

        public CreateModel(Farcas_Razvan_lab2.Data.Farcas_Razvan_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Authors Authors { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Authors == null || Authors == null)
            {
                return Page();
            }

            _context.Authors.Add(Authors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
