using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "OrderDetails",
                newName: "Yaratılma Tarihi");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderID", "ProductID" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "Yaratılma Tarihi",
                table: "OrderDetails",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "ID");

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
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 19, 4, 21, 278, DateTimeKind.Utc).AddTicks(9311), "Aut totam voluptatum eve qui consectetur ad adresini hesap voluptatum." });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");
        }
    }
}
