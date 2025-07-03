namespace Linq04_SQLSintax.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: ${Price.ToString("F2")}, Category: {Category.Name}, Tier: {Category.Tier}";
        }
    }
}
