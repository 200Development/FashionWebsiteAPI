
namespace FashionWebsite.API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public string ImageUrl { get; set; }

        public int AvailableInventory { get; set; }

        public bool IsDiscontinued { get; set; }
    }
}
