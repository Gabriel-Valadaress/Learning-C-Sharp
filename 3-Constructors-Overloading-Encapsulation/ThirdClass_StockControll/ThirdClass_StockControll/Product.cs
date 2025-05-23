using System;

namespace ThirdClass_StockControll
{
    class Product
    {
        public int ProductCode { get; private set; }
        public string ProductName { get; private set; }
        public double ProductPrice { get; private set; }
        public long StockQuantity { get; private set; }

        public Product(int productCode, string productName, double productPrice)
        {
            ProductCode = productCode;
            ProductName = productName;
            ProductPrice = productPrice;
            StockQuantity = 0;
        }

        public Product(int productCode, string productName, double productPrice, long stockQuantity) : this(productCode, productName, productPrice)
        {
            AddProductInStock(stockQuantity);
        }

        public double StockValue()
        {
            return ProductPrice * StockQuantity;
        }

        public void AddProductInStock (long quantity)
        {
            StockQuantity += quantity;
        }

        public void RemoveProductInStock(long quantity)
        {
            if (StockQuantity - quantity >= 0)
            {
                StockQuantity -= quantity;
            } else
            {
                Console.WriteLine($"It is not possible to remove {quantity} from the stock!\nThere are {StockQuantity} of the {this.ProductName} avaliable.");
            }
        }

        public void ChangeProductName (string newName)
        {
            Console.Write($"Are you sure you want to change the product name from {ProductName} to {newName}? (y/n) ");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y' || response == 'Y')
            {
                ProductName = newName;
            }
        }

        public void ChangeProductPrice(double newPrice)
        {
            Console.Write($"Are you sure you want to change the product price from {ProductPrice} to {newPrice}? (y/n) ");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y' || response == 'Y')
            {
                ProductPrice = newPrice;
            }
        }

        public override string ToString()
        {
            return $"\nStock information:\nCode: {ProductCode}\nName: {ProductName}\nPrice: {ProductPrice:F2}\nQuantity: {StockQuantity}\nStock Value: $ {StockValue():F2}\n";
        }
    }
}
