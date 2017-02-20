using System.Runtime.Serialization;

namespace WebshopService
{
    [DataContract]
    public class Product
    {
        public Product(string name, string description, decimal price, double profitMargin, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            ProfitMargin = profitMargin;
            Stock = stock;
        }
        [DataMember]
        public string Name { get; set; }
        public string Description { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        public double ProfitMargin { get; set; }
        [DataMember]
        public int Stock { get; set; }
    }
}
