using System;

namespace Chest.Models
{
    public class ProductInStock
    {
        public Product Product { get; set; }
        public DateTime ExpDate { get; set; }
        public int Quantity { get; set; }
    }
}