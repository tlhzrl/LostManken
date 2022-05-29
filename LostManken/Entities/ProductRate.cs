using System;

namespace LostManken.Entities
{
    public class ProductRate
    {
        public ProductRate()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProductID { get; set; }
        public int Rate { get; set; }
        public Product Product { get; set; }
    }
}