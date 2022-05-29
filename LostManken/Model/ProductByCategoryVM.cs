using LostManken.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostManken.Model
{
    public class ProductByCategoryVM
    {
        public string CategoryName { get; set; }
        public int ProductCounts { get; set; }
        public List<Product> Products { get; set; }
    }
}
