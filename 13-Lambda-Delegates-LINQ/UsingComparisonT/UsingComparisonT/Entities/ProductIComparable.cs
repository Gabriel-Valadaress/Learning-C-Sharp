namespace UsingComparisonT.Entities
{
    public class ProductIComparable : IComparable<ProductIComparable>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductIComparable(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2")}";
        }

        public int CompareTo(ProductIComparable? other)
        {
            return Price.CompareTo(other.Price);
        }
    }
}
