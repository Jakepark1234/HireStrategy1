using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireStrategy.Test.Data;
namespace HireStrategy.Test.ConsoleApp
{
    class Program
    {
        ClientRepository repo;
        public Program()
        {
            repo = new ClientRepository();
        }
        static void Main(string[] args)
        {
            OrdersRepository repository = new OrdersRepository();
            List<Orders> orders = repository.GetOrders();
            Program p = new ConsoleApp.Program();
            #region Task
            p.PrintOrders(orders);
            p.SortByClientAndChargesDesc(orders);
            p.PrintOrdersByDate(orders);
            p.PrintByChargeFilter(orders);
            p.CountOfItemLinesPerDate(orders);
            p.LineItemTotalChargesPerDate(orders);
            #endregion
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }



        public void PrintOrders(List<Orders> orders)
        {

            Console.WriteLine("*** Task 1: Print orders");
            Console.WriteLine("------------------------------------------------------");
            var orderDetails = orders.GroupBy(x => x.ClientId);
            foreach (var item in orderDetails)
            {
                Client c = repo.GetById(item.Key);
                Console.WriteLine("Header Id = " + Guid.NewGuid());
                Console.WriteLine("Client Name = " + c.Name);
                foreach (var i in item)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", i.LineNumber, i.OrderDate, i.ItemName, i.Price);
                }
                Console.WriteLine("------------------------------------------------------");
            }
        }

        public void SortByClientAndChargesDesc(List<Orders> orders)
        {
            Console.WriteLine("*** Task 2: Print orders sorted descending by client name and line items sorted descending by Charges");
            Console.WriteLine("------------------------------------------------------");

            var orderDetails = orders.OrderByDescending(x => x.ClientId).ThenByDescending(x => x.Price).GroupBy(x => x.ClientId);
            foreach (var item in orderDetails)
            {
                Client c = repo.GetById(item.Key);
                Console.WriteLine("Header Id = " + Guid.NewGuid());
                Console.WriteLine("Client Name = " + c.Name);
                foreach (var i in item)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", i.LineNumber, i.OrderDate, i.ItemName, i.Price);
                }
                Console.WriteLine("------------------------------------------------------");
            }
        }


        public void PrintOrdersByDate(List<Orders> orders)
        {
            Console.WriteLine("*** Task3: Print lines ordered by date (ascending)");
            Console.WriteLine("------------------------------------------------------");
            var item = orders.OrderBy(x => x.OrderDate);
            foreach (var i in item)
            {
                Console.WriteLine("{0} | {1} | {2} | {3}", i.LineNumber, i.OrderDate, i.ItemName, i.Price);
            }
            Console.WriteLine("------------------------------------------------------");
        }

        public void PrintByChargeFilter(List<Orders> orders)
        {
            var item = orders.Where(z => z.Price >= 300).OrderBy(x => x.LineNumber);

            Console.WriteLine("*** Task4: Print lines sorted by LineNumber where charge is greater than or equal 300.");
            Console.WriteLine("------------------------------------------------------");

            foreach (var i in item)
            {
                Console.WriteLine("{0} | {1} | {2} | {3}", i.LineNumber, i.OrderDate, i.ItemName, i.Price);
            }
            Console.WriteLine("------------------------------------------------------");
        }

        public void CountOfItemLinesPerDate(List<Orders> orders)
        {

            Console.WriteLine("*** Task 5: Print count of line items per date.");
            Console.WriteLine("------------------------------------------------------");
            var details = orders.GroupBy(x => x.OrderDate);
            foreach (var item in details)
            {
                Console.WriteLine("{0} | {1}", item.Key, item.Count());
            }

            Console.WriteLine("------------------------------------------------------");
        }

        public void LineItemTotalChargesPerDate(List<Orders> orders)
        {

            Console.WriteLine("*** Task 5: Print items total charges per date.");
            Console.WriteLine("------------------------------------------------------");
            var details = orders.GroupBy(x => x.OrderDate);
            foreach (var item in details)
            {
                Console.WriteLine("{0} | {1}", item.Key, item.Sum(x => x.Price));
            }

            Console.WriteLine("------------------------------------------------------");
        }




    }
}
