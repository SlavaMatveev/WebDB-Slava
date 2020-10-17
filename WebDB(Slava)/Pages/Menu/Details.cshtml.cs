﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;
using WebDB_Slava_.Data;

namespace WebDB_Slava_.Pages.Menu
{
    public class DetailsModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public DetailsModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }

        public RESTAURANT.Models.Menu Menu { get; set; }
        public RESTAURANT.Models.Warehouse Warehouse { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Menu = await _context.Menu.FirstOrDefaultAsync(m => m.ID == id);

            if (Menu == null)
            {
                return NotFound();
            }
            Warehouse = await _context.Warehouse.FirstOrDefaultAsync(m => m.ID == id);
            return Page();
        }
    }
}
