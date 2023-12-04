using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class _31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Baby", new DateTime(2023, 12, 4, 20, 8, 54, 410, DateTimeKind.Utc).AddTicks(9274), "Kapının türemiş nemo ötekinden çünkü magnam ekşili dolorem umut nostrum." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Home", new DateTime(2023, 12, 4, 20, 8, 54, 410, DateTimeKind.Utc).AddTicks(9759), "Ea karşıdakine filmini odio vitae makinesi aspernatur koyun ea ab." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Garden", new DateTime(2023, 12, 4, 20, 8, 54, 410, DateTimeKind.Utc).AddTicks(9888), "Quia kalemi anlamsız gülüyorum ullam eius teldeki gazete alias batarya." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 4, 20, 8, 54, 411, DateTimeKind.Utc).AddTicks(2), "Duyulmamış gül çünkü layıkıyla ullam bilgisayarı sequi voluptatum karşıdakine açılmadan." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 20, 8, 54, 411, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 8, 54, 411, DateTimeKind.Utc).AddTicks(214), "Practical Plastic Sausages", 576.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 8, 54, 411, DateTimeKind.Utc).AddTicks(436), "Ergonomic Fresh Hat", 550.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 8, 54, 411, DateTimeKind.Utc).AddTicks(524), "Intelligent Soft Keyboard", 738.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 8, 54, 411, DateTimeKind.Utc).AddTicks(607), "Unbranded Soft Sausages", 355.92m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Grocery", new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(25), "Ötekinden aspernatur bahar beğendim eos makinesi vitae aspernatur domates veritatis." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Beauty", new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(463), "Dergi bundan inventore bahar eius reprehenderit hesap çünkü biber enim." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Sports", new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(594), "Reprehenderit gül bundan dolores sed voluptatem sit dolore architecto ipsa." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "Yaratılma Tarihi", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(713), "Yazın ki commodi layıkıyla yazın et dergi değerli alias nostrum." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(981), "Handmade Soft Tuna", 894.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(1190), "Practical Granite Towels", 150.03m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(1277), "Rustic Rubber Car", 518.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Yaratılma Tarihi", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 20, 5, 53, 386, DateTimeKind.Utc).AddTicks(1360), "Unbranded Steel Chair", 590.79m });
        }
    }
}
