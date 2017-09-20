using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireStrategy.Test.Data
{
    public class OrdersRepository
    {
        List<Orders> orders;
        public OrdersRepository()
        {
            orders = new List<Orders>();
            orders.Add(new Orders() { LineNumber = 1, ItemName = "Item 1", OrderDate = new DateTime(2017, 2, 21), Price = 100, ClientId = 1 });
            orders.Add(new Orders() { LineNumber = 2, ItemName = "Item 2", OrderDate = new DateTime(2017, 2, 22), Price = 200, ClientId = 1 });
            orders.Add(new Orders() { LineNumber = 3, ItemName = "Item 3", OrderDate = new DateTime(2017, 2, 23), Price = 300, ClientId = 1 });

            orders.Add(new Orders() { LineNumber = 1, ItemName = "Item 3", OrderDate = new DateTime(2017, 2, 23), Price = 300, ClientId = 2 });
            orders.Add(new Orders() { LineNumber = 2, ItemName = "Item 4", OrderDate = new DateTime(2017, 2, 24), Price = 400, ClientId = 2 });
            orders.Add(new Orders() { LineNumber = 3, ItemName = "Item 5", OrderDate = new DateTime(2017, 2, 25), Price = 500, ClientId = 2 });

            orders.Add(new Orders() { LineNumber = 1, ItemName = "Item 2", OrderDate = new DateTime(2017, 2, 22), Price = 200, ClientId = 3 });
            orders.Add(new Orders() { LineNumber = 2, ItemName = "Item 4", OrderDate = new DateTime(2017, 2, 24), Price = 400, ClientId = 3 });


        }

        public List<Orders> GetOrders()
        {
            return orders;
        }
    }
}
