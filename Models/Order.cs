using System;
using System.Collections.Generic;

namespace FashionWebsite.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
