namespace FashionWebsite.API.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public int AreaCode { get; set; }
        public int Prefix { get; set; }
        public int LineNumber { get; set; }
    }
}