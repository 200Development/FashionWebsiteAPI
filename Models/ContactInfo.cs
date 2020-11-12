namespace FashionWebsite.API.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    }
}