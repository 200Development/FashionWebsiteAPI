using System.Collections.Generic;

namespace FashionWebsite.API.Models
{
    public class SalesGraphModel
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public Dictionary<string, List<decimal>> Data { get; set; }
        public IEnumerable<string> ColumnNames { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}