using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesNorthWind.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
