using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesNorthWind.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var Context = new NorthWindContext(serviceProvider.GetRequiredService<DbContextOptions<NorthWindContext>>());
            if (!Context.Product.Any())
            {
                Context.Product.AddRange(
                    new Product
                    {
                        Name = "Avena",
                        RegisterDate = new DateTime(2021, 3, 15),
                        Category = "Carbohidratos",
                        UnitPrice = 30.00m
                    },
                    new Product
                    {
                        Name = "Agua",
                        RegisterDate = new DateTime(2021, 4, 16),
                        Category = "Líquidos",
                        UnitPrice = 20.50m
                    }
                );
                Context.SaveChanges();
            }
        }
    }
}
