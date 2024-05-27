using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class configs : Migration
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
                    { 1, "Test Category 1", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 56, DateTimeKind.Local).AddTicks(4901), "192.168.1.21", "Test Category 1 Description", true, new Guid("4b2dfcb5-ad2c-4596-b8e2-4a0845958ade"), 0, null, null, null },
                    { 2, "Test Category 2", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 56, DateTimeKind.Local).AddTicks(7809), "192.168.1.21", "Test Category 2 Description", true, new Guid("53f940a8-971a-4952-800b-23881025177f"), 0, null, null, null },
                    { 3, "Test Category 3", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 56, DateTimeKind.Local).AddTicks(9508), "192.168.1.21", "Test Category 3 Description", true, new Guid("246d5b3f-24cf-482e-ac1a-5567ae1b1bad"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(9637), "192.168.1.21", true, new Guid("81dc5b83-6325-4b8a-8a0f-b18dc7b4ee8b"), null, 0, null, null, null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 64, DateTimeKind.Local).AddTicks(1200), "192.168.1.21", true, new Guid("fd7a0248-fb9b-45e2-889d-884de6e4e5de"), null, 0, null, null, null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 64, DateTimeKind.Local).AddTicks(2690), "192.168.1.21", true, new Guid("db26502b-2bf8-40b8-b4fc-35aa0fc5fb18"), null, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 101, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 58, DateTimeKind.Local).AddTicks(7279), "192.168.1.21", "https://picsum.photos/640/480/?image=933", true, new Guid("a4a6c974-a0e7-4ea7-ab7b-01d44d05705c"), "Table", 0, 1, 583.19m, (short)75, null, null, null },
                    { 102, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 58, DateTimeKind.Local).AddTicks(9243), "192.168.1.21", "https://picsum.photos/640/480/?image=175", true, new Guid("6be4cba7-7825-40de-967c-f1b410bfedf7"), "Towels", 0, 1, 774.15m, (short)57, null, null, null },
                    { 103, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(963), "192.168.1.21", "https://picsum.photos/640/480/?image=134", true, new Guid("618664c7-e6f1-43a1-b413-41f1edf2bdee"), "Fish", 0, 1, 481.71m, (short)58, null, null, null },
                    { 104, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(2563), "192.168.1.21", "https://picsum.photos/640/480/?image=806", true, new Guid("ebaa1474-101a-4d9d-a275-c3cc11d8a749"), "Car", 0, 1, 704.77m, (short)89, null, null, null },
                    { 105, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(4130), "192.168.1.21", "https://picsum.photos/640/480/?image=446", true, new Guid("0abba301-ab9f-4d0d-979e-c1477a89530d"), "Chicken", 0, 1, 800.76m, (short)33, null, null, null },
                    { 106, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(5688), "192.168.1.21", "https://picsum.photos/640/480/?image=535", true, new Guid("ed98a337-cf19-453c-814e-06480a88b5ac"), "Chair", 0, 1, 430.49m, (short)66, null, null, null },
                    { 107, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(7247), "192.168.1.21", "https://picsum.photos/640/480/?image=231", true, new Guid("ec9fa2a8-248b-40d4-a44b-837f1c1b7ea1"), "Keyboard", 0, 1, 88.62m, (short)66, null, null, null },
                    { 108, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 59, DateTimeKind.Local).AddTicks(8774), "192.168.1.21", "https://picsum.photos/640/480/?image=353", true, new Guid("37a0cbe2-aa82-4623-a0c0-d5a1298d83d1"), "Bike", 0, 1, 273.83m, (short)36, null, null, null },
                    { 109, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(303), "192.168.1.21", "https://picsum.photos/640/480/?image=407", true, new Guid("f1591502-00ef-4a5b-9718-67607ad14e6a"), "Keyboard", 0, 1, 174.32m, (short)26, null, null, null },
                    { 110, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(1862), "192.168.1.21", "https://picsum.photos/640/480/?image=822", true, new Guid("005c0c16-e48e-4eba-bc43-359f205139d4"), "Chips", 0, 1, 468.24m, (short)79, null, null, null },
                    { 111, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(3426), "192.168.1.21", "https://picsum.photos/640/480/?image=793", true, new Guid("b1e95828-1269-4634-a1db-e7b67a90992d"), "Ball", 0, 1, 355.64m, (short)42, null, null, null },
                    { 201, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(5152), "192.168.1.21", "https://picsum.photos/640/480/?image=1008", true, new Guid("907cb373-7b8f-4b6b-9f7d-4f6776625e2f"), "Chicken", 0, 2, 105.66m, (short)39, null, null, null },
                    { 202, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(6693), "192.168.1.21", "https://picsum.photos/640/480/?image=344", true, new Guid("2ada21e9-cc33-4205-a993-13595d1cc89c"), "Car", 0, 2, 208.72m, (short)84, null, null, null },
                    { 203, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(8228), "192.168.1.21", "https://picsum.photos/640/480/?image=1004", true, new Guid("92da3631-dca0-4414-b465-8b6eacde699d"), "Shoes", 0, 2, 81.99m, (short)75, null, null, null },
                    { 204, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 60, DateTimeKind.Local).AddTicks(9760), "192.168.1.21", "https://picsum.photos/640/480/?image=287", true, new Guid("315e6d13-cb4f-4e51-94fd-5e4158761d4b"), "Gloves", 0, 2, 995.46m, (short)3, null, null, null },
                    { 205, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(1278), "192.168.1.21", "https://picsum.photos/640/480/?image=230", true, new Guid("85a7d7bd-bbc8-419d-8d93-09d0f2f14a24"), "Mouse", 0, 2, 564.07m, (short)30, null, null, null },
                    { 206, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(2826), "192.168.1.21", "https://picsum.photos/640/480/?image=822", true, new Guid("8cc89cb7-cae7-4567-8a5a-7f79539fa649"), "Pizza", 0, 2, 941.47m, (short)46, null, null, null },
                    { 207, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(4341), "192.168.1.21", "https://picsum.photos/640/480/?image=537", true, new Guid("49893ad0-96cf-4a9f-9c42-bb7246240a95"), "Bacon", 0, 2, 392.24m, (short)25, null, null, null },
                    { 208, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(5845), "192.168.1.21", "https://picsum.photos/640/480/?image=922", true, new Guid("ef878615-c8e8-497a-9135-5e70a9083020"), "Pants", 0, 2, 901.96m, (short)20, null, null, null },
                    { 209, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(7380), "192.168.1.21", "https://picsum.photos/640/480/?image=416", true, new Guid("28ce095c-d670-4102-b99c-d74f9b83fe00"), "Mouse", 0, 2, 360.55m, (short)11, null, null, null },
                    { 210, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 61, DateTimeKind.Local).AddTicks(8895), "192.168.1.21", "https://picsum.photos/640/480/?image=820", true, new Guid("904bd5d6-2585-42ec-a82e-d32bf7dce032"), "Gloves", 0, 2, 531.63m, (short)84, null, null, null },
                    { 211, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(421), "192.168.1.21", "https://picsum.photos/640/480/?image=564", true, new Guid("663e8840-0f55-477b-b2d6-ef92b6f8465e"), "Computer", 0, 2, 767.42m, (short)69, null, null, null },
                    { 301, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(1935), "192.168.1.21", "https://picsum.photos/640/480/?image=59", true, new Guid("82cf8594-3468-494c-b5c9-e558f0733136"), "Soap", 0, 3, 588.93m, (short)70, null, null, null },
                    { 302, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(3485), "192.168.1.21", "https://picsum.photos/640/480/?image=228", true, new Guid("a42b59c8-66b3-4fbb-a028-3d3504e0140f"), "Table", 0, 3, 726.78m, (short)60, null, null, null },
                    { 303, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(5005), "192.168.1.21", "https://picsum.photos/640/480/?image=928", true, new Guid("23c4ae20-823b-476b-b404-add5154b2bee"), "Computer", 0, 3, 219.29m, (short)91, null, null, null },
                    { 304, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(6514), "192.168.1.21", "https://picsum.photos/640/480/?image=713", true, new Guid("357a2fce-89dc-4cb1-a1e1-930097ca7327"), "Ball", 0, 3, 936.36m, (short)86, null, null, null },
                    { 305, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(8021), "192.168.1.21", "https://picsum.photos/640/480/?image=946", true, new Guid("7f145a2a-3716-401a-aee9-349a78febd07"), "Fish", 0, 3, 63.67m, (short)11, null, null, null },
                    { 306, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 62, DateTimeKind.Local).AddTicks(9513), "192.168.1.21", "https://picsum.photos/640/480/?image=1031", true, new Guid("dd1df45b-f7aa-4e28-9a72-f02250b46682"), "Mouse", 0, 3, 388.33m, (short)41, null, null, null },
                    { 307, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(1012), "192.168.1.21", "https://picsum.photos/640/480/?image=10", true, new Guid("6f93e542-d683-46c2-b30c-7786a200450f"), "Salad", 0, 3, 591.39m, (short)43, null, null, null },
                    { 308, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(2509), "192.168.1.21", "https://picsum.photos/640/480/?image=145", true, new Guid("cb472104-362e-4873-b46e-48c5fe6a2aa4"), "Chips", 0, 3, 862.17m, (short)42, null, null, null },
                    { 309, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(4005), "192.168.1.21", "https://picsum.photos/640/480/?image=441", true, new Guid("c219c748-491f-40b8-b516-ef3272b9cce7"), "Table", 0, 3, 515.39m, (short)25, null, null, null },
                    { 310, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(5544), "192.168.1.21", "https://picsum.photos/640/480/?image=13", true, new Guid("f08c11df-4cb0-4fff-af16-4d3f6bb227c0"), "Soap", 0, 3, 574.28m, (short)89, null, null, null },
                    { 311, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 4, 38, 15, 63, DateTimeKind.Local).AddTicks(7070), "192.168.1.21", "https://picsum.photos/640/480/?image=874", true, new Guid("856c9b9b-0d50-4fa8-97a0-5a1f3e83ec3a"), "Keyboard", 0, 3, 815.84m, (short)3, null, null, null }
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
