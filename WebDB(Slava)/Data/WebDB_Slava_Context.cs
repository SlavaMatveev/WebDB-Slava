using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;

namespace WebDB_Slava_.Data
{
    public class WebDB_Slava_Context : DbContext
    {
        public WebDB_Slava_Context (DbContextOptions<WebDB_Slava_Context> options)
            : base(options)
        {
        }

        public DbSet<RESTAURANT.Models.Employee> Employee { get; set; }

        public DbSet<RESTAURANT.Models.Menu> Menu { get; set; }

        public DbSet<RESTAURANT.Models.Order> Order { get; set; }

        public DbSet<RESTAURANT.Models.Position> Position { get; set; }

        public DbSet<RESTAURANT.Models.Warehouse> Warehouse { get; set; }
    }
}
