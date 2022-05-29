﻿using System.Collections.Generic;

namespace LostManken.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Product { get; set; }
    }
}