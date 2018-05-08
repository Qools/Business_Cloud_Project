namespace classlar.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StockControlModel2 : DbContext
    {
        public StockControlModel2()
            : base("name=StockControlModel2")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Lot> Lots { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lot>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Lot)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lot>()
                .HasMany(e => e.Stocks)
                .WithRequired(e => e.Lot)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Stocks)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Vendor)
                .WillCascadeOnDelete(false);
        }
    }
}
