using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 409, DateTimeKind.Local).AddTicks(302), "10.3.21.52", new Guid("f3b264e1-2797-42e9-94d7-2a271794725e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 409, DateTimeKind.Local).AddTicks(4513), "10.3.21.52", new Guid("f86ea682-610d-4cc2-a1f8-0e4e271b72ba") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 409, DateTimeKind.Local).AddTicks(6868), "10.3.21.52", new Guid("a748642f-52f6-47ad-be83-9ba82766f6ab") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 413, DateTimeKind.Local).AddTicks(3251), "10.3.21.52", "https://picsum.photos/640/480/?image=253", new Guid("e191fe80-0c91-40b5-b355-1ceb0e35d804"), "Shirt", 651.26m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 413, DateTimeKind.Local).AddTicks(7828), "10.3.21.52", "https://picsum.photos/640/480/?image=850", new Guid("34499a65-df1e-490c-b513-9de1eae7f646"), "Soap", 918.01m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 414, DateTimeKind.Local).AddTicks(491), "10.3.21.52", "https://picsum.photos/640/480/?image=814", new Guid("9f7f46a3-219b-4def-93e4-f8f9232ba242"), "Pants", 50.30m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 414, DateTimeKind.Local).AddTicks(2904), "10.3.21.52", "https://picsum.photos/640/480/?image=173", new Guid("05015c0e-1ead-4663-9b89-147437a7735f"), "Chicken", 427.71m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 414, DateTimeKind.Local).AddTicks(5284), "10.3.21.52", "https://picsum.photos/640/480/?image=586", new Guid("4c16d88f-9bc7-4c04-a856-3daf43dd83c7"), "Gloves", 175.44m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 414, DateTimeKind.Local).AddTicks(7688), "10.3.21.52", "https://picsum.photos/640/480/?image=1037", new Guid("eb8432d3-2be3-40dc-8303-fd72a20d3646"), "Table", 108.51m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 415, DateTimeKind.Local).AddTicks(106), "10.3.21.52", "https://picsum.photos/640/480/?image=904", new Guid("1de5b363-58a4-43dc-9825-9ce4532a401f"), "Bacon", 212.75m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 415, DateTimeKind.Local).AddTicks(2464), "10.3.21.52", "https://picsum.photos/640/480/?image=671", new Guid("aa2ec005-af9e-4645-9133-08b84a89302b"), "Bike", 496.85m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 415, DateTimeKind.Local).AddTicks(4883), "10.3.21.52", "https://picsum.photos/640/480/?image=446", new Guid("12705a1d-8f9b-4ec6-9e1a-9afed0e44ec3"), "Bike", 905.23m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 415, DateTimeKind.Local).AddTicks(7256), "10.3.21.52", "https://picsum.photos/640/480/?image=938", new Guid("978a8ee5-1186-41b6-abc5-8ad9b415a07b"), "Chicken", 939.85m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 415, DateTimeKind.Local).AddTicks(9596), "10.3.21.52", "https://picsum.photos/640/480/?image=342", new Guid("b3f36c3f-a8b1-459a-a69a-f371fdb63922"), "Keyboard", 376.80m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 416, DateTimeKind.Local).AddTicks(1909), "10.3.21.52", "https://picsum.photos/640/480/?image=446", new Guid("7fb7c3c3-273b-488d-8dae-244adb53d072"), "Bike", 393.19m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 416, DateTimeKind.Local).AddTicks(4187), "10.3.21.52", "https://picsum.photos/640/480/?image=356", new Guid("b5636def-0315-40fb-9cdc-96e07bcc12f4"), "Tuna", 953.29m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 416, DateTimeKind.Local).AddTicks(6484), "10.3.21.52", "https://picsum.photos/640/480/?image=352", new Guid("22885bdb-9e1f-401d-ba91-bfc3be0ada8a"), "Chicken", 520.19m, (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 416, DateTimeKind.Local).AddTicks(9321), "10.3.21.52", "https://picsum.photos/640/480/?image=130", new Guid("2c8567b9-2873-4eb4-b655-3c4944ae849d"), "Bacon", 259.28m, (short)93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 417, DateTimeKind.Local).AddTicks(2133), "10.3.21.52", "https://picsum.photos/640/480/?image=490", new Guid("e469f7e1-8938-4d8a-8679-60675bca59c0"), "Chair", 352.62m, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 417, DateTimeKind.Local).AddTicks(5111), "10.3.21.52", "https://picsum.photos/640/480/?image=988", new Guid("6889d370-ed3f-455c-895d-f6f137d7a8b5"), "Mouse", 863.37m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 417, DateTimeKind.Local).AddTicks(8670), "10.3.21.52", "https://picsum.photos/640/480/?image=425", new Guid("26f6964b-e966-4ed8-8f22-9ce5f1e90ed3"), "Shirt", 925.81m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 418, DateTimeKind.Local).AddTicks(1129), "10.3.21.52", "https://picsum.photos/640/480/?image=443", new Guid("12921094-ae06-4ffa-a97b-56ce90479769"), "Salad", 320.42m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 418, DateTimeKind.Local).AddTicks(3491), "10.3.21.52", "https://picsum.photos/640/480/?image=504", new Guid("62af03f6-8099-4e87-b0ce-15fe528293fe"), "Table", 836.60m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 418, DateTimeKind.Local).AddTicks(5920), "10.3.21.52", "https://picsum.photos/640/480/?image=413", new Guid("5b0fa68a-3447-4dc6-95d3-f84dc1effa3d"), "Chair", 112.18m, (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 418, DateTimeKind.Local).AddTicks(8244), "10.3.21.52", "https://picsum.photos/640/480/?image=1068", new Guid("f675f81d-694a-49e1-861f-7577e355ddb5"), "Bike", 461.04m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 419, DateTimeKind.Local).AddTicks(558), "10.3.21.52", "https://picsum.photos/640/480/?image=521", new Guid("1471baad-f5c3-4944-9a7a-383b472c8498"), "Keyboard", 287.16m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 419, DateTimeKind.Local).AddTicks(2855), "10.3.21.52", "https://picsum.photos/640/480/?image=634", new Guid("4dd5932e-f3ee-4d5b-8aaf-b1d41052510b"), "Fish", 890.60m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 419, DateTimeKind.Local).AddTicks(5167), "10.3.21.52", "https://picsum.photos/640/480/?image=905", new Guid("f068a6ea-1a42-46fa-a47b-6b95755be829"), "Chips", 408.99m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 419, DateTimeKind.Local).AddTicks(7454), "10.3.21.52", "https://picsum.photos/640/480/?image=357", new Guid("567dacae-f7b4-4fc1-bec5-32d6732cde4b"), "Chips", 202.30m, (short)11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 419, DateTimeKind.Local).AddTicks(9827), "10.3.21.52", "https://picsum.photos/640/480/?image=947", new Guid("6273f42f-22d2-4144-ace7-23931390cb9c"), "Ball", 424.19m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 420, DateTimeKind.Local).AddTicks(2132), "10.3.21.52", "https://picsum.photos/640/480/?image=59", new Guid("2a717fb4-7e9e-4538-9334-6853edb447d2"), "Computer", 804.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 420, DateTimeKind.Local).AddTicks(4403), "10.3.21.52", "https://picsum.photos/640/480/?image=618", new Guid("8a83fd65-26c9-4edb-b3e7-251d9a9c8298"), "Cheese", 383.24m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 420, DateTimeKind.Local).AddTicks(6659), "10.3.21.52", "https://picsum.photos/640/480/?image=386", new Guid("814a5d97-1cf0-4dc9-ba62-767427781329"), "Hat", 881.75m, (short)84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 420, DateTimeKind.Local).AddTicks(8929), "10.3.21.52", "https://picsum.photos/640/480/?image=872", new Guid("1d92db53-3124-4643-9d59-27f86bb36b8c"), "Chips", 138.07m, (short)85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 421, DateTimeKind.Local).AddTicks(1195), "10.3.21.52", "https://picsum.photos/640/480/?image=368", new Guid("b0958e80-4739-44b1-bb79-386cfb14ef38"), "Chips", 497.17m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 421, DateTimeKind.Local).AddTicks(3438), "10.3.21.52", "https://picsum.photos/640/480/?image=724", new Guid("a734a194-9e95-4cb9-b228-70f0b5a5e588"), "Cheese", 661.28m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 421, DateTimeKind.Local).AddTicks(8311), "10.3.21.52", new Guid("1542eceb-6f0f-42d9-8455-44843c4aaa43") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 422, DateTimeKind.Local).AddTicks(603), "10.3.21.52", new Guid("eb26b8bc-5290-4b39-8354-27c4b71dc81d") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "KDK-101-PC09-YZ", new DateTime(2024, 5, 29, 10, 31, 55, 422, DateTimeKind.Local).AddTicks(2761), "10.3.21.52", new Guid("c00b077f-4ffc-45b8-9908-83b62c3035cf") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 953, DateTimeKind.Local).AddTicks(7871), "192.168.1.21", new Guid("7f464add-758e-451c-93cf-bf9ae6627784") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 954, DateTimeKind.Local).AddTicks(721), "192.168.1.21", new Guid("2aacced2-9d78-4d09-a4c8-f855e848d559") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 954, DateTimeKind.Local).AddTicks(2402), "192.168.1.21", new Guid("6cc76d09-094a-4377-b39b-90f9de15a06f") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 956, DateTimeKind.Local).AddTicks(6809), "192.168.1.21", "https://picsum.photos/640/480/?image=375", new Guid("894fd03b-23b1-4fa5-b9cc-fa3f87210e1e"), "Sausages", 614.54m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 956, DateTimeKind.Local).AddTicks(8926), "192.168.1.21", "https://picsum.photos/640/480/?image=383", new Guid("364c173d-fc9d-4ac3-ae39-50f11978c3a1"), "Towels", 583.94m, (short)23 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(599), "192.168.1.21", "https://picsum.photos/640/480/?image=90", new Guid("35237ae7-07f9-4464-8bbd-3f3d2efe14e5"), "Car", 866.15m, (short)82 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(2205), "192.168.1.21", "https://picsum.photos/640/480/?image=404", new Guid("57db7647-aaad-43e5-86ec-f0bbd36d5c85"), "Computer", 329.90m, (short)62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(3805), "192.168.1.21", "https://picsum.photos/640/480/?image=552", new Guid("bfd1d9fa-6eb3-4bdd-9aaa-1c8168fe11e0"), "Pants", 170.75m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(5704), "192.168.1.21", "https://picsum.photos/640/480/?image=150", new Guid("2c3c26fc-dea9-475c-8883-8a88664206a8"), "Gloves", 445.67m, (short)46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(7236), "192.168.1.21", "https://picsum.photos/640/480/?image=354", new Guid("a606a4a5-009a-4e88-b8a4-d617248f6b38"), "Shirt", 841.06m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(8746), "192.168.1.21", "https://picsum.photos/640/480/?image=815", new Guid("70dcb1e0-1ffe-42bb-910f-6723368c3b08"), "Ball", 589.02m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(252), "192.168.1.21", "https://picsum.photos/640/480/?image=670", new Guid("3ca256a1-67f4-4546-957b-982e9885a040"), "Chicken", 611.19m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(1755), "192.168.1.21", "https://picsum.photos/640/480/?image=354", new Guid("3eb6aacc-4b9f-4c15-80a2-31722e9e0c13"), "Hat", 125.00m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(3271), "192.168.1.21", "https://picsum.photos/640/480/?image=266", new Guid("07ff7ff5-07bd-46ff-860d-0346ac5e507b"), "Chair", 874.31m, (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(4807), "192.168.1.21", "https://picsum.photos/640/480/?image=302", new Guid("0cfba335-fd4d-4c4a-832a-c12204476638"), "Shoes", 32.69m, (short)74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(6428), "192.168.1.21", "https://picsum.photos/640/480/?image=629", new Guid("2029e62d-1f09-41fc-9320-3e4a19f8a392"), "Shoes", 376.00m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(7928), "192.168.1.21", "https://picsum.photos/640/480/?image=1075", new Guid("e1f7b54d-5e69-43bb-aef3-66ef46135497"), "Hat", 941.58m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(9424), "192.168.1.21", "https://picsum.photos/640/480/?image=674", new Guid("60ca5681-c1c0-45fd-a1a7-caa2d940a183"), "Keyboard", 649.28m, (short)83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(919), "192.168.1.21", "https://picsum.photos/640/480/?image=186", new Guid("780a9728-c7d6-4d75-b45c-23130db110f9"), "Car", 598.64m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(2413), "192.168.1.21", "https://picsum.photos/640/480/?image=449", new Guid("5a8ed91c-7d9d-4e8b-847e-419191b1d44a"), "Shoes", 401.36m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(3913), "192.168.1.21", "https://picsum.photos/640/480/?image=805", new Guid("451f9968-8f62-4f6e-94d5-4eede6257de1"), "Sausages", 531.59m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(5455), "192.168.1.21", "https://picsum.photos/640/480/?image=347", new Guid("9275a5e8-49be-4211-a555-02428e0cde05"), "Sausages", 699.10m, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(6967), "192.168.1.21", "https://picsum.photos/640/480/?image=193", new Guid("ad44694f-7a7f-4c3f-9b2c-646224e705bb"), "Ball", 674.64m, (short)1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(8456), "192.168.1.21", "https://picsum.photos/640/480/?image=725", new Guid("f8900a0a-0579-43f3-b13a-d4adfb0f0079"), "Gloves", 106.02m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(9946), "192.168.1.21", "https://picsum.photos/640/480/?image=1066", new Guid("e2e85b7b-215e-4f61-8fa1-f20e1d60d65e"), "Computer", 899.01m, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(1433), "192.168.1.21", "https://picsum.photos/640/480/?image=262", new Guid("75bccfe2-3547-4efc-8019-5d5f31325675"), "Ball", 765.13m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(2904), "192.168.1.21", "https://picsum.photos/640/480/?image=301", new Guid("6c8a7e4c-f502-40f7-9789-6fb558e2094e"), "Tuna", 847.74m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(4387), "192.168.1.21", "https://picsum.photos/640/480/?image=381", new Guid("817a79fd-bdb6-42cd-a876-5817b9d6ea35"), "Ball", 553.75m, (short)21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(5931), "192.168.1.21", "https://picsum.photos/640/480/?image=319", new Guid("88bbb1f0-8870-4b02-936c-d4c2c564e5f1"), "Fish", 532.17m, (short)81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(7417), "192.168.1.21", "https://picsum.photos/640/480/?image=15", new Guid("e6823585-5850-4ce5-abd3-40249ae480f7"), "Bacon", 914.11m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(8905), "192.168.1.21", "https://picsum.photos/640/480/?image=719", new Guid("b92665a6-39e6-4ecf-a660-3605414aed68"), "Tuna", 70.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(392), "192.168.1.21", "https://picsum.photos/640/480/?image=928", new Guid("8fe146e2-e812-433c-8d9b-d12d969bfa63"), "Bike", 702.90m, (short)86 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(1888), "192.168.1.21", "https://picsum.photos/640/480/?image=615", new Guid("ea4777f0-c7d3-428e-9ccd-cb76dd3fcdc8"), "Car", 433.25m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(3380), "192.168.1.21", "https://picsum.photos/640/480/?image=29", new Guid("3fc8cf4d-3489-40db-ac6b-54779ec98430"), "Sausages", 32.38m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(4860), "192.168.1.21", "https://picsum.photos/640/480/?image=555", new Guid("62e43089-0b32-4d70-b703-6aef65dee9ca"), "Tuna", 813.52m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(6352), "192.168.1.21", "https://picsum.photos/640/480/?image=752", new Guid("cc264dac-1e5c-41ad-a514-77e3c38309d3"), "Bacon", 288.59m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(8968), "192.168.1.21", new Guid("3f2bbb8d-3c48-45ec-9cae-160f0e64372d") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 962, DateTimeKind.Local).AddTicks(492), "192.168.1.21", new Guid("c7152f9e-42eb-4a47-bd10-57c15765ebd1") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 962, DateTimeKind.Local).AddTicks(1956), "192.168.1.21", new Guid("14818fb1-a6ce-4103-9100-a7070e277365") });
        }
    }
}
