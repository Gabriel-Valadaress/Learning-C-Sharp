using Exercise_HandleACSVFile.Entities;
using System.Globalization;

namespace Exercise_HandleACSVFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file.csv";

            string[] lines = File.ReadAllLines(path);

            List<Product> products = new List<Product>();

            foreach (string line in lines)
            {
                string[] productLine = line.Split(",");
                Product product = new Product(productLine[0], double.Parse(productLine[1], CultureInfo.InvariantCulture), int.Parse(productLine[2]));
                products.Add(product);
            }

            List<Product> finalProducts = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                bool validBefore = false;
                for (int j = 0; j < i; j++)
                {
                    if (products[i].Name == products[j].Name)
                    {
                        validBefore = true;
                        j = i;
                    }
                }

                if (validBefore == false)
                {
                    Product finalProduct = new Product(products[i].Name, products[i].TotalIncome);
                    for (int j = i + 1; j < products.Count; j++)
                    {
                        if (products[i].Name == products[j].Name)
                        {
                            finalProduct.TotalIncome += products[j].TotalIncome;
                        }
                    }
                    finalProducts.Add(finalProduct);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(@"c:\temp\newfile.csv", false))
            {
                foreach (Product product in finalProducts)
                {
                    streamWriter.WriteLine(product);
                }
            }
        }
    }
}
