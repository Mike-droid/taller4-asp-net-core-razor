using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesNorthWind.Models;

    public class NorthWindContext : DbContext
    {
        public NorthWindContext (DbContextOptions<NorthWindContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesNorthWind.Models.Product> Product { get; set; }
    }
