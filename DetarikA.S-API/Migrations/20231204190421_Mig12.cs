using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Orders",
                newName: "Yaratılma Tarihi");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "money",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9044), "Aut teldeki kutusu sed quasi quasi explicabo adanaya sequi sit." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "Description" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9311), "Aut totam voluptatum eve qui consectetur ad adresini hesap voluptatum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9382), "Uzattı reprehenderit quaerat veniam corporis sit sed ekşili karşıdakine quia." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9439), "Yapacakmış eos ki karşıdakine iure nihil aperiam lambadaki sevindi çobanın." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9576), "Handcrafted Steel Table", 885.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9735), "Generic Wooden Shirt", 263.86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9776), "Sleek Fresh Chips", 671.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9811), "Sleek Rubber Table", 265.24m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yaratılma Tarihi",
                table: "Orders",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "TotalPrice",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

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
                columns: new[] { "Yaratılma Tarihi", "Description" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 3, 8, 758, DateTimeKind.Utc).AddTicks(7639), "Otobüs adresini ullam corporis veniam ab quis göze ut filmini." });

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
    }
}
