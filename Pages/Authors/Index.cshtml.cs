﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Farcas_Razvan_lab2.Data.Farcas_Razvan_lab2Context _context;

        public IndexModel(Farcas_Razvan_lab2.Data.Farcas_Razvan_lab2Context context)
        {
            _context = context;
        }

        public IList<Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Authors = await _context.Authors.ToListAsync();
            }
        }
    }
}
