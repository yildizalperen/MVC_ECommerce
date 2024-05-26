using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 699, DateTimeKind.Local).AddTicks(7344), new Guid("d46e50ab-8925-4435-986c-b97a631c7ec6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 700, DateTimeKind.Local).AddTicks(63), new Guid("1e03340e-d99d-4769-973b-6790d83ca6c7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 700, DateTimeKind.Local).AddTicks(1694), new Guid("5d05f597-3f83-46d2-9987-82eba4d8be57") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 701, DateTimeKind.Local).AddTicks(6292), "https://picsum.photos/640/480/?image=28", new Guid("57632bb2-3b6f-4264-b296-befa6c972b12"), "Chips", 442.59m, (short)90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 701, DateTimeKind.Local).AddTicks(8214), "https://picsum.photos/640/480/?image=686", new Guid("2427a31b-cb47-44bd-837a-a31b7002d39b"), "Pizza", 625.11m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 701, DateTimeKind.Local).AddTicks(9852), "https://picsum.photos/640/480/?image=581", new Guid("3bd72d12-a29b-42f5-93a8-fee800bcf68f"), "Pizza", 253.25m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 702, DateTimeKind.Local).AddTicks(1454), "https://picsum.photos/640/480/?image=894", new Guid("e0ce6092-c523-4ff7-8a89-43a2725d0298"), "Pants", 789.57m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 702, DateTimeKind.Local).AddTicks(3026), "https://picsum.photos/640/480/?image=479", new Guid("88785ae8-042a-4090-8d61-759853f903ef"), "Shirt", 369.85m, (short)13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 702, DateTimeKind.Local).AddTicks(4592), "https://picsum.photos/640/480/?image=224", new Guid("b1d18f71-865e-4b46-bc50-282ee84eb720"), "Chair", 355.57m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 702, DateTimeKind.Local).AddTicks(6404), "https://picsum.photos/640/480/?image=423", new Guid("a5fc5cbf-57f2-4dc0-b7cc-ad4b825edf46"), "Salad", 670.10m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 702, DateTimeKind.Local).AddTicks(7982), "https://picsum.photos/640/480/?image=522", new Guid("b4daa563-a8ff-4ffa-be95-244258618d52"), "Fish", 580.22m, (short)92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 702, DateTimeKind.Local).AddTicks(9526), "https://picsum.photos/640/480/?image=367", new Guid("fa0fd2b7-0762-430a-a855-ae24be971ba8"), "Sausages", 620.98m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 703, DateTimeKind.Local).AddTicks(1067), "https://picsum.photos/640/480/?image=521", new Guid("e7d54116-fd37-4c00-b81b-b70e63e6bd47"), "Towels", 390.86m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 703, DateTimeKind.Local).AddTicks(2597), "https://picsum.photos/640/480/?image=27", new Guid("7f0a26c3-6a9e-4981-9fb4-1b0f93948cb1"), "Pants", 374.36m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 703, DateTimeKind.Local).AddTicks(4106), "https://picsum.photos/640/480/?image=653", new Guid("a6a6bc13-c3aa-42b2-a70e-c28aff17da3e"), "Keyboard", 150.04m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 703, DateTimeKind.Local).AddTicks(5604), "https://picsum.photos/640/480/?image=927", new Guid("f107eeff-0f55-4720-ad0c-153e74c0ae27"), "Pizza", 594.92m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 703, DateTimeKind.Local).AddTicks(7122), "https://picsum.photos/640/480/?image=62", new Guid("347f9418-aba1-4a2b-8b6f-21e10a8e55da"), "Ball", 585.96m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 703, DateTimeKind.Local).AddTicks(8614), "https://picsum.photos/640/480/?image=270", new Guid("bc2c2b84-bb0c-400e-97fa-e5eae4dc5bac"), "Cheese", 117.88m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(117), "https://picsum.photos/640/480/?image=82", new Guid("93a4c3b2-f4b9-42cf-85d0-57e1b25150b8"), "Ball", 60.82m, (short)93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(1616), "https://picsum.photos/640/480/?image=468", new Guid("58eeb8a4-5b57-422e-b548-9f6b2868b071"), "Shoes", 562.54m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(3135), "https://picsum.photos/640/480/?image=357", new Guid("22e25bb9-8f06-4efb-9957-21ca191e1a41"), 762.25m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(4629), "https://picsum.photos/640/480/?image=1013", new Guid("55ee22ab-caf4-4bdd-bf38-0bb1c722f061"), "Towels", 500.65m, (short)82 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(6130), "https://picsum.photos/640/480/?image=714", new Guid("f51595ad-cf0c-4cd6-a1eb-bdba8f52c777"), "Fish", 485.85m, (short)44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(7621), "https://picsum.photos/640/480/?image=141", new Guid("5e741c08-4dde-48a1-8b70-16664ad21278"), "Towels", 766.87m, (short)63 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 704, DateTimeKind.Local).AddTicks(9134), "https://picsum.photos/640/480/?image=1062", new Guid("3558011b-83a7-4e81-9eb4-fe3409cd7049"), "Car", 694.48m, (short)44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(626), "https://picsum.photos/640/480/?image=44", new Guid("be8f2a5f-beb7-4d12-bb23-280a9f28270a"), "Tuna", 235.56m, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(2123), "https://picsum.photos/640/480/?image=265", new Guid("2926cbad-df4b-4cc8-9de6-cddc6e84e0ad"), "Fish", 295.47m, (short)66 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(3734), "https://picsum.photos/640/480/?image=470", new Guid("89fc964d-414d-440e-a843-f9ea8e6553ca"), "Table", 515.73m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(5232), "https://picsum.photos/640/480/?image=941", new Guid("d07b3cec-5ec0-431f-9ce1-4a702974039d"), "Computer", 782.07m, (short)34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(6730), "https://picsum.photos/640/480/?image=476", new Guid("db19451d-c3f2-422c-9ef9-99932f11e76f"), "Tuna", 743.21m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(8222), "https://picsum.photos/640/480/?image=328", new Guid("a9925d11-3a37-440d-be27-c34accc59088"), "Chair", 904.62m, (short)20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 705, DateTimeKind.Local).AddTicks(9714), "https://picsum.photos/640/480/?image=337", new Guid("40e76ec7-e7e8-4a8e-8fa0-68e8f5004ab3"), "Chips", 697.07m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 706, DateTimeKind.Local).AddTicks(1214), "https://picsum.photos/640/480/?image=26", new Guid("6a937688-921b-48ce-a436-fdb2ad90c87b"), "Tuna", 907.21m, (short)22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 706, DateTimeKind.Local).AddTicks(2714), "https://picsum.photos/640/480/?image=878", new Guid("23424aa9-1644-493e-83b3-ebddd6e4c16a"), "Shirt", 318.78m, (short)43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 706, DateTimeKind.Local).AddTicks(4209), "https://picsum.photos/640/480/?image=641", new Guid("9dabf2dd-e365-4a81-b6b8-0fe587542553"), "Car", 301.81m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 706, DateTimeKind.Local).AddTicks(5695), "https://picsum.photos/640/480/?image=92", new Guid("f1761efd-cafa-43a8-87f3-d6771a4e36a5"), "Keyboard", 618.50m });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 706, DateTimeKind.Local).AddTicks(7830), new Guid("23e4ac01-725c-498f-900e-b0a5cc62cf57") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 706, DateTimeKind.Local).AddTicks(9354), new Guid("fd3522d2-ab4b-44d6-b7a0-3b72d9b2e927") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 35, 20, 707, DateTimeKind.Local).AddTicks(819), new Guid("796123c3-267b-442b-becc-58c22bb80d70") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 240, DateTimeKind.Local).AddTicks(9985), new Guid("46823ac9-be03-4429-95d8-fc97788846f9") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 241, DateTimeKind.Local).AddTicks(2636), new Guid("a77d8b33-de7f-4344-82c0-6b99550ee15b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 241, DateTimeKind.Local).AddTicks(4222), new Guid("9301e476-774b-415d-9608-dee13c808b23") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 242, DateTimeKind.Local).AddTicks(8418), "https://picsum.photos/640/480/?image=742", new Guid("478db1db-f370-4c3d-844b-992844dbbb53"), "Shoes", 743.57m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(227), "https://picsum.photos/640/480/?image=1053", new Guid("f6ecfdd2-c679-497e-a2c8-57c978f7c153"), "Chair", 22.91m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(1794), "https://picsum.photos/640/480/?image=247", new Guid("2dd25fed-66b3-4b6f-bb23-6373d7715fd6"), "Mouse", 934.20m, (short)81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(3285), "https://picsum.photos/640/480/?image=778", new Guid("87f39d54-58ab-466a-b527-438abfe052d5"), "Chicken", 218.14m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(4743), "https://picsum.photos/640/480/?image=1060", new Guid("e8253b60-046c-4f0f-82ec-ebe19ddb9281"), "Bike", 359.88m, (short)32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(6197), "https://picsum.photos/640/480/?image=161", new Guid("fa641415-a870-472c-ac6a-44981e9b2c1a"), "Cheese", 774.14m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(7626), "https://picsum.photos/640/480/?image=265", new Guid("9fb6dea5-6e07-4755-b90c-a90a66486370"), "Chips", 391.03m, (short)79 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 243, DateTimeKind.Local).AddTicks(9043), "https://picsum.photos/640/480/?image=976", new Guid("c366263b-fa0b-4cca-9b4a-20030d119499"), "Salad", 926.17m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(467), "https://picsum.photos/640/480/?image=764", new Guid("8e7db928-74a2-49a2-82e7-67b40b084242"), "Chair", 228.02m, (short)60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(1894), "https://picsum.photos/640/480/?image=494", new Guid("5d9806e7-fa2b-49b6-9b2e-19c9daf7ea74"), "Pants", 385.10m, (short)55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(3307), "https://picsum.photos/640/480/?image=1019", new Guid("4f27a0f4-fb37-4cc5-a579-ecf3fd7648f2"), "Tuna", 126.25m, (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(4741), "https://picsum.photos/640/480/?image=663", new Guid("766c3290-3607-4e14-aae6-ae74b144c160"), "Bike", 901.52m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(6156), "https://picsum.photos/640/480/?image=702", new Guid("3755cdda-87ce-44aa-bbd5-873424c3e146"), "Mouse", 885.82m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(7555), "https://picsum.photos/640/480/?image=755", new Guid("c4eadc16-1666-4e2f-9501-71dc4393677e"), "Computer", 691.36m, (short)53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 244, DateTimeKind.Local).AddTicks(8953), "https://picsum.photos/640/480/?image=1009", new Guid("e1b246bf-4d5b-4072-93c9-8feac5437250"), "Ball", 756.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(356), "https://picsum.photos/640/480/?image=788", new Guid("8f211010-1b1a-4ff4-bd76-fba4d74e1487"), "Mouse", 965.84m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(1753), "https://picsum.photos/640/480/?image=903", new Guid("eb413557-9f83-4b69-993e-5c6a0548f771"), "Fish", 689.40m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(3172), "https://picsum.photos/640/480/?image=861", new Guid("d21d1cde-e289-4d34-9e0d-b55098c13be1"), 948.93m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(4603), "https://picsum.photos/640/480/?image=568", new Guid("6236c0f1-ec76-4496-807c-c2d1c1e5c521"), "Bike", 529.22m, (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(5995), "https://picsum.photos/640/480/?image=966", new Guid("8634030c-9cd5-41e6-a52c-43c3b20830ab"), "Shirt", 126.70m, (short)50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(7395), "https://picsum.photos/640/480/?image=1058", new Guid("e8c42c62-a684-4c89-aaa2-373c2b77a1f4"), "Hat", 734.55m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 245, DateTimeKind.Local).AddTicks(8794), "https://picsum.photos/640/480/?image=636", new Guid("8bd39b11-8584-4253-9172-079a499d5f5c"), "Salad", 633.40m, (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(176), "https://picsum.photos/640/480/?image=382", new Guid("f86113f3-0d8f-4aa2-8f29-479a11d1543a"), "Bike", 804.98m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(1560), "https://picsum.photos/640/480/?image=2", new Guid("239c83e2-040b-44d8-9cf4-956c67796726"), "Tuna", 25.18m, (short)40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(2966), "https://picsum.photos/640/480/?image=606", new Guid("4d1291e7-f4db-4e60-ba50-5efa97904ab1"), "Bacon", 53.33m, (short)29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(4375), "https://picsum.photos/640/480/?image=171", new Guid("8ded2b3a-7ae7-4d19-bc01-4302a1351498"), "Sausages", 398.51m, (short)95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(5785), "https://picsum.photos/640/480/?image=807", new Guid("70c5efd7-f484-4618-985e-21123629af93"), "Pants", 462.05m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(7169), "https://picsum.photos/640/480/?image=117", new Guid("40987884-3df4-475c-b52d-e40da26d5310"), "Chicken", 149.59m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(8560), "https://picsum.photos/640/480/?image=250", new Guid("f0ce37f6-3224-4f65-b2db-1c8f00d88dfc"), "Table", 407.52m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 246, DateTimeKind.Local).AddTicks(9963), "https://picsum.photos/640/480/?image=11", new Guid("b523c29e-3738-430e-99b0-dc31d077c34c"), "Cheese", 487.90m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(1369), "https://picsum.photos/640/480/?image=558", new Guid("576bbe44-e2b0-43a9-a942-29f8c3075a6c"), "Chair", 858.39m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(2761), "https://picsum.photos/640/480/?image=221", new Guid("29a6fabd-30ce-4e10-87a9-f27bbc9d44c0"), "Tuna", 775.82m, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(4162), "https://picsum.photos/640/480/?image=0", new Guid("fb12a40c-6527-4839-a65e-576f37d93401"), "Chicken", 224.11m });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(6167), new Guid("679e5a58-9151-4ff8-8607-1c4334e299b4") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(7591), new Guid("3f0205fc-b9d3-44bc-975a-bd4c2ca591da") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 39, 4, 247, DateTimeKind.Local).AddTicks(8958), new Guid("1eb51741-d528-489b-98c6-9117ff0277e0") });
        }
    }
}
