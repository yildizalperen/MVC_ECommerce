using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class categoryproductsupplier : Migration
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
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    CompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
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
                    { 1, "Test Category 1", "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 882, DateTimeKind.Local).AddTicks(3305), "192.168.1.31", "Test Category 1 Description", true, new Guid("eaae78fd-5e98-4034-a168-7a8474732452"), 0, null, null, null },
                    { 2, "Test Category 2", "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 882, DateTimeKind.Local).AddTicks(6074), "192.168.1.31", "Test Category 2 Description", true, new Guid("3731f474-725e-4b25-849a-ee1f7b79f925"), 0, null, null, null },
                    { 3, "Test Category 3", "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 882, DateTimeKind.Local).AddTicks(7753), "192.168.1.31", "Test Category 3 Description", true, new Guid("c96be295-7d78-4565-a07d-299adeeb3939"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress1", "Test Supplier1", "Test Contact1", "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(5514), "192.168.1.31", true, new Guid("465f41d1-752d-42a9-81d3-b7965f984929"), null, 0, null, null, null },
                    { 2, "Test Supplier Adress2", "Test Supplier2", "Test Contact2", "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(7082), "192.168.1.31", true, new Guid("8c73097a-4756-46fe-913c-9c2e3fb45963"), null, 0, null, null, null },
                    { 3, "TestSupplierAdress3", "TestSupplier3", "Test Contact3", "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(8663), "192.168.1.31", true, new Guid("85578b48-006c-4b19-a1de-45ddf9a2b1db"), null, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 101, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(2539), "192.168.1.31", "https://picsum.photos/640/480/?image=56", true, new Guid("9694f04c-a593-4a2a-be4a-a347764598ca"), "Computer", 0, 1, 849.30m, (short)6, null, null, null },
                    { 102, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(4455), "192.168.1.31", "https://picsum.photos/640/480/?image=127", true, new Guid("d5f89680-bb8b-40a2-93cc-125c17d15c39"), "Chips", 0, 1, 531.07m, (short)33, null, null, null },
                    { 103, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(6214), "192.168.1.31", "https://picsum.photos/640/480/?image=342", true, new Guid("7b89c4ad-d30f-405b-b876-41ad7e94f48c"), "Keyboard", 0, 1, 249.90m, (short)92, null, null, null },
                    { 104, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 884, DateTimeKind.Local).AddTicks(8496), "192.168.1.31", "https://picsum.photos/640/480/?image=672", true, new Guid("ad5fe80c-d018-4790-87c7-8fd612df3cfd"), "Cheese", 0, 1, 959.55m, (short)35, null, null, null },
                    { 105, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(299), "192.168.1.31", "https://picsum.photos/640/480/?image=695", true, new Guid("2018c039-b1ae-47ae-85a5-62c7baaac877"), "Mouse", 0, 1, 364.15m, (short)87, null, null, null },
                    { 106, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(1910), "192.168.1.31", "https://picsum.photos/640/480/?image=423", true, new Guid("9935587b-c569-400d-aa2f-e4aaea037cb2"), "Chair", 0, 1, 374.56m, (short)27, null, null, null },
                    { 107, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(3479), "192.168.1.31", "https://picsum.photos/640/480/?image=539", true, new Guid("3f108704-7d5d-4943-8e3d-316779d7cf25"), "Hat", 0, 1, 272.85m, (short)75, null, null, null },
                    { 108, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(5026), "192.168.1.31", "https://picsum.photos/640/480/?image=486", true, new Guid("48433d6b-6220-44e4-9c9a-2bd76634d1f8"), "Chicken", 0, 1, 502.66m, (short)40, null, null, null },
                    { 109, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(6701), "192.168.1.31", "https://picsum.photos/640/480/?image=428", true, new Guid("efc76e78-dd06-439d-9054-abd354aaa7de"), "Chicken", 0, 1, 404.27m, (short)56, null, null, null },
                    { 110, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(8251), "192.168.1.31", "https://picsum.photos/640/480/?image=549", true, new Guid("e94c1036-b834-49e2-846d-80b6c3c6f7a8"), "Car", 0, 1, 871.75m, (short)21, null, null, null },
                    { 111, 1, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 885, DateTimeKind.Local).AddTicks(9791), "192.168.1.31", "https://picsum.photos/640/480/?image=900", true, new Guid("447faeeb-57af-4c8c-b7cc-6e9fdd86bd00"), "Salad", 0, 1, 573.54m, (short)97, null, null, null },
                    { 201, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(1319), "192.168.1.31", "https://picsum.photos/640/480/?image=938", true, new Guid("e124cf8e-b9f5-4df2-87a7-20457be93212"), "Sausages", 0, 2, 188.32m, (short)64, null, null, null },
                    { 202, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(2832), "192.168.1.31", "https://picsum.photos/640/480/?image=577", true, new Guid("42c9595c-8f65-4b0f-9b37-893b6c236d1b"), "Cheese", 0, 2, 264.05m, (short)10, null, null, null },
                    { 203, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(4335), "192.168.1.31", "https://picsum.photos/640/480/?image=438", true, new Guid("423b6d92-97e8-4827-8a88-0eaf8483f029"), "Table", 0, 2, 15.03m, (short)80, null, null, null },
                    { 204, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(5844), "192.168.1.31", "https://picsum.photos/640/480/?image=415", true, new Guid("ba7cbf5b-557a-4275-a229-f436cf75ba56"), "Towels", 0, 2, 102.08m, (short)40, null, null, null },
                    { 205, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(7376), "192.168.1.31", "https://picsum.photos/640/480/?image=895", true, new Guid("f8831f82-bab1-4873-bb93-4487b88f3200"), "Bike", 0, 2, 183.33m, (short)88, null, null, null },
                    { 206, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 886, DateTimeKind.Local).AddTicks(8875), "192.168.1.31", "https://picsum.photos/640/480/?image=683", true, new Guid("5836a734-7455-4d34-a2ac-3353109b1607"), "Salad", 0, 2, 192.71m, (short)54, null, null, null },
                    { 207, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(486), "192.168.1.31", "https://picsum.photos/640/480/?image=640", true, new Guid("a438ebf3-ee5f-442b-9b80-b5d973c41bcd"), "Fish", 0, 2, 146.08m, (short)28, null, null, null },
                    { 208, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(2006), "192.168.1.31", "https://picsum.photos/640/480/?image=799", true, new Guid("241e9263-a0ac-41db-af73-9ca5e027b4d9"), "Salad", 0, 2, 354.90m, (short)1, null, null, null },
                    { 209, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(3511), "192.168.1.31", "https://picsum.photos/640/480/?image=1083", true, new Guid("72e0f9e0-faef-4ff1-b9df-2b179d449952"), "Bacon", 0, 2, 621.35m, (short)15, null, null, null },
                    { 210, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(5022), "192.168.1.31", "https://picsum.photos/640/480/?image=889", true, new Guid("758dda50-1a5f-4d5f-bb1c-7747f174195d"), "Shoes", 0, 2, 693.30m, (short)47, null, null, null },
                    { 211, 2, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(6543), "192.168.1.31", "https://picsum.photos/640/480/?image=137", true, new Guid("65986db2-715d-4319-ba37-787f9f448810"), "Table", 0, 2, 155.07m, (short)79, null, null, null },
                    { 301, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(8054), "192.168.1.31", "https://picsum.photos/640/480/?image=929", true, new Guid("45961c16-e9d7-4572-93a2-a015e4ed4382"), "Chair", 0, 3, 929.76m, (short)28, null, null, null },
                    { 302, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 887, DateTimeKind.Local).AddTicks(9555), "192.168.1.31", "https://picsum.photos/640/480/?image=334", true, new Guid("1320c3b7-95ef-49e7-a3d1-89e9cc708c03"), "Ball", 0, 3, 358.64m, (short)64, null, null, null },
                    { 303, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(1056), "192.168.1.31", "https://picsum.photos/640/480/?image=714", true, new Guid("fd59c6fc-c855-4fbf-af80-63989d7b7033"), "Pizza", 0, 3, 601.51m, (short)35, null, null, null },
                    { 304, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(2558), "192.168.1.31", "https://picsum.photos/640/480/?image=78", true, new Guid("72887347-540a-481b-8dfd-47c809c48ce2"), "Sausages", 0, 3, 906.71m, (short)14, null, null, null },
                    { 305, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(4050), "192.168.1.31", "https://picsum.photos/640/480/?image=789", true, new Guid("8fcd700b-1afb-40bd-b9f4-964ab3127d95"), "Pizza", 0, 3, 746.05m, (short)6, null, null, null },
                    { 306, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(5532), "192.168.1.31", "https://picsum.photos/640/480/?image=713", true, new Guid("30b05575-9df2-4c4a-b3ad-732c0c862aaa"), "Shirt", 0, 3, 811.51m, (short)15, null, null, null },
                    { 307, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(7059), "192.168.1.31", "https://picsum.photos/640/480/?image=10", true, new Guid("19e033fc-9bfc-43f9-bafe-4adccd2e4eff"), "Pizza", 0, 3, 404.93m, (short)1, null, null, null },
                    { 308, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 888, DateTimeKind.Local).AddTicks(8548), "192.168.1.31", "https://picsum.photos/640/480/?image=44", true, new Guid("7d2c95b8-3056-4dc4-8344-4bc97831fe14"), "Sausages", 0, 3, 496.87m, (short)33, null, null, null },
                    { 309, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(32), "192.168.1.31", "https://picsum.photos/640/480/?image=572", true, new Guid("b05bb36a-5470-4f94-844b-ab694d7605a4"), "Hat", 0, 3, 512.76m, (short)71, null, null, null },
                    { 310, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(1512), "192.168.1.31", "https://picsum.photos/640/480/?image=576", true, new Guid("87f74ae8-dce2-46ce-aea7-f405feef22ca"), "Sausages", 0, 3, 824.12m, (short)68, null, null, null },
                    { 311, 3, "DESKTOP-22DN80G", new DateTime(2024, 5, 23, 15, 57, 56, 889, DateTimeKind.Local).AddTicks(3016), "192.168.1.31", "https://picsum.photos/640/480/?image=642", true, new Guid("3cb1d6e7-3d80-404a-a043-237cb9ec0984"), "Fish", 0, 3, 79.50m, (short)34, null, null, null }
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
