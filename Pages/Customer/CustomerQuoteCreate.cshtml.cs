using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDeskRP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MDeskRP.Pages.Customer
{
    public class CustomerQuoteCreateModel : PageModel
    {

        private readonly MDeskRPContext _context;

        public CustomerQuoteCreateModel(MDeskRPContext context)
        {
            _context = context;
        }

        [BindProperty] public Models.Customer Customer { get; set; }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        [BindProperty]
        public DeskSpecs DeskSpecs { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer
                .Include(c => c.DeskQuotes)
                .FirstOrDefaultAsync(c => c.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }

            ViewData["DeskTypeString"] = new SelectList(_context.DeskTypeDescription, "DeskTypeString", "DeskTypeString",
               DeskTypeEnum.Laminate);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.CustomerID = Customer.CustomerID;
            DeskQuote.DeskSpecsID = DeskSpecs.DeskSpecsID;

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./CustomerQuote", new {id = Customer.CustomerID});
        }
    }
}