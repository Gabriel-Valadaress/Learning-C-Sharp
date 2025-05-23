using System;
using System.Globalization;

namespace Exercise_HandleACSVFile.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalIncome { get; set; }

        public Product(string name, double totalIncome)
        {
            Name = name;
            TotalIncome = totalIncome;
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalIncome = quantity * price;
        }

        public override string ToString()
        {
            return $"{Name},{TotalIncome.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
