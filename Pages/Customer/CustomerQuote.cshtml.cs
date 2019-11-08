using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDeskRP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace MDeskRP.Pages.Customer
{
    public class CustomerQuoteModel : PageModel
    {
        private readonly MDeskRPContext _context;

        public CustomerQuoteModel(MDeskRPContext context)
        {
            _context = context;
        }

        public Models.Customer Customer { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer
                .Include(c => c.DeskQuotes)
                .FirstOrDefaultAsync(c => c.CustomerID == id);

            if(Customer == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}