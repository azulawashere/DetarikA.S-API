using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "Yaratılma Tarihi");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 4, 19, 4, 52, 485, DateTimeKind.Utc).AddTicks(1006), "Duyulmamış consequatur nemo totam qui modi tv ut göze nihil." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yaratılma Tarihi",
                table: "Products",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Electronics", new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(4917), "Koşuyorlar iure dolore bilgiyasayarı et biber quae dignissimos ötekinden nostrum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Computers", new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5225), "De ex çobanın ut eve enim mi ad molestiae totam." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Kids", new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5286), "Açılmadan bilgisayarı aspernatur numquam filmini cesurca totam aliquid et yapacakmış." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5364), "Şafak masanın enim çakıl iusto camisi qui laboriosam umut filmini." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5487), "Awesome Granite Shirt", 255.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5653), "Unbranded Frozen Bacon", 399.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5694), "Ergonomic Frozen Computer", 755.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 4, 42, 354, DateTimeKind.Utc).AddTicks(5730), "Licensed Plastic Ball", 718.02m });
        }
    }
}
