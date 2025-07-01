using UsingComparisonT.Entities;

namespace UsingComparisonT
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ProductIComparable> productsIComparable = new List<ProductIComparable>();

            productsIComparable.Add(new ProductIComparable("TV", 999.99));
            productsIComparable.Add(new ProductIComparable("Stove", 200));
            productsIComparable.Add(new ProductIComparable("Iphone", 399.90));

            productsIComparable.Sort();

            foreach (ProductIComparable product in productsIComparable)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("------------------------");

            List<ProductComparisonT> productComparisonT = new List<ProductComparisonT>();

            productComparisonT.Add(new ProductComparisonT("TV", 999.99));
            productComparisonT.Add(new ProductComparisonT("Stove", 200));
            productComparisonT.Add(new ProductComparisonT("Iphone", 399.90));

            Comparison<ProductComparisonT> comparison = (prod1, prod2) =>
            {
                return prod1.Price.CompareTo(prod2.Price);
            };

            productComparisonT.Sort(comparison);

            foreach (ProductComparisonT product in productComparisonT)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("------------------------");

            productComparisonT.Sort((prod1, prod2) => prod1.Name.ToUpper().CompareTo(prod2.Name.ToUpper()));

            foreach (ProductComparisonT product in productComparisonT)
            {
                Console.WriteLine(product);
            }
        }
    }
}
