using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinqSchool.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName" },
                values: new object[,]
                {
                    { 1, "3A" },
                    { 2, "2A" },
                    { 3, "3B" },
                    { 4, "2B" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseDescription", "CourseName", "FK_TeacherId" },
                values: new object[,]
                {
                    { 1, "Simpel programmering", "Programmering 1", 1 },
                    { 2, "Svårare programmering", "Programmering 2", 3 },
                    { 3, "Fysisk aktivitet", "Idrott", 4 },
                    { 4, "Räkna räkna räkna", "Matematik", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address", "City", "FK_ClassId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Midland 42", "Stad", 1, "Niklas", "Niklasson" },
                    { 2, "Midland 3", "Stad", 2, "Sten", "Stensson" },
                    { 3, "Skåneland 22", "Stranden", 2, "Rick", "Ricksson" },
                    { 4, "Norrland 35", "Skogen", 1, "Morty", "Mortson" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Address", "City", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Norrland 1", "Skogton", "Reidar", "Reidarson" },
                    { 2, "Midland 1", "Staden", "Tobias", "Tobiasson" },
                    { 3, "Norrland 15", "Skogton", "Gunn", "Gunnarson" },
                    { 4, "Skåneland 1", "Stranden", "Sven", "Svensson" }
                });

            migrationBuilder.InsertData(
                table: "ActiveCourses",
                columns: new[] { "ActiveCourseId", "FK_CourseId", "FK_StudentId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, 1, null },
                    { 2, 1, 3, null },
                    { 3, 2, 2, null },
                    { 4, 4, 4, null },
                    { 5, 2, 3, null },
                    { 6, 3, 1, null },
                    { 7, 3, 2, null },
                    { 8, 1, 4, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ActiveCourses",
                keyColumn: "ActiveCourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);
        }
    }
}
