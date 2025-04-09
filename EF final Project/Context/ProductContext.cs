using EF_final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Context
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI_EF_Project;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductLine>().HasData(
         new ProductLine { ID = 1, DesclnText = "Electronics", DesclnHTML = "<b>Electronics</b>", Image = "electronics.jpg" },
                new ProductLine { ID = 2, DesclnText = "Mobile Devices", DesclnHTML = "<b>Mobile Devices</b>", Image = "mobile.jpg" },
                new ProductLine { ID = 3, DesclnText = "Food", DesclnHTML = "<b>Food Products</b>", Image = "food.jpg" },
                new ProductLine { ID = 4, DesclnText = "Appliances", DesclnHTML = "<b>Home Appliances</b>", Image = "appliances.jpg" }
      );

            modelBuilder.Entity<Product>().HasData(
              new Product { Code = 1, Name = "Apple", Scale = 1, Vender = "FreshFarms", PdtDescription = "Organic red apples", QlylnStock = 200, BuyPrice = 1.50m, MSRP = "2.00", ProductlnID = 3 },
              new Product { Code = 2, Name = "Bread", Scale = 1, Vender = "BakersBest", PdtDescription = "Whole wheat bread loaf", QlylnStock = 150, BuyPrice = 2.50m, MSRP = "3.50", ProductlnID = 3 },
              new Product { Code = 3, Name = "Milk", Scale = 1, Vender = "DairyFarm", PdtDescription = "1L fresh milk", QlylnStock = 100, BuyPrice = 3.00m, MSRP = "4.00", ProductlnID = 3 },
              new Product { Code = 4, Name = "Laptop", Scale = 5, Vender = "Dell", PdtDescription = "High-performance laptop", QlylnStock = 10, BuyPrice = 1500, MSRP = "2000", ProductlnID = 1 },
              new Product { Code = 5, Name = "Phone", Scale = 3, Vender = "Samsung", PdtDescription = "Latest smartphone", QlylnStock = 25, BuyPrice = 800, MSRP = "1200", ProductlnID = 2 }
          );


            modelBuilder.Entity<Office>().HasData(
              new Office { Code = 1, City = "New York", Phone = "123456", Address1 = "123 Main St", State = "NY", Country = "USA", PostalCode = 10001, Territory = "North East" },
              new Office { Code = 2, City = "London", Phone = "789101", Address1 = "456 Queen St", Country = "UK", PostalCode = 20002, Territory = "North East" },
              new Office { Code = 3, City = "Los Angeles", Phone = "987654", Address1 = "789 Sunset Blvd", State = "CA", Country = "USA", PostalCode = 90001, Territory = "West Coast" }
          );

            // modelBuilder.Entity<Employee>().HasData(
            //    new Employee { ID = 1, FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", JobTitle = "CEO", OfficeCode = 1, reportTo = 2 },
            //    new Employee { ID = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", JobTitle = "Manager", OfficeCode = 3, reportTo = 1 },
            //    new Employee { ID = 3, FirstName = "Charlie", LastName = "Brown", Email = "charlie@example.com", JobTitle = "Engineer", OfficeCode = 2, reportTo = 2 },
            //    new Employee { ID = 4, FirstName = "John", LastName = "Doe", Extention = "1234", Email = "johndoe@example.com", JobTitle = "Sales Manager", OfficeCode = 1, reportTo = 1 }
            //);





            modelBuilder.Entity<Employee>().HasData(
                new Employee { ID = 1, FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", JobTitle = "CEO", OfficeCode = 1, reportTo = null },
                new Employee { ID = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", JobTitle = "Manager", OfficeCode = 1, reportTo = 1 },
                new Employee { ID = 3, FirstName = "Charlie", LastName = "Brown", Email = "charlie@example.com", JobTitle = "Engineer", OfficeCode = 2, reportTo = 2 }
            );

            modelBuilder.Entity<Customer>().HasData(
              new Customer { ID = 1, FirstName = "Jane", LastName = "Smith", Phone = "987-654-3210", Address1 = "456 Oak St", City = "Los Angeles", State = "CA", PostalCode = 90001, Country = "USA", CreditLimit = 5000, SalesRepEmployeeNum = 1 },
                new Customer { ID = 2, FirstName = "Mike", LastName = "Johnson", Phone = "555-123-4567", Address1 = "789 Maple Ave", City = "Chicago", State = "IL", PostalCode = 60601, Country = "USA", CreditLimit = 7000, SalesRepEmployeeNum = 2 }

              );

            modelBuilder.Entity<Order>().HasData(
                new Order { ID = 1, OrderDate = new DateTime(2024, 3, 31), ReqiredDate = new DateTime(2024, 4, 7), ShippedDate = new DateTime(2024, 4, 2), Status = 1, CustomerID = 1 },
                new Order { ID = 2, OrderDate = new DateTime(2024, 3, 31), ReqiredDate = new DateTime(2024, 4, 10), ShippedDate = new DateTime(2024, 4, 3), Status = 1, CustomerID = 2 }
            );


            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct { ID = 1, Qty = 2, PriceEach = 599, OrderID = 1, ProductCode = 1 },
                new OrderProduct { ID = 2, Qty = 1, PriceEach = 999, OrderID = 1, ProductCode = 2 },
                new OrderProduct { ID = 3, Qty = 1, PriceEach = 199, OrderID = 2, ProductCode = 3 }
            );
        }

        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Office> Offices { set; get; }
        public virtual DbSet<Payment> Payments { set; get; }
        public virtual DbSet<Customer> Customers { set; get; }

        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<ProductLine> ProductLines { set; get; }
        public virtual DbSet<Order> Orders { set; get; }

        public virtual DbSet<OrderProduct> OrderProducts { set; get; }

    }  
}
