using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthClass_StockControll
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        
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
