namespace Task2.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Tesla";
        public decimal Price { get; set; } = 10.5m;
        public string Description { get; set; } = "Electric car";
    }
}