using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class configs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Freight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<short>(type: "smallint", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 721, DateTimeKind.Local).AddTicks(8785), new Guid("ff5f9226-c70f-493a-80a7-ea458e6e95eb") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 722, DateTimeKind.Local).AddTicks(1580), new Guid("521e81ca-a7a3-4fa0-af8a-e1566620eb0e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 722, DateTimeKind.Local).AddTicks(3357), new Guid("c6ecd2f6-464f-4469-82da-8777614c8cd7") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 724, DateTimeKind.Local).AddTicks(814), "https://picsum.photos/640/480/?image=1006", new Guid("64900234-128e-450c-a222-937c4070b7ef"), "Fish", 619.77m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 724, DateTimeKind.Local).AddTicks(2745), "https://picsum.photos/640/480/?image=844", new Guid("ec44881f-0f98-489c-bdb1-3a8c0ce56f9e"), "Ball", 267.40m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 724, DateTimeKind.Local).AddTicks(4422), "https://picsum.photos/640/480/?image=8", new Guid("f5f3dbbb-a037-4a1b-876a-ee79218e9c9b"), "Chicken", 985.64m, (short)17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 724, DateTimeKind.Local).AddTicks(6027), "https://picsum.photos/640/480/?image=238", new Guid("655da3a5-03c5-46ef-b9c3-dbb641dd0c3e"), "Chips", 921.38m, (short)37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 724, DateTimeKind.Local).AddTicks(7607), "https://picsum.photos/640/480/?image=24", new Guid("60b683ff-9912-4b75-b055-fb88323dd3e2"), "Fish", 899.43m, (short)5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 724, DateTimeKind.Local).AddTicks(9173), "https://picsum.photos/640/480/?image=873", new Guid("dad9d1b8-54e0-4cb5-a7e5-51e7ed9e1645"), "Pizza", 725.37m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(716), "https://picsum.photos/640/480/?image=121", new Guid("1d9c471e-dacd-4f14-98af-013ca984dd2d"), "Fish", 459.11m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(2233), "https://picsum.photos/640/480/?image=832", new Guid("b715bb82-5a92-41c8-b5f0-052ae0275fb4"), "Shoes", 674.10m, (short)45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(3858), "https://picsum.photos/640/480/?image=670", new Guid("2dd2e8fc-2fb7-48df-9319-e2633685245b"), "Hat", 674.63m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(5394), "https://picsum.photos/640/480/?image=591", new Guid("ebe227a1-0fc2-4a5e-9bb4-943a00d3827c"), "Towels", 612.52m, (short)47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(6916), "https://picsum.photos/640/480/?image=162", new Guid("3300b22c-4a8a-4577-b7c6-471f92ad417d"), "Chips", 422.83m, (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(8421), "https://picsum.photos/640/480/?image=1026", new Guid("0a506886-3fa9-4b5a-b4b0-cd36f43b0428"), "Computer", 762.25m, (short)54 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 725, DateTimeKind.Local).AddTicks(9937), "https://picsum.photos/640/480/?image=175", new Guid("25d97122-bf83-4a70-b8e6-e21f760195e7"), "Cheese", 970.40m, (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 726, DateTimeKind.Local).AddTicks(1451), "https://picsum.photos/640/480/?image=813", new Guid("933c65c0-df06-4a08-aa5a-1805908b68d8"), "Mouse", 13.55m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 726, DateTimeKind.Local).AddTicks(2982), "https://picsum.photos/640/480/?image=452", new Guid("0a0655eb-ff4c-450b-abbe-a31c1ee57522"), "Shirt", 756.46m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 726, DateTimeKind.Local).AddTicks(4504), "https://picsum.photos/640/480/?image=20", new Guid("7a59dfa0-7336-4672-8eaa-5dd2314bd853"), "Fish", 991.51m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 726, DateTimeKind.Local).AddTicks(6067), "https://picsum.photos/640/480/?image=1055", new Guid("6235228a-259e-45cc-8523-5061b568b90b"), "Bacon", 719.63m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 726, DateTimeKind.Local).AddTicks(7592), "https://picsum.photos/640/480/?image=504", new Guid("cd063c05-0420-4a60-8af4-3ff9c71d7e86"), "Towels", 225.35m, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 726, DateTimeKind.Local).AddTicks(9127), "https://picsum.photos/640/480/?image=288", new Guid("8e9db34b-c975-4754-aa22-222d7e91fe2e"), "Pants", 286.47m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 727, DateTimeKind.Local).AddTicks(624), "https://picsum.photos/640/480/?image=346", new Guid("91e4b4b0-101f-4933-9391-efe80e295ac3"), "Pants", 373.63m, (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 727, DateTimeKind.Local).AddTicks(2118), "https://picsum.photos/640/480/?image=856", new Guid("2cb6fbc4-6267-480e-ab89-5f31ed1fd81f"), "Computer", 811.81m, (short)51 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 727, DateTimeKind.Local).AddTicks(3961), "https://picsum.photos/640/480/?image=286", new Guid("61c657cd-7911-4fff-9ea0-17b6d10ce3f7"), "Chips", 483.70m, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 727, DateTimeKind.Local).AddTicks(5532), "https://picsum.photos/640/480/?image=779", new Guid("1ece50f4-2521-4dc8-b836-bd48a63b52b4"), "Towels", 229.28m, (short)93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 727, DateTimeKind.Local).AddTicks(7105), "https://picsum.photos/640/480/?image=985", new Guid("8e071f84-bdd3-46ed-9824-f58b151a25e9"), "Chips", 572.09m, (short)56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 727, DateTimeKind.Local).AddTicks(8634), "https://picsum.photos/640/480/?image=1018", new Guid("18af9ab3-1574-435a-8117-3968b6320074"), "Towels", 348.51m, (short)57 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(144), "https://picsum.photos/640/480/?image=804", new Guid("08c75b47-07aa-4fa0-9c29-669daaff8d2a"), "Shirt", 471.17m, (short)93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(1653), "https://picsum.photos/640/480/?image=1004", new Guid("291b1e9f-7e6c-4779-aac0-f60c01bee97d"), "Salad", 970.67m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(3193), "https://picsum.photos/640/480/?image=486", new Guid("22a71683-f8b1-4e7d-9fe8-baf33b2aab05"), "Table", 194.64m, (short)67 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(4694), "https://picsum.photos/640/480/?image=236", new Guid("e17465a4-6f89-4b5d-a23d-2517aa4ea394"), "Car", 824.16m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(6285), "https://picsum.photos/640/480/?image=413", new Guid("15b8f95a-8b66-4456-b327-a7e78c2af623"), "Mouse", 545.59m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(7828), "https://picsum.photos/640/480/?image=599", new Guid("e8f3bcc4-13d4-48c6-977a-6fc02a7baf69"), "Chips", 636.92m, (short)96 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 728, DateTimeKind.Local).AddTicks(9329), "https://picsum.photos/640/480/?image=663", new Guid("4a80ae8e-9c3e-4737-8621-57032538e2f0"), "Sausages", 888.93m, (short)68 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 729, DateTimeKind.Local).AddTicks(833), "https://picsum.photos/640/480/?image=242", new Guid("c2431f62-ebc5-4fce-bc71-11a288b61761"), "Shirt", 936.44m });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 729, DateTimeKind.Local).AddTicks(3140), new Guid("0f67010c-a310-4a3d-84bd-3befbf3d63d2") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 729, DateTimeKind.Local).AddTicks(4685), new Guid("abb05fc4-bd73-4ddf-a2c1-d871df03018a") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 4, 20, 47, 729, DateTimeKind.Local).AddTicks(6155), new Guid("bb953253-9435-4ea9-b5f7-4dbb09981541") });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 660, DateTimeKind.Local).AddTicks(8105), new Guid("0cb5bfdc-a8ed-4a0d-b59f-9be7d9be3a53") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 661, DateTimeKind.Local).AddTicks(1053), new Guid("8bfcb228-58cf-4113-9d8f-613a8587b114") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 661, DateTimeKind.Local).AddTicks(2689), new Guid("541f2144-0e45-44a1-80bb-e5ea9bd44a13") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 662, DateTimeKind.Local).AddTicks(7582), "https://picsum.photos/640/480/?image=896", new Guid("4d126777-000c-40ba-8a42-22fe1c360bd9"), "Hat", 638.70m, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 662, DateTimeKind.Local).AddTicks(9451), "https://picsum.photos/640/480/?image=912", new Guid("ca2b9457-d191-42a1-ae6f-27da365e8a36"), "Shirt", 233.30m, (short)5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(1075), "https://picsum.photos/640/480/?image=191", new Guid("da0488a7-88ec-4e8e-8d67-85a99c3ddeb1"), "Table", 970.78m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(2656), "https://picsum.photos/640/480/?image=902", new Guid("f5dcec2d-e116-4699-b5d2-6df985c092e5"), "Cheese", 461.36m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(4198), "https://picsum.photos/640/480/?image=1012", new Guid("5fdcc11e-7590-413d-bb43-b8635ef28d59"), "Chips", 72.24m, (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(5774), "https://picsum.photos/640/480/?image=1069", new Guid("ec42c6e8-00a0-487a-abb9-1c2c32de438f"), "Keyboard", 252.09m, (short)99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(7298), "https://picsum.photos/640/480/?image=253", new Guid("6036cc5e-bad5-4508-a599-80fe89d147f4"), "Bacon", 427.46m, (short)9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(8826), "https://picsum.photos/640/480/?image=790", new Guid("12edf0e9-d622-49f2-9b2b-576d42009557"), "Chips", 888.31m, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(333), "https://picsum.photos/640/480/?image=858", new Guid("1014c96c-09a5-4068-99f4-9a6158901835"), "Shoes", 310.44m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(1841), "https://picsum.photos/640/480/?image=299", new Guid("2dcd09a0-a8cd-4d35-96c2-959b9038fd85"), "Shirt", 344.61m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(3343), "https://picsum.photos/640/480/?image=145", new Guid("5fde1828-79ea-45f3-91d6-eb3d08e79be4"), "Ball", 362.38m, (short)46 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(5194), "https://picsum.photos/640/480/?image=38", new Guid("84f8a882-4cad-441e-ac15-274f514d9c93"), "Hat", 317.85m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(6789), "https://picsum.photos/640/480/?image=68", new Guid("77adaa18-5b38-4e1b-9a91-cb725c2d24e4"), "Sausages", 271.27m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(8325), "https://picsum.photos/640/480/?image=782", new Guid("3d31a329-e774-4e9b-93c2-4b7cae53433f"), "Chair", 424.11m, (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(9853), "https://picsum.photos/640/480/?image=314", new Guid("800c3df4-5590-4fa6-be7f-f75d97f6bee1"), "Chicken", 798.88m, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(1432), "https://picsum.photos/640/480/?image=35", new Guid("ad98bb01-d52b-4ed6-a487-4e8943fb1936"), "Table", 579.27m, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(2958), "https://picsum.photos/640/480/?image=830", new Guid("51b8ea9c-b38d-459c-b4cf-ad84db21d547"), "Car", 696.47m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(4481), "https://picsum.photos/640/480/?image=747", new Guid("377ef9d9-9c6b-45d4-9d44-1523652f08b8"), "Chips", 106.08m, (short)100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(5977), "https://picsum.photos/640/480/?image=111", new Guid("1af9116e-8676-475c-95f0-651eb7d4bdd3"), "Chicken", 78.40m, (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(7477), "https://picsum.photos/640/480/?image=862", new Guid("86c1dcca-d237-4c20-a4cb-30ef4f958233"), "Mouse", 791.58m, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(8958), "https://picsum.photos/640/480/?image=683", new Guid("9f1d1323-dfc4-450e-a667-5521051e2e1f"), "Car", 823.51m, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(448), "https://picsum.photos/640/480/?image=917", new Guid("a855f2d0-eac3-4530-9e4d-35bc63fedb22"), "Ball", 946.58m, (short)43 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(1920), "https://picsum.photos/640/480/?image=216", new Guid("19fe2d70-a7cb-4e25-bd01-4e3c4c047af1"), "Chicken", 489.91m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(3398), "https://picsum.photos/640/480/?image=633", new Guid("025b4c59-667e-4cb5-a7a2-568a84401b6e"), "Gloves", 961.31m, (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(4894), "https://picsum.photos/640/480/?image=971", new Guid("8dfec975-d3e5-4b4f-baca-028ecb0356c7"), "Chair", 762.82m, (short)7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(6371), "https://picsum.photos/640/480/?image=419", new Guid("9b8cd0ba-65ef-4cdb-9c01-684a47fe223c"), "Ball", 748.94m, (short)76 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(7841), "https://picsum.photos/640/480/?image=442", new Guid("50db70e2-7c7b-4317-be54-a411dd2a0c12"), "Car", 635.50m, (short)71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(9334), "https://picsum.photos/640/480/?image=125", new Guid("95234fe6-bfcc-4b14-9538-881792d500ce"), "Keyboard", 843.14m, (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(808), "https://picsum.photos/640/480/?image=630", new Guid("5bdda9db-63d3-41dd-9798-74f673677318"), "Soap", 133.12m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(2286), "https://picsum.photos/640/480/?image=38", new Guid("6add8ef4-d8c4-4bd6-ad08-8f506d50c04f"), "Table", 39.56m, (short)61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(3776), "https://picsum.photos/640/480/?image=442", new Guid("06426ded-063e-493c-96d3-b0a53df790d8"), "Table", 125.43m, (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(5395), "https://picsum.photos/640/480/?image=849", new Guid("53f26ef4-0e57-4a20-97be-86a41c9281c6"), "Towels", 253.16m, (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "ImagePath", "MasterId", "ProductName", "UnitPrice" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(6892), "https://picsum.photos/640/480/?image=80", new Guid("fa1470e9-4791-42b7-b049-b413c6ba208e"), "Tuna", 508.28m });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(9099), new Guid("659354be-78d3-41f7-8d65-6129a434ed70") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 668, DateTimeKind.Local).AddTicks(618), new Guid("db2d2e68-b01d-484d-888e-7818a5ac47e0") });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 25, 45, 668, DateTimeKind.Local).AddTicks(2085), new Guid("537e6f1d-8dd5-47ee-b3ad-5e9cc2283a2d") });
        }
    }
}
