using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Games", new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7192), "Veritatis dignissimos otobüs enim ullam masaya laboriosam camisi ekşili lambadaki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "Description" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7495), "Qui kapının nesciunt mutlu magni amet voluptas otobüs accusantium de." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7589), "Alias şafak koşuyorlar consequatur odit aspernatur kapının molestiae anlamsız ki." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7636), "Gazete de dışarı tv in aut olduğu öyle gülüyorum et." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7714), "Awesome Granite Gloves", 689.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7859), "Licensed Concrete Ball", 608.94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7885), "Sleek Rubber Ball", 539.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 36, 15, 939, DateTimeKind.Utc).AddTicks(7909), "Handcrafted Granite Bike", 472.02m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(602), "Gidecekmiş çorba quis şafak lambadaki sayfası praesentium fugit sevindi consequatur." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "Description" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1006), "Duyulmamış consequatur nemo totam qui modi tv ut göze nihil." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Garden", new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1236), "Eaque sandalye filmini anlamsız otobüs quis blanditiis magni ona gül." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1300), "Voluptatum qui alias modi yapacakmış iure camisi laboriosam de karşıdakine." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1416), "Ergonomic Concrete Towels", 427.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1666), "Licensed Concrete Table", 957.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1753), "Practical Granite Bacon", 898.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1795), "Small Wooden Bacon", 424.74m });
        }
    }
}
