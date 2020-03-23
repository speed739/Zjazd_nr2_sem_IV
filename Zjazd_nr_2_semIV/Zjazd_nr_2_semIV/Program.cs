using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;

namespace Zjazd_2_sem_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new Context();
            ctx.Database.EnsureCreated();

            //ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4", IloscObecnych = 15, Sala = "B316" });
            //ctx.SaveChanges();

            //foreach (var item in ctx.Zajecias)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            using var northwindContext = new Northwind
            var ukClients = northwindContext.Klienci.Where(x => x.Kraj == "UK");
            foreach (var client in ukClients)
            {
                Console.WriteLine($"{client.NazwaFirmy} {client.Miasto} {client.KodPocztowy}");
            }

        }
    }
}
