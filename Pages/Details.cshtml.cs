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
    public class DetailsModel : PageModel
    {
        private readonly MDeskRP.Models.MDeskRPContext _context;

        public DetailsModel(MDeskRP.Models.MDeskRPContext context)
        {
            _context = context;
        }

        public Models.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
