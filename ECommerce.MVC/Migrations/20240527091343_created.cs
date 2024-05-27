using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class created : Migration
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
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1, "Test Category 1", "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 719, DateTimeKind.Local).AddTicks(2538), "10.3.21.52", "Test Category 1 Description", true, new Guid("be70ad7e-4d03-42b6-a537-4d673b7daf09"), 0, null, null, null },
                    { 2, "Test Category 2", "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 719, DateTimeKind.Local).AddTicks(6976), "10.3.21.52", "Test Category 2 Description", true, new Guid("9d74b845-6972-4ad8-a773-0ed2c19bff29"), 0, null, null, null },
                    { 3, "Test Category 3", "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 719, DateTimeKind.Local).AddTicks(9674), "10.3.21.52", "Test Category 3 Description", true, new Guid("034b3f36-d6f4-4623-aa7c-5ab10c3a5bc4"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 731, DateTimeKind.Local).AddTicks(7800), "10.3.21.52", true, new Guid("40f77b61-573d-4f6b-8254-97745cb6d420"), null, 0, null, null, null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 732, DateTimeKind.Local).AddTicks(18), "10.3.21.52", true, new Guid("c1bb4b9c-40ce-4676-b8cd-d92f1fda6ac2"), null, 0, null, null, null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 732, DateTimeKind.Local).AddTicks(2089), "10.3.21.52", true, new Guid("0cf68cf1-7e94-4170-9064-084c0c992e7c"), null, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 101, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 723, DateTimeKind.Local).AddTicks(7656), "10.3.21.52", "https://picsum.photos/640/480/?image=164", true, new Guid("2f0ccf35-470a-499e-b52c-f1b83431bbc1"), "Chicken", 0, 1, 886.27m, (short)59, null, null, null },
                    { 102, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 724, DateTimeKind.Local).AddTicks(2302), "10.3.21.52", "https://picsum.photos/640/480/?image=1026", true, new Guid("d0738ef6-0bdd-4609-9078-97578fdfe139"), "Shirt", 0, 1, 478.50m, (short)88, null, null, null },
                    { 103, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 724, DateTimeKind.Local).AddTicks(4979), "10.3.21.52", "https://picsum.photos/640/480/?image=955", true, new Guid("4c33a694-3b66-49ea-880c-e260a3fa057a"), "Chair", 0, 1, 826.22m, (short)45, null, null, null },
                    { 104, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 724, DateTimeKind.Local).AddTicks(7453), "10.3.21.52", "https://picsum.photos/640/480/?image=836", true, new Guid("9fa0059e-80b6-4bda-b469-48d4a1557a2c"), "Tuna", 0, 1, 249.84m, (short)55, null, null, null },
                    { 105, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 725, DateTimeKind.Local).AddTicks(117), "10.3.21.52", "https://picsum.photos/640/480/?image=530", true, new Guid("65938660-8ee5-42cc-a507-2f0e13fcfb2b"), "Car", 0, 1, 938.93m, (short)48, null, null, null },
                    { 106, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 725, DateTimeKind.Local).AddTicks(2445), "10.3.21.52", "https://picsum.photos/640/480/?image=844", true, new Guid("9de3e20e-2e66-4d18-9acc-410fb7e029d0"), "Towels", 0, 1, 162.69m, (short)27, null, null, null },
                    { 107, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 725, DateTimeKind.Local).AddTicks(4756), "10.3.21.52", "https://picsum.photos/640/480/?image=528", true, new Guid("cac9de29-4e08-4024-bcf9-b69d4c69e372"), "Keyboard", 0, 1, 833.33m, (short)54, null, null, null },
                    { 108, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 725, DateTimeKind.Local).AddTicks(7000), "10.3.21.52", "https://picsum.photos/640/480/?image=530", true, new Guid("6160bc5d-4a46-46d2-b491-8b93309eee17"), "Pants", 0, 1, 554.08m, (short)59, null, null, null },
                    { 109, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 725, DateTimeKind.Local).AddTicks(9338), "10.3.21.52", "https://picsum.photos/640/480/?image=846", true, new Guid("b1f4e4ab-1b19-4ca6-aedc-a12208f70cd6"), "Sausages", 0, 1, 887.12m, (short)30, null, null, null },
                    { 110, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 726, DateTimeKind.Local).AddTicks(1630), "10.3.21.52", "https://picsum.photos/640/480/?image=397", true, new Guid("269b0856-a4e0-4471-8e09-bc50399301d0"), "Table", 0, 1, 705.80m, (short)93, null, null, null },
                    { 111, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 726, DateTimeKind.Local).AddTicks(3917), "10.3.21.52", "https://picsum.photos/640/480/?image=74", true, new Guid("1abb2bc6-2626-43d0-8c60-108aae66a254"), "Bacon", 0, 1, 741.09m, (short)99, null, null, null },
                    { 201, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 726, DateTimeKind.Local).AddTicks(6181), "10.3.21.52", "https://picsum.photos/640/480/?image=474", true, new Guid("b0df5d56-75f7-4faf-bcca-05aa2630f675"), "Shirt", 0, 2, 664.48m, (short)75, null, null, null },
                    { 202, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 726, DateTimeKind.Local).AddTicks(8448), "10.3.21.52", "https://picsum.photos/640/480/?image=758", true, new Guid("9a5fba84-59ba-45f3-8aad-6fe6ffab7871"), "Chair", 0, 2, 320.57m, (short)96, null, null, null },
                    { 203, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 727, DateTimeKind.Local).AddTicks(730), "10.3.21.52", "https://picsum.photos/640/480/?image=956", true, new Guid("6d146fa7-5f10-4afc-b2b9-264fcec6eb05"), "Keyboard", 0, 2, 872.74m, (short)70, null, null, null },
                    { 204, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 727, DateTimeKind.Local).AddTicks(3081), "10.3.21.52", "https://picsum.photos/640/480/?image=100", true, new Guid("4d01eafa-8e68-4eef-a246-207ffbda075d"), "Mouse", 0, 2, 690.60m, (short)24, null, null, null },
                    { 205, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 727, DateTimeKind.Local).AddTicks(5335), "10.3.21.52", "https://picsum.photos/640/480/?image=16", true, new Guid("70a01dcf-28e4-400d-aa7d-805b31d739df"), "Bike", 0, 2, 456.36m, (short)4, null, null, null },
                    { 206, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 727, DateTimeKind.Local).AddTicks(7546), "10.3.21.52", "https://picsum.photos/640/480/?image=521", true, new Guid("2279c022-1a65-4bc6-a61b-8fb423f74cdc"), "Chicken", 0, 2, 259.30m, (short)78, null, null, null },
                    { 207, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 727, DateTimeKind.Local).AddTicks(9778), "10.3.21.52", "https://picsum.photos/640/480/?image=802", true, new Guid("2d49adb9-d402-46ec-8557-367bfe63c660"), "Ball", 0, 2, 716.67m, (short)91, null, null, null },
                    { 208, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 728, DateTimeKind.Local).AddTicks(1991), "10.3.21.52", "https://picsum.photos/640/480/?image=789", true, new Guid("8f5f1740-e7a7-4909-b5b3-7273f0cc61e9"), "Tuna", 0, 2, 483.96m, (short)34, null, null, null },
                    { 209, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 728, DateTimeKind.Local).AddTicks(4191), "10.3.21.52", "https://picsum.photos/640/480/?image=555", true, new Guid("d106fd0a-60f6-487b-965a-528953214cb9"), "Sausages", 0, 2, 114.49m, (short)21, null, null, null },
                    { 210, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 728, DateTimeKind.Local).AddTicks(6423), "10.3.21.52", "https://picsum.photos/640/480/?image=629", true, new Guid("14ca9e0a-69a4-45e3-bb45-0a918bd6439b"), "Sausages", 0, 2, 292.94m, (short)14, null, null, null },
                    { 211, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 728, DateTimeKind.Local).AddTicks(8629), "10.3.21.52", "https://picsum.photos/640/480/?image=891", true, new Guid("4c5912a8-ec77-4440-bd6f-e6ae8030c696"), "Fish", 0, 2, 17.11m, (short)30, null, null, null },
                    { 301, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 729, DateTimeKind.Local).AddTicks(867), "10.3.21.52", "https://picsum.photos/640/480/?image=33", true, new Guid("f83c1a4b-0b1b-49b2-8d2d-0c9ded8092fb"), "Keyboard", 0, 3, 317.94m, (short)54, null, null, null },
                    { 302, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 729, DateTimeKind.Local).AddTicks(3083), "10.3.21.52", "https://picsum.photos/640/480/?image=79", true, new Guid("1deca4b0-2321-4398-a189-1fffc5cdc43e"), "Sausages", 0, 3, 287.72m, (short)21, null, null, null },
                    { 303, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 729, DateTimeKind.Local).AddTicks(5279), "10.3.21.52", "https://picsum.photos/640/480/?image=1007", true, new Guid("bef296e2-77ac-4476-9d9e-a302766a3587"), "Table", 0, 3, 426.62m, (short)17, null, null, null },
                    { 304, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 729, DateTimeKind.Local).AddTicks(7477), "10.3.21.52", "https://picsum.photos/640/480/?image=930", true, new Guid("dd1416b7-4338-4af6-bdff-4883be9727fb"), "Gloves", 0, 3, 76.73m, (short)13, null, null, null },
                    { 305, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 730, DateTimeKind.Local).AddTicks(5), "10.3.21.52", "https://picsum.photos/640/480/?image=459", true, new Guid("6c080125-b24f-410a-aba1-96419aaef33a"), "Towels", 0, 3, 787.46m, (short)39, null, null, null },
                    { 306, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 730, DateTimeKind.Local).AddTicks(2246), "10.3.21.52", "https://picsum.photos/640/480/?image=760", true, new Guid("2ddfdf32-0e67-4947-b924-06b59c32090b"), "Chair", 0, 3, 135.49m, (short)78, null, null, null },
                    { 307, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 730, DateTimeKind.Local).AddTicks(4443), "10.3.21.52", "https://picsum.photos/640/480/?image=349", true, new Guid("e4cd0b3a-450a-4d32-a7a3-df9870e375fe"), "Gloves", 0, 3, 429.97m, (short)18, null, null, null },
                    { 308, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 730, DateTimeKind.Local).AddTicks(6626), "10.3.21.52", "https://picsum.photos/640/480/?image=281", true, new Guid("9bd2b70c-aac7-44f8-a2ac-05b5a736b90c"), "Mouse", 0, 3, 573.96m, (short)84, null, null, null },
                    { 309, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 730, DateTimeKind.Local).AddTicks(8845), "10.3.21.52", "https://picsum.photos/640/480/?image=12", true, new Guid("e9ad9dd3-2715-42ee-b18a-9725fd578b2d"), "Tuna", 0, 3, 216.50m, (short)26, null, null, null },
                    { 310, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 731, DateTimeKind.Local).AddTicks(1070), "10.3.21.52", "https://picsum.photos/640/480/?image=1008", true, new Guid("f355ccf5-69df-41a5-b5f9-97779cbc2f73"), "Sausages", 0, 3, 286.85m, (short)93, null, null, null },
                    { 311, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 27, 12, 13, 42, 731, DateTimeKind.Local).AddTicks(3341), "10.3.21.52", "https://picsum.photos/640/480/?image=364", true, new Guid("e58d2cb1-b849-4dd1-8ea9-f78ac9fbc0a8"), "Table", 0, 3, 815.30m, (short)84, null, null, null }
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
