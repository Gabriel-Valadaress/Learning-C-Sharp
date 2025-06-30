namespace ComparingCollections.Entities
{
    public class IncorrectProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public IncorrectProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
