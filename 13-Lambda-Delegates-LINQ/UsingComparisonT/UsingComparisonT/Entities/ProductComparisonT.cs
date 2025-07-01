namespace UsingComparisonT.Entities
{
    public class ProductComparisonT
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductComparisonT(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2")}";
        }
    }
}
