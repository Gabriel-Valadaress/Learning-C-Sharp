using System;

namespace FirstClass_StockControll
{

    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Quantity = 0;
        }

        public double TotalStockValue()
        {
            return this.Price * this.Quantity;
        }

        public void AddQuantity(int quantity)
        {
            this.Quantity += quantity;
        }

        public void RemoveQuantity(int quantity)
        {
            this.Quantity -= quantity;
        }

        public override string ToString()
        {
            return $"\nProduct information: Name: {this.Name}, Unit price ${this.Price}, Quantity {this.Quantity} units, Total Value: ${this.TotalStockValue()}";
        }
    }
}

