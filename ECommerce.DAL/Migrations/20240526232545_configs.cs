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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Category 1", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 660, DateTimeKind.Local).AddTicks(8105), "192.168.1.21", "Test Category 1 Description", true, new Guid("0cb5bfdc-a8ed-4a0d-b59f-9be7d9be3a53"), 0, null, null, null },
                    { 2, "Test Category 2", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 661, DateTimeKind.Local).AddTicks(1053), "192.168.1.21", "Test Category 2 Description", true, new Guid("8bfcb228-58cf-4113-9d8f-613a8587b114"), 0, null, null, null },
                    { 3, "Test Category 3", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 661, DateTimeKind.Local).AddTicks(2689), "192.168.1.21", "Test Category 3 Description", true, new Guid("541f2144-0e45-44a1-80bb-e5ea9bd44a13"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(9099), "192.168.1.21", true, new Guid("659354be-78d3-41f7-8d65-6129a434ed70"), null, 0, null, null, null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 668, DateTimeKind.Local).AddTicks(618), "192.168.1.21", true, new Guid("db2d2e68-b01d-484d-888e-7818a5ac47e0"), null, 0, null, null, null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 668, DateTimeKind.Local).AddTicks(2085), "192.168.1.21", true, new Guid("537e6f1d-8dd5-47ee-b3ad-5e9cc2283a2d"), null, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 101, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 662, DateTimeKind.Local).AddTicks(7582), "192.168.1.21", "https://picsum.photos/640/480/?image=896", true, new Guid("4d126777-000c-40ba-8a42-22fe1c360bd9"), "Hat", 0, 1, 638.70m, (short)91, null, null, null },
                    { 102, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 662, DateTimeKind.Local).AddTicks(9451), "192.168.1.21", "https://picsum.photos/640/480/?image=912", true, new Guid("ca2b9457-d191-42a1-ae6f-27da365e8a36"), "Shirt", 0, 1, 233.30m, (short)5, null, null, null },
                    { 103, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(1075), "192.168.1.21", "https://picsum.photos/640/480/?image=191", true, new Guid("da0488a7-88ec-4e8e-8d67-85a99c3ddeb1"), "Table", 0, 1, 970.78m, (short)12, null, null, null },
                    { 104, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(2656), "192.168.1.21", "https://picsum.photos/640/480/?image=902", true, new Guid("f5dcec2d-e116-4699-b5d2-6df985c092e5"), "Cheese", 0, 1, 461.36m, (short)41, null, null, null },
                    { 105, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(4198), "192.168.1.21", "https://picsum.photos/640/480/?image=1012", true, new Guid("5fdcc11e-7590-413d-bb43-b8635ef28d59"), "Chips", 0, 1, 72.24m, (short)69, null, null, null },
                    { 106, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(5774), "192.168.1.21", "https://picsum.photos/640/480/?image=1069", true, new Guid("ec42c6e8-00a0-487a-abb9-1c2c32de438f"), "Keyboard", 0, 1, 252.09m, (short)99, null, null, null },
                    { 107, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(7298), "192.168.1.21", "https://picsum.photos/640/480/?image=253", true, new Guid("6036cc5e-bad5-4508-a599-80fe89d147f4"), "Bacon", 0, 1, 427.46m, (short)9, null, null, null },
                    { 108, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 663, DateTimeKind.Local).AddTicks(8826), "192.168.1.21", "https://picsum.photos/640/480/?image=790", true, new Guid("12edf0e9-d622-49f2-9b2b-576d42009557"), "Chips", 0, 1, 888.31m, (short)73, null, null, null },
                    { 109, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(333), "192.168.1.21", "https://picsum.photos/640/480/?image=858", true, new Guid("1014c96c-09a5-4068-99f4-9a6158901835"), "Shoes", 0, 1, 310.44m, (short)39, null, null, null },
                    { 110, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(1841), "192.168.1.21", "https://picsum.photos/640/480/?image=299", true, new Guid("2dcd09a0-a8cd-4d35-96c2-959b9038fd85"), "Shirt", 0, 1, 344.61m, (short)80, null, null, null },
                    { 111, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(3343), "192.168.1.21", "https://picsum.photos/640/480/?image=145", true, new Guid("5fde1828-79ea-45f3-91d6-eb3d08e79be4"), "Ball", 0, 1, 362.38m, (short)46, null, null, null },
                    { 201, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(5194), "192.168.1.21", "https://picsum.photos/640/480/?image=38", true, new Guid("84f8a882-4cad-441e-ac15-274f514d9c93"), "Hat", 0, 2, 317.85m, (short)31, null, null, null },
                    { 202, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(6789), "192.168.1.21", "https://picsum.photos/640/480/?image=68", true, new Guid("77adaa18-5b38-4e1b-9a91-cb725c2d24e4"), "Sausages", 0, 2, 271.27m, (short)77, null, null, null },
                    { 203, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(8325), "192.168.1.21", "https://picsum.photos/640/480/?image=782", true, new Guid("3d31a329-e774-4e9b-93c2-4b7cae53433f"), "Chair", 0, 2, 424.11m, (short)6, null, null, null },
                    { 204, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 664, DateTimeKind.Local).AddTicks(9853), "192.168.1.21", "https://picsum.photos/640/480/?image=314", true, new Guid("800c3df4-5590-4fa6-be7f-f75d97f6bee1"), "Chicken", 0, 2, 798.88m, (short)31, null, null, null },
                    { 205, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(1432), "192.168.1.21", "https://picsum.photos/640/480/?image=35", true, new Guid("ad98bb01-d52b-4ed6-a487-4e8943fb1936"), "Table", 0, 2, 579.27m, (short)41, null, null, null },
                    { 206, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(2958), "192.168.1.21", "https://picsum.photos/640/480/?image=830", true, new Guid("51b8ea9c-b38d-459c-b4cf-ad84db21d547"), "Car", 0, 2, 696.47m, (short)78, null, null, null },
                    { 207, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(4481), "192.168.1.21", "https://picsum.photos/640/480/?image=747", true, new Guid("377ef9d9-9c6b-45d4-9d44-1523652f08b8"), "Chips", 0, 2, 106.08m, (short)100, null, null, null },
                    { 208, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(5977), "192.168.1.21", "https://picsum.photos/640/480/?image=111", true, new Guid("1af9116e-8676-475c-95f0-651eb7d4bdd3"), "Chicken", 0, 2, 78.40m, (short)25, null, null, null },
                    { 209, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(7477), "192.168.1.21", "https://picsum.photos/640/480/?image=862", true, new Guid("86c1dcca-d237-4c20-a4cb-30ef4f958233"), "Mouse", 0, 2, 791.58m, (short)38, null, null, null },
                    { 210, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 665, DateTimeKind.Local).AddTicks(8958), "192.168.1.21", "https://picsum.photos/640/480/?image=683", true, new Guid("9f1d1323-dfc4-450e-a667-5521051e2e1f"), "Car", 0, 2, 823.51m, (short)19, null, null, null },
                    { 211, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(448), "192.168.1.21", "https://picsum.photos/640/480/?image=917", true, new Guid("a855f2d0-eac3-4530-9e4d-35bc63fedb22"), "Ball", 0, 2, 946.58m, (short)43, null, null, null },
                    { 301, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(1920), "192.168.1.21", "https://picsum.photos/640/480/?image=216", true, new Guid("19fe2d70-a7cb-4e25-bd01-4e3c4c047af1"), "Chicken", 0, 3, 489.91m, (short)52, null, null, null },
                    { 302, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(3398), "192.168.1.21", "https://picsum.photos/640/480/?image=633", true, new Guid("025b4c59-667e-4cb5-a7a2-568a84401b6e"), "Gloves", 0, 3, 961.31m, (short)12, null, null, null },
                    { 303, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(4894), "192.168.1.21", "https://picsum.photos/640/480/?image=971", true, new Guid("8dfec975-d3e5-4b4f-baca-028ecb0356c7"), "Chair", 0, 3, 762.82m, (short)7, null, null, null },
                    { 304, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(6371), "192.168.1.21", "https://picsum.photos/640/480/?image=419", true, new Guid("9b8cd0ba-65ef-4cdb-9c01-684a47fe223c"), "Ball", 0, 3, 748.94m, (short)76, null, null, null },
                    { 305, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(7841), "192.168.1.21", "https://picsum.photos/640/480/?image=442", true, new Guid("50db70e2-7c7b-4317-be54-a411dd2a0c12"), "Car", 0, 3, 635.50m, (short)71, null, null, null },
                    { 306, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 666, DateTimeKind.Local).AddTicks(9334), "192.168.1.21", "https://picsum.photos/640/480/?image=125", true, new Guid("95234fe6-bfcc-4b14-9538-881792d500ce"), "Keyboard", 0, 3, 843.14m, (short)2, null, null, null },
                    { 307, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(808), "192.168.1.21", "https://picsum.photos/640/480/?image=630", true, new Guid("5bdda9db-63d3-41dd-9798-74f673677318"), "Soap", 0, 3, 133.12m, (short)88, null, null, null },
                    { 308, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(2286), "192.168.1.21", "https://picsum.photos/640/480/?image=38", true, new Guid("6add8ef4-d8c4-4bd6-ad08-8f506d50c04f"), "Table", 0, 3, 39.56m, (short)61, null, null, null },
                    { 309, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(3776), "192.168.1.21", "https://picsum.photos/640/480/?image=442", true, new Guid("06426ded-063e-493c-96d3-b0a53df790d8"), "Table", 0, 3, 125.43m, (short)59, null, null, null },
                    { 310, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(5395), "192.168.1.21", "https://picsum.photos/640/480/?image=849", true, new Guid("53f26ef4-0e57-4a20-97be-86a41c9281c6"), "Towels", 0, 3, 253.16m, (short)52, null, null, null },
                    { 311, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 27, 2, 25, 45, 667, DateTimeKind.Local).AddTicks(6892), "192.168.1.21", "https://picsum.photos/640/480/?image=80", true, new Guid("fa1470e9-4791-42b7-b049-b413c6ba208e"), "Tuna", 0, 3, 508.28m, (short)18, null, null, null }
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
