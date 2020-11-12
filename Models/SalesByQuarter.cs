
using System.Collections.Generic;

namespace FashionWebsite.API.Models
{
    public class SalesByQuarter
    {
        public string Quarter { get; set; }
        public List<SaleData> Sales { get; set; }
        public decimal Revenue { get; set; }
    }

    public class SaleData
    {
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
    }
}
