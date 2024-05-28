using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class appUser : Migration
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
                    { 1, "Test Category 1", "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 305, DateTimeKind.Local).AddTicks(2513), "10.3.21.52", "Test Category 1 Description", true, new Guid("77aeefb2-03a0-454d-82f0-d80b14a9763e"), 0, null, null, null },
                    { 2, "Test Category 2", "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 305, DateTimeKind.Local).AddTicks(6737), "10.3.21.52", "Test Category 2 Description", true, new Guid("898ce7c9-d5fe-4025-b57b-0255d3dae02d"), 0, null, null, null },
                    { 3, "Test Category 3", "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 305, DateTimeKind.Local).AddTicks(9108), "10.3.21.52", "Test Category 3 Description", true, new Guid("b74d21d8-19a5-4e08-881d-58503f0c1d49"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 317, DateTimeKind.Local).AddTicks(6097), "10.3.21.52", true, new Guid("a48c34a4-a4c1-4c62-b7c6-f19553a2a20c"), null, 0, null, null, null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 317, DateTimeKind.Local).AddTicks(8253), "10.3.21.52", true, new Guid("aa6e11b2-0f30-433b-816f-deb3947cd341"), null, 0, null, null, null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 318, DateTimeKind.Local).AddTicks(315), "10.3.21.52", true, new Guid("31915868-1722-4cb3-8e82-af81e5a6f91c"), null, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 101, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 309, DateTimeKind.Local).AddTicks(5320), "10.3.21.52", "https://picsum.photos/640/480/?image=944", true, new Guid("1f2a2c6b-33d2-45e2-ba94-9400e135c6a0"), "Table", 0, 1, 179.37m, (short)75, null, null, null },
                    { 102, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 309, DateTimeKind.Local).AddTicks(9761), "10.3.21.52", "https://picsum.photos/640/480/?image=22", true, new Guid("7ebd304c-4eb9-4841-acf5-f4cea4a5077f"), "Tuna", 0, 1, 62.21m, (short)56, null, null, null },
                    { 103, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 310, DateTimeKind.Local).AddTicks(2417), "10.3.21.52", "https://picsum.photos/640/480/?image=250", true, new Guid("f64d8dc8-b763-4fe7-9339-a2b5e05ca143"), "Towels", 0, 1, 472.79m, (short)53, null, null, null },
                    { 104, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 310, DateTimeKind.Local).AddTicks(4808), "10.3.21.52", "https://picsum.photos/640/480/?image=344", true, new Guid("2449e464-c27e-4b22-b5e2-2d8e0f4ea88b"), "Computer", 0, 1, 911.64m, (short)95, null, null, null },
                    { 105, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 310, DateTimeKind.Local).AddTicks(7137), "10.3.21.52", "https://picsum.photos/640/480/?image=386", true, new Guid("27ef6b24-d12e-4a6d-9599-eb87f54d9cd5"), "Table", 0, 1, 799.31m, (short)19, null, null, null },
                    { 106, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 310, DateTimeKind.Local).AddTicks(9474), "10.3.21.52", "https://picsum.photos/640/480/?image=487", true, new Guid("78367f66-de6f-4f2b-82f3-ae3be3978d6e"), "Tuna", 0, 1, 919.99m, (short)21, null, null, null },
                    { 107, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 311, DateTimeKind.Local).AddTicks(1897), "10.3.21.52", "https://picsum.photos/640/480/?image=350", true, new Guid("a96a39d0-42eb-4292-aff4-1c6974ff6f06"), "Pants", 0, 1, 710.11m, (short)15, null, null, null },
                    { 108, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 311, DateTimeKind.Local).AddTicks(4303), "10.3.21.52", "https://picsum.photos/640/480/?image=170", true, new Guid("b047acc4-948b-4b30-b1a9-4238a4721bdb"), "Gloves", 0, 1, 499.95m, (short)64, null, null, null },
                    { 109, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 311, DateTimeKind.Local).AddTicks(6687), "10.3.21.52", "https://picsum.photos/640/480/?image=87", true, new Guid("17f58485-858f-4122-99e5-dfdfc2e6175b"), "Chair", 0, 1, 14.18m, (short)85, null, null, null },
                    { 110, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 311, DateTimeKind.Local).AddTicks(9026), "10.3.21.52", "https://picsum.photos/640/480/?image=102", true, new Guid("831951a2-8fa8-4eca-a570-46cd4024195b"), "Car", 0, 1, 734.59m, (short)8, null, null, null },
                    { 111, 1, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 312, DateTimeKind.Local).AddTicks(1371), "10.3.21.52", "https://picsum.photos/640/480/?image=1044", true, new Guid("537a260a-845e-448e-8005-827c62b15163"), "Gloves", 0, 1, 153.93m, (short)12, null, null, null },
                    { 201, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 312, DateTimeKind.Local).AddTicks(3901), "10.3.21.52", "https://picsum.photos/640/480/?image=211", true, new Guid("e32eb667-8075-4d80-8254-6d1dbbd62a65"), "Ball", 0, 2, 274.26m, (short)83, null, null, null },
                    { 202, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 312, DateTimeKind.Local).AddTicks(6172), "10.3.21.52", "https://picsum.photos/640/480/?image=121", true, new Guid("2aa68523-b686-4b27-9015-133b94abbb55"), "Cheese", 0, 2, 503.00m, (short)78, null, null, null },
                    { 203, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 312, DateTimeKind.Local).AddTicks(8425), "10.3.21.52", "https://picsum.photos/640/480/?image=444", true, new Guid("fc9ca347-4abe-406f-b190-ec99b38778d5"), "Pants", 0, 2, 191.12m, (short)63, null, null, null },
                    { 204, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 313, DateTimeKind.Local).AddTicks(754), "10.3.21.52", "https://picsum.photos/640/480/?image=987", true, new Guid("98483ddf-7ac3-42bc-b77f-bc1f2e009680"), "Pants", 0, 2, 247.59m, (short)8, null, null, null },
                    { 205, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 313, DateTimeKind.Local).AddTicks(3030), "10.3.21.52", "https://picsum.photos/640/480/?image=120", true, new Guid("d330a09f-964a-4bd5-a3fe-74e397cf91c9"), "Soap", 0, 2, 998.43m, (short)60, null, null, null },
                    { 206, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 313, DateTimeKind.Local).AddTicks(5287), "10.3.21.52", "https://picsum.photos/640/480/?image=291", true, new Guid("049402ed-057f-4369-907e-85f6082b5319"), "Bike", 0, 2, 93.83m, (short)17, null, null, null },
                    { 207, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 313, DateTimeKind.Local).AddTicks(7531), "10.3.21.52", "https://picsum.photos/640/480/?image=463", true, new Guid("2fb158e0-dad8-4988-83a2-a8e874b1c870"), "Pizza", 0, 2, 782.67m, (short)80, null, null, null },
                    { 208, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 313, DateTimeKind.Local).AddTicks(9777), "10.3.21.52", "https://picsum.photos/640/480/?image=411", true, new Guid("84aa3234-cfc2-4fd7-991f-a0ca26e921d8"), "Bike", 0, 2, 908.85m, (short)42, null, null, null },
                    { 209, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 314, DateTimeKind.Local).AddTicks(2017), "10.3.21.52", "https://picsum.photos/640/480/?image=177", true, new Guid("c2918fa4-7e03-423c-9c4b-eea25d64e8d0"), "Fish", 0, 2, 936.39m, (short)72, null, null, null },
                    { 210, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 314, DateTimeKind.Local).AddTicks(4347), "10.3.21.52", "https://picsum.photos/640/480/?image=604", true, new Guid("251bdb81-132e-4e7a-8a23-02014e54cf72"), "Pizza", 0, 2, 957.11m, (short)1, null, null, null },
                    { 211, 2, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 314, DateTimeKind.Local).AddTicks(6579), "10.3.21.52", "https://picsum.photos/640/480/?image=781", true, new Guid("56da43bc-68a6-40a6-a6d6-ef01ed129671"), "Bike", 0, 2, 953.29m, (short)13, null, null, null },
                    { 301, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 314, DateTimeKind.Local).AddTicks(9404), "10.3.21.52", "https://picsum.photos/640/480/?image=655", true, new Guid("60ef6adc-63a8-4373-99b7-b6209e00ff07"), "Chips", 0, 3, 399.73m, (short)1, null, null, null },
                    { 302, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 315, DateTimeKind.Local).AddTicks(1662), "10.3.21.52", "https://picsum.photos/640/480/?image=62", true, new Guid("aab17deb-1fc0-4cb9-a300-30368b0f50c7"), "Mouse", 0, 3, 45.80m, (short)95, null, null, null },
                    { 303, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 315, DateTimeKind.Local).AddTicks(3921), "10.3.21.52", "https://picsum.photos/640/480/?image=480", true, new Guid("44672cc2-b944-46e9-a0e4-fb677340d8e1"), "Tuna", 0, 3, 40.11m, (short)32, null, null, null },
                    { 304, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 315, DateTimeKind.Local).AddTicks(6214), "10.3.21.52", "https://picsum.photos/640/480/?image=1027", true, new Guid("213c6bb2-9046-43c6-be9a-6cb89c68c206"), "Hat", 0, 3, 578.77m, (short)14, null, null, null },
                    { 305, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 315, DateTimeKind.Local).AddTicks(8409), "10.3.21.52", "https://picsum.photos/640/480/?image=774", true, new Guid("6a97641b-2dac-4a9b-8e66-8d1c0b11170b"), "Shirt", 0, 3, 923.22m, (short)79, null, null, null },
                    { 306, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 316, DateTimeKind.Local).AddTicks(634), "10.3.21.52", "https://picsum.photos/640/480/?image=471", true, new Guid("e37c80d6-1061-41f9-a821-208d90a40a86"), "Bacon", 0, 3, 209.74m, (short)67, null, null, null },
                    { 307, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 316, DateTimeKind.Local).AddTicks(2834), "10.3.21.52", "https://picsum.photos/640/480/?image=312", true, new Guid("0be33f5f-19ea-43c6-9c0c-44baa3b9ff1a"), "Pants", 0, 3, 307.98m, (short)59, null, null, null },
                    { 308, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 316, DateTimeKind.Local).AddTicks(4996), "10.3.21.52", "https://picsum.photos/640/480/?image=136", true, new Guid("8c4414b8-2642-4099-bc6e-e54caa0ac2ea"), "Table", 0, 3, 966.34m, (short)71, null, null, null },
                    { 309, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 316, DateTimeKind.Local).AddTicks(7158), "10.3.21.52", "https://picsum.photos/640/480/?image=687", true, new Guid("11251d82-2ea7-4b1a-ab81-154488bdee0b"), "Car", 0, 3, 638.00m, (short)28, null, null, null },
                    { 310, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 316, DateTimeKind.Local).AddTicks(9319), "10.3.21.52", "https://picsum.photos/640/480/?image=922", true, new Guid("0fd95199-cab8-4b38-916b-ce0b0a6af795"), "Chair", 0, 3, 31.50m, (short)78, null, null, null },
                    { 311, 3, "KDK-101-PC09-YZ", new DateTime(2024, 5, 28, 11, 37, 58, 317, DateTimeKind.Local).AddTicks(1472), "10.3.21.52", "https://picsum.photos/640/480/?image=990", true, new Guid("dd31d733-0624-4d2e-b266-29e7e58e5956"), "Shirt", 0, 3, 530.65m, (short)65, null, null, null }
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
