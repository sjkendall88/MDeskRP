using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MDeskRP.Models;

namespace MDeskRP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MDeskRP.Models.MDeskRPContext _context;

        public IndexModel(MDeskRP.Models.MDeskRPContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
