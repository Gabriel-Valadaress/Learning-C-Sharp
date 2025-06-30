using System;
using System.Text;
using OrderProductsExercise.Entities.Enums;

namespace OrderProductsExercise.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order Summary:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("MM/dd/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items:");

            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total Price: $");
            sb.Append(Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
