using System;
using System.Linq;
using Zjazd_nr_2_sem_IV.Baza;
namespace Zjazd_nr_2_sem_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var ctx = new Context();
            //ctx.Database.EnsureCreated();

            //ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4", IloscObecnych = 15, Sala = "B316" });
            //ctx.SaveChanges();

            //foreach (var item in ctx.Zajecias)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            NorthwindContext northwindContext = new NorthwindContext();

            //var ukClients = northwindContext.Customers.Where(x => x.City == "London");
            //foreach (var client in ukClients)
            //{
            //    Console.WriteLine($"{client.CompanyName} - {client.Country}");
            //}
           
            var orders = northwindContext.Orders.Where(x => x.CustomerId == "ALFKI");
            foreach (var order in orders)
            {
                int orderId = order.OrderId;
                var orders_details = northwindContext.OrderDetails.Where(x => x.OrderId == orderId);

                Console.WriteLine("Produkty z zamowienia o nr " + orderId);
                
                foreach (var produkt in orders_details)
                {
                    Console.WriteLine(produkt.ProductId);
                }
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
        }
    }
}
