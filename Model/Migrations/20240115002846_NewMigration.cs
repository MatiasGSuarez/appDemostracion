using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delete = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "Age", "Creation", "Delete", "DocumentNumber", "Name", "PhoneNumber", "Surname", "Update" },
                values: new object[,]
                {
                    { 1L, "All Boys", 16, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8760), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 1", "3644680649", "Customer 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "All Boys", 17, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8784), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 2", "3644680649", "Customer 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "All Boys", 18, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8787), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 3", "3644680649", "Customer 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "All Boys", 19, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 4", "3644680649", "Customer 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "All Boys", 20, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8792), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 5", "3644680649", "Customer 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, "All Boys", 21, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 6", "3644680649", "Customer 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "All Boys", 22, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 7", "3644680649", "Customer 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "All Boys", 23, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 8", "3644680649", "Customer 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, "All Boys", 24, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 9", "3644680649", "Customer 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, "All Boys", 25, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 10", "3644680649", "Customer 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, "All Boys", 26, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 11", "3644680649", "Customer 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, "All Boys", 27, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8827), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 12", "3644680649", "Customer 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13L, "All Boys", 28, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 13", "3644680649", "Customer 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14L, "All Boys", 29, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 14", "3644680649", "Customer 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, "All Boys", 30, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8838), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 15", "3644680649", "Customer 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16L, "All Boys", 31, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 16", "3644680649", "Customer 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17L, "All Boys", 32, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 17", "3644680649", "Customer 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18L, "All Boys", 33, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 18", "3644680649", "Customer 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, "All Boys", 34, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8891), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 19", "3644680649", "Customer 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20L, "All Boys", 35, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8923), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 20", "3644680649", "Customer 20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21L, "All Boys", 36, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8925), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 21", "3644680649", "Customer 21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22L, "All Boys", 37, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8927), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 22", "3644680649", "Customer 22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, "All Boys", 38, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8929), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 23", "3644680649", "Customer 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24L, "All Boys", 39, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8932), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 24", "3644680649", "Customer 24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25L, "All Boys", 40, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8935), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 25", "3644680649", "Customer 25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26L, "All Boys", 41, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8937), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 26", "3644680649", "Customer 26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27L, "All Boys", 42, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8940), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 27", "3644680649", "Customer 27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28L, "All Boys", 43, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8942), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 28", "3644680649", "Customer 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, "All Boys", 44, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8945), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 29", "3644680649", "Customer 29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30L, "All Boys", 45, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8947), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 30", "3644680649", "Customer 30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31L, "All Boys", 46, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8950), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 31", "3644680649", "Customer 31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32L, "All Boys", 47, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8952), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 32", "3644680649", "Customer 32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33L, "All Boys", 48, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8955), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 33", "3644680649", "Customer 33", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34L, "All Boys", 49, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8960), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 34", "3644680649", "Customer 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35L, "All Boys", 50, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8962), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 35", "3644680649", "Customer 35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36L, "All Boys", 51, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8965), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 36", "3644680649", "Customer 36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37L, "All Boys", 52, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8967), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 37", "3644680649", "Customer 37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38L, "All Boys", 53, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8969), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 38", "3644680649", "Customer 38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39L, "All Boys", 54, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8972), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 39", "3644680649", "Customer 39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40L, "All Boys", 55, new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41016905", "Customer 40", "3644680649", "Customer 40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
