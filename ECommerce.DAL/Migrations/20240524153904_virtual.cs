using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class @virtual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 240, DateTimeKind.Local).AddTicks(9985), "192.168.1.21", new Guid("46823ac9-be03-4429-95d8-fc97788846f9") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 241, DateTimeKind.Local).AddTicks(2636), "192.168.1.21", new Guid("a77d8b33-de7f-4344-82c0-6b99550ee15b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 241, DateTimeKind.Local).AddTicks(4222), "192.168.1.21", new Guid("9301e476-774b-415d-9608-dee13c808b23") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 242, DateTimeKind.Local).AddTicks(8418), "192.168.1.21", "https://picsum.photos/640/480/?image=742", new Guid("478db1db-f370-4c3d-844b-992844dbbb53"), "Shoes", 743.57m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(227), "192.168.1.21", "https://picsum.photos/640/480/?image=1053", new Guid("f6ecfdd2-c679-497e-a2c8-57c978f7c153"), "Chair", 22.91m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(1794), "192.168.1.21", "https://picsum.photos/640/480/?image=247", new Guid("2dd25fed-66b3-4b6f-bb23-6373d7715fd6"), "Mouse", 934.20m, (short)81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(3285), "192.168.1.21", "https://picsum.photos/640/480/?image=778", new Guid("87f39d54-58ab-466a-b527-438abfe052d5"), "Chicken", 218.14m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(4743), "192.168.1.21", "https://picsum.photos/640/480/?image=1060", new Guid("e8253b60-046c-4f0f-82ec-ebe19ddb9281"), "Bike", 359.88m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(6197), "192.168.1.21", "https://picsum.photos/640/480/?image=161", new Guid("fa641415-a870-472c-ac6a-44981e9b2c1a"), "Cheese", 774.14m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(7626), "192.168.1.21", "https://picsum.photos/640/480/?image=265", new Guid("9fb6dea5-6e07-4755-b90c-a90a66486370"), "Chips", 391.03m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(9043), "192.168.1.21", "https://picsum.photos/640/480/?image=976", new Guid("c366263b-fa0b-4cca-9b4a-20030d119499"), "Salad", 926.17m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(467), "192.168.1.21", "https://picsum.photos/640/480/?image=764", new Guid("8e7db928-74a2-49a2-82e7-67b40b084242"), "Chair", 228.02m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(1894), "192.168.1.21", "https://picsum.photos/640/480/?image=494", new Guid("5d9806e7-fa2b-49b6-9b2e-19c9daf7ea74"), "Pants", 385.10m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(3307), "192.168.1.21", "https://picsum.photos/640/480/?image=1019", new Guid("4f27a0f4-fb37-4cc5-a579-ecf3fd7648f2"), "Tuna", 126.25m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(4741), "192.168.1.21", "https://picsum.photos/640/480/?image=663", new Guid("766c3290-3607-4e14-aae6-ae74b144c160"), "Bike", 901.52m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(6156), "192.168.1.21", "https://picsum.photos/640/480/?image=702", new Guid("3755cdda-87ce-44aa-bbd5-873424c3e146"), "Mouse", 885.82m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(7555), "192.168.1.21", "https://picsum.photos/640/480/?image=755", new Guid("c4eadc16-1666-4e2f-9501-71dc4393677e"), "Computer", 691.36m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(8953), "192.168.1.21", "https://picsum.photos/640/480/?image=1009", new Guid("e1b246bf-4d5b-4072-93c9-8feac5437250"), "Ball", 756.64m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(356), "192.168.1.21", "https://picsum.photos/640/480/?image=788", new Guid("8f211010-1b1a-4ff4-bd76-fba4d74e1487"), "Mouse", 965.84m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(1753), "192.168.1.21", "https://picsum.photos/640/480/?image=903", new Guid("eb413557-9f83-4b69-993e-5c6a0548f771"), "Fish", 689.40m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(3172), "192.168.1.21", "https://picsum.photos/640/480/?image=861", new Guid("d21d1cde-e289-4d34-9e0d-b55098c13be1"), "Bike", 948.93m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(4603), "192.168.1.21", "https://picsum.photos/640/480/?image=568", new Guid("6236c0f1-ec76-4496-807c-c2d1c1e5c521"), "Bike", 529.22m, (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(5995), "192.168.1.21", "https://picsum.photos/640/480/?image=966", new Guid("8634030c-9cd5-41e6-a52c-43c3b20830ab"), "Shirt", 126.70m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(7395), "192.168.1.21", "https://picsum.photos/640/480/?image=1058", new Guid("e8c42c62-a684-4c89-aaa2-373c2b77a1f4"), "Hat", 734.55m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(8794), "192.168.1.21", "https://picsum.photos/640/480/?image=636", new Guid("8bd39b11-8584-4253-9172-079a499d5f5c"), "Salad", 633.40m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(176), "192.168.1.21", "https://picsum.photos/640/480/?image=382", new Guid("f86113f3-0d8f-4aa2-8f29-479a11d1543a"), "Bike", 804.98m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(1560), "192.168.1.21", "https://picsum.photos/640/480/?image=2", new Guid("239c83e2-040b-44d8-9cf4-956c67796726"), "Tuna", 25.18m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(2966), "192.168.1.21", "https://picsum.photos/640/480/?image=606", new Guid("4d1291e7-f4db-4e60-ba50-5efa97904ab1"), "Bacon", 53.33m, (short)29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(4375), "192.168.1.21", "https://picsum.photos/640/480/?image=171", new Guid("8ded2b3a-7ae7-4d19-bc01-4302a1351498"), 398.51m, (short)95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(5785), "192.168.1.21", "https://picsum.photos/640/480/?image=807", new Guid("70c5efd7-f484-4618-985e-21123629af93"), "Pants", 462.05m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(7169), "192.168.1.21", "https://picsum.photos/640/480/?image=117", new Guid("40987884-3df4-475c-b52d-e40da26d5310"), "Chicken", 149.59m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(8560), "192.168.1.21", "https://picsum.photos/640/480/?image=250", new Guid("f0ce37f6-3224-4f65-b2db-1c8f00d88dfc"), "Table", 407.52m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(9963), "192.168.1.21", "https://picsum.photos/640/480/?image=11", new Guid("b523c29e-3738-430e-99b0-dc31d077c34c"), "Cheese", 487.90m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(1369), "192.168.1.21", "https://picsum.photos/640/480/?image=558", new Guid("576bbe44-e2b0-43a9-a942-29f8c3075a6c"), "Chair", 858.39m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(2761), "192.168.1.21", "https://picsum.photos/640/480/?image=221", new Guid("29a6fabd-30ce-4e10-87a9-f27bbc9d44c0"), "Tuna", 775.82m, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(4162), "192.168.1.21", "https://picsum.photos/640/480/?image=0", new Guid("fb12a40c-6527-4839-a65e-576f37d93401"), "Chicken", 224.11m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(6167), "192.168.1.21", new Guid("679e5a58-9151-4ff8-8607-1c4334e299b4") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(7591), "192.168.1.21", new Guid("3f0205fc-b9d3-44bc-975a-bd4c2ca591da") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(8958), "192.168.1.21", new Guid("1eb51741-d528-489b-98c6-9117ff0277e0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 882, DateTimeKind.Local).AddTicks(3305), "192.168.1.31", new Guid("eaae78fd-5e98-4034-a168-7a8474732452") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 882, DateTimeKind.Local).AddTicks(6074), "192.168.1.31", new Guid("3731f474-725e-4b25-849a-ee1f7b79f925") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 882, DateTimeKind.Local).AddTicks(7753), "192.168.1.31", new Guid("c96be295-7d78-4565-a07d-299adeeb3939") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(2539), "192.168.1.31", "https://picsum.photos/640/480/?image=56", new Guid("9694f04c-a593-4a2a-be4a-a347764598ca"), "Computer", 849.30m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(4455), "192.168.1.31", "https://picsum.photos/640/480/?image=127", new Guid("d5f89680-bb8b-40a2-93cc-125c17d15c39"), "Chips", 531.07m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(6214), "192.168.1.31", "https://picsum.photos/640/480/?image=342", new Guid("7b89c4ad-d30f-405b-b876-41ad7e94f48c"), "Keyboard", 249.90m, (short)92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(8496), "192.168.1.31", "https://picsum.photos/640/480/?image=672", new Guid("ad5fe80c-d018-4790-87c7-8fd612df3cfd"), "Cheese", 959.55m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(299), "192.168.1.31", "https://picsum.photos/640/480/?image=695", new Guid("2018c039-b1ae-47ae-85a5-62c7baaac877"), "Mouse", 364.15m, (short)87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(1910), "192.168.1.31", "https://picsum.photos/640/480/?image=423", new Guid("9935587b-c569-400d-aa2f-e4aaea037cb2"), "Chair", 374.56m, (short)27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(3479), "192.168.1.31", "https://picsum.photos/640/480/?image=539", new Guid("3f108704-7d5d-4943-8e3d-316779d7cf25"), "Hat", 272.85m, (short)75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(5026), "192.168.1.31", "https://picsum.photos/640/480/?image=486", new Guid("48433d6b-6220-44e4-9c9a-2bd76634d1f8"), "Chicken", 502.66m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(6701), "192.168.1.31", "https://picsum.photos/640/480/?image=428", new Guid("efc76e78-dd06-439d-9054-abd354aaa7de"), "Chicken", 404.27m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(8251), "192.168.1.31", "https://picsum.photos/640/480/?image=549", new Guid("e94c1036-b834-49e2-846d-80b6c3c6f7a8"), "Car", 871.75m, (short)21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(9791), "192.168.1.31", "https://picsum.photos/640/480/?image=900", new Guid("447faeeb-57af-4c8c-b7cc-6e9fdd86bd00"), "Salad", 573.54m, (short)97 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(1319), "192.168.1.31", "https://picsum.photos/640/480/?image=938", new Guid("e124cf8e-b9f5-4df2-87a7-20457be93212"), "Sausages", 188.32m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(2832), "192.168.1.31", "https://picsum.photos/640/480/?image=577", new Guid("42c9595c-8f65-4b0f-9b37-893b6c236d1b"), "Cheese", 264.05m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(4335), "192.168.1.31", "https://picsum.photos/640/480/?image=438", new Guid("423b6d92-97e8-4827-8a88-0eaf8483f029"), "Table", 15.03m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(5844), "192.168.1.31", "https://picsum.photos/640/480/?image=415", new Guid("ba7cbf5b-557a-4275-a229-f436cf75ba56"), "Towels", 102.08m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(7376), "192.168.1.31", "https://picsum.photos/640/480/?image=895", new Guid("f8831f82-bab1-4873-bb93-4487b88f3200"), "Bike", 183.33m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(8875), "192.168.1.31", "https://picsum.photos/640/480/?image=683", new Guid("5836a734-7455-4d34-a2ac-3353109b1607"), "Salad", 192.71m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(486), "192.168.1.31", "https://picsum.photos/640/480/?image=640", new Guid("a438ebf3-ee5f-442b-9b80-b5d973c41bcd"), "Fish", 146.08m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(2006), "192.168.1.31", "https://picsum.photos/640/480/?image=799", new Guid("241e9263-a0ac-41db-af73-9ca5e027b4d9"), "Salad", 354.90m, (short)1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(3511), "192.168.1.31", "https://picsum.photos/640/480/?image=1083", new Guid("72e0f9e0-faef-4ff1-b9df-2b179d449952"), "Bacon", 621.35m, (short)15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(5022), "192.168.1.31", "https://picsum.photos/640/480/?image=889", new Guid("758dda50-1a5f-4d5f-bb1c-7747f174195d"), "Shoes", 693.30m, (short)47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(6543), "192.168.1.31", "https://picsum.photos/640/480/?image=137", new Guid("65986db2-715d-4319-ba37-787f9f448810"), "Table", 155.07m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(8054), "192.168.1.31", "https://picsum.photos/640/480/?image=929", new Guid("45961c16-e9d7-4572-93a2-a015e4ed4382"), "Chair", 929.76m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(9555), "192.168.1.31", "https://picsum.photos/640/480/?image=334", new Guid("1320c3b7-95ef-49e7-a3d1-89e9cc708c03"), "Ball", 358.64m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(1056), "192.168.1.31", "https://picsum.photos/640/480/?image=714", new Guid("fd59c6fc-c855-4fbf-af80-63989d7b7033"), "Pizza", 601.51m, (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(2558), "192.168.1.31", "https://picsum.photos/640/480/?image=78", new Guid("72887347-540a-481b-8dfd-47c809c48ce2"), 906.71m, (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(4050), "192.168.1.31", "https://picsum.photos/640/480/?image=789", new Guid("8fcd700b-1afb-40bd-b9f4-964ab3127d95"), "Pizza", 746.05m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(5532), "192.168.1.31", "https://picsum.photos/640/480/?image=713", new Guid("30b05575-9df2-4c4a-b3ad-732c0c862aaa"), "Shirt", 811.51m, (short)15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(7059), "192.168.1.31", "https://picsum.photos/640/480/?image=10", new Guid("19e033fc-9bfc-43f9-bafe-4adccd2e4eff"), "Pizza", 404.93m, (short)1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(8548), "192.168.1.31", "https://picsum.photos/640/480/?image=44", new Guid("7d2c95b8-3056-4dc4-8344-4bc97831fe14"), "Sausages", 496.87m, (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(32), "192.168.1.31", "https://picsum.photos/640/480/?image=572", new Guid("b05bb36a-5470-4f94-844b-ab694d7605a4"), "Hat", 512.76m, (short)71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(1512), "192.168.1.31", "https://picsum.photos/640/480/?image=576", new Guid("87f74ae8-dce2-46ce-aea7-f405feef22ca"), "Sausages", 824.12m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(3016), "192.168.1.31", "https://picsum.photos/640/480/?image=642", new Guid("3cb1d6e7-3d80-404a-a043-237cb9ec0984"), "Fish", 79.50m, (short)34 });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(5514), "192.168.1.31", new Guid("465f41d1-752d-42a9-81d3-b7965f984929") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(7082), "192.168.1.31", new Guid("8c73097a-4756-46fe-913c-9c2e3fb45963") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatedIpAddress", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(8663), "192.168.1.31", new Guid("85578b48-006c-4b19-a1de-45ddf9a2b1db") });
        }
    }
}
