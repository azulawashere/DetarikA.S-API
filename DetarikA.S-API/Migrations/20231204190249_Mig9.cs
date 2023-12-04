using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "Yaratılma Tarihi");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yaratılma Tarihi",
                table: "Categories",
                newName: "CreatedDate");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2023, 12, 4, 19, 0, 1, 657, DateTimeKind.Utc).AddTicks(9875), "Incidunt odit açılmadan voluptatem quasi kalemi ea aut minima eius." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(177), "Et çakıl blanditiis quis autem adanaya koyun duyulmamış hesap ama." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(271), "Mi aspernatur aliquid nesciunt çıktılar bilgisayarı nostrum açılmadan dağılımı dolores." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(326), "Aspernatur sarmal otobüs dolores sıla makinesi iusto karşıdakine quia gördüm." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(460), "Unbranded Fresh Pants", 71.27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(625), "Awesome Fresh Table", 559.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(668), "Practical Fresh Table", 408.74m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 0, 1, 658, DateTimeKind.Utc).AddTicks(732), "Unbranded Steel Keyboard", 563.89m });
        }
    }
}
