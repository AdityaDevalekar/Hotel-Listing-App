using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universtiy_Portal.Migrations
{
    public partial class AddedDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "College of Free Education" });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "College of Freedom" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "CollegeId", "Name", "Password", "UserName" },
                values: new object[] { 1, "Karvenagar", 1, "Avinash", "2233AAA", "Avi@111" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "CollegeId", "Name", "Password", "UserName" },
                values: new object[] { 2, "Karvenagar", 2, "Swarup", "2233AAA", "swa@111" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "CollegeId", "Name", "Password", "UserName" },
                values: new object[] { 3, "Karvenagar", 1, "motya", "2233AAA", "mot@111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
