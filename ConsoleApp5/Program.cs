using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zjazd_2_sem_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new Context();
            ctx.Zajecias.Add(new Zajecia() { Nazva = "P4", IloscObecnych = 15, Sala = "B316" });
            ctx.SaveChanges();

            foreach (var item in ctx.Zajecias)
            {
                Console.WriteLine(item);
            }

        }

    }
}
