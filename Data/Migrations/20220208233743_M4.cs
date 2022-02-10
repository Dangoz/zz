using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab.Data.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Department", "FirstName", "LastName" },
                values: new object[] { "Mining", "Ann", "Fay" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Department", "FirstName", "LastName" },
                values: new object[] { "Nursing", "Joe", "Sun" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "10", "Computing", "Tim", "Rex" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "11", "Business", "Rob", "Ram" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "12", "Mining", "Jan", "Fry" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "13", "Science", "Jim", "Tex" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "14", "Business", "Ben", "Kid" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "15", "Medicine", "Mia", "Chu" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "16", "Computing", "Ted", "Tao" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "17", "Business", "Amy", "Day" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "18", "Science", "Ian", "Roy" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "19", "Nursing", "Liz", "Kit" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "20", "Medicine", "Mat", "Tan" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "21", "Medicine", "Deb", "Roy" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "22", "Tourism", "Ana", "Ray" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "23", "Computing", "Lyn", "Poe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "24", "Science", "Amy", "Raj" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "25", "Mining", "Kim", "Ash" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "26", "Nursing", "Bec", "Kid" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "27", "Computing", "Eva", "Fry" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "28", "Business", "Eli", "Lap" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "29", "Science", "Sam", "Yim" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "30", "Mining", "Joe", "Hui" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "31", "Nursing", "Liz", "Jin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "32", "Linguistics", "Ric", "Kuo" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "33", "Computing", "Pam", "Mak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "34", "Business", "Stu", "Day" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "35", "Tourism", "Tom", "Gad" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "36", "Agriculture", "Bob", "Bee" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "37", "Agriculture", "Jim", "Ots" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "38", "Linguistics", "Tom", "Mag" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "39", "Mining", "Hal", "Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "4", "Mining", "Ben", "Ray" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "40", "Tourism", "Roy", "Kim" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "41", "Nursing", "Vis", "Cox" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "42", "Science", "Kay", "Aga" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "43", "Nursing", "Reo", "Hui" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "44", "Mining", "Bob", "Roe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "5", "Business", "Zoe", "Cox" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "6", "Mining", "Sam", "Ray" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "7", "Medicine", "Dan", "Ash" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "8", "Computing", "Pat", "Lee" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "9", "Science", "Kim", "Day" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Department", "FirstName", "LastName" },
                values: new object[] { "Medicine", "Jane", "Doe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Department", "FirstName", "LastName" },
                values: new object[] { "MATH", "Jack", "Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName" },
                values: new object[] { "1", "IT", "John", "Doe" });
        }
    }
}
