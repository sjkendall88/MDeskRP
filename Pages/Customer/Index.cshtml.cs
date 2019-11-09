using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MDeskRP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MDeskRP.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly MDeskRP.Models.MDeskRPContext _context;

        public IndexModel(MDeskRP.Models.MDeskRPContext context)
        {
            _context = context;
        }

        public IList<Models.Customer> Customer { get;set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentFilter2 { get; set; }
        public string NameList { get; set; }
        public SelectList Customers { get; set; }
        public async Task OnGetAsync(string sortOrder, string SearchString, string SearchString2)
        {
            //Customer = await _context.Customer.ToListAsync();

            {
                NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                DateSort = sortOrder == "Date" ? "date_desc" : "Date";

                CurrentFilter = SearchString;
                CurrentFilter2 = SearchString2;

                IQueryable<Models.Customer> customers = from ol in _context.Customer
                                                       select ol;
                switch (sortOrder)
                {
                    //setting filters for sorting
                    case "name_desc":
                        customers = customers.OrderByDescending(ol => ol.LastName);
                        break;
                    case "Date":
                        customers = customers.OrderBy(ol => ol.OrderDate);
                        break;
                    case "date_desc":
                        customers = customers.OrderByDescending(ol => ol.OrderDate);
                        break;
                    default:
                        customers = customers.OrderBy(ol => ol.LastName);
                        break;
                }

                Customer = await customers.AsNoTracking().ToListAsync();

                //using input for searching last names
                IQueryable<string> customerQuery = from c in _context.Customer
                                               orderby c.LastName
                                               select c.LastName;

                if (!string.IsNullOrEmpty(SearchString))
                {
                    customers = customers.Where(s => s.LastName.Contains(SearchString));
                }

                if (!string.IsNullOrEmpty(NameList))
                {
                    customers = customers.Where(x => x.LastName == NameList);
                }

               Customers = new SelectList(await customerQuery.Distinct().ToListAsync());
               Customer = await customers.AsNoTracking().ToListAsync();

                //using input for searching notes
                //IQueryable<string> noteQuery = from n in _context.Customer
                //                               orderby n.Notes
                //                               select n.Notes;

                //if (!string.IsNullOrEmpty(SearchString2))
                //{
                //    bookEntries = bookEntries.Where(s2 => s2.Notes.Contains(SearchString2));
                //}

                //if (!string.IsNullOrEmpty(NoteList))
                //{
                //    bookEntries = bookEntries.Where(x2 => x2.Notes == NoteList);
                //}

                //Note = new SelectList(await noteQuery.Distinct().ToListAsync());
                //Entries = await bookEntries.ToListAsync();
            }
        }
    }
}
