using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class MigrationDemo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 37L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 38L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 39L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 40L,
                column: "Creation",
                value: new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9997));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 8L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 9L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 10L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 11L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 12L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 13L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 14L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 15L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 16L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 17L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 18L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 19L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 20L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 21L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 22L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 23L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 24L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 25L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 30L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 31L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 32L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 33L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 34L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 35L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 36L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 37L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 38L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 39L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 40L,
                column: "Creation",
                value: new DateTime(2024, 1, 14, 21, 28, 46, 229, DateTimeKind.Local).AddTicks(8975));
        }
    }
}
