using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DetarikA.S_API.Migrations
{
    /// <inheritdoc />
    public partial class Mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2229), "Çorba beğendim türemiş gördüm sed öyle quasi aliquam doloremque nihil." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2564), "Bilgisayarı quia öyle layıkıyla et rem eum ipsum kulu patlıcan." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2654), "Ut neque düşünüyor voluptatem lambadaki alias dergi voluptatem şafak quasi." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2718), "Fugit quae lakin et illo aut odit kapının quam doğru." });

            migrationBuilder.UpdateData(
                table: "Dealers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(2853), "Fantastic Cotton Gloves", 803.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3018), "Awesome Cotton Shoes", 723.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3054), "Incredible Fresh Mouse", 804.86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 18, 57, 46, 446, DateTimeKind.Utc).AddTicks(3114), "Awesome Soft Salad", 723.24m });
        }
    }
}
