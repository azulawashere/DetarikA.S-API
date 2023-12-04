using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "DeletedDate", "Description", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Shoes", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2229), null, "Çorba beğendim türemiş gördüm sed öyle quasi aliquam doloremque nihil.", null, 1 },
                    { 2, "Automotive", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2564), null, "Bilgisayarı quia öyle layıkıyla et rem eum ipsum kulu patlıcan.", null, 1 },
                    { 3, "Industrial", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2654), null, "Ut neque düşünüyor voluptatem lambadaki alias dergi voluptatem şafak quasi.", null, 1 },
                    { 4, "Movies", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2718), null, "Fugit quae lakin et illo aut odit kapının quam doğru.", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "ID", "CompanyName", "CreatedDate", "DeletedDate", "ModifiedDate", "ShippingAdress", "Status" },
                values: new object[] { 1, "AlfaTeam", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3180), null, null, "Istanbul Tahtakale Merkezzz", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedDate", "DeletedDate", "ModifiedDate", "ProductName", "Status", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2853), null, null, "Fantastic Cotton Gloves", 1, 803.25m },
                    { 2, 2, new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3018), null, null, "Awesome Cotton Shoes", 1, 723.56m },
                    { 3, 3, new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3054), null, null, "Incredible Fresh Mouse", 1, 804.86m },
                    { 4, 4, new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3114), null, null, "Awesome Soft Salad", 1, 723.24m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
