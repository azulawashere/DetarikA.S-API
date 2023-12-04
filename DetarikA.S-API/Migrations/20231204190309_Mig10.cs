using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Dealers",
                newName: "Yaratılma Tarihi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(7332), "Sokaklarda bilgisayarı ex sıfat kutusu değirmeni ex kutusu voluptas dolayı." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(7639), "Otobüs adresini ullam corporis veniam ab quis göze ut filmini." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(7702), "Layıkıyla filmini nisi eum domates filmini için velit ut açılmadan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Outdoors", new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(7756), "Layıkıyla ab nesciunt ex aut magnam sinema numquam qui uzattı." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(7869), "Tasty Wooden Table", 907.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(8030), "Handmade Frozen Chips", 350.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(8070), "Rustic Rubber Gloves", 98.27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(8105), "Awesome Frozen Bike", 820.01m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yaratılma Tarihi",
                table: "Dealers",
                newName: "CreatedDate");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(6711), "Veniam ki bilgiyasayarı dergi aut in telefonu totam quis dicta." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Industrial", new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7030), "Nostrum voluptatum qui magnam ut sit filmini sed ut anlamsız." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Jewelery", new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7093), "Architecto gitti nihil sıfat çakıl patlıcan ratione voluptatem laboriosam et." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Industrial", new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7155), "Odio sed olduğu mutlu nesciunt blanditiis nostrum dağılımı un perferendis." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7284), "Practical Plastic Table", 353.90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7445), "Handcrafted Steel Pants", 188.62m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7482), "Fantastic Metal Towels", 115.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 2, 48, 765, DateTimeKind.Utc).AddTicks(7520), "Handcrafted Concrete Tuna", 672.60m });
        }
    }
}
