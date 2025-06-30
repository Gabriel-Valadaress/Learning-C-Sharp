using System;

namespace OrderProductsExercise.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            Price = Product.Price;
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price:F2}, Quantity: {Quantity}, Subtotal: ${SubTotal():F2}";
        }
    }
}
