using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Model
{
    public class Order
    {
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>
            {
                new Order { CustomerId = 1, Amount = 250 },
                new Order { CustomerId = 2, Amount = 150 },
                new Order { CustomerId = 1, Amount = 100 },
                new Order { CustomerId = 3, Amount = 200 },
                new Order { CustomerId = 2, Amount = 300 }
            };
            return orders;
        }
    }
    public class Order1
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

        public static List<Order1> GetAllOrders()
        {
            // Sample list of orders
            List<Order1> orders = new List<Order1>
            {
                new Order1 { CustomerId = 1, OrderId = 100, OrderDate = new DateTime(2023, 1, 25), Total = 150.00m },
                new Order1 { CustomerId = 1, OrderId = 101, OrderDate = new DateTime(2023, 3, 12), Total = 250.00m },
                new Order1 { CustomerId = 2, OrderId = 102, OrderDate = new DateTime(2023, 2, 28), Total = 100.00m },
                new Order1 { CustomerId = 2, OrderId = 103, OrderDate = new DateTime(2024, 1, 15), Total = 200.00m },
                // Add more orders as needed
            };
            return orders;
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Order2
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
    }
}
