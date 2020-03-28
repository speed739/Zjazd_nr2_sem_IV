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
            var ukClients = northwindContext.Customers.Where(x => x.City == "London");

            foreach (var client in ukClients)
            {
                Console.WriteLine($"{client.CompanyName} - {client.Country}");
            }
            Console.ReadLine();
        }
    }
}
