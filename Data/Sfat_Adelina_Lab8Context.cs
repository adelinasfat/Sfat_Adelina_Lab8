using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sfat_Adelina_Lab8.Models;

namespace Sfat_Adelina_Lab8.Data
{
    public class Sfat_Adelina_Lab8Context : DbContext
    {
        public Sfat_Adelina_Lab8Context (DbContextOptions<Sfat_Adelina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sfat_Adelina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sfat_Adelina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sfat_Adelina_Lab8.Models.Category> Category { get; set; }
    }
}
