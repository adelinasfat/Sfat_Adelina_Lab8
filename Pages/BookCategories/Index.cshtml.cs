using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sfat_Adelina_Lab8.Data;
using Sfat_Adelina_Lab8.Models;

namespace Sfat_Adelina_Lab8.Pages.BookCategories
{
    public class IndexModel : PageModel
    {
        private readonly Sfat_Adelina_Lab8.Data.Sfat_Adelina_Lab8Context _context;

        public IndexModel(Sfat_Adelina_Lab8.Data.Sfat_Adelina_Lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
