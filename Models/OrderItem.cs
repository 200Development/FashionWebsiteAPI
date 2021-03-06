﻿
namespace FashionWebsite.API.Models
{
    public class OrderItem
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}