using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Code", "Address1", "Address2", "City", "Country", "Phone", "PostalCode", "State", "Territory" },
                values: new object[,]
                {
                    { 1, "123 Main St", null, "New York", "USA", "123456", 10001, "NY", "North East" },
                    { 2, "456 Queen St", null, "London", "UK", "789101", 20002, null, "North East" },
                    { 3, "789 Sunset Blvd", null, "Los Angeles", "USA", "987654", 90001, "CA", "West Coast" }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "DesclnHTML", "DesclnText", "Image" },
                values: new object[,]
                {
                    { 1, "<b>Electronics</b>", "Electronics", "electronics.jpg" },
                    { 2, "<b>Mobile Devices</b>", "Mobile Devices", "mobile.jpg" },
                    { 3, "<b>Food Products</b>", "Food", "food.jpg" },
                    { 4, "<b>Home Appliances</b>", "Appliances", "appliances.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Extention", "FirstName", "JobTitle", "LastName", "OfficeCode", "reportTo" },
                values: new object[] { 1, "alice@example.com", null, "Alice", "CEO", "Smith", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Code", "BuyPrice", "MSRP", "Name", "PdtDescription", "ProductlnID", "QlylnStock", "Scale", "Vender" },
                values: new object[,]
                {
                    { 1, 1.50m, "2.00", "Apple", "Organic red apples", 3, 200, 1, "FreshFarms" },
                    { 2, 2.50m, "3.50", "Bread", "Whole wheat bread loaf", 3, 150, 1, "BakersBest" },
                    { 3, 3.00m, "4.00", "Milk", "1L fresh milk", 3, 100, 1, "DairyFarm" },
                    { 4, 1500m, "2000", "Laptop", "High-performance laptop", 1, 10, 5, "Dell" },
                    { 5, 800m, "1200", "Phone", "Latest smartphone", 2, 25, 3, "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address1", "Address2", "City", "Country", "CreditLimit", "FirstName", "LastName", "Name", "Phone", "PostalCode", "SalesRepEmployeeNum", "State" },
                values: new object[] { 1, "456 Oak St", null, "Los Angeles", "USA", 5000, "Jane", "Smith", null, "987-654-3210", 90001, 1, "CA" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Extention", "FirstName", "JobTitle", "LastName", "OfficeCode", "reportTo" },
                values: new object[] { 2, "bob@example.com", null, "Bob", "Manager", "Johnson", 1, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address1", "Address2", "City", "Country", "CreditLimit", "FirstName", "LastName", "Name", "Phone", "PostalCode", "SalesRepEmployeeNum", "State" },
                values: new object[] { 2, "789 Maple Ave", null, "Chicago", "USA", 7000, "Mike", "Johnson", null, "555-123-4567", 60601, 2, "IL" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Extention", "FirstName", "JobTitle", "LastName", "OfficeCode", "reportTo" },
                values: new object[] { 3, "charlie@example.com", null, "Charlie", "Engineer", "Brown", 2, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Comments", "CustomerID", "OrderDate", "ReqiredDate", "ShippedDate", "Status" },
                values: new object[] { 1, null, 1, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "ID", "OrderID", "PriceEach", "ProductCode", "Qty" },
                values: new object[,]
                {
                    { 1, 1, 599, 1, 2 },
                    { 2, 1, 999, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Comments", "CustomerID", "OrderDate", "ReqiredDate", "ShippedDate", "Status" },
                values: new object[] { 2, null, 2, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "ID", "OrderID", "PriceEach", "ProductCode", "Qty" },
                values: new object[] { 3, 2, 199, 3, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Code",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductLines",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Code",
                keyValue: 1);
        }
    }
}
