using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farcas_Razvan_lab2.Data;
using Farcas_Razvan_lab2.Models;

namespace Farcas_Razvan_lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Farcas_Razvan_lab2.Data.Farcas_Razvan_lab2Context _context;

        public DetailsModel(Farcas_Razvan_lab2.Data.Farcas_Razvan_lab2Context context)
        {
            _context = context;
        }

      public Authors Authors { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else 
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
