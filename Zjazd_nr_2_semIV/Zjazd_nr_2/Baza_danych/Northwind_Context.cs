namespace Zjazd_nr_2.Baza_danych
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Northwind_Context : DbContext
    {
        public Northwind_Context()
            : base("name=ZNorthwind")
        {
        }

        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<PozycjeZamówienia> PozycjeZamówienia { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Spedytorzy> Spedytorzy { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zamówienia> Zamówienia { get; set; }
        public virtual DbSet<Dostawcy> Dostawcy { get; set; }
        public virtual DbSet<Kategorie> Kategorie { get; set; }
        public virtual DbSet<Produkty> Produkty { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klienci>()
                .Property(e => e.IDklienta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Klienci>()
                .Property(e => e.KodPocztowy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Klienci>()
                .HasMany(e => e.Zamówienia)
                .WithRequired(e => e.Klienci)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PozycjeZamówienia>()
                .Property(e => e.CenaJednostkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pracownicy>()
                .Property(e => e.KodPocztowy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zamówienia>()
                .Property(e => e.IDklienta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zamówienia>()
                .Property(e => e.Fracht)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Zamówienia>()
                .HasMany(e => e.PozycjeZamówienia)
                .WithRequired(e => e.Zamówienia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dostawcy>()
                .Property(e => e.KodPocztowy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produkty>()
                .Property(e => e.CenaJednostkowa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Produkty>()
                .HasMany(e => e.PozycjeZamówienia)
                .WithRequired(e => e.Produkty)
                .WillCascadeOnDelete(false);
        }
    }
}
