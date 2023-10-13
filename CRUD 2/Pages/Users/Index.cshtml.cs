using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_2.Data;
using CRUD_2.Models;

namespace CRUD_2.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_2.Data.CRUD_2Context _context;

        public IndexModel(CRUD_2.Data.CRUD_2Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
