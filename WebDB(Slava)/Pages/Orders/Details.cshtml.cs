using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;
using WebDB_Slava_.Data;

namespace WebDB_Slava_.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public DetailsModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }

        public Order Order { get; set; }
        public RESTAURANT.Models.Menu Menu1 { get; set; }
        public RESTAURANT.Models.Menu Menu2 { get; set; }
        public RESTAURANT.Models.Menu Menu3 { get; set; }
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order.FirstOrDefaultAsync(m => m.ID == id);
            Menu1 = await _context.Menu.FirstOrDefaultAsync(m => m.ID == Order.dish_1ID);
            Menu2 = await _context.Menu.FirstOrDefaultAsync(m => m.ID == Order.dish_2ID);
            Menu3 = await _context.Menu.FirstOrDefaultAsync(m => m.ID == Order.dish_3ID);

            if (Order == null)
            {
                return NotFound();
            }
            
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.ID == id);
            return Page();
        }
    }
}
