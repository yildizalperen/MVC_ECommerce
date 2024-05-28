using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class cookies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Freight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
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
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
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
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<short>(type: "smallint", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Category 1", "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 953, DateTimeKind.Local).AddTicks(7871), "192.168.1.21", "Test Category 1 Description", true, new Guid("7f464add-758e-451c-93cf-bf9ae6627784"), 0, null, null, null },
                    { 2, "Test Category 2", "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 954, DateTimeKind.Local).AddTicks(721), "192.168.1.21", "Test Category 2 Description", true, new Guid("2aacced2-9d78-4d09-a4c8-f855e848d559"), 0, null, null, null },
                    { 3, "Test Category 3", "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 954, DateTimeKind.Local).AddTicks(2402), "192.168.1.21", "Test Category 3 Description", true, new Guid("6cc76d09-094a-4377-b39b-90f9de15a06f"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(8968), "192.168.1.21", true, new Guid("3f2bbb8d-3c48-45ec-9cae-160f0e64372d"), null, 0, null, null, null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 962, DateTimeKind.Local).AddTicks(492), "192.168.1.21", true, new Guid("c7152f9e-42eb-4a47-bd10-57c15765ebd1"), null, 0, null, null, null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 962, DateTimeKind.Local).AddTicks(1956), "192.168.1.21", true, new Guid("14818fb1-a6ce-4103-9100-a7070e277365"), null, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 101, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 956, DateTimeKind.Local).AddTicks(6809), "192.168.1.21", "https://picsum.photos/640/480/?image=375", true, new Guid("894fd03b-23b1-4fa5-b9cc-fa3f87210e1e"), "Sausages", 0, 1, 614.54m, (short)33, null, null, null },
                    { 102, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 956, DateTimeKind.Local).AddTicks(8926), "192.168.1.21", "https://picsum.photos/640/480/?image=383", true, new Guid("364c173d-fc9d-4ac3-ae39-50f11978c3a1"), "Towels", 0, 1, 583.94m, (short)23, null, null, null },
                    { 103, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(599), "192.168.1.21", "https://picsum.photos/640/480/?image=90", true, new Guid("35237ae7-07f9-4464-8bbd-3f3d2efe14e5"), "Car", 0, 1, 866.15m, (short)82, null, null, null },
                    { 104, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(2205), "192.168.1.21", "https://picsum.photos/640/480/?image=404", true, new Guid("57db7647-aaad-43e5-86ec-f0bbd36d5c85"), "Computer", 0, 1, 329.90m, (short)62, null, null, null },
                    { 105, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(3805), "192.168.1.21", "https://picsum.photos/640/480/?image=552", true, new Guid("bfd1d9fa-6eb3-4bdd-9aaa-1c8168fe11e0"), "Pants", 0, 1, 170.75m, (short)10, null, null, null },
                    { 106, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(5704), "192.168.1.21", "https://picsum.photos/640/480/?image=150", true, new Guid("2c3c26fc-dea9-475c-8883-8a88664206a8"), "Gloves", 0, 1, 445.67m, (short)46, null, null, null },
                    { 107, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(7236), "192.168.1.21", "https://picsum.photos/640/480/?image=354", true, new Guid("a606a4a5-009a-4e88-b8a4-d617248f6b38"), "Shirt", 0, 1, 841.06m, (short)83, null, null, null },
                    { 108, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 957, DateTimeKind.Local).AddTicks(8746), "192.168.1.21", "https://picsum.photos/640/480/?image=815", true, new Guid("70dcb1e0-1ffe-42bb-910f-6723368c3b08"), "Ball", 0, 1, 589.02m, (short)45, null, null, null },
                    { 109, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(252), "192.168.1.21", "https://picsum.photos/640/480/?image=670", true, new Guid("3ca256a1-67f4-4546-957b-982e9885a040"), "Chicken", 0, 1, 611.19m, (short)42, null, null, null },
                    { 110, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(1755), "192.168.1.21", "https://picsum.photos/640/480/?image=354", true, new Guid("3eb6aacc-4b9f-4c15-80a2-31722e9e0c13"), "Hat", 0, 1, 125.00m, (short)68, null, null, null },
                    { 111, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(3271), "192.168.1.21", "https://picsum.photos/640/480/?image=266", true, new Guid("07ff7ff5-07bd-46ff-860d-0346ac5e507b"), "Chair", 0, 1, 874.31m, (short)72, null, null, null },
                    { 201, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(4807), "192.168.1.21", "https://picsum.photos/640/480/?image=302", true, new Guid("0cfba335-fd4d-4c4a-832a-c12204476638"), "Shoes", 0, 2, 32.69m, (short)74, null, null, null },
                    { 202, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(6428), "192.168.1.21", "https://picsum.photos/640/480/?image=629", true, new Guid("2029e62d-1f09-41fc-9320-3e4a19f8a392"), "Shoes", 0, 2, 376.00m, (short)52, null, null, null },
                    { 203, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(7928), "192.168.1.21", "https://picsum.photos/640/480/?image=1075", true, new Guid("e1f7b54d-5e69-43bb-aef3-66ef46135497"), "Hat", 0, 2, 941.58m, (short)17, null, null, null },
                    { 204, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 958, DateTimeKind.Local).AddTicks(9424), "192.168.1.21", "https://picsum.photos/640/480/?image=674", true, new Guid("60ca5681-c1c0-45fd-a1a7-caa2d940a183"), "Keyboard", 0, 2, 649.28m, (short)83, null, null, null },
                    { 205, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(919), "192.168.1.21", "https://picsum.photos/640/480/?image=186", true, new Guid("780a9728-c7d6-4d75-b45c-23130db110f9"), "Car", 0, 2, 598.64m, (short)8, null, null, null },
                    { 206, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(2413), "192.168.1.21", "https://picsum.photos/640/480/?image=449", true, new Guid("5a8ed91c-7d9d-4e8b-847e-419191b1d44a"), "Shoes", 0, 2, 401.36m, (short)78, null, null, null },
                    { 207, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(3913), "192.168.1.21", "https://picsum.photos/640/480/?image=805", true, new Guid("451f9968-8f62-4f6e-94d5-4eede6257de1"), "Sausages", 0, 2, 531.59m, (short)51, null, null, null },
                    { 208, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(5455), "192.168.1.21", "https://picsum.photos/640/480/?image=347", true, new Guid("9275a5e8-49be-4211-a555-02428e0cde05"), "Sausages", 0, 2, 699.10m, (short)42, null, null, null },
                    { 209, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(6967), "192.168.1.21", "https://picsum.photos/640/480/?image=193", true, new Guid("ad44694f-7a7f-4c3f-9b2c-646224e705bb"), "Ball", 0, 2, 674.64m, (short)1, null, null, null },
                    { 210, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(8456), "192.168.1.21", "https://picsum.photos/640/480/?image=725", true, new Guid("f8900a0a-0579-43f3-b13a-d4adfb0f0079"), "Gloves", 0, 2, 106.02m, (short)69, null, null, null },
                    { 211, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 959, DateTimeKind.Local).AddTicks(9946), "192.168.1.21", "https://picsum.photos/640/480/?image=1066", true, new Guid("e2e85b7b-215e-4f61-8fa1-f20e1d60d65e"), "Computer", 0, 2, 899.01m, (short)18, null, null, null },
                    { 301, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(1433), "192.168.1.21", "https://picsum.photos/640/480/?image=262", true, new Guid("75bccfe2-3547-4efc-8019-5d5f31325675"), "Ball", 0, 3, 765.13m, (short)67, null, null, null },
                    { 302, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(2904), "192.168.1.21", "https://picsum.photos/640/480/?image=301", true, new Guid("6c8a7e4c-f502-40f7-9789-6fb558e2094e"), "Tuna", 0, 3, 847.74m, (short)32, null, null, null },
                    { 303, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(4387), "192.168.1.21", "https://picsum.photos/640/480/?image=381", true, new Guid("817a79fd-bdb6-42cd-a876-5817b9d6ea35"), "Ball", 0, 3, 553.75m, (short)21, null, null, null },
                    { 304, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(5931), "192.168.1.21", "https://picsum.photos/640/480/?image=319", true, new Guid("88bbb1f0-8870-4b02-936c-d4c2c564e5f1"), "Fish", 0, 3, 532.17m, (short)81, null, null, null },
                    { 305, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(7417), "192.168.1.21", "https://picsum.photos/640/480/?image=15", true, new Guid("e6823585-5850-4ce5-abd3-40249ae480f7"), "Bacon", 0, 3, 914.11m, (short)33, null, null, null },
                    { 306, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 960, DateTimeKind.Local).AddTicks(8905), "192.168.1.21", "https://picsum.photos/640/480/?image=719", true, new Guid("b92665a6-39e6-4ecf-a660-3605414aed68"), "Tuna", 0, 3, 70.52m, (short)67, null, null, null },
                    { 307, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(392), "192.168.1.21", "https://picsum.photos/640/480/?image=928", true, new Guid("8fe146e2-e812-433c-8d9b-d12d969bfa63"), "Bike", 0, 3, 702.90m, (short)86, null, null, null },
                    { 308, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(1888), "192.168.1.21", "https://picsum.photos/640/480/?image=615", true, new Guid("ea4777f0-c7d3-428e-9ccd-cb76dd3fcdc8"), "Car", 0, 3, 433.25m, (short)59, null, null, null },
                    { 309, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(3380), "192.168.1.21", "https://picsum.photos/640/480/?image=29", true, new Guid("3fc8cf4d-3489-40db-ac6b-54779ec98430"), "Sausages", 0, 3, 32.38m, (short)54, null, null, null },
                    { 310, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(4860), "192.168.1.21", "https://picsum.photos/640/480/?image=555", true, new Guid("62e43089-0b32-4d70-b703-6aef65dee9ca"), "Tuna", 0, 3, 813.52m, (short)79, null, null, null },
                    { 311, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 28, 15, 14, 15, 961, DateTimeKind.Local).AddTicks(6352), "192.168.1.21", "https://picsum.photos/640/480/?image=752", true, new Guid("cc264dac-1e5c-41ad-a514-77e3c38309d3"), "Bacon", 0, 3, 288.59m, (short)78, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
