using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Make = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoginInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LoginType = table.Column<int>(type: "int", nullable: true),
                    Key = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginInfos_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LoginInfos_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LoginInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "EmailAddress", "FirstName", "LastName", "UpdatedAt", "UpdatedUserId" },
                values: new object[] { new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new DateTime(2023, 5, 6, 14, 5, 35, 927, DateTimeKind.Local).AddTicks(1271), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "admecom@mailinator.com", "Jace", "Beleren", new DateTime(2023, 5, 6, 14, 5, 35, 927, DateTimeKind.Local).AddTicks(1272), new Guid("777eab55-31b1-494a-b804-078b8eaaa000") });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "Make", "Manufacturer", "UpdatedAt", "UpdatedUserId", "Year" },
                values: new object[] { new Guid("742acd91-f526-47bf-b862-0e2e018b0680"), new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3238), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "Xpander Cross", "Mitsubishi", new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3239), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), 2023 });

            migrationBuilder.InsertData(
                table: "LoginInfos",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "Key", "LoginType", "UpdatedAt", "UpdatedUserId", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("2a2e3066-ea8b-4ecb-8dfc-beb3561db018"), new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8446), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "AccountStatus", null, new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8447), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "Active" },
                    { new Guid("531709be-09b1-42b3-95af-5bc663c7739c"), new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8314), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "Password", null, new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8330), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "$2a$10$Mjaf3iexE0kcKC3gdeEwG.n8z0mKzZw3mzTDGwx5BJEEcRpSFZT9a" },
                    { new Guid("efd1d492-6068-4d2d-a06a-a1a54ce875e6"), new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8420), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "LoginRetries", null, new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8421), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "0" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "EmailAddress", "FirstName", "LastName", "UpdatedAt", "UpdatedUserId" },
                values: new object[] { new Guid("777eab55-31b1-494a-b804-078b8eccc000"), new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8479), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "custecom@mailinator.com", "Liliana", "Vess", new DateTime(2023, 5, 6, 14, 5, 35, 980, DateTimeKind.Local).AddTicks(8479), new Guid("777eab55-31b1-494a-b804-078b8eaaa000") });

            migrationBuilder.InsertData(
                table: "LoginInfos",
                columns: new[] { "Id", "CreatedAt", "CreatedByUserId", "Key", "LoginType", "UpdatedAt", "UpdatedUserId", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("06e6da25-fe43-492f-adf9-6315be3828ff"), new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3220), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "AccountStatus", null, new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3222), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new Guid("777eab55-31b1-494a-b804-078b8eccc000"), "Active" },
                    { new Guid("734982df-979c-478f-9312-6a259c4aa0f7"), new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3165), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "Password", null, new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3176), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new Guid("777eab55-31b1-494a-b804-078b8eccc000"), "$2a$10$CVRWc.XZ/x7t9nmH.3lrjejnSru0AHbyDDGdvIN06PNa.za8quLP." },
                    { new Guid("be7a6499-e8c1-4d15-91b5-2c4b169b9a52"), new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3201), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), "LoginRetries", null, new DateTime(2023, 5, 6, 14, 5, 36, 34, DateTimeKind.Local).AddTicks(3201), new Guid("777eab55-31b1-494a-b804-078b8eaaa000"), new Guid("777eab55-31b1-494a-b804-078b8eccc000"), "0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CreatedByUserId",
                table: "Cars",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UpdatedUserId",
                table: "Cars",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfos_CreatedByUserId",
                table: "LoginInfos",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfos_UpdatedUserId",
                table: "LoginInfos",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfos_UserId",
                table: "LoginInfos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedByUserId",
                table: "Users",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdatedUserId",
                table: "Users",
                column: "UpdatedUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "LoginInfos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
