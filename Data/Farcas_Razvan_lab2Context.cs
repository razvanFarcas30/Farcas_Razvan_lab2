using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Farcas_Razvan_lab2.Models;

namespace Farcas_Razvan_lab2.Data
{
    public class Farcas_Razvan_lab2Context : DbContext
    {
        public Farcas_Razvan_lab2Context (DbContextOptions<Farcas_Razvan_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Farcas_Razvan_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Farcas_Razvan_lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Farcas_Razvan_lab2.Models.Authors>? Authors { get; set; }
    }
}
