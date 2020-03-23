using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zjazd_nr_2.Baza_danych;

namespace Zjazd_nr_2
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
            Console.WriteLine("TEST");
            Northwind_Context northwindContext = new Northwind_Context();
            var ukClients = northwindContext.Klienci.Where(x => x.Miasto == "Londyn");
            Console.WriteLine("TEST 2 ");
            
            foreach (var client in ukClients)
            {
                Console.WriteLine($"{client.NazwaFirmy} - {client.Kraj}");
            }
            Console.WriteLine("TEST 3 ");
            Console.ReadLine();

        }
    }
}
