using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "3", "MATH", "Jack", "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
