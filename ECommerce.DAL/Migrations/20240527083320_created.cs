using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 810, DateTimeKind.Local).AddTicks(6514), "10.3.21.52", new Guid("409e9ce7-b5f7-4ccc-88ee-dee0c0301496") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 811, DateTimeKind.Local).AddTicks(386), "10.3.21.52", new Guid("83890739-1317-40f4-bf49-834e0373422c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 811, DateTimeKind.Local).AddTicks(2716), "10.3.21.52", new Guid("373b69ff-3ca6-4199-a38f-580d2f112d92") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 819, DateTimeKind.Local).AddTicks(2775), "10.3.21.52", "https://picsum.photos/640/480/?image=532", new Guid("f54e8e70-0388-4c2b-8539-62db8b661ca9"), "Soap", 814.14m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 819, DateTimeKind.Local).AddTicks(7102), "10.3.21.52", "https://picsum.photos/640/480/?image=190", new Guid("67bd4838-cf17-437d-84e7-a615dda0cdf9"), "Soap", 162.27m, (short)36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 819, DateTimeKind.Local).AddTicks(9545), "10.3.21.52", "https://picsum.photos/640/480/?image=1072", new Guid("f96f65c6-4618-485d-a618-66a51bff786e"), "Pizza", 657.81m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 820, DateTimeKind.Local).AddTicks(1893), "10.3.21.52", "https://picsum.photos/640/480/?image=570", new Guid("c3c769b5-ee2e-4344-b1ac-9999d63e239d"), "Chips", 196.69m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 820, DateTimeKind.Local).AddTicks(4144), "10.3.21.52", "https://picsum.photos/640/480/?image=229", new Guid("5af5db49-7521-4478-99cc-cb22a118785a"), "Towels", 776.95m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 820, DateTimeKind.Local).AddTicks(6447), "10.3.21.52", "https://picsum.photos/640/480/?image=779", new Guid("a77c1483-7e34-4fd5-9d36-67f181302b0b"), "Keyboard", 876.14m, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 820, DateTimeKind.Local).AddTicks(8728), "10.3.21.52", "https://picsum.photos/640/480/?image=918", new Guid("fa0ece68-5d9e-46a6-8648-55355c375ebe"), "Ball", 580.58m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 821, DateTimeKind.Local).AddTicks(1064), "10.3.21.52", "https://picsum.photos/640/480/?image=221", new Guid("8b1d82d7-8c45-4182-8dd0-fe32b8d383bd"), "Mouse", 578.96m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 821, DateTimeKind.Local).AddTicks(3362), "10.3.21.52", "https://picsum.photos/640/480/?image=564", new Guid("d09b24e6-d7c3-43ea-97d8-5d1a67a8d2b9"), "Pants", 96.74m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 821, DateTimeKind.Local).AddTicks(5633), "10.3.21.52", "https://picsum.photos/640/480/?image=904", new Guid("fffadd59-eb4c-4b87-bd19-3ba47aae6295"), "Pizza", 863.17m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 821, DateTimeKind.Local).AddTicks(7795), "10.3.21.52", "https://picsum.photos/640/480/?image=475", new Guid("d2f0071b-df25-4426-92ad-3df159358397"), "Mouse", 139.93m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 821, DateTimeKind.Local).AddTicks(9979), "10.3.21.52", "https://picsum.photos/640/480/?image=412", new Guid("f0479a78-1236-478a-bc15-3702f826675f"), "Salad", 429.82m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 822, DateTimeKind.Local).AddTicks(2119), "10.3.21.52", "https://picsum.photos/640/480/?image=351", new Guid("ea636f00-718e-4455-995c-690a3118d8d1"), "Fish", 619.08m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 822, DateTimeKind.Local).AddTicks(4276), "10.3.21.52", "https://picsum.photos/640/480/?image=853", new Guid("7b1f82cf-10a6-4cf9-9701-3f5a13aa06d2"), "Table", 277.91m, (short)84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 822, DateTimeKind.Local).AddTicks(6416), "10.3.21.52", "https://picsum.photos/640/480/?image=100", new Guid("da7477f9-005d-428f-92b6-be81416ff097"), "Pants", 177.38m, (short)5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 822, DateTimeKind.Local).AddTicks(8562), "10.3.21.52", "https://picsum.photos/640/480/?image=115", new Guid("6c4807c3-3d4e-4930-b300-ca0bb6db7af8"), "Pants", 485.81m, (short)44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 823, DateTimeKind.Local).AddTicks(725), "10.3.21.52", "https://picsum.photos/640/480/?image=584", new Guid("4ddc5d75-a571-47ce-89f5-59fa474fd5a6"), "Fish", 483.54m, (short)3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 823, DateTimeKind.Local).AddTicks(2865), "10.3.21.52", "https://picsum.photos/640/480/?image=41", new Guid("d8d06e3d-0c0b-4ad9-95eb-08c711be8efd"), "Hat", 487.35m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 823, DateTimeKind.Local).AddTicks(5015), "10.3.21.52", "https://picsum.photos/640/480/?image=576", new Guid("c4f70011-85f2-489c-ba56-ca3939a88c6f"), "Cheese", 702.44m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 823, DateTimeKind.Local).AddTicks(7157), "10.3.21.52", "https://picsum.photos/640/480/?image=266", new Guid("caf26dc9-e500-49ef-a3c4-bbe37eced6ae"), "Pants", 45.50m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 823, DateTimeKind.Local).AddTicks(9314), "10.3.21.52", "https://picsum.photos/640/480/?image=561", new Guid("7d8e76bb-c738-45e1-a5c5-097af751886d"), "Tuna", 282.37m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 824, DateTimeKind.Local).AddTicks(1437), "10.3.21.52", "https://picsum.photos/640/480/?image=631", new Guid("aa77b849-2557-4107-a20c-b577938057b8"), "Shirt", 22.61m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 824, DateTimeKind.Local).AddTicks(3554), "10.3.21.52", "https://picsum.photos/640/480/?image=132", new Guid("ccc6b5df-6f26-45ee-94da-34dcdc0f446f"), "Bike", 166.03m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 824, DateTimeKind.Local).AddTicks(5670), "10.3.21.52", "https://picsum.photos/640/480/?image=71", new Guid("5e9ed04e-2e96-43c2-9b9d-8181a06806c7"), "Chicken", 278.58m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 824, DateTimeKind.Local).AddTicks(7792), "10.3.21.52", "https://picsum.photos/640/480/?image=914", new Guid("13a8224d-1ed6-49aa-98f1-f48882d8a01a"), "Cheese", 321.36m, (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 824, DateTimeKind.Local).AddTicks(9934), "10.3.21.52", "https://picsum.photos/640/480/?image=407", new Guid("569f3bb3-ac91-44a8-aa43-94c88d70d345"), "Computer", 74.07m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 825, DateTimeKind.Local).AddTicks(2058), "10.3.21.52", "https://picsum.photos/640/480/?image=1047", new Guid("bd2d644b-6bdf-4fed-b728-ecc4125fe3f1"), "Soap", 379.70m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 825, DateTimeKind.Local).AddTicks(4188), "10.3.21.52", "https://picsum.photos/640/480/?image=206", new Guid("49ffc4d4-f8d4-4a33-972a-8652c1e82fda"), "Chicken", 140.04m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 825, DateTimeKind.Local).AddTicks(6321), "10.3.21.52", "https://picsum.photos/640/480/?image=546", new Guid("3cefab0b-6210-415a-bc8c-5fdfb668376c"), "Computer", 552.22m, (short)30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 825, DateTimeKind.Local).AddTicks(8441), "10.3.21.52", "https://picsum.photos/640/480/?image=45", new Guid("905307d5-5e84-419e-ab7c-4ab440966b4b"), "Ball", 335.22m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 826, DateTimeKind.Local).AddTicks(583), "10.3.21.52", "https://picsum.photos/640/480/?image=214", new Guid("cdf60464-cee0-4e22-8f0a-454d12a0da9d"), "Pants", 496.40m, (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 826, DateTimeKind.Local).AddTicks(2709), "10.3.21.52", "https://picsum.photos/640/480/?image=1003", new Guid("e7d8b021-16f2-42fd-a087-e21c61b3bee4"), 184.15m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 826, DateTimeKind.Local).AddTicks(4824), "10.3.21.52", "https://picsum.photos/640/480/?image=626", new Guid("0ac31150-f058-464a-a04d-dc9f966bbac4"), "Car", 160.78m, (short)76 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 826, DateTimeKind.Local).AddTicks(8690), "10.3.21.52", new Guid("73a4ef58-1921-4fb8-b08d-7e6370ba0f51") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 827, DateTimeKind.Local).AddTicks(783), "10.3.21.52", new Guid("0783c6f5-275b-4dfa-9f86-febf3a7f50bc") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 11, 33, 19, 827, DateTimeKind.Local).AddTicks(2792), "10.3.21.52", new Guid("39057ff4-788c-48d2-b1f8-3941a769a01f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 56, DateTimeKind.Local).AddTicks(4901), "192.168.1.21", new Guid("4b2dfcb5-ad2c-4596-b8e2-4a0845958ade") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 56, DateTimeKind.Local).AddTicks(7809), "192.168.1.21", new Guid("53f940a8-971a-4952-800b-23881025177f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 56, DateTimeKind.Local).AddTicks(9508), "192.168.1.21", new Guid("246d5b3f-24cf-482e-ac1a-5567ae1b1bad") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 58, DateTimeKind.Local).AddTicks(7279), "192.168.1.21", "https://picsum.photos/640/480/?image=933", new Guid("a4a6c974-a0e7-4ea7-ab7b-01d44d05705c"), "Table", 583.19m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 58, DateTimeKind.Local).AddTicks(9243), "192.168.1.21", "https://picsum.photos/640/480/?image=175", new Guid("6be4cba7-7825-40de-967c-f1b410bfedf7"), "Towels", 774.15m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(963), "192.168.1.21", "https://picsum.photos/640/480/?image=134", new Guid("618664c7-e6f1-43a1-b413-41f1edf2bdee"), "Fish", 481.71m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(2563), "192.168.1.21", "https://picsum.photos/640/480/?image=806", new Guid("ebaa1474-101a-4d9d-a275-c3cc11d8a749"), "Car", 704.77m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(4130), "192.168.1.21", "https://picsum.photos/640/480/?image=446", new Guid("0abba301-ab9f-4d0d-979e-c1477a89530d"), "Chicken", 800.76m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(5688), "192.168.1.21", "https://picsum.photos/640/480/?image=535", new Guid("ed98a337-cf19-453c-814e-06480a88b5ac"), "Chair", 430.49m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(7247), "192.168.1.21", "https://picsum.photos/640/480/?image=231", new Guid("ec9fa2a8-248b-40d4-a44b-837f1c1b7ea1"), "Keyboard", 88.62m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(8774), "192.168.1.21", "https://picsum.photos/640/480/?image=353", new Guid("37a0cbe2-aa82-4623-a0c0-d5a1298d83d1"), "Bike", 273.83m, (short)36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(303), "192.168.1.21", "https://picsum.photos/640/480/?image=407", new Guid("f1591502-00ef-4a5b-9718-67607ad14e6a"), "Keyboard", 174.32m, (short)26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(1862), "192.168.1.21", "https://picsum.photos/640/480/?image=822", new Guid("005c0c16-e48e-4eba-bc43-359f205139d4"), "Chips", 468.24m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(3426), "192.168.1.21", "https://picsum.photos/640/480/?image=793", new Guid("b1e95828-1269-4634-a1db-e7b67a90992d"), "Ball", 355.64m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(5152), "192.168.1.21", "https://picsum.photos/640/480/?image=1008", new Guid("907cb373-7b8f-4b6b-9f7d-4f6776625e2f"), "Chicken", 105.66m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(6693), "192.168.1.21", "https://picsum.photos/640/480/?image=344", new Guid("2ada21e9-cc33-4205-a993-13595d1cc89c"), "Car", 208.72m, (short)84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(8228), "192.168.1.21", "https://picsum.photos/640/480/?image=1004", new Guid("92da3631-dca0-4414-b465-8b6eacde699d"), "Shoes", 81.99m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(9760), "192.168.1.21", "https://picsum.photos/640/480/?image=287", new Guid("315e6d13-cb4f-4e51-94fd-5e4158761d4b"), "Gloves", 995.46m, (short)3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(1278), "192.168.1.21", "https://picsum.photos/640/480/?image=230", new Guid("85a7d7bd-bbc8-419d-8d93-09d0f2f14a24"), "Mouse", 564.07m, (short)30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(2826), "192.168.1.21", "https://picsum.photos/640/480/?image=822", new Guid("8cc89cb7-cae7-4567-8a5a-7f79539fa649"), "Pizza", 941.47m, (short)46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(4341), "192.168.1.21", "https://picsum.photos/640/480/?image=537", new Guid("49893ad0-96cf-4a9f-9c42-bb7246240a95"), "Bacon", 392.24m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(5845), "192.168.1.21", "https://picsum.photos/640/480/?image=922", new Guid("ef878615-c8e8-497a-9135-5e70a9083020"), "Pants", 901.96m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(7380), "192.168.1.21", "https://picsum.photos/640/480/?image=416", new Guid("28ce095c-d670-4102-b99c-d74f9b83fe00"), "Mouse", 360.55m, (short)11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(8895), "192.168.1.21", "https://picsum.photos/640/480/?image=820", new Guid("904bd5d6-2585-42ec-a82e-d32bf7dce032"), "Gloves", 531.63m, (short)84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(421), "192.168.1.21", "https://picsum.photos/640/480/?image=564", new Guid("663e8840-0f55-477b-b2d6-ef92b6f8465e"), "Computer", 767.42m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(1935), "192.168.1.21", "https://picsum.photos/640/480/?image=59", new Guid("82cf8594-3468-494c-b5c9-e558f0733136"), "Soap", 588.93m, (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(3485), "192.168.1.21", "https://picsum.photos/640/480/?image=228", new Guid("a42b59c8-66b3-4fbb-a028-3d3504e0140f"), "Table", 726.78m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(5005), "192.168.1.21", "https://picsum.photos/640/480/?image=928", new Guid("23c4ae20-823b-476b-b404-add5154b2bee"), "Computer", 219.29m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(6514), "192.168.1.21", "https://picsum.photos/640/480/?image=713", new Guid("357a2fce-89dc-4cb1-a1e1-930097ca7327"), "Ball", 936.36m, (short)86 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(8021), "192.168.1.21", "https://picsum.photos/640/480/?image=946", new Guid("7f145a2a-3716-401a-aee9-349a78febd07"), "Fish", 63.67m, (short)11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(9513), "192.168.1.21", "https://picsum.photos/640/480/?image=1031", new Guid("dd1df45b-f7aa-4e28-9a72-f02250b46682"), "Mouse", 388.33m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(1012), "192.168.1.21", "https://picsum.photos/640/480/?image=10", new Guid("6f93e542-d683-46c2-b30c-7786a200450f"), "Salad", 591.39m, (short)43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(2509), "192.168.1.21", "https://picsum.photos/640/480/?image=145", new Guid("cb472104-362e-4873-b46e-48c5fe6a2aa4"), "Chips", 862.17m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(4005), "192.168.1.21", "https://picsum.photos/640/480/?image=441", new Guid("c219c748-491f-40b8-b516-ef3272b9cce7"), "Table", 515.39m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(5544), "192.168.1.21", "https://picsum.photos/640/480/?image=13", new Guid("f08c11df-4cb0-4fff-af16-4d3f6bb227c0"), 574.28m, (short)89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(7070), "192.168.1.21", "https://picsum.photos/640/480/?image=874", new Guid("856c9b9b-0d50-4fa8-97a0-5a1f3e83ec3a"), "Keyboard", 815.84m, (short)3 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(9637), "192.168.1.21", new Guid("81dc5b83-6325-4b8a-8a0f-b18dc7b4ee8b") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 64, DateTimeKind.Local).AddTicks(1200), "192.168.1.21", new Guid("fd7a0248-fb9b-45e2-889d-884de6e4e5de") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 64, DateTimeKind.Local).AddTicks(2690), "192.168.1.21", new Guid("db26502b-2bf8-40b8-b4fc-35aa0fc5fb18") });
        }
    }
}
